using LatijnLogic.Interfaces;
using LatijnLogic.Types;

namespace LatijnLogic.Services
{
    public class VervoegingenLogic : IVervoegingenLogic
    {
        private readonly IUitgangenData _uitgangenData;
        private readonly IWerkwoordenData _werkwoordenData;
        private readonly IRandomNumbers _random;
        private readonly IVervoegingenData _vervoegingenData;

        private readonly int nrOfWerkwoorden = 79;
        private readonly int nrOfUitgangen = 131;

        public VervoegingenLogic(IUitgangenData uitgangenData, IWerkwoordenData werkwoordenData, IRandomNumbers random, IVervoegingenData vervoegingenData)
        {
            _uitgangenData = uitgangenData;
            _werkwoordenData = werkwoordenData;
            _random = random;
            _vervoegingenData = vervoegingenData;
        }

        public async Task<bool> CreateVervoegingen(int amount, int toetsId)
        {
            List<int> randomWerkwoordenIDs = _random.GenerateNRandomNumbers(nrOfWerkwoorden, amount);
            List<int> randomUitgangenIDs = _random.GenerateNRandomNumbers(nrOfUitgangen, amount);

            List<Werkwoord> randomWerkwoorden = await _werkwoordenData.GetWerkwoorden(randomWerkwoordenIDs);

            List<int> adjustedUitgangenIDs = AdjustConjugatie(randomWerkwoorden, randomUitgangenIDs);

            List<Uitgang> randomUitgangen = await _uitgangenData.GetUitgangen(adjustedUitgangenIDs);

            List<string> vormen = Vervoeg(randomWerkwoorden, randomUitgangen);

            List<Vervoeging> vervoegingen = CreateVervoegingenList(vormen, randomUitgangen, randomWerkwoorden, toetsId);

            List<Vervoeging> shuffledVervoegingen = _random.ShuffleVervoegingen(vervoegingen);

            return await _vervoegingenData.CreateVervoegingen(shuffledVervoegingen);
        }

        private List<int> AdjustConjugatie(List<Werkwoord> werkwoorden, List<int> uitgangenIDs)
        {
            List<int> newUitgangenIDs = new List<int>();
            for (int i = 0; i<werkwoorden.Count(); i++)
            {
                int newID = uitgangenIDs[i] + ((werkwoorden[i].Conjugatie - 1) * nrOfUitgangen);
                newUitgangenIDs.Add(newID);
            }

            return newUitgangenIDs;
        }

        private List<string> Vervoeg(List<Werkwoord> werkwoorden, List<Uitgang> uitgangen)
        {
            List<string> vormen = new List<string>();
            for (int i = 0; i < werkwoorden.Count(); i++)
            {
                string vorm = "";
                switch (uitgangen[i].Stam)
                {
                    case "praesens":
                        vorm = werkwoorden[i].Praesens.Remove(werkwoorden[i].Praesens.Length - 1) + uitgangen[i].Vorm;
                        break;
                    case "perfectum":
                        vorm = werkwoorden[i].Perfectum.Remove(werkwoorden[i].Perfectum.Length - 1) + uitgangen[i].Vorm;
                        break;
                    case "supinum":
                        vorm = werkwoorden[i].Supinum.Remove(werkwoorden[i].Supinum.Length - 2) + uitgangen[i].Vorm;
                        break;
                    case "infinitivus":
                        vorm = werkwoorden[i].Infinitivus.Remove(werkwoorden[i].Infinitivus.Length - 2) + uitgangen[i].Vorm;
                        break;
                    default:
                        break;
                }
                vormen.Add(vorm);
            }
            
            return vormen;
        }

        private List<Vervoeging> CreateVervoegingenList(List<string> vormen, List<Uitgang> uitgangen, List<Werkwoord> werkwoorden, int toetsId)
        {
            List<Vervoeging> vervoegingen = new List<Vervoeging>();
            for (int i = 0; i < vormen.Count; i++)
            {
                Vervoeging vervoeging = new Vervoeging
                {
                    ToetsId = toetsId,
                    IsCorrect = false,
                    Vorm = vormen[i],
                    Modus = uitgangen[i].Modus,
                    Tempus = uitgangen[i].Tempus,
                    Genus = uitgangen[i].Genus,
                    Persoon = uitgangen[i].Persoon,
                    Getal = uitgangen[i].Getal,

                    Infinitivus = werkwoorden[i].Infinitivus,
                    Praesens = werkwoorden[i].Praesens,
                    Perfectum = werkwoorden[i].Perfectum,
                    Supinum = werkwoorden[i].Supinum,
                    Conjugatie = werkwoorden[i].Conjugatie,
                    Betekenis = werkwoorden[i].Betekenis
                };
                vervoegingen.Add(vervoeging);
            }
            
            return vervoegingen;
        }
    }
}

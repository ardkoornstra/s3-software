import { CheckCircledIcon } from "@radix-ui/react-icons";
import {
  Box,
  Button,
  Flex,
  Heading,
  RadioCards,
  Section,
} from "@radix-ui/themes";

interface AntwoordInputProps {
  werkwoordsvorm: Werkwoordsvorm;
}

export default function AntwoordInput(props: AntwoordInputProps) {
  function HandleSubmit() {}
  return (
    <>
      <Section>
        <Flex justify={"between"}>
          <Box>
            <Heading align={"center"}>Modus</Heading>
            <RadioCards.Root name="Modus" color="blue">
              <RadioCards.Item value="Indicativus">Indicativus</RadioCards.Item>
              <RadioCards.Item value="Coniunctivus">
                Coniunctivus
              </RadioCards.Item>
              <RadioCards.Item value="Imperativus">Imperativus</RadioCards.Item>
              <RadioCards.Item value="Participium">Participium</RadioCards.Item>
              <RadioCards.Item value="Infinitivus">Infinitivus</RadioCards.Item>
            </RadioCards.Root>
          </Box>
          <Box>
            <Heading align={"center"}>Tempus</Heading>
            <RadioCards.Root name="Tempus" color="cyan">
              <RadioCards.Item value="Praesens">Praesens</RadioCards.Item>
              <RadioCards.Item value="Imperfectum">Imperfectum</RadioCards.Item>
              <RadioCards.Item value="Futurum">Futurum</RadioCards.Item>
              <RadioCards.Item value="Perfectum">Perfectum</RadioCards.Item>
              <RadioCards.Item value="Plusquam Perfectum">
                Plusquam Perfectum
              </RadioCards.Item>
              <RadioCards.Item value="Futurum Exactum">
                Futurum Exactum
              </RadioCards.Item>
            </RadioCards.Root>
          </Box>
          <Box>
            <Heading align={"center"}>Genus</Heading>
            <RadioCards.Root name="Genus" color="teal">
              <RadioCards.Item value="Activum">Activum</RadioCards.Item>
              <RadioCards.Item value="Passivum">Passivum</RadioCards.Item>
            </RadioCards.Root>
          </Box>
          <Box>
            <Heading align={"center"}>Persoon</Heading>
            <RadioCards.Root name="Persoon" color="jade">
              <RadioCards.Item value="Eerste">Eerste</RadioCards.Item>
              <RadioCards.Item value="Tweede">Tweede</RadioCards.Item>
            </RadioCards.Root>
          </Box>
          <Box>
            <Heading align={"center"}>Getal</Heading>
            <RadioCards.Root name="Getal" color="green">
              <RadioCards.Item value="Singularis">Singularis</RadioCards.Item>
              <RadioCards.Item value="Pluralis">Pluralis</RadioCards.Item>
            </RadioCards.Root>
          </Box>
        </Flex>
      </Section>
      <Flex justify={"end"}>
        <Button onClick={HandleSubmit} size={"3"}>
          <CheckCircledIcon />
          Antwoord inleveren
        </Button>
      </Flex>
    </>
  );
}

"use client";

import {
  AlertDialog,
  Box,
  Button,
  Flex,
  Link,
  Section,
} from "@radix-ui/themes";
import VraagNr from "../components/toets/vraagnr";
import { useEffect, useState } from "react";
import AantalGoed from "../components/toets/aantalgoed";
import Vorm from "../components/toets/vorm";
import AntwoordInput from "../components/toets/antwoordinput";
import { CheckCircledIcon } from "@radix-ui/react-icons";

export default function Vraag() {
  const [vervoegingen, setVervoegingen] = useState<Werkwoordsvorm[]>();
  const [correct, setCorrect] = useState<boolean>(false);

  const [modus, setModus] = useState<string>();
  const [tempus, setTempus] = useState<string>();
  const [genus, setGenus] = useState<string>();
  const [persoon, setPersoon] = useState<string>();
  const [getal, setGetal] = useState<string>();

  useEffect(() => {
    if (!vervoegingen) {
      try {
        fetch("https://localhost:7125/api/Vervoegingen?amount=" + totaal)
          .then((res) => res.json())
          .then((data) => setVervoegingen(data));
      } catch (error) {
        console.log(error);
      }
    }
  }, []);

  function HandleSubmit() {
    if (
      modus == vervoegingen[index].modus &&
      tempus == vervoegingen[index].tempus &&
      genus == vervoegingen[index].genus &&
      persoon == vervoegingen[index].persoon &&
      getal == vervoegingen[index].getal
    ) {
      //Correct
      setCorrect(true);
      setAantal(aantal + 1);
      console.log("AAAAA");
    } else {
      console.log("BBBBB");
    }
  }

  function HandleNext() {
    setCorrect(false);
    setIndex(index + 1);
  }

  return (
    <>
      {vervoegingen ? (
        <>
          <Section size={"1"}>
            <Flex justify={"between"} p={"3"}>
              <Box>
                <VraagNr nummer={index + 1} totaal={totaal} />
              </Box>
              <Box>
                <AantalGoed aantal={aantal} />
              </Box>
            </Flex>
            <Vorm werkwoordsvorm={vervoegingen[index]} />
          </Section>
          <AntwoordInput
            onModusChange={setModus}
            onTempusChange={setTempus}
            onGenusChange={setGenus}
            onPersoonChange={setPersoon}
            onGetalChange={setGetal}
          />
          <Flex justify={"end"}>
            <AlertDialog.Root>
              <AlertDialog.Trigger>
                <Button onClick={HandleSubmit} size={"3"}>
                  <CheckCircledIcon />
                  Antwoord inleveren
                </Button>
              </AlertDialog.Trigger>
              <AlertDialog.Content>
                <AlertDialog.Title>
                  {correct
                    ? "Goed gedaan, dat is juist!"
                    : "Helaas, dat is onjuist."}
                </AlertDialog.Title>
                <AlertDialog.Description>
                  {vervoegingen[index].vorm.charAt(0).toUpperCase() +
                    vervoegingen[index].vorm.slice(1)}{" "}
                  is {correct ? "inderdaad " : "niet "}
                  de {modus} {tempus} {genus} {persoon} persoon {getal} van{" "}
                  {vervoegingen[index].infinitivus}{" "}
                  {"(" + vervoegingen[index].betekenis + ")"}
                  {correct ? "!" : "."}
                </AlertDialog.Description>
                <Flex justify={"end"}>
                  <AlertDialog.Action>
                    {index != totaal - 1 ? (
                      <Button onClick={HandleNext}>Volgende vraag</Button>
                    ) : (
                      <Link
                        href={
                          "/resultaat?aantalGoed=" +
                          aantal +
                          "&totaal=" +
                          totaal
                        }
                      >
                        <Button>Toets voltooien</Button>
                      </Link>
                    )}
                  </AlertDialog.Action>
                </Flex>
              </AlertDialog.Content>
            </AlertDialog.Root>
          </Flex>
        </>
      ) : (
        <></>
      )}
    </>
  );
}

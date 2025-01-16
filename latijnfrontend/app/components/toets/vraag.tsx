"use client";

import { AlertDialog, Box, Button, Flex, Section } from "@radix-ui/themes";
import VraagNr from "./vraagnr";
import { Dispatch, SetStateAction, useState } from "react";
import AantalGoed from "./aantalgoed";
import Vorm from "./vorm";
import AntwoordInput from "./antwoordinput";
import { CheckCircledIcon } from "@radix-ui/react-icons";
import { Toetsstate } from "@/types/toetsstate";

interface VraagProps {
  totaal: number;
  index: number;
  setIndex: Dispatch<SetStateAction<number>>;
  aantalGoed: number;
  setAantalGoed: Dispatch<SetStateAction<number>>;
  vragen: Vraag[] | undefined;
  onHandleStateChange: (toetsstate: Toetsstate) => void;
}

export default function Vraag(props: VraagProps) {
  const [correct, setCorrect] = useState<boolean>(false);

  const [modus, setModus] = useState<string>();
  const [tempus, setTempus] = useState<string>();
  const [genus, setGenus] = useState<string>();
  const [persoon, setPersoon] = useState<string>();
  const [getal, setGetal] = useState<string>();

  function HandleSubmit() {
    const antwoord: Antwoord = {
      id: props.vragen[props.index].id,
      modus: modus,
      tempus: tempus,
      genus: genus,
      persoon: persoon,
      getal: getal,
    };
    //Check answer with API
    try {
      fetch("https://localhost:7125/api/Vragen", {
        method: "POST",
        body: JSON.stringify(antwoord),
        headers: {
          "Content-type": "application/json; charset=UTF-8",
        },
      })
        .then((res) => res.json())
        .then((data) => setCorrect(data));
    } catch (error) {
      console.log(error);
    }

    if (correct) {
      props.setAantalGoed(props.aantalGoed + 1);
    }
  }

  function HandleNext() {
    setCorrect(false);
    props.setIndex(props.index + 1);
  }

  function HandleFinish() {
    props.onHandleStateChange(Toetsstate.Result);
    setCorrect(false);
    props.setIndex(0);
  }

  return (
    <>
      {props.vragen && props.vragen.length != 0 ? (
        <>
          <Section size={"1"}>
            <Flex justify={"between"} p={"3"}>
              <Box>
                <VraagNr nummer={props.index + 1} totaal={props.totaal} />
              </Box>
              <Box>
                <AantalGoed aantal={props.aantalGoed} />
              </Box>
            </Flex>
            <Vorm vraag={props.vragen[props.index]} />
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
                  {props.vragen[props.index].vorm.charAt(0).toUpperCase() +
                    props.vragen[props.index].vorm.slice(1)}{" "}
                  is {correct ? "inderdaad " : "niet "}
                  de {modus} {tempus} {genus} {persoon} persoon {getal} van{" "}
                  {props.vragen[props.index].infinitivus}{" "}
                  {"(" + props.vragen[props.index].betekenis + ")"}
                  {correct ? "!" : "."}
                </AlertDialog.Description>
                <Flex justify={"end"}>
                  <AlertDialog.Action>
                    {props.index != props.totaal - 1 ? (
                      <Button onClick={HandleNext}>Volgende vraag</Button>
                    ) : (
                      <Button onClick={HandleFinish}>Toets voltooien</Button>
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

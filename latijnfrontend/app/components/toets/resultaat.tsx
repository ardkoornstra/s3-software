"use client";

import { Toetsstate } from "@/types/toetsstate";
import { Pencil2Icon } from "@radix-ui/react-icons";
import { Button, Flex, Heading, Section, Strong, Text } from "@radix-ui/themes";

interface ResultaatProps {
  toets: Toets | undefined;
  aantalGoed: number;
  totaal: number;
  onHandleStateChange: (toetsstate: Toetsstate) => void;
}

export default function Resultaat(props: ResultaatProps) {
  return (
    <>
      {props.toets ? (
        <>
          <Section>
            <Heading align={"center"} size={"9"}>
              Resultaat
            </Heading>
            <Text align={"center"}>
              Je hebt <Strong>{props.toets.aantalGoed}</Strong> van de{" "}
              <Strong>{props.totaal}</Strong> vragen juist beantwoord.
            </Text>
          </Section>
          <Flex justify={"end"}>
            <Button
              size={"3"}
              onClick={() => props.onHandleStateChange(Toetsstate.Setup)}
            >
              <Pencil2Icon />
              Nieuwe toets starten
            </Button>
          </Flex>
        </>
      ) : (
        <></>
      )}
    </>
  );
}

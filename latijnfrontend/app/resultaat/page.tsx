"use client";

import { Pencil2Icon } from "@radix-ui/react-icons";
import {
  Button,
  Flex,
  Heading,
  Link,
  Section,
  Strong,
  Text,
} from "@radix-ui/themes";
import { useSearchParams } from "next/navigation";

export default function Resultaat() {
  const params = useSearchParams();
  const aantalGoed = params.get("aantalGoed");
  const totaal = params.get("totaal");

  return (
    <>
      <Section>
        <Heading align={"center"} size={"9"}>
          Resultaat
        </Heading>
        <Text align={"center"}>
          Je hebt <Strong>{aantalGoed}</Strong> van de <Strong>{totaal}</Strong>{" "}
          vragen juist beantwoord.
        </Text>
      </Section>
      <Flex justify={"end"}>
        <Link href={"/oefentoets"}>
          <Button size={"3"}>
            <Pencil2Icon />
            Nieuwe toets starten
          </Button>
        </Link>
      </Flex>
    </>
  );
}

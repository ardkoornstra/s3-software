"use client";

import { ThickArrowRightIcon } from "@radix-ui/react-icons";
import {
  Heading,
  Section,
  Text,
  RadioGroup,
  Flex,
  Button,
} from "@radix-ui/themes";
import Link from "next/link";

export default function Oefentoets() {
  function HandleStart() {}

  return (
    <>
      <Section size={"1"}>
        <Heading align={"center"} size={"9"}>
          Oefentoets starten
        </Heading>
        <Text>Kies je niveau</Text>
      </Section>
      <RadioGroup.Root defaultValue="3" name="niveau">
        <RadioGroup.Item value="1" disabled>
          Niveau 1
        </RadioGroup.Item>
        <RadioGroup.Item value="2" disabled>
          Niveau 2
        </RadioGroup.Item>
        <RadioGroup.Item value="3">Niveau 3 - Alle vormen</RadioGroup.Item>
      </RadioGroup.Root>
      <Flex justify={"end"}>
        <Link href={"/vraag"}>
          <Button onClick={HandleStart} size={"3"}>
            <ThickArrowRightIcon />
            Start
          </Button>
        </Link>
      </Flex>
    </>
  );
}

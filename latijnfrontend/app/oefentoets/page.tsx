"use client";

import { Box, Flex, Section } from "@radix-ui/themes";
import VraagNr from "../components/toets/vraagnr";
import { useState } from "react";
import AantalGoed from "../components/toets/aantalgoed";
import Vorm from "../components/toets/vorm";
import AntwoordInput from "../components/toets/antwoordinput";

export default function Oefentoets() {
  const [nummer, setNummer] = useState<number>(0);
  const [totaal, setTotaal] = useState<number>(0);
  const [aantal, setAantal] = useState<number>(0);

  const nieuwevorm: Werkwoordsvorm = {
    vorm: "Terramus",
    infinitivus: "terrere",
    praesens: "terreo",
    perfectum: "terrui",
    supinum: "territum",
    betekenis: "bang maken",
  };

  return (
    <>
      <Section size={"1"}>
        <Flex justify={"between"} p={"3"}>
          <Box>
            <VraagNr nummer={nummer} totaal={totaal} />
          </Box>
          <Box>
            <AantalGoed aantal={aantal} />
          </Box>
        </Flex>
        <Vorm werkwoordsvorm={nieuwevorm} />
      </Section>
      <AntwoordInput werkwoordsvorm={nieuwevorm} />
    </>
  );
}

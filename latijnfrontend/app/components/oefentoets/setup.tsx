import { Toetsstate } from "@/types/toetsstate";
import { ThickArrowRightIcon } from "@radix-ui/react-icons";
import {
  Heading,
  Section,
  Text,
  RadioGroup,
  Flex,
  Button,
} from "@radix-ui/themes";

interface SetupProps {
  onHandleStateChange: (toetsstate: Toetsstate) => void;
}

export default function Setup(props: SetupProps) {
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
        <Button
          onClick={() => props.onHandleStateChange(Toetsstate.Question)}
          size={"3"}
        >
          <ThickArrowRightIcon />
          Start
        </Button>
      </Flex>
    </>
  );
}

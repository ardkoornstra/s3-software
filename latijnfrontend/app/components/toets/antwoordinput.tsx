import { Box, Flex, Heading, RadioCards, Section } from "@radix-ui/themes";
import { Dispatch, SetStateAction } from "react";

interface AntwoordInputProps {
  onModusChange: Dispatch<SetStateAction<string | undefined>>;
  onTempusChange: Dispatch<SetStateAction<string | undefined>>;
  onGenusChange: Dispatch<SetStateAction<string | undefined>>;
  onPersoonChange: Dispatch<SetStateAction<string | undefined>>;
  onGetalChange: Dispatch<SetStateAction<string | undefined>>;
}

export default function AntwoordInput(props: AntwoordInputProps) {
  return (
    <>
      <Section>
        <Flex justify={"between"}>
          <Box>
            <Heading align={"center"}>Modus</Heading>
            <RadioCards.Root
              name="Modus"
              color="blue"
              onValueChange={(value) =>
                props.onModusChange(value.toLowerCase())
              }
            >
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
            <RadioCards.Root
              name="Tempus"
              color="cyan"
              onValueChange={(value) =>
                props.onTempusChange(value.toLowerCase())
              }
            >
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
            <RadioCards.Root
              name="Genus"
              color="teal"
              onValueChange={(value) =>
                props.onGenusChange(value.toLowerCase())
              }
            >
              <RadioCards.Item value="Activum">Activum</RadioCards.Item>
              <RadioCards.Item value="Passivum">Passivum</RadioCards.Item>
            </RadioCards.Root>
          </Box>
          <Box>
            <Heading align={"center"}>Persoon</Heading>
            <RadioCards.Root
              name="Persoon"
              color="jade"
              onValueChange={(value) =>
                props.onPersoonChange(value.toLowerCase())
              }
            >
              <RadioCards.Item value="Eerste">Eerste</RadioCards.Item>
              <RadioCards.Item value="Tweede">Tweede</RadioCards.Item>
              <RadioCards.Item value="Derde">Derde</RadioCards.Item>
            </RadioCards.Root>
          </Box>
          <Box>
            <Heading align={"center"}>Getal</Heading>
            <RadioCards.Root
              name="Getal"
              color="green"
              onValueChange={(value) =>
                props.onGetalChange(value.toLowerCase())
              }
            >
              <RadioCards.Item value="Singularis">Singularis</RadioCards.Item>
              <RadioCards.Item value="Pluralis">Pluralis</RadioCards.Item>
            </RadioCards.Root>
          </Box>
        </Flex>
      </Section>
    </>
  );
}

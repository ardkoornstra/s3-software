import { CheckIcon } from "@radix-ui/react-icons";
import { Button, Container, Heading, Section, Text } from "@radix-ui/themes";

export default function Home() {
  return (
    <>
      <Container>
        <Section size="1">
          <Heading size="9">Welkom op deze pagina</Heading>
          <Text size="5" color="red">
            Dit is een test
          </Text>
        </Section>
        <Section size="1">
          <Button>
            <CheckIcon /> Ok dat is fijn
          </Button>
        </Section>
      </Container>
    </>
  );
}

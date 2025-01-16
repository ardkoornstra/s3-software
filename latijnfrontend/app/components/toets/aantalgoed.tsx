import { Heading, Text } from "@radix-ui/themes";

interface AantalGoedProps {
  aantal: number;
}

export default function AantalGoed(props: AantalGoedProps) {
  return (
    <>
      <Text>Aantal goed</Text>
      <Heading align={"right"} size={"7"}>
        {props.aantal}
      </Heading>
    </>
  );
}

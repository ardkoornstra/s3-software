import { Heading, Text } from "@radix-ui/themes";

interface VraagNrProps {
  nummer: number;
  totaal: number;
}

export default function VraagNr(props: VraagNrProps) {
  return (
    <>
      <Text>Vraagnummer</Text>
      <Heading size={"7"}>
        {props.nummer} / {props.totaal}
      </Heading>
    </>
  );
}

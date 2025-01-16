import { Heading, Text } from "@radix-ui/themes";

interface VormProps {
  vraag: Vraag;
}

export default function Vorm(props: VormProps) {
  return (
    <>
      <Text align={"center"} as="div">
        Benoem de volgende vorm
      </Text>
      <Heading align={"center"} size={"9"}>
        {props.vraag.vorm}
      </Heading>
      <Text align={"center"} as="div">
        {props.vraag.infinitivus}, {props.vraag.praesens},{" "}
        {props.vraag.perfectum}, {props.vraag.supinum}
      </Text>
      <Text align={"center"} as="div">
        {props.vraag.betekenis}
      </Text>
    </>
  );
}

import { Heading, Text } from "@radix-ui/themes";

interface VormProps {
  werkwoordsvorm: Werkwoordsvorm;
}

export default function Vorm(props: VormProps) {
  return (
    <>
      <Text align={"center"} as="div">
        Benoem de volgende vorm
      </Text>
      <Heading align={"center"} size={"9"}>
        {props.werkwoordsvorm.vorm}
      </Heading>
      <Text align={"center"} as="div">
        {props.werkwoordsvorm.infinitivus}, {props.werkwoordsvorm.praesens},{" "}
        {props.werkwoordsvorm.perfectum}, {props.werkwoordsvorm.supinum}
      </Text>
      <Text align={"center"} as="div">
        {props.werkwoordsvorm.betekenis}
      </Text>
    </>
  );
}

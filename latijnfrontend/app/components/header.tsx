import { PersonIcon } from "@radix-ui/react-icons";
import { Box, Button, Flex, Heading } from "@radix-ui/themes";
import { LightDarkSwitch } from "./lightdarkswitch";
import Menu from "./menu";

export default function Header() {
  return (
    <Box className="header">
      <Flex justify="between" p="3">
        <Menu />
        <Heading>Latijnse Werkwoorden</Heading>
        <Flex gap="3">
          <Button>
            <PersonIcon />
            Log in
          </Button>
          <LightDarkSwitch />
        </Flex>
      </Flex>
    </Box>
  );
}

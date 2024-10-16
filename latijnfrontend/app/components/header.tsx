import { PersonIcon } from "@radix-ui/react-icons";
import { Box, Button, Flex, Heading } from "@radix-ui/themes";
import { LightDarkSwitch } from "./lightdarkswitch";
import Menu from "./menu";

export default function Header() {
  return (
    <Box className="header">
      <Flex justify="between" p="3">
        <Box width="33.33%">
          <Menu />
        </Box>
        <Box width="33.33%">
          <Heading align="center">Latijnse Werkwoorden</Heading>
        </Box>
        <Flex gap="3" justify="end" width="33.33%">
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

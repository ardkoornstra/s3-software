import {
  FileTextIcon,
  HamburgerMenuIcon,
  HomeIcon,
  ListBulletIcon,
  Pencil2Icon,
  QuestionMarkCircledIcon,
  QuestionMarkIcon,
} from "@radix-ui/react-icons";
import { DropdownMenu, IconButton } from "@radix-ui/themes";

export default function Menu() {
  return (
    <DropdownMenu.Root>
      <DropdownMenu.Trigger>
        <IconButton variant="surface">
          <HamburgerMenuIcon />
        </IconButton>
      </DropdownMenu.Trigger>
      <DropdownMenu.Content>
        <DropdownMenu.Item>
          <HomeIcon /> Home
        </DropdownMenu.Item>
        <DropdownMenu.Item>
          <FileTextIcon /> Grammatica
        </DropdownMenu.Item>
        <DropdownMenu.Item>
          <ListBulletIcon /> Woordenlijst
        </DropdownMenu.Item>
        <DropdownMenu.Separator />
        <DropdownMenu.Item>
          <QuestionMarkIcon /> Oefentoets
        </DropdownMenu.Item>
        <DropdownMenu.Item>
          <Pencil2Icon /> Toets
        </DropdownMenu.Item>
        <DropdownMenu.Separator />
        <DropdownMenu.Item>
          <QuestionMarkCircledIcon /> Help
        </DropdownMenu.Item>
      </DropdownMenu.Content>
    </DropdownMenu.Root>
  );
}

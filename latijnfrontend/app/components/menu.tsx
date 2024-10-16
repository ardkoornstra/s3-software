import {
  FileTextIcon,
  HamburgerMenuIcon,
  HomeIcon,
  ListBulletIcon,
  Pencil2Icon,
  QuestionMarkCircledIcon,
} from "@radix-ui/react-icons";
import { DropdownMenu, IconButton } from "@radix-ui/themes";
import Link from "next/link";

export default function Menu() {
  return (
    <DropdownMenu.Root>
      <DropdownMenu.Trigger>
        <IconButton variant="surface">
          <HamburgerMenuIcon />
        </IconButton>
      </DropdownMenu.Trigger>
      <DropdownMenu.Content>
        <Link href="/">
          <DropdownMenu.Item>
            <HomeIcon /> Home
          </DropdownMenu.Item>
        </Link>
        <Link href="/grammatica">
          <DropdownMenu.Item>
            <FileTextIcon /> Grammatica
          </DropdownMenu.Item>
        </Link>
        <Link href="/woordenlijst">
          <DropdownMenu.Item>
            <ListBulletIcon /> Woordenlijst
          </DropdownMenu.Item>
        </Link>
        <DropdownMenu.Separator />
        <Link href="/oefentoets">
          <DropdownMenu.Item>
            <Pencil2Icon /> Oefentoets
          </DropdownMenu.Item>
        </Link>
        <Link href="/toets">
          <DropdownMenu.Item>
            <Pencil2Icon /> Toets
          </DropdownMenu.Item>
        </Link>
        <DropdownMenu.Separator />
        <Link href="/help">
          <DropdownMenu.Item>
            <QuestionMarkCircledIcon /> Help
          </DropdownMenu.Item>
        </Link>
      </DropdownMenu.Content>
    </DropdownMenu.Root>
  );
}

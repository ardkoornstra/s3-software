"use client";
import { MoonIcon, SunIcon } from "@radix-ui/react-icons";
import { IconButton } from "@radix-ui/themes";
import { useTheme } from "next-themes";

export function LightDarkSwitch() {
  const { theme, setTheme } = useTheme();
  function switchTheme() {
    if (theme == "dark") {
      setTheme("light");
    } else if (theme == "light") {
      setTheme("dark");
    }
  }

  return (
    <IconButton variant="surface" onClick={() => switchTheme()}>
      {theme == "light" ? <SunIcon /> : <MoonIcon />}
    </IconButton>
  );
}

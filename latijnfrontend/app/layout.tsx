import type { Metadata } from "next";
import "@radix-ui/themes/styles.css";
import { Container, Theme } from "@radix-ui/themes";
import { ThemeProvider } from "next-themes";
import "./globals.css";
import Header from "./components/header";

export const metadata: Metadata = {
  title: "Latijn",
  description: "Werkwoorden oefenen",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="nl">
      <body>
        <ThemeProvider attribute="class" defaultTheme="light">
          <Theme accentColor="grass">
            <Header />
            <Container size="3">{children}</Container>
          </Theme>
        </ThemeProvider>
      </body>
    </html>
  );
}

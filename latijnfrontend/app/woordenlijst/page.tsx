"use client";
import { Heading, Section, Table } from "@radix-ui/themes";
import { useEffect, useState } from "react";

export default function Woordenlijst() {
  const array = [
    {
      id: 1,
      infinitivus: "a",
      praesens: "a",
      perfectum: "a",
      supinum: "a",
      conjugatie: 1,
      betekenis: "a",
    },
    {
      id: 2,
      infinitivus: "b",
      praesens: "b",
      perfectum: "b",
      supinum: "b",
      conjugatie: 2,
      betekenis: "b",
    },
  ];
  const [woordenlijst, setWoordenlijst] = useState<Werkwoord[]>(array);

  function createRows() {
    const rows = woordenlijst.map((woord) => (
      <Table.Row key={woord.id}>
        <Table.Cell>{woord.infinitivus}</Table.Cell>
        <Table.Cell>{woord.praesens}</Table.Cell>
        <Table.Cell>{woord.perfectum}</Table.Cell>
        <Table.Cell>{woord.supinum}</Table.Cell>
        <Table.Cell>{woord.conjugatie}</Table.Cell>
        <Table.Cell>{woord.betekenis}</Table.Cell>
      </Table.Row>
    ));
    return rows;
  }

  return (
    <>
      <Section size={"1"}>
        <Heading align={"center"}>Woordenlijst</Heading>
      </Section>
      <Table.Root>
        <Table.Header>
          <Table.Row>
            <Table.ColumnHeaderCell>Infinitivus</Table.ColumnHeaderCell>
            <Table.ColumnHeaderCell>Praesens</Table.ColumnHeaderCell>
            <Table.ColumnHeaderCell>Perfectum</Table.ColumnHeaderCell>
            <Table.ColumnHeaderCell>P.P.P</Table.ColumnHeaderCell>
            <Table.ColumnHeaderCell>Conjugatie</Table.ColumnHeaderCell>
            <Table.ColumnHeaderCell>Betekenis</Table.ColumnHeaderCell>
          </Table.Row>
        </Table.Header>

        <Table.Body>{createRows()}</Table.Body>
      </Table.Root>
    </>
  );
}

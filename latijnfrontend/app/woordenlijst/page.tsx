"use client";
import { Heading, Section, Table } from "@radix-ui/themes";
import { useEffect, useState } from "react";

export default function Woordenlijst() {
  const [woordenlijst, setWoordenlijst] = useState<Werkwoord[]>();

  useEffect(() => {
    if (!woordenlijst) {
      try {
        fetch("https://localhost:7125/api/Werkwoorden")
          .then((res) => res.json())
          .then((data) => setWoordenlijst(data));
      } catch (error) {
        console.log(error);
      }
    }
  }, []);

  function createRows() {
    if (woordenlijst) {
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
      <Section size={"1"}></Section>
    </>
  );
}

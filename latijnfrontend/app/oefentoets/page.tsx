"use client";

import { useEffect, useState } from "react";
import Vraag from "../components/toets/vraag";
import Setup from "../components/oefentoets/setup";
import Resultaat from "../components/toets/resultaat";
import { Toetsstate } from "@/types/toetsstate";

export default function Oefentoets() {
  const [state, setState] = useState<Toetsstate>(Toetsstate.Setup);
  const [toetsId, setToetsId] = useState<number>(0);
  const [toets, setToets] = useState<Toets>();
  const [vragen, setVragen] = useState<Vraag[]>();

  const [index, setIndex] = useState<number>(0);
  const totaal: number = 5;
  const [aantalGoed, setAantalGoed] = useState<number>(0);

  function HandleStateChange(toetsstate: Toetsstate) {
    if (toetsstate === Toetsstate.Question) {
      FetchData();
    } else if (toetsstate === Toetsstate.Result) {
      FetchAantalGoed();
    }
    setState(toetsstate);
  }

  function FetchData() {
    //create toets to get id
    const toets: Toets = {
      id: 0,
      name: "Test Test",
      aantalVragen: totaal,
      aantalGoed: 0,
      sessionId: 0,
    };
    try {
      fetch("https://localhost:7125/api/Toetsen", {
        method: "POST",
        body: JSON.stringify(toets),
        headers: {
          "Content-type": "application/json; charset=UTF-8",
        },
      })
        .then((res) => res.json())
        .then((data) => setToetsId(data));
    } catch (error) {
      console.log(error);
    }
  }

  function FetchAantalGoed() {
    try {
      fetch("https://localhost:7125/api/Toetsen?id=" + toetsId)
        .then((res) => res.json())
        .then((data) => setToets(data));
    } catch (error) {
      console.log(error);
    }
  }

  useEffect(() => {
    //get vragen by toetsid
    if (toetsId != 0) {
      try {
        fetch("https://localhost:7125/api/Vragen?toetsId=" + toetsId)
          .then((res) => res.json())
          .then((data) => setVragen(data));
      } catch (error) {
        console.log(error);
      }
    }
  }, [toetsId]);

  useEffect(() => {
    if (toets) {
      setAantalGoed(toets.aantalGoed);
    }
  }, [toets]);

  useEffect(() => {
    if (toetsId != 0) {
      FetchAantalGoed();
    }
  }, [index]);

  return (
    <>
      {(state === Toetsstate.Setup && (
        <Setup onHandleStateChange={HandleStateChange} />
      )) ||
        (state === Toetsstate.Question && (
          <Vraag
            totaal={totaal}
            index={index}
            setIndex={setIndex}
            aantalGoed={aantalGoed}
            setAantalGoed={setAantalGoed}
            vragen={vragen}
            onHandleStateChange={HandleStateChange}
          />
        )) ||
        (state === Toetsstate.Result && (
          <Resultaat
            toets={toets}
            aantalGoed={aantalGoed}
            totaal={totaal}
            onHandleStateChange={HandleStateChange}
          />
        ))}
    </>
  );
}

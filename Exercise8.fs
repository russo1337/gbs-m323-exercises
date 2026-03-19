namespace Excercises
open Lib

module Exercise8 =
    // Umrechnung Pound - Shilling - Penny
    // Darstellung als Tupel (pound, shilling, penny)

    let pencePerShilling = 12
    let shillingsPerPound = 20
    let pencePerPound = pencePerShilling * shillingsPerPound // 240

    /// In pence umrechnen
    let toPence (pound:int, shilling:int, penny:int) : int =
        pound * pencePerPound + shilling * pencePerShilling + penny

    /// Von pence in (pound, shilling, penny) umrechnen.
    /// Negative Beträge werden nicht speziell geprüft; Komponenten werden direkt aus Division/Modulo berechnet.
    let fromPence (totalPence:int) : int * int * int =
        let pounds = totalPence / pencePerPound
        let rem = totalPence % pencePerPound
        let shillings = rem / pencePerShilling
        let pence = rem % pencePerShilling
        (pounds, shillings, pence)

    /// Normalize: sorgt dafür, dass pence < 12 und shilling < 20 (mit Vorzeichenbehandlung)
    let normalize (p,s,c) = fromPence (toPence (p,s,c))

    /// Addition und Subtraktion
    let addPrices a b = fromPence (toPence a + toPence b)
    let subPrices a b = fromPence (toPence a - toPence b)

    // Beispiel: price = (Pound, Shilling, Penny)
    // Beispielwerte und Demo-Ausgabe
    let run() =
        let amount1 = (3, 25, 11) // 3 Pound 25 Shilling 11 Pence
        let amount2 = (1, 4, 6)   // 1 Pound 4 Shilling 6 Pence

        printfn "amount1 = %A" amount1
        printfn "amount2 = %A" amount2

        let sum = addPrices amount1 amount2
        let diff = subPrices amount1 amount2

        printfn "sum = %A" (normalize sum)
        printfn "diff = %A" (normalize diff)

        printfn "amount1 in pence = %d" (toPence amount1)
        printfn "amount2 in pence = %d" (toPence amount2)

        // weitere Beispiele
        printfn "0 als Tupel = %A" (fromPence 0)
        printfn "-1 Pence = %A" (fromPence -1)
        ()

namespace Excercises
open Lib

module Exercise9 =
    type Gerade = float * float

    let m (gerade: Gerade) = fst gerade
    let b (gerade: Gerade) = snd gerade

    let spiegelAnXAchse ((m, b): Gerade) : Gerade =
        (-m, -b)

    let spiegelAnYAchse ((m, b): Gerade) : Gerade =
        (-m, b)

    let sindParallel ((m1, _): Gerade) ((m2, _): Gerade) : bool =
        m1 = m2

    let sindSenkrecht ((m1, _): Gerade) ((m2, _): Gerade) : bool =
        m1 * m2 = -1.0

    let berechneY ((m, b): Gerade) x =
        m * x + b

    let enthaeltPunkt ((m, b): Gerade) (x, y) =
        y = m * x + b

    let schnittpunkt ((m1, b1): Gerade) ((m2, b2): Gerade) =
        if m1 = m2 then
            None
        else
            let x = (b2 - b1) / (m1 - m2)
            let y = m1 * x + b1
            Some (x, y)

    let verschiebeNachOben ((m, b): Gerade) delta =
        (m, b + delta)

    let sindIdentisch ((m1, b1): Gerade) ((m2, b2): Gerade) =
        m1 = m2 && b1 = b2

    let geradeAlsString ((m, b): Gerade) =
        sprintf "y = %gx + %g" m b

    let run () =
        let g1: Gerade = (2.0, 3.0)
        let g2: Gerade = (2.0, -1.0)
        let g3: Gerade = (-0.5, 4.0)

        printfn "Gerade g1: %s" (geradeAlsString g1)
        printfn "Gerade g2: %s" (geradeAlsString g2)
        printfn "Gerade g3: %s" (geradeAlsString g3)

        printfn "\n1. Spiegeln an X-Achse (g1): %A" (spiegelAnXAchse g1)

        printfn "2. Spiegeln an Y-Achse (g1): %A" (spiegelAnYAchse g1)

        printfn "3. Sind g1 und g2 parallel? %b" (sindParallel g1 g2)

        printfn "4. Sind g1 und g3 senkrecht? %b" (sindSenkrecht g1 g3)

        printfn "5. y-Wert von g1 für x = 5: %f" (berechneY g1 5.0)

        printfn "6. Liegt Punkt (1,5) auf g1? %b" (enthaeltPunkt g1 (1.0, 5.0))

        printfn "7. Schnittpunkt von g1 und g3: %A" (schnittpunkt g1 g3)

        printfn "8. g1 um 2 nach oben verschoben: %A" (verschiebeNachOben g1 2.0)

        printfn "9. Sind g1 und g2 identisch? %b" (sindIdentisch g1 g2)

        printfn "10. String Darstellung von g1: %s" (geradeAlsString g1)

        0

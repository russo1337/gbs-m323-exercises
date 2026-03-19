namespace Excercises
open Lib

module Exercise7 =
    // Brüche als Tupel darstellen (Zaehler:int, Nenner:int)

    let private normalize (n:int) (d:int) : int * int =
        if d = 0 then invalidArg "nenner" "Der Nenner darf nicht 0 sein"
        let g = Math.gcd n d
        let n' = n / g
        let d' = d / g
        if d' < 0 then (-n', -d') else (n', d')

    let reduce (n,d) = normalize n d

    let reciprocal (n,d) =
        if n = 0 then invalidArg "zaehler" "Kein Kehrwert fuer 0 moeglich"
        normalize d n

    let multk k (n,d) = normalize (n * k) d

    let mult (n1,d1) (n2,d2) = normalize (n1 * n2) (d1 * d2)

    let divk k (n,d) =
        if k = 0 then invalidArg "k" "Division durch 0 nicht erlaubt"
        normalize n (d * k)

    let div (n1,d1) (n2,d2) =
        if n2 = 0 then invalidArg "divisor" "Division durch Bruch mit Zaehler 0 nicht moeglich"
        normalize (n1 * d2) (d1 * n2)

    let asFloat (n,d) = float n / float d

    let expand k (n,d) =
        if k = 0 then invalidArg "k" "Erweitern mit 0 nicht erlaubt"
        normalize (n * k) (d * k)

    let add (n1,d1) (n2,d2) = normalize (n1 * d2 + n2 * d1) (d1 * d2)

    let sub (n1,d1) (n2,d2) = normalize (n1 * d2 - n2 * d1) (d1 * d2)

    let equal (a,b) (c,d) =
        let (an,ad) = reduce (a,b)
        let (cn,cd) = reduce (c,d)
        an = cn && ad = cd

    // Operatoren fuer Brueche (nach den Funktionen definiert)
    let (+) a b = add a b
    let (-) a b = sub a b
    let (*) a b = mult a b
    let (/) a b = div a b

    // Beispielausgabe
    let run() =
        let a = (1,2)
        let b = (3,4)
        printfn "a = %A, b = %A" a b
        printfn "a + b = %A" (add a b)
        printfn "a - b = %A" (sub a b)
        printfn "a * b = %A" (mult a b)
        printfn "a / b = %A" (div a b)
        printfn "a + b (Operator) = %A" (a + b)
        printfn "a * 2 (multk) = %A" (multk 2 a)
        printfn "Kehrwert von a = %A" (reciprocal a)
        printfn "a als Kommazahl = %g" (asFloat a)
        ()

namespace Examples
open Lib

module OperatorOverload =
    
    let run () =
        //Funktionen    
        let mul (a, b) (c, d) =
            (a * c), (b * d)
    
        let div (a, b) (c, d) =  
            (a * d), (b * c)

        let equal (a, b) (c, d) =
            let k1 = a * d
            let k2 = b * c
            k1 = k2

        //let a1 = (1, 2)
        //let a2 = (2, 3)
        //let quot = a1 * a2

        //Operatoren überladen
        let (*) a b = mul a b
        let (/) a b = div a b
        let (==) a b = equal a b
        let (<>) a b = not (a == b)
        let b1 = (1, 2)
        let b2 = (2, 3)

        //Funktionen anwenden
        let p = mul b1 b2
        let q = div b1 b2
        let e = equal b1 b2
        let ne = not (equal b1 b2)
        printfn "Product: %A" p
        printfn "Quotient: %A" q
        printfn "Equal: %b" e
        printfn "Not Equal: %b" ne

        //Operatoren anwenden 
        let quot = b1 / b2
        let prod = b1 * b2 
        let eq = b1 == b2
        let neq = b1 <> b2

        printfn "Product: %A" prod
        printfn "Quotient: %A" quot
        printfn "Equal: %b" eq
        printfn "Not Equal: %b" neq

        //funktioniert nicht mehr, da * Operator überladen wurde
        //let mult2 a b = a * b
        //let res = mult2 3 4
        //printfn "Mult2: %d" res

namespace Excercises
open Lib

module Excercise5 =

    let run () =
        
        let calc func a b = 
            func a b
        let result1 = calc Math.add 5 10
        printfn "The result of adding 5 and 10 is %d" result1

        let result2 = calc Math.subtract 5 8
        printfn "The result of subtracting 8 from 5 is %d" result2

        let calc2 (s :string) =
            match s with
            | "add" -> Math.add
            | "subtract" -> Math.subtract
            | "multiply" -> Math.multiply
            | "divide" -> Math.divide

        let result3 = calc (calc2 "multiply") 5 10
        printfn "The result of multiplying 5 and 10 is %d" result3

        let calc3 (s :string) a b =
            match s with
            | "add" -> Math.add a b
            | "subtract" -> Math.subtract a b
            | "multiply" -> Math.multiply a b
            | "divide" -> Math.divide a b

        let result4 = calc3 "divide" 10 5
        printfn "The result of dividing 10 by 5 is %d" result4
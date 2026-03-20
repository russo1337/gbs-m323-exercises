open Excercises
open Examples

[<EntryPoint>]
let main argv =
    printfn "Running Exercise 1 and 2..."
    Exercise1and2.run()
    printfn "-----------------------------------"
    printfn "Running Exercise 3..."
    Exercise3.run()
    printfn "-----------------------------------"
    printfn "Running Exercise 5..."
    Exercise5.run()
    printfn "-----------------------------------"
    printfn "Running Partial Appliction..."
    PartialExamples.run()
    printfn "-----------------------------------"
    printfn "Running Exercise 7..."
    Exercise7.run()
    printfn "-----------------------------------"
    printfn "Running OperatorOverload example"
    OperatorOverload.run()
    printfn "-----------------------------------"
    printfn "Running Exercise 8..."
    Exercise8.run()
    printfn "-----------------------------------"
    printfn "Running Exercise 9..."
    Exercise9Tuple.run()
    Exercise9.run()
    printfn "-----------------------------------"
    printfn "Running Record Excercise ..."
    ExerciseRecords.run()
    printfn "Finished running Excercises. Press any key to exit."

    0

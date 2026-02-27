open Excercises

[<EntryPoint>]
let main argv =
    printfn "Running Excercise 1 and 2..."
    Excercise1and2.run()
    printfn "-----------------------------------"
    printfn "Running Excercise 3..."
    Excercise3.run()
    printfn "-----------------------------------"
    printfn "Running Excercise 5..."
    Excercise5.run()
    printfn "-----------------------------------"
    printfn "Running Partial Appliction..."
    PartialExamples.run()

    printfn "Finished running Excercises. Press any key to exit."

    0

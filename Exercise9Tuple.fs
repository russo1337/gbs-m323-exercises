namespace Excercises
open Lib

module Exercise9Tuple =
    
    let gerade1 = (2.0, 3.0)
    let gerade2 = (2.0, -1.0)
    let gerade3 = (2.0, 8.0)

    let mirrorX (m, b) = (-m, -b)
    let mirrorY (m, b) = (-m, b)
    let isparallel (m1, _) (m2, _) = m1 = m2
    let isperpendicular (m1, _) (m2, _) = m1 * m2 = -1.0

    let run () =
        printfn "senkrecht %b" (isperpendicular gerade1 gerade2)
        printfn "parallel %b" (isparallel gerade1 gerade3)
        0

namespace Excercises
open Lib

module ExerciseAlias =
    // Type alias for a 2D vector with non-integer components
    type Vector2 = float * float

    // Basic vector operations
    let add (ax, ay) (bx, by) : Vector2 = (ax + bx, ay + by)

    let sub (ax, ay) (bx, by) : Vector2 = (ax - bx, ay - by)

    let scale k (x, y) : Vector2 = (k * x, k * y)

    let dot (ax, ay) (bx, by) : float = ax * bx + ay * by

    // 6. Betrag (Länge) eines Vektors
    let magnitude (x, y) : float = sqrt (x * x + y * y)

    // 7. Einheitsvektor: v / |v|
    let normalize v : Vector2 =
        let mag = magnitude v
        if mag = 0.0 then (0.0, 0.0) else scale (1.0 / mag) v

    let run () =
        0

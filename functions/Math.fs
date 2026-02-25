namespace Lib

module Math =

    let add a b = a + b
    let subtract a b = a - b
    let multiply a b = a * b
    let divide a b = a / b

    let rec summerizeFromTo start finish =
         match start with
            | start when start > finish -> 0   
            | start -> start + summerizeFromTo (start + 1) finish
    let fibonacci n =
        let rec fib n =
            match n with
                | 0 -> 0
                | 1 -> 1
                | n -> fib (n - 1) + fib (n - 2)
        fib n
    let rec factorial (n:int64) :int64 =
        match n with
            | 0L -> 1
            | n -> n * factorial (n - 1L)

    let pythagorean (a:float) (b:float) : float =
        sqrt (a ** 2.0 + b ** 2.0)

    let celciusToFahrenheit (c:float) : float =
        (c * 9.0 / 5.0) + 32.0

    let fahrenheitToCelcius (f:float) : float =
        (f - 32.0) * 5.0 / 9.0

    let scoreToGrade (score:float) (maxScore:float) : float =
        System.Math.Round((score * 5.0 / maxScore) + 1.0, 1)

    let gcd a b =
        let rec gcd' a b =
            match b with
                | 0 -> a
                | _ -> gcd' b (a % b)
        gcd' a b

    let lcm a b =
        (a * b) / gcd a b

    let primesFromTo a b =
        let isPrime n =
            if n < 2 then false
            else
                let rec checkDivisors d =
                    d * d > n || (n % d <> 0 && checkDivisors (d + 1))
                checkDivisors 2
        [a .. b] |> List.filter isPrime


        



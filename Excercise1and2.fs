namespace Excercises
open Lib

module Excercise1and2 =

    let sum = Math.add 5 10
    printfn "The sum of 5 and 10 is %d" sum

    let summerize = Math.summerizeFromTo 1 5
    printfn "The summerize from 1 to 5 is %d" summerize

    let factorial = Math.factorial 5
    printfn "The factorial of 5 is %d" factorial

    let factorial64 = Math.factorial 20L
    printfn "The factorial of 20 is %d" factorial64

    let fibonacci = Math.fibonacci 10
    printfn "The 10th Fibonacci number is %d" fibonacci

    let pythagorean = Math.pythagorean 3.0 4.0
    printfn "The hypotenuse of a right triangle with sides 3 and 4 is %f" pythagorean

    let celciusToFahrenheit = Math.celciusToFahrenheit 25.0
    printfn "25 degrees Celcius is %f degrees Fahrenheit" celciusToFahrenheit

    let fahrenheitToCelcius = Math.fahrenheitToCelcius 77.0
    printfn "77 degrees Fahrenheit is %f degrees Celcius" fahrenheitToCelcius

    let score = 88.0
    let maxScore = 99.0    
    let scoreToGrade = Math.scoreToGrade score maxScore
    printfn "A score of %f out of %f corresponds to a grade of %f" score maxScore scoreToGrade

    let gcd = Math.gcd 48 18
    printfn "The greatest common divisor of 48 and 18 is %d" gcd

    let lcm = Math.lcm 48 18
    printfn "The least common multiple of 48 and 18 is %d" lcm




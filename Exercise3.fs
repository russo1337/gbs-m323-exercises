namespace Excercises
open Lib

module Exercise3 =

    let run () =
        let price1 = 253.3
        let price2 = 121.5
        let price3 = 30.0

        let netPrice1 = NetPrice.calculateNetPrice price1
        let netPrice2 = NetPrice.calculateNetPrice price2
        let netPrice3 = NetPrice.calculateNetPrice price3

        printfn "The net price for an item costing %f is %f" price1 netPrice1
        printfn "The net price for an item costing %f is %f" price2 netPrice2
        printfn "The net price for an item costing %f is %f" price3 netPrice3

        let primesFrom = 1
        let primesTo = 999
        let listOfPrimes = Math.primesFromTo primesFrom primesTo
        printfn "The prime numbers from %d to %d are: %A" primesFrom primesTo listOfPrimes

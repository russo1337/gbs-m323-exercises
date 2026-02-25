namespace Excercises
open Lib

module Excercise3 =

    let price1 = 253.3
    let price2 = 121.5
    let price3 = 30.0

    let netPrice1 = NetPrice.calculateNetPrice price1
    let netPrice2 = NetPrice.calculateNetPrice price2
    let netPrice3 = NetPrice.calculateNetPrice price3

    printfn "The net price for an item costing %f is %f" price1 netPrice1
    printfn "The net price for an item costing %f is %f" price2 netPrice2
    printfn "The net price for an item costing %f is %f" price3 netPrice3


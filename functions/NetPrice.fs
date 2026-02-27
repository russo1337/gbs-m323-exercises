namespace Lib

module NetPrice =
    let discountedPrice price = 
        match price with
        | price when price > 200.0 -> price * 0.90
        | price when price > 100.0 -> price * 0.95
        | _ -> price

    let under50add10Surcharge price =
        if price < 50.0 then price + 10.0 else price

    let addShipping price =
        match price with
        | price when price > 150.0 -> price
        | _ -> price + 20.0

    let calculateNetPrice price =
        System.Math.Round (
            discountedPrice price 
            |> under50add10Surcharge 
            |> addShipping 
        ,1)

    let calculateNetPrice2 price =
        System.Math.Round (price |> discountedPrice |> under50add10Surcharge |> addShipping ,1)





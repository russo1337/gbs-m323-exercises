namespace Excercises
open Lib

module Excercise6 =

    // -- Constants (units: cm for radius/thickness, g/cm^3 for density, currency per gram)
    let vreneliRadiusCm = 1.05
    let vreneliThicknessCm = 0.13

    let densityGold_g_cm3 = 19.32
    let densitySilver_g_cm3 = 10.49

    let priceGold_per_g = 130.0
    let priceSilver_per_g = 2.3

    // -- Helper functions
    let coinVolume (radius_cm:float) (thickness_cm:float) : float =
        System.Math.PI * radius_cm * radius_cm * thickness_cm

    let coinMass (radius_cm:float) (thickness_cm:float) (density_g_cm3:float) : float =
        coinVolume radius_cm thickness_cm * density_g_cm3

    // -- Mass and volume using helpers
    let vreneliVolume_cm3 = coinVolume vreneliRadiusCm vreneliThicknessCm
    let vreneliMass_g_gold = coinMass vreneliRadiusCm vreneliThicknessCm densityGold_g_cm3
    let vreneliMass_g_silver = coinMass vreneliRadiusCm vreneliThicknessCm densitySilver_g_cm3

    // Main function to calculate coin value
    let coinValue (radius_cm:float) (thickness_cm:float) (density_g_cm3:float) (price_per_g:float) : float =
        coinMass radius_cm thickness_cm density_g_cm3 * price_per_g

    // Partially apply size -> function that takes density then price
    let vreneliCoin = coinValue vreneliRadiusCm vreneliThicknessCm

    // Partially apply density -> function that takes price
    let vreneliGold = vreneliCoin densityGold_g_cm3
    let vreneliSilver = vreneliCoin densitySilver_g_cm3

    // Fully applied values
    let vreneliValue_gold = vreneliGold priceGold_per_g
    let vreneliValue_silver = vreneliSilver priceSilver_per_g

    let run() =
        printfn "Vreneli (radius=%g cm, thickness=%g cm)" vreneliRadiusCm vreneliThicknessCm
        printfn "Volume: %g cm^3" vreneliVolume_cm3
        printfn "Mass (gold): %g g" vreneliMass_g_gold
        printfn "Mass (silver): %g g" vreneliMass_g_silver
        printfn "Value (gold @ %g per g): %g" priceGold_per_g vreneliValue_gold
        printfn "Value (silver @ %g per g): %g" priceSilver_per_g vreneliValue_silver
        ()


namespace Excercises

module PartialExamples =

    let run() =
        let multiply a b = a * b
        let double = multiply 2
        let result = double 5
        printfn "Double of 5 is %d" result
    
    
        let addiere a b c = a + b + c

        let addPartial1 = addiere 1
        let addPartial2 = addPartial1 2
        let addPartial3 = addPartial2 3
        printfn "The result of adding 1, 2 and 3 is %d" addPartial3

        let say (s1:string) (s2:string) (s3:string) =
            printfn "%s %s %s" s1 s2 s3

        let sayHello = say "Hello"
        let sayHelloMr = sayHello "Mr"
        let sayHelloMrMueller = sayHelloMr "Müller"
        let sayHalloHerr = say "Hallo" "Herr"
        say "Hallo" "Herr" "Müller"
        sayHello "Mis" "Meier"
        sayHelloMr "Manser"
        sayHelloMrMueller
        sayHalloHerr "Müller"
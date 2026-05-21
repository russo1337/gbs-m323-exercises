namespace TestExercises1

open System
open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type Test1 () =

    [<DataTestMethod>]
    [<DataRow(2, 3, 5)>]
    [<DataRow(-1, 1, 0)>]
    [<DataRow(0, 0, 0)>]
    member this.TestAdd (a:int, b:int, expected:int) =
        Assert.AreEqual<int>(expected, Lib.Math.add a b)

    [<DataTestMethod>]
    [<DataRow(5, 3, 2)>]
    [<DataRow(0, 1, -1)>]
    [<DataRow(-2, -3, 1)>]
    member this.TestSubtract (a:int, b:int, expected:int) =
        Assert.AreEqual<int>(expected, Lib.Math.subtract a b)

    [<DataTestMethod>]
    [<DataRow(2, 3, 6)>]
    [<DataRow(-1, 5, -5)>]
    [<DataRow(0, 10, 0)>]
    member this.TestMultiply (a:int, b:int, expected:int) =
        Assert.AreEqual<int>(expected, Lib.Math.multiply a b)

    [<DataTestMethod>]
    [<DataRow(6, 3, 2)>]
    [<DataRow(5, 2, 2)>]
    [<DataRow(-6, 3, -2)>]
    member this.TestDivide (a:int, b:int, expected:int) =
        Assert.AreEqual<int>(expected, Lib.Math.divide a b)
        
    [<TestMethod>]
    member this.TestDivideByZero () =
        // divide uses failwith on division by zero which raises System.Exception
        Assert.Throws<System.Exception>(
            System.Action(fun () -> Lib.Math.divide 1 0 |> ignore)
        ) |> ignore

    [<DataTestMethod>]
    [<DataRow(6, 3, 2)>]
    [<DataRow(5, 2, 2)>]
    [<DataRow(-6, 3, -2)>]
    member this.TestDivide2 (a:int, b:int, expected:int) =
        match Lib.Math.divide2 a b with
        | Ok v -> Assert.AreEqual<int>(expected, v)
        | Error msg -> Assert.Fail(sprintf "Expected Ok %d but got Error: %s" expected msg)

    [<TestMethod>]
    member this.TestDivide2ByZero () =
        match Lib.Math.divide2 1 0 with
        | Ok v -> Assert.Fail(sprintf "Expected Error but got Ok %d" v)
        | Error msg -> Assert.AreEqual("Division by zero", msg)


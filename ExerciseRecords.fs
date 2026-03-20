namespace Excercises
open Lib

module ExerciseRecords =
    // Aufgabe: Adresse- und Person-Records
    type Address = { Street: string; City: string; PostalCode: string; Country: string }

    type Person = { Name: string; Age: int; Address: Address }

    let createPersonWithAddress (name:string) (age:int) (address:Address) : Person =
        { Name = name; Age = age; Address = address }

    let printPersonWithAddress (p:Person) : unit =
        let a = p.Address
        printfn "Name: %s" p.Name
        printfn "Age: %d" p.Age
        printfn "Address: %s, %s %s, %s" a.Street a.PostalCode a.City a.Country
    
    // --- Aufgabe 2: Student Record und Funktionen
    // Student: Name, Matrikelnummer, Noten (Tupel mit 5 Noten)
    type Student = { Name: string; Matrikelnummer: int; Noten: float * float * float * float * float }

    /// Durchschnittsnote berechnen (ohne Listen)
    let durchschnitt (s:Student) : float =
        let (a,b,c,d,e) = s.Noten
        (a + b + c + d + e) / 5.0

    /// Median der 5 Noten berechnen (ohne Listen)
    let median (s:Student) : float =
        let (a,b,c,d,e) = s.Noten
        let isMedian x =
            let less = (if a < x then 1 else 0) + (if b < x then 1 else 0) + (if c < x then 1 else 0) + (if d < x then 1 else 0) + (if e < x then 1 else 0)
            let greater = (if a > x then 1 else 0) + (if b > x then 1 else 0) + (if c > x then 1 else 0) + (if d > x then 1 else 0) + (if e > x then 1 else 0)
            less <= 2 && greater <= 2
        if isMedian a then a
        elif isMedian b then b
        elif isMedian c then c
        elif isMedian d then d
        else e

    /// Prüfen, ob Student bestanden hat (ohne Listen)
    /// Regeln: Durchschnitt >= 4.0 und die Summe der Abweichungen der Einzelnoten unter 4
    /// (jeweils grade - 4.0) darf nicht kleiner sein als -1.0
    let bestanden (s:Student) : bool =
        let avg = durchschnitt s
        let (a,b,c,d,e) = s.Noten
        let belowSum =
            (if a < 4.0 then a - 4.0 else 0.0) +
            (if b < 4.0 then b - 4.0 else 0.0) +
            (if c < 4.0 then c - 4.0 else 0.0) +
            (if d < 4.0 then d - 4.0 else 0.0) +
            (if e < 4.0 then e - 4.0 else 0.0)
        avg >= 4.0 && belowSum >= -1.0

    // Beispielverwendung
    let runStudents () =
        let s1 = { Name = "Anna"; Matrikelnummer = 12345; Noten = (4.5, 5.0, 3.0, 4.0, 4.2) }
        let s2 = { Name = "Boris"; Matrikelnummer = 54321; Noten = (3.0, 3.5, 6.0, 6.0, 6.0) }
        printfn "Student %s: avg=%g median=%g passed=%b" s1.Name (durchschnitt s1) (median s1) (bestanden s1)
        printfn "Student %s: avg=%g median=%g passed=%b" s2.Name (durchschnitt s2) (median s2) (bestanden s2)
        ()

    let run () =
        let addr = { Street = "Baker Street 221B"; City = "London"; PostalCode = "NW1"; Country = "UK" }
        let person = createPersonWithAddress "Sherlock Holmes" 40 addr
        printPersonWithAddress person
        // also run student examples
        runStudents()
        0

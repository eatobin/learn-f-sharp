// [eric@eric-macmini dot-netish]$ dotnet new console --language F#
// [eric@eric-macmini dot-netish]$ dotnet run

// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

// Define a function to construct a message to print
let from whom = sprintf "from %s" whom

[<EntryPoint>]
let main _ =
    let message =
        from "F#!!!!!? Ericky to Karen!! Bye! New house!!" // Call the function

    printfn "Hello world %s" message

    let numbers = [ 0 .. 100 ]

    let myFun (l: int list): int =
        l
        |> List.filter (fun x -> x % 2 = 0)
        |> List.map (fun x -> x * 2)
        |> List.sum

    let res = myFun numbers

    printfn "answer: %i" res

    let rec len l =
        match l with
        | [] -> 0
        | _ :: tail -> len tail + 1

    let list1 = [ "a"; "b" ]
    let res2 = len list1
    let list2 = [ 1 .. 10 ]
    let res3 = len list2
    printfn "length l1: %i" res2
    printfn "length l2: %i" res3

    let lenR l =
        let rec loop cur cnt =
            match cur with
            | [] -> cnt
            | (_ :: tail) -> loop tail (cnt + 1)

        loop l 0

    let list10 = [ "a"; "b" ]
    let res20 = lenR list10
    let list20 = [ 1 .. 10 ]
    let res30 = lenR list20
    let list30 = [ 1 .. 100001 ]
    let res40 = lenR list30
    printfn "length l10: %i" res20
    printfn "length l20: %i" res30
    printfn "length l30: %i" res40

    0 // return an integer exit code

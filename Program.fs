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

    let MyFun (l: int list): int =
        l
        |> List.filter (fun x -> x % 2 = 0)
        |> List.map (fun x -> x * 2)
        |> List.sum

    let res = MyFun numbers

    printfn "answer: %i" res

    0 // return an integer exit code

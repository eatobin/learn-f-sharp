// [eric@eric-macmini dot-netish]$ dotnet new console --language F#
// [eric@eric-macmini dot-netish]$ dotnet run

// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

// Define a function to construct a message to print
let from whom = sprintf "from %s" whom

[<EntryPoint>]
let main _ =
    let message = from "F#!!!!!? Ericky to Karen!! Bye!" // Call the function
    printfn "Hello world %s" message
    0 // return an integer exit code

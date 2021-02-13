printfn "Hello World from F# and Ericky Jones!! And one more."

let rec sum aList =
    match aList with
    | [] -> 0
    | x :: xs -> x + sum xs

let s = sum [ 1 .. 10 ]
printfn "answer = %i" s

let rec boom i =
    match i with
    | 0 -> 999
    | _ -> boom (i - 1)

let res = boom 3
printfn "boom = %i" res

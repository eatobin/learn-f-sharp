let inputs =
    [ 199
      200
      208
      210
      200
      207
      240
      269
      260
      263 ]

inputs
|> List.windowed 2
|> List.map (fun p -> p.[0] < p.[1])
|> List.map (fun b -> if b then 1 else 0)
|> List.sum

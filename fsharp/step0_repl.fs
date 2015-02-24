module REPL
    let read input =
        input

    let eval ast =
        ast

    let print v =
        printfn "=> %A" v

    let rep input =
        input
        |> read
        |> eval
        |> print

    [<EntryPoint>]
    let rec main args =
        match System.Console.ReadLine() with
        | null -> 0
        | input -> 
            rep input
            main args

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    printfn "\nPress any key to continue."  
    System.Console.ReadKey(true) |> ignore  
    0 // return an integer exit code

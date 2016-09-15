﻿// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System
open System.Windows.Forms

[<EntryPoint>]
let main argv = 
    let form = new Form(Text = "First F# form")
    let button = new Button(Text = "Click me to close!", Dock = DockStyle.Fill)
    button.Click.Add(fun _ -> Application.Exit() |> ignore)
    form.Controls.Add(button)
    Application.Run(form);
    0
       
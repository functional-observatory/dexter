module Main

open Elmish
open Elmish.React
open Elmish.Debug
open Elmish.HMR

// App
Program.mkProgram App.init App.update App.render
|> Program.withReactSynchronous "app"
|> Program.run

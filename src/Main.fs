module Main

open Elmish
open Elmish.React
open Elmish.Debug
open Elmish.HMR

// App
Program.mkProgram MessageBroker.init MessageBroker.update App.render
|> Program.withReactSynchronous "app"
|> Program.run

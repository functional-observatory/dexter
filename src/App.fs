module App

open Feliz
open Elmish
open Components.Header
open Components.Style
open Components.Card

type State = { Count: int }

type Msg =
  | Increment
  | Decrement

let init () = { Count = 0 }, Cmd.none

let update (msg: Msg) (state: State) =
  match msg with
  | Increment -> { state with Count = state.Count + 1 }, Cmd.none
  | Decrement -> { state with Count = state.Count - 1 }, Cmd.none

let render (state: State) (dispatch: Msg -> unit) =
  Html.div [ style
             header (Some "Doppler")
             card ]

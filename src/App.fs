module App

open Feliz
open Elmish
open Components.Header
open Components.Style
open Components.Card
open Components.Text
open Fable.SimpleHttp

type RemotePokemon<'a> =
  | NotLoaded
  | Loading
  | Loaded of 'a

type State = { ResponseText: RemotePokemon<Result<string, string>> }

type Msg = GetData of int | DataLoaded of string | DataError of string

let getPokemon (pokeId: int) = async {
  let! (statusCode, responseText) = Http.get (sprintf "https://pokeapi.co/api/v2/pokemon/%i" pokeId)
  return if statusCode = 200 then DataLoaded responseText else DataError "Cannot get Pokemon"
}

let withLoadPokemon pokeId state = state, Cmd.OfAsync.perform getPokemon pokeId id
let withoutLoadPokemon state = state, Cmd.none

let init () = { ResponseText = NotLoaded } |> (withLoadPokemon 151)

let update (msg: Msg) (state: State) =
  match msg with
  | GetData pokeId -> { state with ResponseText = Loading } |> withLoadPokemon pokeId
  | DataLoaded data -> { state with ResponseText = Loaded (Ok data) } |> withoutLoadPokemon
  | DataError error -> { state with ResponseText = Loaded (Error error) } |> withoutLoadPokemon

let renderData (data: RemotePokemon<Result<string, string>>) =
  match data with
  | NotLoaded -> Html.none
  | Loading -> text [] "Loading"
  | Loaded (Ok pokemon) -> text [] pokemon
  | Loaded (Error error) -> text [] error

let render (state: State) (dispatch: Msg -> unit) =
  Html.div [ style
             header (Some "Doppler")
             renderData state.ResponseText
             card ]

module MessageBroker

open Fable.SimpleHttp
open Elmish

type RemotePokemon<'a> =
  | NotLoaded
  | Loading
  | Loaded of 'a

type State =
  { ResponseText: RemotePokemon<Result<string, string>>
    SearchText: string }

type Msg =
  | GetData of string
  | DataLoaded of string
  | DataError of string

let getPokemon (pokeId: string) =
  async {
    let! (statusCode, responseText) = Http.get (sprintf "https://pokeapi.co/api/v2/pokemon/%s" pokeId)
    return if statusCode = 200 then DataLoaded responseText else DataError "Cannot get Pokemon"
  }

let withLoadPokemon (state: State) =
  state, Cmd.OfAsync.perform getPokemon (state.SearchText.ToLower()) id

let withoutLoadPokemon state = state, Cmd.none

let init () =
  { ResponseText = NotLoaded
    SearchText = "Ho-oh" }
  |> withLoadPokemon

let update (msg: Msg) (state: State) =
  match msg with
  | GetData pokemonName ->
      if (pokemonName.Length > 3) then
        { state with
            ResponseText = Loading
            SearchText = pokemonName }
        |> withLoadPokemon
      else
        { state with SearchText = pokemonName }, Cmd.none
  | DataLoaded data ->
      { state with
          ResponseText = Loaded(Ok data) }
      |> withoutLoadPokemon
  | DataError error ->
      { state with
          ResponseText = Loaded(Error error) }
      |> withoutLoadPokemon

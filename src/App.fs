module App

open Feliz
open Elmish
open Components.Grid
open Components.Flex
open Components.Style
open Components.Card
open Components.Text
open Fable.SimpleHttp

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

let renderData (data: RemotePokemon<Result<string, string>>) =
  match data with
  | NotLoaded -> Html.none
  | Loading -> text [] "Loading"
  | Loaded (Ok pokemon) -> card pokemon
  | Loaded (Error error) -> text [] error

let pageLayout =
  [ style.alignItems.center
    style.custom ("gridTemplateColumns", "1fr 1fr")
    style.custom ("placeItems", "center")
    style.custom ("justifyContent", "stretch")
    style.height (length.vh 100) ]

let searchInput =
  [ style.fontSize 90
    style.width (length.percent 70)
    style.color "#fbfbfc"
    style.custom ("background", "none")
    style.backgroundColor "none"
    style.custom ("border", "none") ]

let render (state: State) (dispatch: Msg -> unit) =
  grid
    pageLayout
    [ styles
      column [ style.alignItems.center
               style.height (length.percent 100)
               style.fontFamily "'Roboto', sans-serif"
               style.justifyContent.spaceAround ] [
        Html.input [ prop.style searchInput
                     prop.custom ("spellCheck", false)
                     prop.autoFocus true
                     prop.className "searchInput"
                     prop.type'.text
                     prop.value state.SearchText
                     prop.onChange (GetData >> dispatch) ]
        Html.a [ prop.style [ style.fontSize 24
                              style.textDecoration.none
                              style.color "#fbfbfc"
                              style.width (length.percent 70) ]
                 prop.text "View Source 👨‍💻"
                 prop.href "https://github.com/rajatsharma/doppler" ]
      ]
      renderData state.ResponseText ]

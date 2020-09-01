module App

open Feliz
open MessageBroker
open Components.Card
open Components.Flex
open Components.Grid
open Components.Link
open Components.Search
open Components.Style
open Components.Text

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

let render (state: State) (dispatch: Msg -> unit) =
  grid
    pageLayout
    [ styles
      column [ style.alignItems.center
               style.height (length.percent 100)
               style.fontFamily "'Roboto', sans-serif"
               style.justifyContent.spaceAround ] [
        (searchInput (state.SearchText, (fun text -> text |> GetData |> dispatch)))
        (link "👨‍💻 View Code" "https://github.com/rajatsharma/dexter")
      ]
      renderData state.ResponseText ]

module Components.Card

open Feliz
open Components.Flex
open Components.Grid
open Components.Text
open Components.Typegradient
open Fable.JsonProvider

type P = Generator<"https://pokeapi.co/api/v2/pokemon/151">

let cardLayout pokemonType =
  [ style.width 300
    style.borderRadius 15
    style.margin 10
    style.height 450
    style.padding 15
    style.backgroundImage (getGradient pokemonType)
    style.alignItems.center ]

let cardHero =
  [ style.width (length.percent 100)
    style.position.relative
    style.height 300
    style.alignItems.center
    style.justifyContent.center
    style.backgroundColor "rgba(0,0,0,0.8)" ]

let cardDesc =
  [ style.marginTop 10
    style.color "#060713"
    style.zIndex 1
    style.backgroundColor "rgba(255, 255, 255, 0.7)"
    style.width (length.percent 100)
    style.height (length.percent 100) ]

let cardTitle =
  [ style.color "#060713"
    style.textTransform.capitalize
    style.fontSize 20
    style.fontWeight.bolder ]

let subTitle =
  [ style.color "#060713"
    style.textTransform.capitalize
    style.fontWeight.bolder
    style.fontStyle.italic ]

let stat =
  [ style.color "#060713"
    style.textTransform.capitalize
    style.fontSize 12
    style.fontStyle.italic ]

let abilitiesGrid =
  [ style.marginTop 10
    style.custom ("place-content", "center")
    style.custom ("column-gap", "10px")
    style.custom ("grid-template-columns", "1fr 1fr") ]

let movesGrid =
  [ style.marginTop 10
    style.custom ("column-gap", "10px")
    style.custom ("grid-template-rows", "1fr 1fr") ]

type CardProps = { Pokemon: string }

let card' =
  React.functionComponent
    ("Card",
     (fun (props: CardProps) ->
       column
         (cardLayout (Array.head (P props.Pokemon).types).``type``.name)
         [ row
             cardHero
             [ Html.img [ prop.src (P props.Pokemon).sprites.other.``official-artwork``.front_default
                          prop.style [ style.position.absolute ]
                          prop.className "cardHero"
                          prop.width 300
                          prop.height 350 ] ]
           column
             cardDesc
             [ column [ style.alignItems.center ] [
                 text cardTitle (P props.Pokemon).name
                 text subTitle (sprintf "%s Pokemon" (P props.Pokemon).types.[0].``type``.name)
               ]
               column [ style.padding 10 ] [
                 text [ style.fontWeight.bolder ] "Moves"
                 grid
                   movesGrid
                   [ yield! Array.map (fun (elem: P.Moves) -> text [] elem.move.name)
                              (Array.take 3 (P props.Pokemon).moves) ]
               ]
               column [ style.padding 10 ] [
                 text [ style.fontWeight.bolder ] "Abilities"
                 grid
                   movesGrid
                   [ yield! Array.map (fun (elem: P.Abilities) -> text [] elem.ability.name) (P props.Pokemon).abilities ]
               ] ] ]))

let card (pokemon: string) = card' ({ Pokemon = pokemon })

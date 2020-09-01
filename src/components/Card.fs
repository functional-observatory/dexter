module Components.Card

open Feliz
open Operators
open AppUtils.PokemonColor
open AppUtils.Shades
open Components.Flex
open Components.Grid
open Components.Text
open Types.Api

let cardLayout pokemonType =
  [ style.width 300
    style.borderRadius 15
    style.margin 10
    style.height 450
    style.custom ("placeSelf", "center")
    style.padding 15
    style.backgroundImage
    <| getPokemonColor pokemonType
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
    style.color dark
    style.zIndex 1
    style.backgroundColor "rgba(255, 255, 255, 0.7)"
    style.width (length.percent 100)
    style.height (length.percent 100) ]

let cardTitle =
  [ style.color dark
    style.textTransform.capitalize
    style.fontSize 20
    style.fontWeight.bolder ]

let subTitle =
  [ style.color dark
    style.textTransform.capitalize
    style.fontWeight.bolder
    style.fontStyle.italic ]

let movesGrid =
  [ style.marginTop 10
    style.custom ("columnGap", "10px")
    style.custom ("gridTemplateRows", "1fr 1fr") ]

type CardProps = { Pokemon: string }

let ``Pokemon Card`` =
  "Card"
  => fun (props: CardProps) ->
       let pokemon = Pokemon props.Pokemon

       let pokemonType = (Array.head pokemon.types).``type``.name

       let pokemonImage =
         pokemon.sprites.other.``official-artwork``.front_default

       let pokemonMoves =
         Array.map (fun (elem: Pokemon.Moves) -> text [] elem.move.name) (Array.take 3 pokemon.moves)

       let pokemonAbilities =
         Array.map (fun (elem: Pokemon.Abilities) -> text [] elem.ability.name) pokemon.abilities

       column
         (cardLayout pokemonType)
         [ row
             cardHero
             [ Html.img [ prop.src pokemonImage
                          prop.style [ style.position.absolute ]
                          prop.className "cardHero"
                          prop.width 300
                          prop.height 350 ] ]
           column
             cardDesc
             [ column [ style.alignItems.center ] [
                 text cardTitle pokemon.name
                 text subTitle (sprintf "%s Pokemon" pokemonType)
               ]
               column [ style.padding 10 ] [
                 text [ style.fontWeight.bolder ] "Moves"
                 grid movesGrid [ yield! pokemonMoves ]
               ]
               column [ style.padding 10 ] [
                 text [ style.fontWeight.bolder ] "Abilities"
                 grid movesGrid [ yield! pokemonAbilities ]
               ] ] ]

let card (pokemon: string) = ``Pokemon Card`` ({ Pokemon = pokemon })

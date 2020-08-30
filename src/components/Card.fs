module Components.Card

open Feliz
open Components.Flex
open Components.Grid
open Components.Text

let cardLayout =
  [ style.width 350
    style.borderRadius 15
    style.margin 10
    style.height 500
    style.padding 15
    style.backgroundImage "linear-gradient(-225deg, #69EACB 0%, #EACCF8 48%, #6654F1 100%)"
    style.alignItems.center ]

let cardHero =
  [ style.width (length.percent 100)
    style.height 200
    style.alignItems.center
    style.justifyContent.center
    style.backgroundColor "rgba(0,0,0,0.8)" ]

let cardDesc =
  [ style.marginTop 10
    style.color "#060713"
    style.justifyContent.center
    style.alignItems.center
    style.backgroundColor "rgba(255, 255, 255, 0.5)"
    style.width (length.percent 100) ]

let cardDescName =
  [ style.paddingBottom 6
    style.justifyContent.spaceBetween ]

let cardTitle =
  [ style.color "#060713"
    style.fontSize 20
    style.fontWeight.bolder ]

let subTitle =
  [ style.color "#060713"
    style.fontWeight.bolder
    style.fontStyle.italic ]

let statGrid =
  [ style.marginTop 10
    style.custom ("place-content", "center")
    style.custom ("column-gap", "10px")
    style.custom ("grid-template-columns", "1fr 1fr") ]

let card' =
  React.functionComponent
    ("Card",
     (fun _ ->
       column
         cardLayout
         [ row
             cardHero
             [ Html.img [ prop.src "https://pokeres.bastionbot.org/images/pokemon/151.png"
                          prop.className "cardHero"
                          prop.width 300
                          prop.height 180 ] ]
           column
             cardDesc
             [ column [ style.alignItems.center ] [
                 text cardTitle "Mu"
                 text subTitle "Psychic Pokemon"
               ]
               grid
                 statGrid
                 [ text [ style.textTransform.uppercase ] "Height"
                   text [] "35"
                   text [ style.textTransform.uppercase ] "Weight"
                   text [] "35" ] ] ]))

let card = card' ()

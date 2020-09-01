module Components.Style

open Feliz
open Operators
open AppUtils.Shades

let styles' =
  "Style"
  => fun _ ->
    Html.style
      (sprintf """
       body {
          font-family: 'Raleway', sans-serif;
          background: %s;
          color: %s;
       }

       .cardHero {
          object-fit: scale-down;
       }
  """   dark light)

let styles = styles' ()

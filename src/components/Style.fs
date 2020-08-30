module Components.Style

open Feliz

let style' =
  React.functionComponent
    ("Style",
     (fun _ ->
       Html.style """
       body {
          font-family: 'Raleway', sans-serif;
          background: #060713;
          color: #fbfbfc;
       }

       .cardHero {
          object-fit: scale-down;
       }
  """))

let style = style' ()

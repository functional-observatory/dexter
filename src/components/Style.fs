module Components.Style

open Feliz

let styles' =
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

       : focus {
          outline: none;
       }
  """))

let styles = styles' ()

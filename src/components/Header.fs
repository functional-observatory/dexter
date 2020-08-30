module Components.Header

open Feliz

type HeaderProps = { Title: string }

let header' =
  React.functionComponent
    ("Header",
     (fun (props: HeaderProps) ->
       Html.div [ prop.style [ style.width (length.percent 100)
                               style.height 60
                               style.display.flex
                               style.alignItems.center
                               style.justifyContent.center
                               style.backgroundImage "linear-gradient(135deg, #667eea 0%, #764ba2 100%)" ]
                  prop.children [ Html.h1  props.Title ] ]))

let header title = header' { Title = title }

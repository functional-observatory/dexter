module Components.Text

open Feliz

type TextProps =
  { Style: IStyleAttribute list
    Text: string }

let text' =
  React.functionComponent
    ("Text",
     (fun (props: TextProps) ->
       Html.div [ prop.style [ style.display.flex
                               if props.Style.Length > 0 then yield! props.Style ]
                  prop.text props.Text ]))

let text (style: IStyleAttribute list) (text: string) = text' { Style = style; Text = text }

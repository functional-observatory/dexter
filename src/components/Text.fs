module Components.Text

open Feliz
open Operators

type TextProps =
  { Style: IStyleAttribute list
    Text: string }

let text' =
  "Text"
  => fun (props: TextProps) ->
       Html.div [ prop.style [ style.textTransform.capitalize
                               if props.Style.Length > 0 then yield! props.Style ]
                  prop.text props.Text ]

let text (style: IStyleAttribute list) (text: string) = text' { Style = style; Text = text }

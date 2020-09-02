module Components.Link

open Feliz
open Operators

type LinkProps = { Href: string; Text: string }

let link' =
  "Link"
  => fun (props: LinkProps) ->
       Html.a [ prop.style [ style.fontSize 24
                             style.textDecoration.none
                             style.color "currentColor"
                             style.width (length.percent 70) ]
                prop.text props.Text
                prop.href props.Href ]

let link (text: string) (href: string) = link' { Href = href; Text = text }

module Components.Grid

open Feliz
open Operators

type GridProps =
  { Style: IStyleAttribute list
    Children: Fable.React.ReactElement list }

let grid' =
  "Grid"
  => fun (props: GridProps) ->
       Html.div [ prop.style [ style.display.grid
                               if props.Style.Length > 0 then yield! props.Style ]
                  prop.children props.Children ]

let grid (style: IStyleAttribute list) (children: Fable.React.ReactElement list) =
  grid' { Style = style; Children = children }

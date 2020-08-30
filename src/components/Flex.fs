module Components.Flex

open Feliz

type FlexProps =
  { Style: IStyleAttribute list
    Children: Fable.React.ReactElement list }

let flex' =
  React.functionComponent
    ("Flex",
     (fun (props: FlexProps) ->
       Html.div [ prop.style [ style.display.flex
                               if props.Style.Length > 0 then yield! props.Style ]
                  prop.children props.Children ]))

let row (style: IStyleAttribute list) (children: Fable.React.ReactElement list) =
  flex' { Style = style; Children = children }

let column (styles: IStyleAttribute list) (children: Fable.React.ReactElement list) =
  flex'
    { Style =
        [ style.flexDirection.column
          yield! styles ]
      Children = children }

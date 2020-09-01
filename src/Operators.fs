module Operators

open Feliz

let inline (=>)<'props> (componentName: string) (reactComponent: 'props -> Fable.React.ReactElement) =
  React.functionComponent (componentName, reactComponent)

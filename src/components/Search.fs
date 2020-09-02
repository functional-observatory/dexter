module Components.Search

open Feliz
open Operators
open AppUtils.Shades

let searchInputStyle =
  [ style.fontSize 90
    style.width (length.percent 70)
    style.color "currentColor"
    style.custom ("background", "none")
    style.backgroundColor "none"
    style.custom ("border", "none") ]

type SearchInputProps =
  { Value: string
    OnChange: string -> unit }

let ``Search Input`` =
  "Search"
  => fun (props: SearchInputProps) ->
       Html.input [ prop.style searchInputStyle
                    prop.custom ("spellCheck", false)
                    prop.autoFocus true
                    prop.className "searchInput"
                    prop.type'.text
                    prop.value props.Value
                    prop.onChange props.OnChange ]

let searchInput (value: string, onChange: string -> unit) =
  ``Search Input`` ({ Value = value; OnChange = onChange })

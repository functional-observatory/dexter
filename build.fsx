#load ".paket/load/netcoreapp3.1/Feliz.ViewEngine.fsx"
#load ".paket/load/netcoreapp3.1/Fake.Core.Process.fsx"

open System
open Fake.Core
open Feliz.ViewEngine

let globalStyles = """
html {
    box-sizing: border-box;
  }

  html,
  body {
    margin: 0;
    padding: 0;
    height: 100%;
  }

  input {
    font-family: Roboto, sans-serif;
    font-weight: 900;
  }

  :focus {
    outline: none;
  }

  a:visited {
    color: currentColor;
  }

  a:active {
    color: currentColor;
  }
"""

let html =
  Html.html [ Html.head [ Html.title "Dexter"
                          Html.meta [ prop.httpEquiv.contentType
                                      prop.content "text/html; charset=utf-8" ]
                          Html.meta [ prop.name "viewport"
                                      prop.content "width=device-width, initial-scale=1" ]
                          Html.script [ prop.src "https://cdn.polyfill.io/v2/polyfill.js?features=es6" ]
                          Html.link [ prop.href
                                        "https://fonts.googleapis.com/css2?family=Raleway:wght@200;800&family=Roboto:wght@900&display=swap"
                                      prop.rel.stylesheet ]
                          Html.style globalStyles ]
              Html.body [ Html.div [ prop.id "app" ] ] ]
  |> Render.htmlView

let argv = Environment.GetCommandLineArgs()

let mode =
  if argv.Length = 3
  then argv.[2]
  else failwith "Please pass one of the arg: dev or build"

IO.File.WriteAllText("src/index.html", html)

CreateProcess.fromRawCommandLine "./node_modules/.bin/phi" mode
|> Proc.run
|> ignore

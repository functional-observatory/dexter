module AppUtils.PokemonColor

let rec getPokemonColor pokemonType =
  match pokemonType with
  | "bug" -> "linear-gradient(120deg, #d4fc79 0%, #96e6a1 100%)"
  | "dark" -> "linear-gradient(to top, #30cfd0 0%, #330867 100%)"
  | "dragon" -> "linear-gradient(to top, #d299c2 0%, #fef9d7 100%)"
  | "electric" -> "linear-gradient(to right, #fa709a 0%, #fee140 100%)"
  | "fairy" -> "linear-gradient(to top, #feada6 0%, #f5efef 100%)"
  | "fighting" -> "linear-gradient(to top, #6a85b6 0%, #bac8e0 100%)"
  | "fire" -> "linear-gradient(to right, #f83600 0%, #f9d423 100%)"
  | "flying" -> "linear-gradient(to top, #f3e7e9 0%, #e3eeff 99%, #e3eeff 100%)"
  | "ghost" -> "linear-gradient(60deg, #29323c 0%, #485563 100%)"
  | "grass" -> "linear-gradient(to top, #0fd850 0%, #f9f047 100%)"
  | "ground" -> "linear-gradient(to top, #e6b980 0%, #eacda3 100%)"
  | "ice" -> "linear-gradient(to top, #bdc2e8 0%, #bdc2e8 1%, #e6dee9 100%)"
  | "normal" -> "linear-gradient(-225deg, #fffeff 0%, #d7fffe 100%)"
  | "poison" -> "linear-gradient(-225deg, #ac32e4 0%, #7918f2 48%, #4801ff 100%)"
  | "psychic" -> "linear-gradient(-225deg, #69eacb 0%, #eaccf8 48%, #6654f1 100%)"
  | "rock" -> "linear-gradient(to top, lightgrey 0%, lightgrey 1%, #e0e0e0 26%, #efefef 48%, #d9d9d9 75%, #bcbcbc 100%)"
  | "steel" ->
      "linear-gradient(-180deg, #bcc5ce 0%, #929ead 98%), radial-gradient(at top left, rgba(255,255,255,0.30) 0%, rgba(0,0,0,0.30) 100%)"
  | "water" -> "linear-gradient(120deg, #89f7fe 0%, #66a6ff 100%)"
  // If no above type found return colors of normal type
  | _ -> getPokemonColor "normal"

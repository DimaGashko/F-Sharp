let rec len x = 
    if List.isEmpty x then 0
    else 1 + len (List.tail x)

let rec len2 = function
    | [] -> 0
    | _::tl -> 1 + len2 tl

let isVowels = function
    |'A'|'E'|'I'|'O'|'U'|'a'|'e'|'i'|'o'|'u' -> true
    | _ -> false

let rec countVowels = function
    [] -> 0
    | h::t when isVowels h -> 1 + countVowels t
    | _::t -> countVowels t

countVowels (List.ofSeq "aeiouyyy555oooo")

let test = function
    | [x;_;_] when x = 1 -> 1
    | _ -> 0

test [1;2;3;4]

let ff x =
   let rec _ff x acc =
      if x <= 1 then acc
      else _ff (x - 1) (acc * x)
 
   _ff x 1
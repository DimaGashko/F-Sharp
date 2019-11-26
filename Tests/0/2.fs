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
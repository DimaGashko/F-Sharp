let mutable a = 10

a <- 5

printf "%d" a

let items = [1..10]

let r = List.append items [6]

let wrap by str: string =
    by + str + by

let names = ["Makr"; "Doe"; "Jane"]

let aWrap = wrap "@"

let doubleWrap = wrap "+" << wrap "-"

let res = 
    names
    |> Seq.map aWrap
    |> Seq.map (fun x -> printf "Mapped over %s \n" x; "xxx-" + x)
    |> Seq.map (wrap "?" >> doubleWrap)

res
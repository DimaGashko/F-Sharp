let mutable a = 10

a <- 5

printf "%d" a

let items = [1..10]

let r = List.append items [6]

let prefix prefixStr baseStr =
    prefixStr + ", " + baseStr

prefix "Hello" "Jeck"


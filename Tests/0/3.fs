let disp = List.filter (fun x -> x % 17 = 0)

let dispr n = List.filter (fun x -> x % n = 0)

let t = dispr 5

let gencount n =
   let x = ref (n-1) in
   fun() -> (x:=!x + 1; !x )

let count = gencount 10


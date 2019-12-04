let product predicate =
   List.filter predicate >> (List.fold (*) 1)

let productOfNegs = product (fun x -> x < 0)
let productOfOdds = product (fun x -> x % 2 <> 0)

productOfNegs [-1;-2;-3]
productOfNegs [2;3;-2;-5]
productOfNegs [1;2;3;-5;4]
productOfNegs [1;2;3;4]
productOfNegs []

productOfOdds [1;2;3;4;5]

product (fun x -> x < 4) [5;2;3;4;5;1;2]
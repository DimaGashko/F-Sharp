let productOfNegs =
    List.filter (fun x -> x < 0) >> (List.fold (*) 1)

productOfNegs [-1;-2;-3]
productOfNegs [2;3;-2;-5]
productOfNegs [1;2;3;-5;4]
productOfNegs [1;2;3;4]
productOfNegs []
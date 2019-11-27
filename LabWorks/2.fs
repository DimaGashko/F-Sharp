let rec productOfNegs = function
    | [] -> 1
    | x::t when x < 0 -> x * productOfNegs t
    | _::t -> productOfNegs t

productOfNegs [-1;-2;-3]
productOfNegs [2;3;-2;-5]
productOfNegs [1;2;3;-5;4]
productOfNegs [1;2;3;4]
productOfNegs []

// https://math.stackexchange.com/questions/110546/what-is-the-product-of-the-empty-set
// https://en.wikipedia.org/wiki/Empty_product
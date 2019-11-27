let rec productOfNegs = function
   | [] -> 1
   | x::t when x < 0 -> x * productOfNegs t
   | _::t -> productOfNegs t

let productOfNegsTail x = 
   let rec _productOfNegs acc = function
      | [] -> acc
      | x::tail when x < 0 -> _productOfNegs (acc * x) tail
      | _::tail -> _productOfNegs acc tail

   _productOfNegs 1 x

productOfNegs [-1;-2;-3]
productOfNegsTail [-1;-2;-3]

productOfNegs [2;3;-2;-5]
productOfNegsTail [2;3;-2;-5]

productOfNegs [1;2;3;-5;4]
productOfNegsTail [1;2;3;-5;4]

productOfNegs [1;2;3;4]
productOfNegsTail [1;2;3;4]

productOfNegs []
productOfNegsTail []

// https://math.stackexchange.com/questions/110546/what-is-the-product-of-the-empty-set
// https://en.wikipedia.org/wiki/Empty_product

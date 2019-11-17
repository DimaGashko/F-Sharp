let rec pow x n =
    if n = 0 then 1.
    else x * pow x (n - 1)

let pow2 x = x * x

let rec fact x =
    if x <= 1 then 1.
    else float x * fact (x - 1)

let step x n = 
    fact (n * 2) / (pow 4. n * (fact >> pow2) n) *
    (fun k -> (pow x k) / float k)(n * 2 + 1)

let rec _arcsin x n eps =
    let v = step x n

    if abs v < eps then v
    else v + _arcsin x (n + 1) eps

let arcsin x =
    _arcsin x 0 0.001

arcsin 0.0
arcsin 0.5 
arcsin -0.5
arcsin 0.9

asin 0.0
asin 0.5 
asin -0.5
asin 0.9

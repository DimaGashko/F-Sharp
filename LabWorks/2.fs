let rec mulOfNegs = function
    | [] -> 0
    | x::t when x < 0 -> x * if mulOfNegs t <> 0 then mulOfNegs t else 1
    | _::t -> mulOfNegs t

mulOfNegs [2;3;-1;-2;-3]
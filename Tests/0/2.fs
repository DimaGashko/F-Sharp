
match [2;1;3] with 
| [2;hhh;y] -> printfn "x=%A y=%A" hhh y
| 1::tail -> printfn "tail=%A" tail 
| [] -> printfn "empty"
| _ -> printfn "else"

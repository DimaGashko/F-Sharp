let rec genlist n clo =
   if n = 0 then []
   else clo()::genlist (n-1) clo

let sinCosGen (initialAngle: float) step =
   let mutable angle = initialAngle - step;
   fun() -> (angle <- angle + step; (sin angle, cos angle))

let sinCosGenRef (initialAngle: float) step =
   let angle = ref (initialAngle - step);
   fun() -> (angle := !angle + step; (sin !angle, cos !angle))

genlist 10 (sinCosGen 0.0 (System.Math.PI / 4.))
   |> List.map (fun x -> sprintf "\t(%.3f,%.3f)\n" (fst x) (snd x))
   |> List.reduce (+)

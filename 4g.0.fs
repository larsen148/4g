(* Opgave [opgavenummer (3i, 4g osv)]
 * Gruppe nr 2:
    * Marie
    * Martin
    * Mathias
*)

(* 4g.0 *)
module vec2d
(* len function*)

(* The function takes a tuple containing an x and an y coordinate, and
calculates the length of the vector *)

/// <param name="x"> The x coordinate of the vector </param>
/// <param name="y"> The y coordinate of the vector </param>
/// <returns> The length of the vector </returns>

let len (x:float, y:float) : float =
  let v = sqrt(x**2.0 + y**2.0)
  v

(* ang function*)

(* The function takes a tuple containing an x and an y coordinate, and
calculates the angle of the vector *)

/// <param name="x"> The x coordinate of the vector </param>
/// <param name="y"> The y coordinate of the vector </param>
/// <returns> The vectors angle </returns>

let ang (x:float, y:float) : float =
  let v = atan2 x y
  v

(* scale function*)

(* The function takes a tuple containing an x and an y coordinate, as well as an
a value. Then the function calculates a new up-/downscaled vector *)

/// <param name="a"> The order of which the vector will be scaled </param>
/// <param name="x"> The x coordinate of the vector </param>
/// <param name="y"> The y coordinate of the vector </param>
/// <returns> The a new vector, up-/downscaled depending on a </returns>

let scale (a:float) (x:float, y:float) : float*float =
  let x2 = a*x
  let y2 = a*y
  let v = (x2, y2)
  v

(* add function*)

(* The function takes two tuples each containing an x and an y coordinate, and
calculates the sum vector *)

/// <param name="x1"> The x coordinate of the first vector </param>
/// <param name="y1"> The y coordinate of the first vector </param>
/// <param name="x2"> The x coordinate of the second vector </param>
/// <param name="y3"> The y coordinate of the second vector </param>
/// <returns> A third vector, which is the sum of the two vectors </returns>

let add (x1:float, y1:float) (x2:float, y2:float) : float*float =
  let x3 = x1 + x2
  let y3 = y1 + y2
  let v = (x3, y3)
  v

(* add function*)

(* The function takes two tuples each containing an x and an y coordinate, and
calculates the dot product of the two vectors *)

/// <param name="x1"> The x coordinate of the first vector </param>
/// <param name="y1"> The y coordinate of the first vector </param>
/// <param name="x2"> The x coordinate of the second vector </param>
/// <param name="y3"> The y coordinate of the second vector </param>
/// <returns> A float, the dot product of the two vecotrs </returns>

let dot (x1:float, y1:float) (x2:float, y2:float) : float =
  let x3 = x1 * x2
  let y3 = y1 * y2
  let v = x3 + y3
  v

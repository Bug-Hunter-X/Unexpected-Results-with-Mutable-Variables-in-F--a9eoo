let mutable x = 10
let mutable y = 20
let add x y = 
    let sum = x + y
    x <- x + 1 //Modifying x
    y <- y + 1 //Modifying y
    sum
printf "%d" (add x y)
//Alternatively, avoid mutable variables altogether
let add2 x y = x + y
let x2 = 10
let y2 = 20
let sum2 = add2 x2 y2
printf "%d" sum2
//Another solution:
let add3 (x:byref<int>) (y:byref<int>) = 
    let sum = x + y
    x <- x + 1
    y <- y + 1
    sum
let mutable x3 = 10
let mutable y3 = 20
let sum3 = add3 &x3 &y3
printf "%A" (x3,y3,sum3)
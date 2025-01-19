let mutable x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d %d" x y // Output: 10 11

let y2 = addOne x // reassign y2 to reflect the change in x
x <- addOne x
printfn "%d %d %d" x y y2 //Output: 12 11 12

//Alternatively, if you don't need to retain the initial value of y,  you can directly mutate y:
let mutable y3 = addOne x
 x <- addOne x
y3 <- addOne x // directly update y3
printfn "%d %d" x y3 // Output: 12 13
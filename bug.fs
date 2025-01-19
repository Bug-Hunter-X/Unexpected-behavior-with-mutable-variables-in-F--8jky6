let mutable x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d %d" x y // Output: 10 11
x <- addOne x
printfn "%d %d" x y //Output: 11 11

//In the above example, x is mutable. The value of x is changed after the function call of addOne. However, y is not updated to reflect the change in x, because y was assigned a value based on the value of x at the time of the function call. This is a common pitfall for beginners in F#.
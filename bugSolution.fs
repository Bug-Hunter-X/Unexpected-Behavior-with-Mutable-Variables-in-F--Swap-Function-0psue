let x = ref 10
let y = ref 20

let swap x y = 
    let temp = !x
    x := !y
    y := temp

swap x y
printf "%d %d" (!x) (!y)

//Alternative Functional Approach

let swap2 (x,y) = (y,x)
let x2 = 10
let y2 = 20
let (x3,y3) = swap2 (x2, y2)
printf "%d %d" x3 y3
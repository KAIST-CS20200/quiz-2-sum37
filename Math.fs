module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let isEven (n:uint64) =
  if n%2UL =0UL then true
  else false

let collatz n =
  let rec iter (n:uint64) counter =
    if n=1UL then counter
    elif isEven n then iter (n/2UL) (counter+1)
    else iter (3UL*n+1UL) (counter+1)
  iter (uint64 n) 0

//오ㅐ 틀렸냐면 overflow때문임. 그래서 문제가 발생한 거임. 끄어억 unsigned로 해보자

// let collotz n =
//   let rec iter cnt n =
//     let result =f n
//     printfn "%d" result
//     if result = 1 then cnt
//     else cnt+1 result
//   iter 1 n

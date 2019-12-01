module File2

open System
//Input from console
let read _ = Console.ReadLine()
let isValid = function null -> false | _ -> true
let inputList = Seq.initInfinite read |> Seq.takeWhile isValid |> Seq.toList
               // |>List.map(fun x->x|>int)

//let reading parser =
//    Seq.initInfinite (fun _ -> Console.ReadLine())
//    |> Seq.choose (parser >> function true, v -> Some v | _ -> None)
//Dividing head and tail part
let numOfSeq = inputList.Head 
let remList = inputList.Tail

let remList2 = inputList.Tail.Head.Split(' ')|> Array.toList|>List.map(fun x->x |> int)|>List.take (numOfSeq|>int)
                
//-------------List Replication  ---------------------//
let f n (arr:int list) = 
        let mutable x = []
        for j = 0 to arr.Length-1 do
         for i=1 to n do
           x <-arr.[j]::x 
 
        x
        |>List.rev

//---------------Filter by given number---------------------//
let filterfun n (arr:int list)=
    let mutable x = []
    let mutable y = []
    for i=0 to arr.Length-1 do
        match arr.[i]<n with
        |true-> x <- arr.[i]::x
        |false -> y <- arr.[i]::y

    x|>List.rev

//let result = filterfun numOfSeq remList
//result|>List.iter(fun x-> printfn "%A" x)
//printfn "%A" (filterfun numOfSeq remList)


//------------revese a list---------------------//
let revList (arr:int list) =
    let mutable x = []
    for i=0 to arr.Length-1 do
        x<-arr.[i]::x
    x

//let res = revList inputList
//res|>List.iter(fun x-> printfn "%A" x)

//--------------Filter odd positions in a list-----------///

let filterPos (arr:int list) =
        let mutable x = []
        let mutable y = []
        for i=0 to arr.Length-1 do
                match (i%2)=0 with
                |true->  x<-arr.[i]::x
                |false -> y<-arr.[i]::y

        y

//---------Sum of odd elements--------------------//
let sumOdd (arr: int list)= 
        arr|>List.filter(fun x->x%2<>0)
        |>List.sum

 //-----------E ^ x evaluation -------------//

let power x y =
  seq { 1..y } |> Seq.fold (fun m _ -> m * x) 1.0

let factorial x =
  seq { 1..x } |> Seq.fold (fun m v -> m * float(v)) 1.0

let sum s =
  s |> Seq.fold (fun s v -> s + v) 0.0

let ex x =
  seq { 0..9 }
  |> Seq.map (fun n -> (power x n) / (factorial n))
  |> sum


//printfn "%A" (ex 2.0)



//-------------------  Counting number of Socks Pair  -----------------------//

let SockPair (arr:int list) = 
    arr|>Seq.countBy(fun x->x)
            |>Seq.filter(fun (a,b) -> b>1) 
            |>Seq.map(fun (a,b) -> b/2)
            |>Seq.toList|>List.sum 
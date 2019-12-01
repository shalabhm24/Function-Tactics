// Learn more about F# at http://fsharp.org
    module File1
    open FSharp.Core

    let inline a x = x*x

    let am = a 10
    printf "%d" am
    let inline printAsFloatingPoint number =
        printfn "%f" (float number)

    let printFloat (number) =
        printfn "%f" (float number)

    let c = printFloat 'c'

    let f1 name = 
        name + " FSharp"

    let f2 name =
        name + " Programming"

    let composedFun = f1>>f2

    printf "%A" (composedFun "Hello")

    type Year =  
       | January = 0  
       | Fabruary = 1  
       | March = 2  
       | April = 3  
  
// Use of an enumeration.  
    let monthName = enum<Year>(3)  
    printf "%A" monthName  
    let monthLiteral : Year = Year.January  
    let n = int monthLiteral  
    printf "\n%d" n 


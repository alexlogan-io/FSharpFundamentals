type Person = {name:string;age:int}

let data = [
    {name="Adam";age=4}
    {name="Joe";age=40}
    {name="Otis";age=22}
    {name="Jordan";age=23}
    {name="Hattie";age=22}
]

let namesOfAdults = List.filter (fun p -> p.age >= 18) data
                    |> List.map (fun p -> p.name)

open System.Linq
let namesOfAdultsLinq = 
    data   
        .Where(fun p -> p.age >= 18)
        .Select(fun p -> p.name)
printfn "%A" namesOfAdultsLinq 

let namesOfAdultsLinqQuery = 
    query {
        for p in data do
        where (p.age >= 18)
        select p.name
    }
printfn "%A" namesOfAdultsLinqQuery

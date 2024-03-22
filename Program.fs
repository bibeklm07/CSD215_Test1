// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello! It's me Bibek"

let earnings = [75000M; 48000M; 120000M; 190000M; 300113M; 92000M; 36000M]

//Filtering high-income earnings
let highEarnings = earnings |> List.filter (fun earning -> earning > 100000M)

//Calculating tax for all earnings
let calculateTax earning =
    match earning with
    | x when x <= 49020M -> 0.15M * x
    | x when x <= 98040M -> 0.205M * x
    | x when x <= 151978M -> 0.26M * x
    | x when x <= 216511M -> 0.29M * x
    | _ -> 0.33M * earning

let taxes = earnings |> List.map calculateTax

//Adding $20,000 to earnings less than $49,020
let adjustEarnings = earnings |> List.map (fun earning -> if earning < 49020M then earning + 20000M else earning)

//Sum of earnings between $50,000 and $100,000
let sumEarnings = 
    earnings 
    |> List.filter (fun earning -> earning >= 50000M && earning <= 100000M) 
    |> List.sum

// Output results
printfn "Income of High Earnings: %A" highEarnings
printfn "Taxes: %A" taxes
printfn "Adjusted Earnings: %A" adjustEarnings
printfn "Sum of Earnings between $50,000 and $100,000: %M" sumEarnings

// Tail recursion
let rec addMultiplesOf3 b gcc =
    if b = 0 then gcc
    else addMultiplesOf3 (b - 3) (gcc + b)

// Example usage
let result = addMultiplesOf3 60 0
printfn "Add of multiples of 3 up to 60: %d" result



let  f = fun f-> f>500

let procutlist = [300;400;550;600;545]

let costlyPrroduct= procutlist |> List.filter f

costlyPrroduct |> List.iter (printfn "%d")

 

let taxedProduct =
    List.map (fun price ->
        if price < 500 then float price + float price * 0.15
        elif price >= 500 then float price + float price * 0.20
        else float price
    ) procutlist
 


printfn "Taxed Product: %A" taxedProduct

let sumOfProducts = List.fold (fun acc price -> acc + price) 0 procutlist

printfn "Sum of Products: %d" sumOfProducts



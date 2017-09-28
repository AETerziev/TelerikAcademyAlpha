function theBiggestOfFiveNumbers(args){
    let numbers=args.map(Number);
    numbers.sort((a,b)=>{
        return a-b;
    }).reverse();
    
    return numbers[0];
}

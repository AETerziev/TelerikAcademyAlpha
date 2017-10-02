'use strict'

const isPrime = ((number) => {
    for (let i = 2; i < number; i++) {
        if (number % i === 0 && i !== number){
            return false;
        }
    }
    return true;
});

let sumArrayOfNumbers=((args)=>{

    if(parseInt(args[0])!=NaN && parseInt(args[1])!=NaN){
        var fromRange=parseInt(args[0]);
        var toRange=parseInt(args[1]);
    }
    else{
        throw 'One of the arguments is not a legit number!';
    }
    let result=[];
    for(let i=fromRange;i<=toRange;i++){
        if(isPrime(i)){
            result.push(i);
        }
    }
    console.log(result);
});
let sumArrayOfNumbers=((args)=>{
let sum=0;
    if(args==undefined){
        throw 'No argument was passed!';
    }
    
    if(args==false){
        return null;
    }

    for(let i=0;i<args.length;i++){
        if(!(sum+=parseInt(args[i]))){
            throw 'The element could not be parsed to int';
        }
    }

    return sum;
});

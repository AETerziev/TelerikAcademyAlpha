let largerThanNeighbours=((args)=>{
    let counter=0;
    for(let i= 0;i<args.length;i++){
        if(i===0){
            if(+args[i]>+args[i+1]){
                counter++;
            }
        }
        else if(i===args.length-1){
            if(+args[i]>+args[i-1]){
                counter++;
            }
        }
        else{
            if(+args[i]>+args[i-1] && +args[i]>+args[i+1]){
                counter++;
            }
        }
    }
    return counter;
});
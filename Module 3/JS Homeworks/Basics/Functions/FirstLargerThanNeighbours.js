let firstLargerThanNeighbour=((args)=>{
    for(let i= 0;i<args.length;i++){
        if(i===0){
            if(+args[i]>+args[i+1]){
                return i;
            }
        }
        else if(i===args.length-1){
            if(+args[i]>+args[i-1]){
                return i;
            }
        }
        else{
            if(+args[i]>+args[i-1] && +args[i]>+args[i+1]){
                return i;
            }
        }
    }
    return -1;
});
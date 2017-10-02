let appearanceCount=((numberToFind,args)=>{
    let counter=0;
    for(let i= 0;i<args.length;i++){
        if(numberToFind==args[i]){
            counter++;
        }
    }
    return counter;
});
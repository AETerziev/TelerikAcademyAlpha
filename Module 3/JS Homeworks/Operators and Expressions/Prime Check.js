function primeCheck(args){
    let number=parseInt(args[0]);
    let counter=0;
    if(number<0){
    return false;
    }
    for(let i=1;i<=number;i++){
        if(number%i==0 && i!=number && i!=1){
            return 'false';
        }
    }
    return 'true';
}
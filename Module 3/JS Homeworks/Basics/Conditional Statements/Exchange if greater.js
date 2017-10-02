function exchangeIfGreater(args){
    let a = args[0];
    let b = args[1];
    if(a>b){
        return b + ' ' + a;
    }
    else{
        return a + ' ' + b;
    }

}

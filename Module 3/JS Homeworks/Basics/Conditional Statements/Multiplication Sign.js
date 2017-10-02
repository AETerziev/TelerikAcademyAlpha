function multiplicationSign(args){
    let x=args[0];
    let y=args[1];
    let z=args[2];
    if(x*y*z<0){
        return '-';
    }
    else if(x*y*z===0){
        return '0';
    }
    else{
        return '+';
    }
}

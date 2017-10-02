function trapesoid(args){
    let a=+args[0];
    let b=+args[1];
    let height=+args[2];
    let result = parseFloat((a+b)/2*height);
    return result.toFixed(7);

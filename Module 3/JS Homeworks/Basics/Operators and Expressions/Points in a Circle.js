function pointInCircle(args){
    let lenght=args[0]*args[0] + args[1]*args[1];
    if(lenght <= 4){
        return 'yes' + ' ' + Math.sqrt(lenght).toFixed(2);
    }
    else{
        return 'no' + ' ' + Math.sqrt(lenght).toFixed(2);
    }
}

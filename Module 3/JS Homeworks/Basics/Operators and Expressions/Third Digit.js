function thirdDigit(args){
    let number=parseInt((args[0]/100)%10);
    if(number===7){
        return 'true'
    }
    else{
        return 'false' + ' ' + number;
    }
}
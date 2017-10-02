function divideBySevenAndFive(args) {
    let number=+args[0];
    if(number%5==0 && number%7==0)
    return 'true' + ' ' + args[0];
    else
    return 'false' + ' ' + args[0];
}
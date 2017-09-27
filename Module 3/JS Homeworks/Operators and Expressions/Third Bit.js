function thirdBit(args){
    let number=parseInt(args[0]);
    return (number>>3)&1;
}
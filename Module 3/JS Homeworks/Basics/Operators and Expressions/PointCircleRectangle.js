function pointCircleRectangle(args){
    let x = +args[0];
    let y = +args[1];
    let isInCircle=Math.sqrt((x-1)*(x-1)+ (y-1)*(y-1))<=1.5;
    let isInRectangle=(1<=x && x<=7 && -1>=y && y>=-3);
    let result='';

    if(isInCircle){
        result+='inside circle ';
    }
    else{
        result+='outside circle ';
    }
    if(isInRectangle){
        result+='inside rectangle';
    }
    else{
        result+='outside rectangle';
    }
    console.log(result);
}
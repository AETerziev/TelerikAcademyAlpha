function quadraticEquation(args){
    let a=+args[0];
    let b=+args[1];
    let c=+args[2];
    let d=b*b-4*a*c;

    if(d<0)
    {
        console.log('no real roots');
        return;
    }
    else if(d==0)
    {
        let res=(b*-1)/2*a;
        return 'x1=x2='+x1.toFixed(2);
    }
    else{
        let x1=((b*-1) + Math.sqrt(d))/(2*a);
        let x2=((b*-1) - Math.sqrt(d))/(2*a);
        if(x1<x2){
            return 'x1='+x1.toFixed(2) +';' + ' ' + 'x2='+x2.toFixed(2);
        }
        else{
            return 'x1='+x2.toFixed(2) +';' + ' ' + 'x2='+x1.toFixed(2);
        }
    }
}
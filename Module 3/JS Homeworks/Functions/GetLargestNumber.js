function getLargestNumber(args){
    let getMax=((a,b)=>{
        return a<b?b:a;
    });
    let arr=args.split(' ');
    console.log(getMax(getMax(+arr[0],+arr[1]),+arr[2]));
}    
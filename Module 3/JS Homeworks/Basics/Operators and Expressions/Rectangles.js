function areaAndPerimeterOfRectangle(args) {
    let perimeter=(+args[0])*2 + (+args[1])*2;
    let area=+args[0] * +args[1];
    return parseFloat(area).toFixed(2) + ' ' + parseFloat(perimeter).toFixed(2);
}
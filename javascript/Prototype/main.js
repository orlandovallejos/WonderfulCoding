var Example = function (j) {
    this.j = j
};

Example.prototype.getPropJ = function () {
    return this.j;
};

var e1 = new Example(1);
var e2 = new Example(2);

console.log('This is me learning javascript prototype:');

console.log(e1);
console.log(e2);
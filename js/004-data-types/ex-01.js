// number
let num = 10;
console.log(`${typeof num} ${num}`);

let floatNum = 43.8;
console.log(`${typeof floatNum} ${floatNum}`);

// string
let str = "hello";
console.log(`${typeof str} ${str}`);

// bool
let isTrue = true;
console.log(`${typeof isTrue} ${isTrue}`);

//object
let nullValue = null;
console.log(`${typeof nullValue} ${nullValue}`);

// undefined
let undefinedValue;
console.log(`${typeof undefinedValue} ${undefinedValue}`);

// object
let arr = [1, 2, 3, 4, 5];
console.log(`${typeof arr} ${arr}`);

// object
let obj = {
    name: "Jane",
    age: 30,
};
console.log(`${typeof obj} ${obj}`);

// function
function greet(name) {
    console.log("hi " + name + "!!!");
}
/*
    OR 
    const greet = (name) => console.log("hi " + name + "!!!");
*/
console.log(`${typeof greet} ${greet}`);

// symbol
let sym = Symbol('s');
console.log(`${typeof sym} ${sym.description}`);

// bigint
let bigint = 123412341234123412341234123412341234321n;
console.log(`${typeof bigint} ${bigint}`);

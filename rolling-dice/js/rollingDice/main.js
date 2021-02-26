// Put your code here

console.log("Let's roll some dice, baby!")
console.log("---------------------------")

function getRandomInt(min, max) {
    min = Math.ceil(1);
    max = Math.floor(6);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}


let result1 = () => {
    if (Die1 === 1) {
        console.log("\u2680")
    }
    else if (Die1 === 2) {
        console.log("\u2681")
    }
    else if (Die1 === 3) {
        console.log("\u2682")
    }
    else if (Die1 === 4) {
        console.log("\u2683")
    }
    else if (Die1 === 5) {
        console.log("\u2684")
    }
    else if (Die1 === 6) {
        console.log("\u2685")
    }
}
let result2 = () => {
    if (Die2 === 1) {
        console.log("\u2680")
    }
    else if (Die2 === 2) {
        console.log("\u2681")
    }
    else if (Die2 === 3) {
        console.log("\u2682")
    }
    else if (Die2 === 4) {
        console.log("\u2683")
    }
    else if (Die2 === 5) {
        console.log("\u2684")
    }
    else if (Die2 === 6) {
        console.log("\u2685")
    }
}

const Die1 = getRandomInt()
console.log(Die1)
result1()
const Die2 = getRandomInt()
console.log(Die2)
result2()

const rollDoubles = () => {
    if (Die1 === Die2) {
        console.log("DOUBLES!")
    }

}
rollDoubles();

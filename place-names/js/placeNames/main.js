// Put your code here

const names = [
    "Nashville",
    "Hong Kong",
    "The back yard",
    "Earth",
    "London",
    "The mall",
    "Ryman Auditorium",
    "The Great Wall of China"
]

console.log(names);

const theNames = names.filter(name => name.includes("The"))

console.log(theNames)
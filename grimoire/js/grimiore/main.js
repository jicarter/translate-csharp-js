// Put your code here

console.log("Do you believe in magic?");
console.log("------------------------");

const spellList = [
    {
        Name:"Turn enemy into a newt",
        IsEvil: true,
        EnergyReqired: 5.1
    },
    {
        Name: "Conjure some gold for a local charity",
        IsEvil: false,
        EnergyReqired: 2.99
    },
    {
        Name: "Give a deaf person the ability to heal",
        IsEvil: false,
        EnergyReqired: 12.2
    },
    {
        Name: "Make yourself emperor of the universe",
        IsEvil: true,
        EnergyReqired: 100.0
    },
    {
        Name: "Convince your relatives your political views are correct",
        IsEvil: false,
        EnergyReqired: 2921.5
    }
]

const goodBook = () => {
    console.log('Good Book')
    for ( const spell of spellList) {
        if (spell.IsEvil === false) {
            console.log(`Spell:${spell.Name} Energy:${spell.EnergyReqired}`)
        } 
    }
}
const evilBook = () => {
    console.log('Evil Book')
    for ( const spell of spellList) {
        if (spell.IsEvil === true) {
            console.log(`Spell:${spell.Name} Energy:${spell.EnergyReqired}`)
        }
    }
}

goodBook();
evilBook();
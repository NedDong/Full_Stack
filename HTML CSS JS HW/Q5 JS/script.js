let styles = ["James", "Brennie"];
styles.push("Robert");
styles[Math.floor(styles.length / 2)] = "Calvin";
let first = styles.shift();
console.log(first);

styles.unshift("Rose", "Regal");


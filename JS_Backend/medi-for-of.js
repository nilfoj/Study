const notas = [10, 8, 7.5, 6.5];

let media = 0;

for (let elemento of notas) {
    media += elemento; 
}

console.log(media/notas.length);



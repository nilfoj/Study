const notas = [10, 8, 7.5, 6.5];

let somadasmedias = 0;

for (i = 0; i < notas.length; i += 1) {
    somadasmedias += notas[i];
}

const media = somadasmedias / notas.length;
console.log(media);
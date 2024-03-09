const letras = ["A","B","C","D"];
const numeros = [1, 2, 3, 4];

const lista = [letras, numeros];

console.log(letras);
console.log(numeros);
console.log(lista);

function exibe (letras) {
  if (lista[0].includes(letras)) {
  
    const indice = lista[0].indexOf(letras);

    const referencia = lista[1][indice];

    console.log(`${letras} tem o numero ${referencia}`);
  }

  else{
    Console.log("Erro")
  }
}

exibe("A");
exibe("B");
exibe("C");
exibe("D");

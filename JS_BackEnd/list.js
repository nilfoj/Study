//const nota1 = 10;
//const nota2 = 6.5;
//const nota3 = 8;
//const nota4 = 7.5;
//const media = ((nota1 + nota2 + nota3 + nota4) /4);

const nota = [10, 6.5, 8, 7.5];

const resultado = (nota[0] + nota [1] + nota [2] + nota [3] / nota.length);

console.log(resultado);



//Push! 

const alunos = [1, 2, 3];

alunos.push(4);

const calculo =  (alunos[0] + alunos[1] + alunos[2] + alunos[3]) / alunos.length;

console.log(alunos);


//Pop!

const frutas = ["maça", "banana", "goiaba", "cenoura"];

frutas.pop();

console.log(frutas);


//slice

const sala = ["Alice", "Bernardo", "Davi", "Gabriela", "Gabriel", "Heitor", "Helena", "Heloísa", "Isabella", "Laura", "Lucas", "Luiza", "Manuela", "Matheus", "Miguel", "Pedro", "Rafael", "Sophia", "Valentina"];+

sala.push("Ricardo", "Mario");

sala.pop();

console.log(sala);

const sala1 = sala.slice(0, sala.length/2);
const sala2 = sala.slice(sala.length/2);

console.log(sala1);
console.log(sala2);


//Concatenar

const salasJs = ["Maria","Joao","Ricardo"];
const salaPython = ["Pedro","Paulo","Carlos"];

const salasUnificadas = salaPython.concat(salasJs);

console.log(salasUnificadas);



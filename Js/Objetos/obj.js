// //Entrada
// const estudante = {
//     nome: 'Jose Silva',
//     idade: 32,
//     cpf: '123456789',
//     turma: 'JavaScrip'
// }

// //Processo
// console.log(estudante.nome);
// console.log(`O nome do estudante é ${estudante.nome}`);
// console.log(`Os três primeiros números do CPF são: ${estudante.cpf.substring(2, 5)}`);

// function eIEstudante(objEstudante, eIEstudante) {
//     return objEstudante[eIEstudante];
// }

// console.log(eIEstudante(estudante, 'nome'));
// console.log(eIEstudante(estudante, 'cpf'));
// console.log(eIEstudante(estudante, 'pet'));

// estudante.telefone = '00000000';
// estudante.pet = 'Cachorro';

// console.log(estudante.telefone);
// console.log(estudante.pet);
// console.log(estudante);

// const estudante = {
//     nome: 'Jose Silva',
//     idade: 32,
//     cpf: '123456789',
//     turma: 'JavaScrip',
//     bolsista: true,
//     telefone: ['00000000', '11111111']
// }

// console.log(estudante.telefone[0]);
// console.log(estudante.telefone[0], estudante.telefone[1]);
// console.log(estudante.telefone[0, 1]);

// estudante.endereco = {
//     rua: 'Dom João Batista',
//     numero: '404',
//     compleemento: 'Apartamento 04'
// }

// console.log(estudante);
// console.log(estudante.endereco);
// console.log(estudante.endereco.rua);


//Entrada
const estudante = {
    nome: 'Maria',
    idade: 21,
    cpf: '4894859685',
    turma: 'Python',
    bolsista: false,
    telefone: ['00000000', '22222222'],
    mediaAluno: 8.2,

    aprovado: function (media) {
        return this.mediaAluno >= media ? true : false
    }
}

for (let chave in estudante) {
    const tipo = typeof estudante[chave];
    if (tipo !== 'object' && tipo !== 'function') {
        console.log(`A chave ${chave} tem o valor ${estudante[chave]}`);
    }

}
















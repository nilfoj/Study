//parametros
//retorno

function nome(nome, nota){
    console.log(`O nome do aluno é ${nome} e sua nota foi ${nota}`);
}

nome(`Joao`, 10);



const estudante = function (notafinal, faltas){
    if (notafinal >= 7 && faltas >= 8){
        return true;
    }
    else {
        return false;
    }
}

console.log(estudante(8, 5));



const estudante2 = (notafinal, faltas) => {
    if (notafinal >= 7 && faltas <= 8){
        return true;
    }
    else {
        return false;
    }
}

console.log(estudante2(10, 5));
const num1 = 1;
const num2 = 2;
const num3 = 3;
const num4 = 4;


const total1 = (num1 + num2 + num3 + num4);
console.log(total1);


const total2 = (num1 - num2 - num3 + num4);
console.log(total2);


const tota3 = (num1 + num2 / num3 + num4);
console.log(tota3.toFixed(2));


if(total1 >= total2){
    console.log("Total 1 maior ou igual ao total 2");
}

else{
    console.log('Total 1 é menor que Total 2')
}

console.log(`1 + 1 = ${total1}`);


if (`0` == 0){
    console.log(`Valor igual a 0`);
}
else{
    console.log(`Valor diferente de 0`);
}

// `0` == 0 > A comparação é feita apenas dos valores logo é true
// `0` === 0 > A comparação feita é dos valores e do tipo de dado. Logo false
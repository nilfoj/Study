const dados = require("./client.json");

console.log(dados);


const cliente = {
    nome: "Joao",
    idade: 23,
    email: "joao@gmail.com",
    telefone: ["00000000", "11111111"],
};



cliente.enderecos = [
{	
    
    rua: "Rua Projetada",
	numero: 123,
	apartamento: true,
	complemento: "Ap Pequeno",
    
},
];


cliente.enderecos.push({
    rua: "Rua Projetada 2",
	numero: 456,
	apartamento: false,
	complemento: "Casa Pequena",
});

console.log(cliente.enderecos)


const listaApartamentos = cliente.enderecos.filter(
    (endereco) => endereco.apartamento === true 
);





const cliente = {
    nome: "Joao",
    idade: 50,
    telefone: 0000000,
    saldo: 100,
    
    Pagamento: function (valor) {
        
        if (valor > this.saldo) {
            console.log("Salda Insuficinete.")
        }

        else {
            this.saldo -= valor;
            console.log(`Pagamento realizado. Novo saldo: ${this.saldo}`); 
        }
    },


};

cliente.Pagamento(120);
cliente.Pagamento(10);

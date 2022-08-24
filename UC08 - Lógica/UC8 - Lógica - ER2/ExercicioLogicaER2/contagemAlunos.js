// let index = 0 - Declaração da variavel contadora
// index < array.length - Verificação da quantidade / Quantas vezes irá repetir
// index++ - Incremento / Irá adicionar a cada volta
// length == Comprimento
// for (let index = 0; index < array.length; index++) {
    
// }

//forEach - Especifico para listas/array
// array.forEach(element => {
    
// });


//while - Estrutura de repetição condicional e verifica a condição ANTES da execução
// while (condition) {
   
// }


// do while - Estrutura de repetição condicional e verifica a condição DEPOIS da primeira execução
// ele executará pelo menos 1 vez.
// do {
    
// } while (condition);


// texto - String - precisa estar entre aspas ""
// numeros inteiros - int
// numeros decimais - float 0,0000000
// numeros decimais - double 0,0000000000000000
// 0 ou 1 / false ou true - bool ou boolean


// let quantidade = 5;
// for (let contador = 0; contador < quantidade; contador++) {
//     // console.log("O numero da volta é " + contador);
//     console.log(`O numero da volta é ${contador + 1}`);
// }


// let contador = 0
// while (contador < quantidade) {

//     console.log("ola")

//     // contador++
// }




//Se o numero for par, escreva "par" e o numero correspondente
//Se o numero for impar, escreva "impar" e o numero correspondente
//Se for zero, escreva "zero"

// % - pega o resto da divisão
let numeroDeAlunos = ["a", "b",, "d", "e"]
for (let contador = 0; contador < numeroDeAlunos.length; contador++) {

    if (contador == 0) {
        console.log("Zero")

    }else if (contador % 2 == 0) {
        console.log(`O numero ${contador} é par`)

    }else{
        console.log(`O numero ${contador} é impar`)
    }
}



// numeroDeAlunos.forEach(cadaItem => {
//     console.log(cadaItem)
// });


//DESAFIO
//Mostrar o nome do aluno, seu numero e se o numero é par ou impar



// for (const iterator of numeroDeAlunos) {
//     console.log(iterator)
// }

// numeroDeAlunos.forEach(element => {
//     console.log(element)
// });
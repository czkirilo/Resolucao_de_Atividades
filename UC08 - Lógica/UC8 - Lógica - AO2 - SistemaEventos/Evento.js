//Data do evento maior que a data atual

let data = new Date();
let dataDoEvento = new Date("2022-08-04")

if (dataDoEvento > data) {
    console.log("Evento permitido.")

    //Lista de Participantes até 100 pessoas
    let listaDeParticipantes = ["participante1", "participante2", "participante3", "participante4"];

    if (listaDeParticipantes.length < 100) {
        console.log("Vaga Disponível. Cadastro permitido, Digite seus Dados")

        //Idade do participante maior que 18
        let idadeDoParticipante = 25
        
        if (idadeDoParticipante >= 18) {
            console.log("Participação Perrmitida")

        } else {
            console.log("Cadastro não permiditido, Evento permitido somente para maiores de 18 anos")
        }

    } else {
        console.log("Cadastro não permitido, Vagas Esgotadas")
    }

} else {
    console.log("Evento não permitido, escolha outra data para realização")
}
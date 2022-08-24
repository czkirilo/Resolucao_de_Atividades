$( document ).ready(function() {

    $("#carrosel img:eq(0)").addClass("banner-ativo").show()

    setInterval(slide, 1000)

    function slide(){
        if($(".banner-ativo").next().length ){
            $(".banner-ativo").removeClass("banner-ativo").hide().next().addClass("banner-ativo").show()
        }else{
            $(".banner-ativo").removeClass().hide()
            $("#carrosel img:eq(0)").addClass("banner-ativo").show()
        }
    }

    $("#barras").click(function () {
        $("#menu").toggleClass("menu-ativo")

        // if ($("#menu").hasClass("menu-ativo")) {
        //     $("#menu").removeClass("menu-ativo")
        // } else {
        //     $("#menu").addClass("menu-ativo")
        // }
    })
})


let email = document.getElementById("campo-email");

// let menu = document.getElementById("menu");

// function mostrarMenu() {
//     if (menu.style.display != "none") {
//         menu.style.display = "none"
//     } else {
//         menu.style.display = "flex"
//     }
// }

let listaNoticias = [
    {
        titulo: "Brasil leva 1 gol no inicio do jogo",
        descricao: "Houve uma falha de defesa brasileira, que deixou atacante adversário cara a cara com o goleiro"
    },
    {
        titulo: "O dolar está alto",
        descricao: "O dolar está realmente muito alto, não to saindo pra lado nenhum"
    },
    {
        titulo: "Brasil leva 2 gol no inicio do jogo",
        descricao: "Houve uma falha de defesa brasileira, que deixou atacante adversário cara a cara com o goleiro"
    },
    {
        titulo: "O euro está alto",
        descricao: "O euro está realmente muito alto, não to saindo pra lado nenhum"
    },
    {
        titulo: "Brasil leva 3 gol no inicio do jogo",
        descricao: "Houve uma falha de defesa brasileira, que deixou atacante adversário cara a cara com o goleiro"
    },
    {
        titulo: "O peso argentino está alto",
        descricao: "O peso está realmente muito alto, não to saindo pra lado nenhum"
    }
]

function enviarEmail() {
    let emailDigitado = email.value;
    console.log(emailDigitado)
}

function renderizarNoticias() {
    let espaco = document.getElementById("espaco-noticias")

    let template = "";

    for (let index = 0; index < listaNoticias.length; index++) {
        const noticia = listaNoticias[index];

        template += `  <div class="cardnews">
        <img src="img/cardnews.jpg" alt="Foto da jogadora profissional">
        <h3>${noticia.titulo}</h3>
        <p>${noticia.descricao}</p>
    </div>`
    }

    espaco.innerHTML = template;
}
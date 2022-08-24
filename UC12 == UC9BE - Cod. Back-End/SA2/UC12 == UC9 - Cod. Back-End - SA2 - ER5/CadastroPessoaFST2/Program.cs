using CadastroPessoaFST2.Classes;


Console.Clear();
Console.WriteLine(@$"
=============================================
|   Bem vindo ao sistema de cadastro de     |
|       Pessoas Físicas e Juridícas         |
=============================================
");

BarraCarregamento("Carregando", 500);

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
=============================================
|       Escolha uma das opções abaixo       |
|-------------------------------------------|
|           1 - Pessoa Física               |
|           2 - Pessoa Juridíca             |
|                                           |
|           0 - Sair                        |
=============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica novaPf = new PessoaFisica();
            PessoaFisica metodoPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();

            novaPf.nome = "Odirlei";
            novaPf.dataNasc = new DateTime(2000, 01, 01);
            novaPf.cpf = "1234567890";
            novaPf.rendimento = 5000.5f;

            novoEnd.logradouro = "Alameda Barão de Limeira";
            novoEnd.numero = 539;
            novoEnd.complemento = "SENAI Informatica";
            novoEnd.endComercial = true;

            novaPf.endereco = novoEnd;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPf.nome}
CPF: {novaPf.cpf}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
            ");

            Console.WriteLine($"{metodoPf.ValidarDataNasc(novaPf.dataNasc)}");

            //Console.WriteLine($"{metodoPf.ValidarDataNasc("01/0100")}");

            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();


            break;

        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco endPj = new Endereco();

            novaPj.nome = "Nome Pj";
            novaPj.razaoSocial = "Razão social Pj";
            novaPj.Cnpj = "00.000.000/0001-00";
            novaPj.rendimento = 10000.5f;

            endPj.logradouro = "Alameda Barão de Limeira";
            endPj.numero = 539;
            endPj.complemento = "Senai Informatica";
            endPj.endComercial = true;

            novaPj.endereco = endPj;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.Cnpj}
CNPJ válido: {metodoPj.ValidarCnpj(novaPj.Cnpj)}
");

            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();

            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");

            BarraCarregamento("Finalizando", 300);

            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção!");
            Thread.Sleep(3000);
            break;
    }
} while (opcao != "0");



static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.Gray;
    Console.ForegroundColor = ConsoleColor.DarkRed;

    Console.Write(texto);

    for (var i = 0; i < 6; i++)
    {
        Console.Write(".");
        Thread.Sleep(tempo);
    }

    Console.ResetColor();
}
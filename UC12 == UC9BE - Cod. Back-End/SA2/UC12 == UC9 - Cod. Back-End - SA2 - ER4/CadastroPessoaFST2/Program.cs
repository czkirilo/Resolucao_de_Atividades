using CadastroPessoaFST2.Classes;

// PessoaFisica novaPf = new PessoaFisica();
// PessoaFisica metodoPf = new PessoaFisica();
// Endereco novoEnd = new Endereco();

// novaPf.nome = "Odirlei";
// novaPf.dataNasc = new DateTime(2000, 01, 01);
// novaPf.cpf = "1234567890";
// novaPf.rendimento = 5000.5f;

// novoEnd.logradouro = "Alameda Barão de Limeira";
// novoEnd.numero = 539;
// novoEnd.complemento = "SENAI Informatica";
// novoEnd.endComercial = true;

// novaPf.endereco = novoEnd;

// Console.WriteLine($"Nome: {novaPf.nome}");
// Console.WriteLine($"CPF: {novaPf.cpf}");
// Console.WriteLine($"Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");

// Console.WriteLine(@$"
// Nome: {novaPf.nome}
// CPF: {novaPf.cpf}
// Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
// ");



//Console.WriteLine($"{metodoPf.ValidarDataNasc(novaPf.dataNasc)}");

// Console.WriteLine($"{metodoPf.ValidarDataNasc("01/0100")}");



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

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.Cnpj}
CNPJ válido: {metodoPj.ValidarCnpj(novaPj.Cnpj)}
");
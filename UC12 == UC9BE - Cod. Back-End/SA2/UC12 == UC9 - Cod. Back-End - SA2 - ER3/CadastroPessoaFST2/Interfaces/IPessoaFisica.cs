namespace CadastroPessoaFST2.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNasc(DateTime dataNasc);

        bool ValidarDataNasc(string dataNasc);
    }
}
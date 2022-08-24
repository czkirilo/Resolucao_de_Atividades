using CadastroPessoaFST2.Interfaces;

namespace CadastroPessoaFST2.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? Nome { get; set; }

        public float Rendimento { get; set; }

        public string? Endereco { get; set; }

        public abstract float PagarImposto(float redimento);
        
    }
}
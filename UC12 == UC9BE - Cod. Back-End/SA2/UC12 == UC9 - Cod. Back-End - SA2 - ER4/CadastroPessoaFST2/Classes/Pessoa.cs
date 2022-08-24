using CadastroPessoaFST2.Interfaces;

namespace CadastroPessoaFST2.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? nome { get; set; }

        public float rendimento { get; set; }

        public Endereco? endereco { get; set; }

        public abstract float PagarImposto(float redimento);
        
    }
}
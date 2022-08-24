using CadastroPessoaFST2.Interfaces;

namespace CadastroPessoaFST2.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {
        public string? cpf { get; set; }
        
        public DateTime dataNasc { get; set; }

        public override float PagarImposto(float rendimento)
        {            
            if (rendimento <= 1500)
            {
               return 0; 
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                return (rendimento / 100) * 2;
            }
            else if (rendimento > 3500 && rendimento <= 6000)
            {
                return (rendimento /100) * 3.5f;
            }
            else
            {
                return (rendimento / 100) * 5;
            }
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            Console.WriteLine($"{anos}");
            
            if (anos >= 18)
            {
                return true;
            }
            
            return false;        
        }

        
        public bool ValidarDataNasc(string dataNasc){

            DateTime dataConvertida;  

            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;
                
                Console.WriteLine($"{anos}");

                if (anos >= 18 && anos < 120)
                {
                    return true;
                }
                
                return false;
            }

            return false;          
        }
    }
}
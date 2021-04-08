using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjLoja.Model
{
    public class Pessoa
    {
        //Decalração dos atributos da classe pessoa:
        public int Codigo{ get; set;}
        public string Nome{ get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string FoneRes { get; set; }
        public string FoneCel { get; set; }
        public string Documento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipalProjetoFinal
{
    public class Usuario : Pessoa
    {
        public byte Dia { get; set; }
        public byte Mes { get; set; }
        public int Ano { get; set; }
        public byte Classificacao { get; set; }
        public string Comentar { get; set; }

        public Usuario()
        {
           
        }

        public override string imprimir()
        {
            string x = "ID: " + Id + "\nNOME: " + Nome + "\nSEXO: " + Sexo +
                 "\nDATA DE NASCIMENTO: " + Dia + " / " + Mes + " / " + Ano + "\nCLASSIFICAÇÂO: " + Classificacao +
                 "\nCOMENTÁRIO: " + Comentar;
            return x;
        }
    }
}

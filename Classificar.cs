using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipalProjetoFinal
{
    public class Classificar
    {
        public Usuario ClassificarUsuario { get; set; }

        public string imprimi()
        {
            string y = "\nCLASSIFICAÇÃO : " + ClassificarUsuario.Classificacao +
                "\nCOMENTÁRIO : " + ClassificarUsuario.Comentar;
            return y;
        }
    }
    
}

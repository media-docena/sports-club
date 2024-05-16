using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIclubdeportivo.Entidades
{
    internal class E_No_Socio : E_Cliente
    {
        public E_No_Socio(string nombreC, string apellidoC, string dniC, int telC, 
                          string correoC, string tipoC, bool estadoC, int? idCliente = null) : base(nombreC, 
                          apellidoC, dniC, telC, correoC, tipoC, estadoC, idCliente)
        {
        }
    }
}

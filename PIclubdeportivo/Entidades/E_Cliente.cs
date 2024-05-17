using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIclubdeportivo.Entidades
{
    public class E_Cliente
    {
        
        public int? IdCliente { get; } 
        public string NombreC { get; }
        public string ApellidoC { get; }
        public string DniC { get; }
        public int TelC { get; }
        public string CorreoC { get; }
        public string TipoC { get; }
        public bool EstadoC { get; }

        public E_Cliente(string nombreC, string apellidoC, string dniC,
            int telC, string correoC, string tipoC, bool estadoC, int? idCliente = null)
        {      
            NombreC = nombreC;
            ApellidoC = apellidoC;
            DniC = dniC;
            TelC = telC;
            CorreoC = correoC;
            TipoC = tipoC;
            EstadoC = estadoC;
            IdCliente = idCliente;
        }
        
        
    }
}

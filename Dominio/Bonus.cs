using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Bonus
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Bet { get; set; }
        public double Multi { get; set; }
        public double Win { get; set; }
        public double MaxWin { get; set; }
        public bool Activo { get; set; }
    }
}

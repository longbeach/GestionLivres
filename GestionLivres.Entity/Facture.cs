using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivres.Entities
{
    public class Facture
    {

        public decimal IdFacture { get; set; }
        public string NumFacture { get; set; }
        public string NumCommande { get; set; }
        public DateTime DateCreation { get; set; }
        public string DateCreationFormat { get { return DateCreation.ToString("dd/MM/yyyy"); } }
    }
}

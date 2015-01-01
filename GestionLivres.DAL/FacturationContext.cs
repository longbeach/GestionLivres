using GestionLivres.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivres.DAL
{
    class FacturationContext : DbContext
    {
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }  
    }
}

using GestionLivres.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivres.DAL
{
    class FacturationDal
    {

        FacturationContext context = new FacturationContext();

        /// <summary>
        /// Retourne la liste des fournisseurs
        /// </summary>
        /// <returns>La liste retournée</returns>
        public List<Fournisseur> GetAll()
        {
            return context.Fournisseurs.ToList();
        }

        /// <summary>
        /// Insertion d'un fournisseur
        /// </summary>
        /// <param name="fournisseur">Fournisseur à insérer</param>
        /// <returns>Succès/échec</returns>
        public bool Insert(Fournisseur fournisseur)
        {
            context.Fournisseurs.Add(fournisseur);
            return context.SaveChanges() > 0;
        }


        /// <summary>
        /// Mise à jour d'un fournisseur
        /// </summary>
        /// <param name="fournisseur">Fournisseur à mettre à jour</param>
        /// <returns>Succès/échec</returns>
        public bool Update(Fournisseur fournisseur)
        {
            context.Entry(fournisseur).State = EntityState.Modified;
            return context.SaveChanges() > 0;
        }

        /// <summary>
        /// Suppression d'une facture
        /// </summary>
        /// <param name="facture">Facture à supprimer</param>
        /// <returns>Succès/échec</returns>
        public bool DeleteFacture(Facture facture)
        {
            context.Factures.Remove(facture);
            return context.SaveChanges() > 0;
        }
    }
}

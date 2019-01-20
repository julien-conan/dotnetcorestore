using System.ComponentModel.DataAnnotations;
using System;

namespace src.Models
{
    public class Paiement
    { 
        public int Id { get; set; }
        public int IdAssociation { get; set; }
        public int IdUtilisateur { get; set; }
        public float Montant { get; set; }
        public float MontantPourboire { get; set; }
        public string Statut { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string Donator { get; set; }
    }
}
﻿namespace TPLOCAL1.Models
{
    public class FormModel
    {
        public required string Nom { get; set; }
        public required string Prenom { get; set; }
        public required string Sexe { get; set; }
        public required string Adresse { get; set; }
        public required int CodePostal { get; set; }
        public required string Ville { get; set; }
        public required string AdresseMail { get; set; }
        public required DateTime DebutFormation { get; set; }
        public required string Cour { get; set; }
        public string CobolFormation { get; set; } = string.Empty;
        public string CSFormation { get; set; } = string.Empty;
    }
}

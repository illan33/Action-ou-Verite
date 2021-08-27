using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Action_ou_vérité.Models
{
    [Table("Joueurs")]
    public class Joueurs
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100), Unique]
        public string Name { get; set; }

        /*public string Sexe { get; set; }

        public string Orientation_Sexuelle { get; set; }*/

    }
}

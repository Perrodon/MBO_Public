using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBO.Models
{
    public class User
    {
        private string NomUtilisateur { get; set; }
        private string PrenomUtilisateur { get; set; }
        private DateTime DateCreationUtilisateur { get; set; }
        private string LoginUtilisateur { get; set; }
        private string MotDePasseUtilisateur { get; set; }
    }
}

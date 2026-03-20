using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class User
    {
        private int idUser;
        private string login;
        private string mdp;
        private string image;

        public User(int idUser, string login, string mdp, string image)
        {
            this.IdUser = idUser;
            this.Login = login;
            this.Mdp = mdp;
            this.Image = image;
        }

        public int IdUser { get => idUser; set => idUser = value; }
        public string Login { get => login; set => login = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Image { get => image; set => image = value; }
    }
}

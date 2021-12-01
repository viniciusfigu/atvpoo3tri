using System;
using System.Collections.Generic;
using System.Text;

namespace proj_3camadas.code.DTO
{
    class LoginDTO
    {
        private int _id;
        private string _email;
        private string _senha;

        public int id { get => id; set => _id = value; }
        public string email { get => email; set => _email = value; }
        public string senha { get => senha; set => _senha = value; }
    }
}


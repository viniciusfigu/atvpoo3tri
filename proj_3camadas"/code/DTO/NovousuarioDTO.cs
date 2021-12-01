using System;
using System.Collections.Generic;
using System.Text;

namespace proj_3camadas.code.DTO
{
    class NovousuarioDTO
    {
        private int _id;
        private string _email;
        private string _senha;
        private string _nome;
        private string _telefone;
        private string _rua;
        private string _numero;
        private string _bairro;
        private string _cidade;
        private string _estado;
        private string _country;
        private string _pais;
        private int _cpf;
        private int _rg;
        private string _datanascimento;


        public int id { get => id; set => _id = value; }
        public string email { get => email; set => _email = value; }
        public string senha { get => senha; set => _senha = value; }
        public string nome { get => nome; set => _nome = value; }
        public string telefone { get => telefone; set => _telefone = value; }
        public string rua { get => rua; set => _rua = value; }
        public string numero { get => numero; set => _numero = value; }
        public string bairro { get => bairro; set => _bairro = value; }
        public string cidade { get => cidade; set => _cidade = value; }
        public string estado { get => estado; set => _estado = value; }
        public string country { get => country; set => _country = value; }
        public string pais { get => pais; set => _pais = value; }
        public int cpf { get => cpf; set => _cpf = value; }
        public int rg { get => rg; set => _rg = value; }
        public string datanascimento { get => datanascimento; set => _datanascimento = value; }
    }
}

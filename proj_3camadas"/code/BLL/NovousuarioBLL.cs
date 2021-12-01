using proj_3camadas.code.DAL;
using proj_3camadas.code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace proj_3camadas.code.BLL
{
    class NovousuarioBLL
    {
        Conexao conexao = new Conexao();
        string table = "tbl_usuario";

        public bool RealizarLogin(LoginDTO login)
        {
            {
                string sql = " select * from { tbl_usuario } where email = '{ tlb_usuario . Email }' and senha = '{ tbl_usuario . Senha }' ";
                DataTable dt = conexao.ExecutarConsulta(sql);

                if (dt.Rows.Count > 0)
                    return true;
                else
                    return false;
            }

        }

        public string RetornarSenha(LoginDTO login)      // Requer: using System.Data;
        {
            string sql = $" select * from { table } where email = ' { login.email } ' ";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return dt.Rows[0][" senha "].ToString();
            else
                return " falso ";
        }
    }
}

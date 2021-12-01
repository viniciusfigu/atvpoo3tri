using proj_3camadas.code.BLL;
using proj_3camadas.code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace proj_3camadas.UI
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }

        LoginBLL loginBBL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        private void btnentrar_Click(object sender, EventArgs e)
        {
           
            loginDTO.email = txtemail.Text;
            loginDTO.senha = txtsenha.Text;


            
            if (loginBBL.RealizarLogin(loginDTO) == true)
            {

                Frmnovousuario frmdados = new Frmnovousuario();
                Frmnovousuario.ShowDialog();
            }
            else
            {
               MessageBox.Show(" verificar e-mail e senha. ", " Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkesqueceusenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Configura o cliente Gmail
            var client = new SmtpClient(" smtp.gmail.com ", 587)
            {
                Credentials = new NetworkCredential(" viniciusfig27@gmail.com.br ", " lwkejdlxawtwpnjc "),
                EnableSsl = true
            };


            loginDTO.email = txtemail.Text;
            string senha = loginBBL.RetornarSenha(loginDTO);


            // TODO: Altere para enviar o e-mail e senha recuperados do banco
            // Send ("quem envia", "para quem envia", "assunto", "corpo");
            client.Send(" viniciusfig27@gmail.com.br ", " { txtEmail . Text } ", " Redefinição de Senha ", " Seu e-mail é { txtEmail . Text } com senha { senha } ");


            MessageBox.Show(" E-mail e senha enviados com sucesso. ", " E-mail ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}

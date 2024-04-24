using OfficeScheduler.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeScheduler
{
    public partial class formLogin : Form
    {
        public formLogin()
        {            
            InitializeComponent();
            SetLanguage();            
        }

        private bool isFrench = false;
        private bool submitClicked = false;
     
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = fldUsername.Text;
            string password = fldPassword.Text;
            if(User.VerifyUsername(username) && User.VerifyPassword(password))
            {
                submitClicked = true;
                User.SetCurrentUser(username);
                /*if (Appointment.loginAppCheck()) //Unneccessarry feature 11/13
                {
                    if (isFrench)
                    {
                        MessageBox.Show("Vous avez un rendez-vous dans les 15 prochaines minutes. Veuillez consulter votre calendrier pour plus de détails.");
                    }
                    else
                    {
                        MessageBox.Show("You have an appointment within the next 15 minutes. Please check your calendar for details.");
                    }
                }*/
                User.SuccessfulLogin(username);
                this.Close();                
            }
            else
            {
                User.FailedLogin(username);
                if (isFrench)
                {
                    MessageBox.Show("Nom d'utilisateur et mot de passe ne correspondent pas. Veuillez réessayer ou contacter votre administrateur.");
                }
                else
                {
                    MessageBox.Show("Username and password do not match. Please try again or contact your administrator.");
                }

             }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
        private void SetLanguage()
        {
            if (User.GetCultureInfo() == "fr")
            {
                isFrench = true;
                this.Text ="Se connecter";
                this.lblWelcome.Text = "Bienvenu!";
                this.lblLoginPrompt.Text = "Veuillez s'il vous plaît entrer votre nom d'utilisateur et votre mot de passe.";
                this.lblUsername.Text = "Nom d'utilisateur:";
                this.lblPassword.Text = "Mot de passe:";
                this.btnSubmit.Text = "Soumettre";
                this.btnCancel.Text = "Annuler";                
            }
        }

        //This ensures the application closes if the user clicks the 'X' button
        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !submitClicked)
            {
                
                Application.Exit();
            }
        }


    }
}

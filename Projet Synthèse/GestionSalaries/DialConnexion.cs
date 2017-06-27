using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalariesDll;
using Utilitaires;

namespace GestionSalaraies
{
    public partial class DialConnexion : Form
    {
        public DialConnexion()
        {
            InitializeComponent();
        }
        #region Gestionnaires Evenements Validation

        /// <summary>
        /// Validation ID Utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIdentifiant_Validating(object sender, CancelEventArgs e)
        {

            if (IsIdCorrect(txtIdentifiant.Text))
            {
                epUtilisateur.SetError(txtIdentifiant, String.Empty);
            }
            else
            {
                epUtilisateur.SetError(txtIdentifiant, "Identifiant invalide");
                e.Cancel = true;
            }

        }
        /// <summary>
        /// Interception du traitement de la touche
        /// Assignation de dialogResult Cancel sur Escap
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape) this.DialogResult = DialogResult.Cancel;
            return base.ProcessDialogKey(keyData);

        }

        /// <summary>
        /// Vérification du mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMDP_Validating(object sender, CancelEventArgs e)
        {
            if (IsMotPasseCorrect(txtMDP.Text, txtIdentifiant.Text))
            {
                epUtilisateur.SetError(txtMDP, String.Empty);
            }
            else
            {
                epUtilisateur.SetError(txtMDP, "Mot de passe incorrect");
                e.Cancel = true;
            }

        }
        #endregion



        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Application.Exit();  // Quitter l'application
        }

        private bool IsIdCorrect(string id)
        {
            if (String.IsNullOrEmpty(id)) return false;
            if (!char.IsLetter(id[0])) return false;
            if (id.Length < 3) return false;
            return true;
        }

        private bool IsMotPasseCorrect(string motPasse, string id)
        {
            if (String.IsNullOrEmpty(motPasse)) return false;
            if (motPasse.Length < 5) return false;
            return true;
        }



        public Utilisateur Utilis
        {
            get
            {
                Roles _roles = new Roles(); // instances roles
                Utilisateurs utils = new Utilisateurs(); // instance de la liste des utilisateurs
                Utilisateur util = new Utilisateur(); // utilisateur
                ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
                utils.Load(serialiseur, Properties.Settings.Default.AppData); // chargement des utilisateurs
                _roles.Load(serialiseur, Properties.Settings.Default.AppData); // chargement de roles }
                util = utils.UtilisateurByMatricule(txtIdentifiant.Text.Trim());
                return util;
            }

        }

        int _nombreEchecsConsecutifs = 0;
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Roles _roles = new Roles(); // instances roles
            Utilisateurs utils = new Utilisateurs(); // instance de la liste des utilisateurs
            Utilisateur util = new Utilisateur(); // utilisateur
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            utils.Load(serialiseur, Properties.Settings.Default.AppData); // chargement des utilisateurs
            _roles.Load(serialiseur, Properties.Settings.Default.AppData); // chargement de roles }
            util = utils.UtilisateurByMatricule(txtIdentifiant.Text.Trim().ToUpper());

            if (util != null) // compte existe
            {
                util.NombreEchecsConsecutifs = _nombreEchecsConsecutifs;
                _nombreEchecsConsecutifs++;


                if (util.NombreEchecsConsecutifs > 3) // verfication du compte (bloqué ou pas)
                {
                    epUtilisateur.SetError(txtMDP, "Compte bloqué");
                    return;
                }

                if (!string.IsNullOrEmpty(util.Role.Identifiant)) // L'utilisteur fait il parti d'un role?
                {
                    switch (util.Connecter(txtMDP.Text.Trim()))
                    {
                        case ConnectionResult.Connecte:
                            this.Close();
                            break;
                        case ConnectionResult.CompteBloqué:
                            epUtilisateur.SetError(txtMDP, "Compte bloqué");
                            break;
                        case ConnectionResult.MotPasseInvalide:
                            epUtilisateur.SetError(txtMDP, "Mot de passe invalide");
                            break;
                    }

                }



            }
            else
            {
                epUtilisateur.SetError(txtIdentifiant, "Le compte n'existe pas"); // compte n'existe pas
            }


        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalariesDll;
using GestionSalaraies.Properties;
using Utilitaires;


namespace GestionSalaraies
{
    public partial class FrmUtilisateurs : Form
    {
        Utilisateurs utilisateurs;
        Roles roles;
        Utilisateur utilisateur;
        ActionValider modeValidation; // variable contenant l'action à mener

        /// <summary>
        /// Actions à mener 
        /// </summary>
        enum ActionValider
        { validerAjout = 0,
          validerModifiction = 1
        }
        

        enum Contextes
        {
            Initial = 0,
            Consultation = 1,
            ModificationInitiale = 2,
            ModificationAnnuler = 3,
            ModificationValider = 4,
            AjoutInitial = 5,
            AjoutValider = 6

        }
        public FrmUtilisateurs()
        {
            InitializeComponent();
           
        }
        void GestionnaireContextes(Contextes contexte)
            
        {
            
            switch (contexte)
            {
                case Contextes.Initial:
                    cbUtilisateurs.Enabled = (cbUtilisateurs.Items.Count>0);
                    btnNouveau.Enabled = true;
                    gbDetailUtilisateur.Visible = false;

                    break;
                case Contextes.Consultation:
                    btnNouveau.Enabled = true;
                    gbDetailUtilisateur.Visible = true;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = true;
                    btnAnnuler.Enabled = false;
                    btnValider.Enabled = false;
                    txtIdentifiant.ReadOnly = true;
                    txtMotDePasse.ReadOnly = true;
                    txtNom.ReadOnly = true;
                    chkCompteBloque.Enabled = false;
                    cbRoles.Enabled = false;
                    break;
                case Contextes.ModificationInitiale:
                    btnNouveau.Enabled = false;
                    gbDetailUtilisateur.Visible = true;
                    cbUtilisateurs.Enabled = false;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    txtIdentifiant.ReadOnly = true;
                    txtMotDePasse.ReadOnly = false;
                    chkCompteBloque.Enabled = true;
                    txtNom.ReadOnly = false;
                    cbRoles.Enabled = true;
                    break;
                case Contextes.ModificationAnnuler:
                    GestionnaireContextes(Contextes.Consultation);
                    break;
                case Contextes.ModificationValider:
                    //utilisateur.Identifiant = txtIdentifiant.Text.Trim().ToUpper();
                    utilisateur.Nom = txtNom.Text.Trim();
                    utilisateur.MotDePasse = txtMotDePasse.Text.Trim();
                    utilisateur.CompteBloque = chkCompteBloque.Checked;
                    utilisateur.Role = ChargerRole();
                    break;
                case Contextes.AjoutInitial:
                    btnNouveau.Enabled = false;
                    gbDetailUtilisateur.Visible = true;
                    cbUtilisateurs.Enabled = false;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    txtIdentifiant.ReadOnly = false;
                    txtMotDePasse.ReadOnly = false;
                    chkCompteBloque.Enabled = true;
                    txtNom.ReadOnly = false;
                    cbRoles.Enabled = true;
                    

                    break;
                case Contextes.AjoutValider:
                    AjouterUtilisateur();
                    break;
                default:
                    break;
            }

        }
       
        private Role ChargerRole()
        {
            Role rl = new Role();
            rl = roles.RechercherRole(cbRoles.Text.Trim());

            return rl;

        }
        /// <summary>
        /// méthode de création d'un nouveau utilisateur dans un role
        /// </summary>
        private void AjouterUtilisateur()
        {
            Utilisateur UtilNouveau = new Utilisateur();
            UtilNouveau.Identifiant = txtIdentifiant.Text.Trim();
            UtilNouveau.Nom = txtNom.Text.Trim();
            UtilNouveau.MotDePasse = txtMotDePasse.Text.Trim();
            UtilNouveau.CompteBloque = chkCompteBloque.Checked;
           
            UtilNouveau.Role = ChargerRole();
           utilisateurs.Add(UtilNouveau);

        }

       
        private void ChargerValeursUtilisateur()
        {
            txtIdentifiant.Text = utilisateur.Identifiant;
            txtMotDePasse.Text = utilisateur.MotDePasse;
            txtNom.Text = utilisateur.Nom;
            chkCompteBloque.Checked = utilisateur.CompteBloque;
            foreach (var item in cbRoles.Items)
            {
                if (item.ToString() == utilisateur.Role.Identifiant)
                {
                    cbRoles.SelectedItem = item;
                    break;
                }
            }
        }
        private void ModifierUtilisateur()
        {

            if (IsValidChamps())
            {
                try
                {
                    utilisateur.Identifiant = txtIdentifiant.Text;
                    utilisateur.MotDePasse = txtMotDePasse.Text;
                    txtNom.Text = utilisateur.Nom;
                    chkCompteBloque.Checked = utilisateur.CompteBloque;
                    utilisateur.Identifiant = txtIdentifiant.Text;
                    utilisateur.MotDePasse = txtMotDePasse.Text;
                    txtNom.Text = utilisateur.Nom;
                    chkCompteBloque.Checked = utilisateur.CompteBloque;
                }
                catch (Exception)
                {

                    // a programmer
                }


            }
        }
        private bool IsValidChamps()
        {
            bool valid = true;

            if (!Utilisateur.IsIdentifiantValide(txtIdentifiant.Text))
            {
                valid = false;
                epUtilisateur.SetError(txtIdentifiant, "L'identifiant n'est pas valide");

            }
            else
            {
                epUtilisateur.SetError(txtIdentifiant, string.Empty);
            }



            return valid;
        }
        private void ChargerRoles()
        {
            roles = new Roles();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            roles.Load(serialiseur,Properties.Settings.Default.AppData);

            foreach (Role item in roles)
            {
                cbRoles.Items.Add(item.Identifiant);
            }
        }
        private void ChargerUtilisateurs()
        {
            utilisateurs = new Utilisateurs();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            utilisateurs.Load(serialiseur,Properties.Settings.Default.AppData);
            foreach (Utilisateur item in utilisateurs)
            {
                cbUtilisateurs.Items.Add(item.Identifiant);
            }
        }
        private void FrmUtilisateurs_Load(object sender, EventArgs e)
        {
            ChargerUtilisateurs();
            ChargerRoles();
            GestionnaireContextes(Contextes.Initial);
        }
        private void cbUtilisateurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            utilisateur = utilisateurs.UtilisateurByMatricule(cbUtilisateurs.Items[cbUtilisateurs.SelectedIndex].ToString());
            ChargerValeursUtilisateur();
            GestionnaireContextes(Contextes.Consultation);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.ModificationInitiale);
            modeValidation = ActionValider.validerModifiction;// affecter l'action à mener (valider la modification)
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ChargerValeursUtilisateur();
            GestionnaireContextes(Contextes.ModificationAnnuler);
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.AjoutInitial);
            modeValidation = ActionValider.validerAjout; // affecter l'action à mener (valider l'ajout)
        }

        /// <summary>
        /// Valider selon l'ajout d'un utilisateur ou modification de celui  ci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            switch(modeValidation)
            {
                case ActionValider.validerAjout:
                    GestionnaireContextes(Contextes.AjoutValider);
                    GestionnaireContextes(Contextes.Consultation);
                    break;
                case ActionValider.validerModifiction:
                    GestionnaireContextes(Contextes.ModificationValider);
                    break;
            }

            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            utilisateurs.Save(serialiseur, Properties.Settings.Default.AppData);
        }

       
    }
}

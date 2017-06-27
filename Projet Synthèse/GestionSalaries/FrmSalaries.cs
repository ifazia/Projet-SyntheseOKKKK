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
    public partial class FrmSalaries : Form
    {
        public FrmSalaries()
        {
            InitializeComponent();
        }

        Salaries salaries;
        Roles roles;
        Salarie salarie;
        
        ActionValider modeValidation; // variable contenant l'action à mener
        #region enum
        /// <summary>
        /// Actions à mener 
        /// </summary>
        enum ActionValider
        {
            validerAjout = 0,
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
        
        void GestionnaireContextes(Contextes contexte)

        {

            switch (contexte)
            {
                case Contextes.Initial:
                    cbSalaries.Enabled = (cbSalaries.Items.Count > 0);
                    btNouveau.Enabled = true;
                    gbDetailsSalaries.Visible = false;
                    gbDetailsCommercial.Visible = false;
                    break;
                case Contextes.Consultation:
                    btNouveau.Enabled = true;
                    gbDetailsSalaries.Visible = true;
                    gbTypeSalarie.Visible = true;
                    panelBT.Enabled = true;
                    btnModifier.Enabled = true;
                    btnAnnuler.Enabled = false;
                    btnValider.Enabled = false;

                    foreach (Control ctl in gbDetailsSalaries.Controls)
                        {
                        if (ctl.GetType() == typeof(TextBox))
                            ((TextBox)(ctl)).ReadOnly = true;
                        }

                    if (gbTypeSalarie.Visible == true && ckbCommercial.Checked)
                    {
                        ((Commercial)salarie).ChiffreAffaire = Convert.ToDecimal(txtChiffreAffaire.Text);
                        ((Commercial)salarie).Commission = Convert.ToDecimal(txtComission.Text);
                    }

                    //txtMatricule.ReadOnly = true;
                    //txtNom.ReadOnly = true;
                    //txtPrenom.ReadOnly = true;
                    //txtDateNaissance.ReadOnly = true;

                    break;
                case Contextes.ModificationInitiale:
                    btNouveau.Enabled = false;
                    gbDetailsSalaries.Visible = true;
                    cbSalaries.Enabled = false;
                    panelBT.Enabled = true;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    foreach (Control clt in gbDetailsSalaries.Controls)
                    {
                        if (clt.GetType() == typeof(TextBox))
                            ((TextBox)(clt)).ReadOnly = false;
                    }
                    txtMatricule.ReadOnly = true;
                    if (gbTypeSalarie.Visible == true && ckbCommercial.Checked)
                    {
                        ((Commercial)salarie).ChiffreAffaire = Convert.ToDecimal(txtChiffreAffaire.Text);
                        ((Commercial)salarie).Commission = Convert.ToDecimal(txtComission.Text);
                    }
                    //txtMotDePasse.ReadOnly = false;
                    //chkCompteBloque.Enabled = true;
                    //txtNom.ReadOnly = false;
                    //cbRoles.Enabled = true;
                    break;
                case Contextes.ModificationAnnuler:
                    GestionnaireContextes(Contextes.Consultation);
                    break;
                case Contextes.ModificationValider: 
                    salarie.Matricule = txtMatricule.Text.Trim().ToUpper();
                    salarie.Nom = txtNom.Text.Trim();
                    salarie.Prenom = txtPrenom.Text.Trim();
                    salarie.DateNaissance = Convert.ToDateTime(txtDateNaissance.Text);
                    salarie.SalaireBrut = Convert.ToDecimal(txtSalaireBrut.Text);                    
                    salarie.TauxCS = Convert.ToDecimal(txtTaux.Text);
                    if (gbTypeSalarie.Visible == true && ckbCommercial.Checked)
                    {
                        ((Commercial)salarie).ChiffreAffaire = Convert.ToDecimal(txtChiffreAffaire.Text);
                        ((Commercial)salarie).Commission = Convert.ToDecimal(txtComission.Text);
                    }

                    break;
                case Contextes.AjoutInitial:
                    gbDetailsSalaries.Visible = true;
                    btnValider.Enabled = true;
                    cbSalaries.Enabled = false;
                    foreach (Control clt in gbDetailsSalaries.Controls)
                    {
                        if (clt.GetType() == typeof(TextBox))
                            ((TextBox)(clt)).ReadOnly = false;
                    }

                    break;
                case Contextes.AjoutValider:
                    AjouterSalarie();
                    break;
                default:
                    break;
            }

        }
        #endregion
        private void ChargerSalaries()
        {
            salaries = new Salaries();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            salaries.Load(serialiseur, Properties.Settings.Default.AppData);

            foreach (Salarie item in salaries)
            {
                cbSalaries.Items.Add(item.Matricule);
            }
            
        }
       
        private void FrmSalaries_Load(object sender, EventArgs e)
        {
            ChargerSalaries();
            GestionnaireContextes(Contextes.Initial);
        }

        private void ChargerValeursSalaries()
        {
            txtMatricule.Text = salarie.Matricule;
            txtNom.Text = salarie.Nom;
            txtPrenom.Text = salarie.Prenom;
            txtDateNaissance.Text = salarie.DateNaissance.ToShortDateString();
            txtSalaireBrut.Text = salarie.SalaireBrut.ToString();
            txtTaux.Text = salarie.TauxCS.ToString();
            if (gbTypeSalarie.Visible == true && ckbCommercial.Checked)
            {
                ((Commercial)salarie).ChiffreAffaire = Convert.ToDecimal(txtChiffreAffaire.Text);
                ((Commercial)salarie).Commission = Convert.ToDecimal(txtComission.Text);
            }

        }

        private void Modifiersalarie()
        {

            if (IsValidChamps())
            {
                try
                {
                    //salarie.Matricule = txtMatricule.Text;
                    salarie.Nom = txtNom.Text;
                    salarie.Prenom=txtPrenom.Text ;
                    salarie.DateNaissance=Convert.ToDateTime(txtDateNaissance.Text) ;
                    try
                    {
                        salarie.SalaireBrut=Convert.ToDecimal(txtSalaireBrut.Text);
                        salarie.TauxCS= Convert.ToDecimal(txtTaux.Text);
                    }
                    catch   (Exception ex)
                    {
                        MessageBox.Show(string.Format("conversion decimal {0}", ex.Source));
                    }
                    if (gbTypeSalarie.Visible == true && ckbCommercial.Checked)
                    {
                        ((Commercial)salarie).ChiffreAffaire = Convert.ToDecimal(txtChiffreAffaire.Text);
                        ((Commercial)salarie).Commission = Convert.ToDecimal(txtComission.Text);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(string.Format("conversion globale {0}", ex.TargetSite));
                }
            }
        }
        private bool IsValidChamps()
        {
            bool valid = true;

            if (!Salarie.IsMatriculeValide(txtMatricule.Text))
            {
                valid = false;
                epSalarie.SetError(txtMatricule, "L'identifiant n'est pas valide");

            }
            else
            {
                epSalarie.SetError(txtMatricule, string.Empty);
            }



            return valid;
        }
        private void cbSalaries_SelectedIndexChanged(object sender, EventArgs e)
        {
            salarie = salaries.ExtraireSalarie(cbSalaries.Items[cbSalaries.SelectedIndex].ToString());
            ChargerValeursSalaries();
            GestionnaireContextes(Contextes.Consultation);

        }

       
        private void AjouterSalarie()
        {
           
            Salarie SalarieNouveau = new Salarie();
            SalarieNouveau.Matricule = txtMatricule.Text.Trim();
            SalarieNouveau.Nom = txtNom.Text.Trim();
            SalarieNouveau.Prenom = txtPrenom.Text.Trim();
            SalarieNouveau.DateNaissance = Convert.ToDateTime(txtDateNaissance.Text);
            SalarieNouveau.SalaireBrut = Convert.ToDecimal(txtSalaireBrut.Text);
            SalarieNouveau.TauxCS = Convert.ToDecimal(txtTaux.Text);

            if (gbTypeSalarie.Visible == true && ckbCommercial.Checked)
            {
                ((Commercial)salarie).ChiffreAffaire = Convert.ToDecimal(txtChiffreAffaire.Text);
                ((Commercial)salarie).Commission = Convert.ToDecimal(txtComission.Text);
            }
            salaries.Add(SalarieNouveau);
        }
        #region Boutons
        private void btnModifier_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.ModificationInitiale);
            modeValidation = ActionValider.validerModifiction;// affecter l'action à mener (valider la modification)

        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            { 
            switch (modeValidation)
            {
                case ActionValider.validerAjout:
                    GestionnaireContextes(Contextes.AjoutValider);
                    GestionnaireContextes(Contextes.Consultation);
                    break;
                case ActionValider.validerModifiction:
                       // Modifiersalarie();
                    GestionnaireContextes(Contextes.ModificationValider);
                    break;
            }

            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            salaries.Save(serialiseur, Properties.Settings.Default.AppData);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ChargerValeursSalaries();
            GestionnaireContextes(Contextes.ModificationAnnuler);
        }

        private void btNouveau_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.AjoutInitial);
            modeValidation = ActionValider.validerAjout; // affecter l'action à mener (valider l'ajout)
        }
        #endregion
    }
}
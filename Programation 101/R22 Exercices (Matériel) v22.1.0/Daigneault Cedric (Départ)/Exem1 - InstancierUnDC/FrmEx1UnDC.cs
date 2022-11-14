using System;
using System.Windows.Forms;
using Librairie1N6;

namespace InstancierUnDC
{
    public partial class FrmEx1UnDC : Form
    {
        ///----------------------------------------------------------------------
        /// <summary>
        /// Description : Instancier un objet de la classe DisqueCompact.
        /// </summary>
        //-----------------------------------------------------------------------
        public const string APP_INFO = "(Mat�riel)";

        #region NE PAS MODIFIER
        public FrmEx1UnDC()
        {
            InitializeComponent();
            Text += APP_INFO;

        }
        private void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion 

        //  ------------------------------------------------------------------------------------------
        private void btnInstancierUnDC_Click(object sender, EventArgs e)
        {
            // TODO 1A : D�clarer et Instancier un objet disque compact avec le constructeur sans param�tre.
            // � compl�ter
           DisqueCompact objDisque = new DisqueCompact();


            // TODO 1B : Afficher les informations sur le disque instanci� dans les zones de texte appropri�es:
            //           le nombre de pistes, la dur�e totale en secondes, la dur�e totale en MM:SS et le genre de musique.
            //           Pour obtenir la dur�e totale dans un format MM:SS utiliser la m�thode statique FormatMMSS() de la classe DisqueCompact
            //  ATTENTION une m�thode statique est appell�e � partir de la classe et non � partir de l'objet (Comme une constante qui est statique)
            // � compl�ter
            txtNbPistes.Text = objDisque.Pistes.Length.ToString();
            txtDureeTotaleSecondes.Text = objDisque.Dur�e.ToString();
            txtDureeTotaleMMSS.Text = DisqueCompact.FormatMMSS(objDisque.Dur�e);
            txtGenre.Text = objDisque.Genre.ToString();



		   
		   
        }

        private void txtNbPistes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
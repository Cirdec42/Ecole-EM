using System.Windows.Forms;
using Librairie1N6;

namespace AfficherInfosPistes
{
    /// <summary>
    /// Description :   Afficher les informations sur les pistes d'un  disque Compact.
    /// </summary>
    public partial class FrmEx2InfosPistes : Form
    {
        public const string APP_INFO = "(Mat�riel)";

        DisqueCompact m_objDisqueCourant = null;

        #region NE PAS MODIFIER
        ///--------------------------------------------------------------------------------
        public FrmEx2InfosPistes()
        {
            InitializeComponent();
            Text += APP_INFO;
            //----------------------------  
            vsaGrilleInfosPistes.ColumnHeaderArray[0] = "Dur�e";
        }
        ///--------------------------------------------------------------------------------
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        #endregion

        #region AfficherInfosDisque
        /// <summary>
        /// Affiche les informations du disque courant (sauf les pistes)
        /// </summary>
        private void AfficherInfosDisque()
        {
            // TODO 2B1 : Compl�ter le code pour afficher : le nombre de pistes et le genre de musique
            // � compl�ter
            txtNbPistes.Text = m_objDisqueCourant.Pistes.Length.ToString();
            txtGenre.Text = m_objDisqueCourant.Genre.ToString();
            // TODO 2B2 : Compl�ter le code pour afficher : la dur�e totale et la dur�e moyenne des pistes
            // � compl�ter
            txtDureeMaximum.Text = m_objDisqueCourant.Dur�e.ToString();
           


        }
        #endregion

        #region AfficherInfosPistes
        /// <summary>
        /// Affiche les informations des pistes du disque courant
        /// </summary>
        private void AfficherInfosPistes()
        {
            vsaGrilleInfosPistes.Clear();
            vsaGrilleInfosPistes.RowCount = m_objDisqueCourant.Pistes.Length;
            // TODO 2K : Afficher la grille vsaGrilleInfosPistes, la dur�e de chacune des pistes
            // � compl�ter
            vsaGrilleInfosPistes[0] =DisqueCompact.FormatMMSS(m_objDisqueCourant.Pistes[0]);


            // TODO 2L : Afficher dans la zone de texte, le nombre de pistes dont la dur�e est sup�rieure � 5 minutes.
            //           ATTENTION: Utiliser la m�thode que vous avez faites en 2I
            // � compl�ter
                txtNbPistesSupA5Min.Text=NbPistesDur�eSup�rieure�5Minutes().ToString();


            // TODO 2M : Afficher dans la zone de texte, la dur�e en MM:SS de la piste la plus longue.
            //           ATTENTION: Utiliser la m�thode que vous avez faites en 2J
            // � compl�ter


        }
        #endregion

        #region Instancier un disque Normal
        /// ----------------------------------------------------------------------------     
        private void BtnInstancierUnDisqueNormal_Click(object sender, System.EventArgs e)
        {
            // TODO 2A1 : Instancier un disque et conserver sa r�f�rence dans la variable m_objDisqueCourant
            // � compl�ter
            m_objDisqueCourant = new DisqueCompact();


            // TODO 2A2 : Appeler les m�thodes AfficherInfosDisque et AfficherInfosPistes
            // � compl�ter
            AfficherInfosDisque();
            AfficherInfosPistes();
        }

        #endregion

        #region Instancier un disque Test1, Test2 ou Test3
        private void BtnInstancierUnDisqueTest1_Click(object sender, System.EventArgs e)
        {
            // TODO 2C : Instancier un disque Test1 et conserver sa r�f�rence dans la variable m_objDisqueCourant
            // � compl�ter
            m_objDisqueCourant = new DisqueCompact(SorteDeDisque.Test1);



            // TODO 2D : Appeler les m�thodes AfficherInfosDisque et AfficherInfosPistes
            // � compl�ter
            AfficherInfosDisque();
            AfficherInfosPistes();
					   
        }
        private void BtnInstancierUnDisqueTest2_Click(object sender, System.EventArgs e)
        {
            // TODO 2E : Instancier un disque Test2 et conserver sa r�f�rence dans la variable m_objDisqueCourant
            // � compl�ter
            m_objDisqueCourant=new DisqueCompact(SorteDeDisque.Test2);

            // TODO 2F : Appeler les m�thodes AfficherInfosDisque et AfficherInfosPistes
            // � compl�ter
            AfficherInfosPistes();
            AfficherInfosDisque();
        }
        private void BtnInstancierUnDisqueTest3_Click(object sender, System.EventArgs e)
        {
            // TODO 2G : Instancier un disque Test3 et conserver sa r�f�rence dans la variable m_objDisqueCourant
            // � compl�ter
            m_objDisqueCourant = new DisqueCompact(SorteDeDisque.Test3);
            // TODO 2H : Appeler les m�thodes AfficherInfosDisque et AfficherInfosPistes
            // � compl�ter
            AfficherInfosDisque();
            AfficherInfosPistes();
			
        }
        #endregion

        #region NbPistesDureeSupA5Min
        ///-------------------------------------------------------------------------------------------
        /// <summary>
        /// Compte le nombre de pistes sur le disque courant dont la dur�e est sup�rieure � 5 minutes.
        /// </summary>
        /// <returns>Le nombre de pistes dont la dur�e est sup�rieure � 5 minutes.</returns>
        /// ------------------------------------------------------------------------------------------
        private int NbPistesDur�eSup�rieure�5Minutes()
        {
            // TODO 2I : Compl�ter le code de cette m�thode
            // � compl�ter
            for (int i = 0; i < m_objDisqueCourant.Pistes.Length; i++)
            {
                if (m_objDisqueCourant.Dur�e<5.00)
                {
                    txtNbPistesSupA5Min.Text += 1;
                }
            }
                return 0;
        }
        #endregion

        #region DureeMaximum
        /// -----------------------------------------------------------------------------------
        /// <summary>
        /// Parcourt la collection de pistes du disque courant afin de d�terminer celle ayant 
        /// la dur�e plus grande.
        /// </summary>
        /// <returns>Dur�e en secondes de la piste la plus longue.</returns>
        /// -----------------------------------------------------------------------------------
        private int DureeMaximum()
        {
            // TODO 2J : Compl�ter le code de cette m�thode
            // � compl�ter
            return 0;
        }

        #endregion

        private void grpInfoDC_Enter(object sender, System.EventArgs e)
        {

        }
    }
   
}
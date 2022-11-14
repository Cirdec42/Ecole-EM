using System.Windows.Forms;
using Librairie1N6;

namespace LecteurUnDC
{
    /// <summary>
    /// Instanciation et manipulation d'un objet de la classe DisqueCompact
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFOS = "(Daigneault et C�dric)";

        #region Variables membres

        // TODO 01 : D�clarer et initialiser � null une variable membre m_objDisqueCourant pour le disque courant.
        //           D�clarer et initialiser � -1 une variable membre m_indexPisteCourante pour l'index de la piste courante.
        DisqueCompact m_objDisqueCourant = null;
        DisqueCompact m_indexPisteCourante;
        //� compl�ter


        #endregion

        //---------------------------------------------------------------------------------
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFOS;

            // Initialiser l'application.
            MettreAJourSelonContexte();

            // Mettre vos tests ici
            InitialiserAffichageDuLecteur();
            // � compl�ter
            

        }

        #region InitialiserAffichageDuLecteur
        private void InitialiserAffichageDuLecteur()
        {
            // TODO 02: Remettre � "00:00" la dur�e totale en MMSS et le temps restant
            txtDureeTotaleMMSS.Text = "00:00";
            txtTempsRestant.Text = "00:00";
            //          Remettre � "00/00" la piste courante  et � "????" le genre de musique
            txtPisteCourante.Text = "00/00";
            txtGenre.Text = "????";
            // Pour tester: Faites un appel de cette m�thode dans le constructeur du formulaire FrmPrincipal
            //              et enlevez cet appel apr�s le test.
            //    ATTENTION: enlevez les commentaires sur la premi�re ligne de code de MettreAJourSelonContexte()
			
            //� compl�ter

        }
        #endregion


        #region �v�nements du menu pour allumer ou �teindre le lecteur

        /// -------------------------------------------------------------------------------
        private void mnuEditionAllumerEteindre_Click(object sender, System.EventArgs e)
        {
            // TODO 03: Changer la valeur de la propri�t� Checked de l'objet chkPower
            chkPower.Checked = true;
            if (chkPower.Checked == true)
            {
                mnuEditionAllumerEteindre.Text = "�teindre le lecteur";
            }
            else
            {
                mnuEditionAllumerEteindre.Text = "Allumer le lecteur";
            }
            //         ( Remarquez que cette instruction d�clenche l'�v�nement chkPower_CheckedChanged qui fera des appels)
            //    ATTENTION: 
            //         Dans MettreAJourSelonContexte, changez �galement le texte du mnuEditionAllumerEteindre de fa�on appropri�e

            //� compl�ter

        }
        #endregion

        #region InsererUnDisque
        /// -----------------------------------------------------------------------------
        /// <summary>
        ///		Ins�re un disque d'une certaine sorte.
        /// </summary>
        /// <param name="pSorteDeDisque">La sorte de disque, un disque normal ou de test.</param>
        /// ------------------------------------------------------------------------------
        private void InsererUnDisque(SorteDeDisque pSorteDeDisque)
        {
            // TODO 04: Instanciez un nouveau disque de la sorte pSorteDeDisque, 
            //   initialisez la piste courant � 0
            m_objDisqueCourant = new DisqueCompact(pSorteDeDisque) ;
            //   puis appelez la m�thode AfficherInfosDisqueCourant 
            AfficherInfosDisqueCourant();
            //             et la m�thode MettreAJourSelonContexte
            MettreAJourSelonContexte();
 
            //    ATTENTION: on ne peut encore rien tester � cette �tape
            //� compl�ter


        }
        #endregion 

        #region AfficherInfosDisqueCourant
        /// -------------------------------------------------------------------------------
        /// <summary>
        ///		Affiche les informations du disque courant soit :
        ///		la dur�e totale, la piste courante, le temps restant et le genre de musique.
        /// </summary>
        /// -------------------------------------------------------------------------------
        private void AfficherInfosDisqueCourant()
        {
            // TODO 05: Afficher les infos du disque courant
            //       V�rifiez s'il y a un disque dans le lecteur
            //           Si oui,  
            if (true)
            {

            }
            //             -	Affichez la dur�e totale en minutes et secondes
            txtDureeTotaleMMSS.Text = m_objDisqueCourant.Dur�e.ToString("0000");
            //             -    Affichez la piste courante
            txtPisteCourante.Text = m_objDisqueCourant.Pistes.ToString();
			//  ATTENTION, pour afficher un nombre avec deux chiffres, utilisez .ToString("00")  au lieu de .ToString()
 			//
            //             -    Appelez la m�thode TempsRestant et affichez le temps restant en minutes et secondes
            //           Si non,
            //             -	Appelez la m�thode InitialiserAffichageDuLecteur

            //   IMPORTANT POUR TESTER, enlevez InitialiserAffichageDuLecteur() du contructeur FrmPrincipal
            //             Et faites l'appel de la m�thode InsererUnDisque(SorteDeDisque.Test1)
            //             Remarquez qu'on peut voir les infos du disque 
            //             et qu'un disque est ins�r� dans le lecteur
			
            //� compl�ter

        }

        #endregion

        #region TempsRestant
        /// -------------------------------------------------------------------------------
        /// <summary>
        /// Calcul le temps restant d'un disque en consid�rant la piste courante
        /// </summary>
        /// <returns>Temps restant � jouer</returns>
        private int TempsRestant()
        {
            // TODO 06: Calculez le temps restant 
            //               en accumulant, � partir de la piste courante, les secondes des pistes
            //               qui restent
            //          (Pistes de DisqueCompact est index� comme un tableau,
            //                avec chaque valeur �tant la dur�e en secondes de chaque piste du disque)
            //  
            //  N'oubliez pas de retourner le r�sultat � la fin de cette m�thode
            //
            //  POUR TESTER:  r�ex�cuter simplement

            //� compl�ter


            return 0;  
        }
        #endregion

        #region �v�nements des menus pour ins�rer un disque
        /// -------------------------------------------------------------------------------
        private void mnuEditionInsererDisqueNormal_Click(object sender, System.EventArgs e)
        {
            // TODO 07A: Appel de la m�thode InsererUnDisque avec la SorteDeDisque Normal
            //    ATTENTION: Enlever les deux appels qu'on avait mis dans le constructeur FrmPrincipal()

            //� compl�ter
        }

        /// -------------------------------------------------------------------------------
        private void mnuEditionInsererDisqueTest1_Click(object sender, System.EventArgs e)
        {
            // TODO 07B: Appel de la m�thode InsererUnDisque avec la SorteDeDisque Test1

            //� compl�ter
        }

        /// -------------------------------------------------------------------------------
        private void mnuEditionInsererDisqueTest2_Click(object sender, System.EventArgs e)
        {
            // TODO 07C: Appel de la m�thode InsererUnDisque avec la SorteDeDisque Test2

            //� compl�ter
        }

        /// -------------------------------------------------------------------------------
        private void mnuEditionInsererDisqueTest3_Click(object sender, System.EventArgs e)
        {
            // TODO 07D: Appel de la m�thode InsererUnDisque avec la SorteDeDisque Test3

            //� compl�ter
        }

        #endregion

        #region MettreAJourSelonContexte avec les boutons pistes suivantes et pistes pr�c�dentes

        /// -------------------------------------------------------------------------------
        private void btnPisteSuivante_Click(object sender, System.EventArgs e)
        {
            // TODO 08:   Bouton pour voir la piste suivante
            //     faites les 3 �tapes suivantes:
            //           1. Avancez � la piste suivante
            //           2. Si vous �tes rendus � la fin du disque courant, revenez � la piste du d�but
            //           3. Appelez la m�thode AfficherInfosDisqueCourant pour que l'affichage s'ajuste

            //� compl�ter

        }

        /// -------------------------------------------------------------------------------
        /// <summary>
        ///		Met � jour les contr�les du lecteur s'il est �teint ou non
        ///		et s'il y a un disque ou non.
        /// </summary>
        /// -------------------------------------------------------------------------------
        private void MettreAJourSelonContexte()
        {
            panInfos.Visible = chkPower.Checked;  //Enlever le commentaire comme sp�cifi� dans le todo 02 
            //panDisque.Visible = chkPower.Checked && m_objDisqueCourant != null; //Enlever le commentaire comme sp�cifi� dans le todo 05 

            //   Suite du TODO 3
           // --- Menu �dition ------------------------------------------------------------ 			
			// � compl�ter
			
			
			
			
			
         
            //TODO 09:    Mettre � jour les menus et les boutons selon le contexte
            //      Faites les �tapes suivantes:
            //           1. Cr�ez une variable bool qui v�rifiera que le disque est allum� et s'il y a un disque dans le lecteur
            //              (la valeur de la propri�t� Checked de chkPower et que le disque courant n'est pas null)
            //           2. Utilisez cette variable pour activer ou non les objets suivants:
            //              btnPisteSuivante et  mnuEditionPistePrecedente,
            //              btnPistePrecedente et  mnuEditionPisteSuivante,
            //              mnuEditionEjecter   
            //           
            //  

            // � compl�ter


        }

        /// -------------------------------------------------------------------------------
        private void btnPistePrecedente_Click(object sender, System.EventArgs e)
        {
            // TODO 10:   Bouton pour voir la piste pr�c�dente
            //      faites les 3 �tapes suivantes:
            //           1. Reculez � la piste suivante
            //           2. Si vous �tes rendus au d�but du disque courant, revenez � la piste de la fin
            //           3. Appelez la m�thode AfficherInfosDisqueCourant pour que l'affichage s'ajuste

            //� compl�ter

        }
        #endregion

        #region �v�nements du menu pour �jecter un disque
        /// -------------------------------------------------------------------------------
        private void mnuEditionEjecter_Click(object sender, System.EventArgs e)
        {
            // TODO 11:  �jecter un disque du lecteur
            //     Faites les �tapes suivantes:
            //          On met l�index de la piste courante � -1
            //          et le disque courant � null 
            //          Appellez les m�thodes AfficherInfosDisqueCourant et MettreAJourSelonContexte

            //� compl�ter



         
        }
        #endregion

        



        #region NE PAS MODIFIER

        /// -------------------------------------------------------------------------------
        private void chkPower_CheckedChanged(object sender, System.EventArgs e)
        {
            AfficherInfosDisqueCourant();  // Ne pas modifier
            MettreAJourSelonContexte();    // Ne pas modifier
        }
       

        /// -----------------------------------------------------------------------
        private void MnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion

        private void FrmPrincipal_Load(object sender, System.EventArgs e)
        {

        }
    }
}
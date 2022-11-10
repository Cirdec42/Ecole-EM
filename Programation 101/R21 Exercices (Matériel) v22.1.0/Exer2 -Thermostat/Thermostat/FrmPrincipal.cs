﻿using System;
using System.Windows.Forms;
using Librairie1N6;

namespace ExerciceThermostat
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";
        /// ==================================================================================
        /// <summary>
        /// Variable membre permettant de référer sur un objet de la classe Thermostat
        /// </summary>
        /// ----------------------------------------------------------------------------------
        // TODO 01 : Définir une variable pour objet Thermostat

        //====================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 02 : Instancier un objet Thermostat et l'affecter dans m_objThermostat
            

            // TODO 03 : Afficher la température courante dans lblTemperature
           

            // TODO 04 : Appeler la méthode ActualiserBoutonsSelonContexte
           
        }
        //====================================================================================
        private void MnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        //====================================================================================
        private void BtnAugmenter_Click(object sender, System.EventArgs e)
        {
            // TODO 05A : Augmenter la température du Thermostat
           
            // TODO 5B : Afficher la température courante du Thermostat
            
            // TODO 5C : Appeler la méthode ActualiserBoutonsSelonContexte
            
        }
        //====================================================================================
        private void BtnDiminuer_Click(object sender, System.EventArgs e)
        {
            // TODO 06A : Diminuer la température du Thermostat
            
            // TODO 6B : Afficher la température courante du Thermostat
            
            // TODO 6C : Appeler la méthode ActualiserBoutonsSelonContexte
           
        }
        //====================================================================================
        private void MnuAffichageTempMin_Click(object sender, EventArgs e)
        {
            // TODO 07A : Afficher la température minimale d'un Thermostat
           
            // TODO 07A : Démarrer l'horloge tmrTempérature
           
        }
        //====================================================================================
        private void MnuAffichageTempMax_Click(object sender, EventArgs e)
        {
            // TODO 08A : Afficher la température maximale d'un Thermostat
           
            // TODO 08B : Démarrer l'horloge tmrTempérature
            
        }
        //====================================================================================
        private void TmrTempérature_Tick(object sender, EventArgs e)
        {
            // TODO 09A : Arrêter l'horloge tmrTempérature
           
            // TODO 09B : Afficher la température actuelle du Thermostat
           
        }
        //====================================================================================
        private void ActualiserBoutonsSelonContexte()
        {
            // TODO 10A : btnDiminuer est actif seulement si la température courante est supérieure à TEMPÉRATURE_MINIMALE
           
            // TODO 10B : btnAugmenter est actif seulement si la température courante est inférieure à TEMPÉRATURE_MAXIMALE
           
        }
    }
}
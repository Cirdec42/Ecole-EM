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
        Thermostat m_objThermostat = new Thermostat();

        //====================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 02 : Instancier un objet Thermostat et l'affecter dans m_objThermostat


            // TODO 03 : Afficher la température courante dans lblTemperature
            lblTemperature.Text = m_objThermostat.Température.ToString();

            // TODO 04 : Appeler la méthode ActualiserBoutonsSelonContexte
            ActualiserBoutonsSelonContexte();
           
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
            m_objThermostat.AugmenterTemperature();
            // TODO 5B : Afficher la température courante du Thermostat
            lblTemperature.Text = m_objThermostat.Température.ToString();
            // TODO 5C : Appeler la méthode ActualiserBoutonsSelonContexte
            ActualiserBoutonsSelonContexte();
        }
        //====================================================================================
        private void BtnDiminuer_Click(object sender, System.EventArgs e)
        {
            // TODO 06A : Diminuer la température du Thermostat
            m_objThermostat.DiminuerTemperature();
            // TODO 6B : Afficher la température courante du Thermostat
            lblTemperature.Text = m_objThermostat.Température.ToString();
            // TODO 6C : Appeler la méthode ActualiserBoutonsSelonContexte
            ActualiserBoutonsSelonContexte();
        }
        //====================================================================================
        private void MnuAffichageTempMin_Click(object sender, EventArgs e)
        {
            // TODO 07A : Afficher la température minimale d'un Thermostat
            lblTemperature.Text = Thermostat.TEMPÉRATURE_MINIMALE.ToString();
            // TODO 07A : Démarrer l'horloge tmrTempérature
            tmrTempérature.Start();
        }
        //====================================================================================
        private void MnuAffichageTempMax_Click(object sender, EventArgs e)
        {
            // TODO 08A : Afficher la température maximale d'un Thermostat
            lblTemperature.Text = Thermostat.TEMPÉRATURE_MAXIMALE.ToString();
            // TODO 08B : Démarrer l'horloge tmrTempérature
            tmrTempérature.Start();
        }
        //====================================================================================
        private void TmrTempérature_Tick(object sender, EventArgs e)
        {
            // TODO 09A : Arrêter l'horloge tmrTempérature
            tmrTempérature.Stop();
            // TODO 09B : Afficher la température actuelle du Thermostat
            lblTemperature.Text = m_objThermostat.Température.ToString();
        }
        //====================================================================================
        private void ActualiserBoutonsSelonContexte()
        {
            // TODO 10A : btnDiminuer est actif seulement si la température courante est supérieure à TEMPÉRATURE_MINIMALE
            if (m_objThermostat.Température>Thermostat.TEMPÉRATURE_MINIMALE)
            {
                btnDiminuer.Enabled = true;
            }
            else
            {
                btnDiminuer.Enabled = false;
            }
            // TODO 10B : btnAugmenter est actif seulement si la température courante est inférieure à TEMPÉRATURE_MAXIMALE
            if (m_objThermostat.Température < Thermostat.TEMPÉRATURE_MAXIMALE)
            {
                btnAugmenter.Enabled = true;
            }
            else
            {
                btnAugmenter.Enabled = false;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
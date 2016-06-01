﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Model;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CybersportManager.Client
{
    /// <summary>
    /// Interaction logic for AddPlayer.xaml
    /// </summary>
    public partial class AddPlayer : UserControl
    {
        
        public AddPlayer()
        {
            this.DataContext = this;
            InitializeComponent();
            FillTeamComboBox();
        }



        private void ClearInputs()
        {
            nametb.Text = "";
            snametb.Text = "";
            nnametb.Text = "";
            agetb.Text = "";
            rolecb.Text = "";
            countrycb.Text = "";
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (nametb.Text != null & snametb.Text != null && nnametb.Text != null && agetb.Text != null&& agetb.Text.All(char.IsDigit) && rolecb.SelectedItem !=null)
            {
               
               
                Player newplayer = new Player(nametb.Text, snametb.Text, nnametb.Text, Convert.ToInt32(agetb.Text), (RoleType)Enum.Parse(typeof(RoleType), rolecb.Text));
                if (teamcb.SelectedItem != null)
                {
                    newplayer.Team = Database.searchTeam(teamcb.Text);
                }
                else
                { newplayer.Teamless = true; }
                newplayer.Homeland = Database.searchCountry(countrycb.Text);
                Database.addPlayer(newplayer);
                ClearInputs();
            }
            else
                MessageBox.Show("Eror");
        }

        private ActivePage currentPage;
        private void FillTeamComboBox()
        {
            foreach (Team team in Database.allTeams)
            {
                teamcb.Items.Add(team.Name);
            }
        }
        
        private void PlayerPageBtn_Click(object sender, RoutedEventArgs e)
        {
            PlayersPage pp = new PlayersPage();
            currentPage = ActivePage.Players;
            pp.currentPage = this.currentPage;
            this.Content = pp;
        }

        private void TeamPageBtn_Click(object sender, RoutedEventArgs e)
        {
            TeamsPage tp = new TeamsPage();
            currentPage = ActivePage.Teams;
            tp.currentPage = this.currentPage;
            this.Content = tp;

        }

        private void TournamentPageBtn_Click(object sender, RoutedEventArgs e)
        {
            TournamentsPage tp = new TournamentsPage();
            currentPage = ActivePage.Tournaments;
            tp.currentPage = this.currentPage;
            this.Content = tp;

        }

        private void HeroesPageBtn_Click(object sender, RoutedEventArgs e)
        {
            HeroesPage hp = new HeroesPage();
            currentPage = ActivePage.Heroes;
            hp.currentPage = this.currentPage;
            this.Content = hp;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (currentPage)
            {
                case (ActivePage.Players):
                    this.Content = new AddPlayer();
                    break;
                case (ActivePage.Teams):
                    this.Content = new AddTeam();
                    break;
            }
        }

        private void ViewBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (currentPage)
            {
                case (ActivePage.Players):
                    this.Content = new ViewPlayers();
                    break;
                case (ActivePage.Teams):
                    this.Content = new ViewTeams();
                    break;
            }
        }


    }
}

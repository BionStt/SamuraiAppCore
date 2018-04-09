﻿using SamuraiAppCore.Data;
using SamuraiAppCore.Domain;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace SamuraiAppCore.Wpf
{
    /// <summary>
    /// Interaction logic for BattlesWindow.xaml
    /// </summary>
    public partial class BattlesWindow : Window
    {
        private readonly ConnectedData _repo = new ConnectedData();
        private List<Samurai> _availableSamurais;
        private ObjectDataProvider _battleViewSource;
        private Battle _currentBattle;
        private bool _isListChanging;
        private bool _isLoading;
        //TODO

        public BattlesWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _isLoading = true;
            battleListBox.ItemsSource = _repo.BattlesListInMemory();
            _battleViewSource = (ObjectDataProvider)FindResource("battleDataProvider");
            _isLoading = false;
            battleListBox.SelectedIndex = 0;
        }

        private void battleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_currentBattle != null && _currentBattle.IsDirty)
            {
                ShowSaveBattleMessageBox();
            }

            if (_isLoading == false)
            {
                _isListChanging = true;
                _currentBattle = _repo.LoadBattleGraph((int)battleListBox.SelectedValue);
                _battleViewSource.ObjectInstance = _currentBattle;
                _availableSamurais = _repo.SamuraisNotInBattle(_currentBattle.Id);
                samuraisNotInBattle.ItemsSource = _availableSamurais;
                _isListChanging = false;
            }
        }

        private void ShowSaveBattleMessageBox()
        {
            //TODO
            throw new NotImplementedException();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _repo.SaveChanges(_currentBattle.GetType());
        }

        #region AddSamuraiToBattle

        private void samuraisInBattle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //TODO
        }

        private void samuraisInBattle_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            //TODO
        }

        private void samuraisInBattle_DragEnter(object sender, DragEventArgs e)
        {
            //TODO
        }

        private void samuraisInBattle_Drop(object sender, DragEventArgs e)
        {
            //TODO
        }

        #endregion AddSamuraiToBattle

        #region RemoveSamuraiFromBattle

        private void samuraisNotInBattle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //TODO
        }

        private void samuraisNotInBattle_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            //TODO
        }

        private void samuraisNotInBattle_DragEnter(object sender, DragEventArgs e)
        {
            //TODO
        }

        private void samuraisNotInBattle_Drop(object sender, DragEventArgs e)
        {
            //TODO
        }

        #endregion RemoveSamuraiFromBattle

        private void nameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //TODO
        }

        private void startDateDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            //TODO
        }

        private void endDateDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            //TODO
        }

        private void NoteSamuraiMove()
        {
            //TODO
        }

        private void GatherSelectedItemForMove(object sender, MouseEventArgs e)
        {
            //TODO
        }

        private static void IgnoreNonSamuraiItem(object sender, DragEventArgs e)
        {
            //TODO
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            _isListChanging = true;
            _currentBattle = _repo.CreateNewBattle();
            _battleViewSource.ObjectInstance = _currentBattle;
            battleListBox.SelectedItem = _currentBattle;
            samuraisInBattle.ItemsSource = _currentBattle.SamuraiBattles;
            _isListChanging = false;
            _currentBattle.IsDirty = true;
        }

        private void GotoSamurais_Click(object sender, RoutedEventArgs e)
        {
            var samuraisWindow = new MainWindow();
            samuraisWindow.Show();
            Close();
        }
    }
}
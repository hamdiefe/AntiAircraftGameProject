﻿using AntiAircraftGameProject.Library.Concrete;
using System;
using System.Windows.Forms;

namespace AntiAircraftGameProject.Desktop
{
    public partial class MainForm : Form
    {
        private readonly Game _game;

        public MainForm()
        {
            InitializeComponent();
            _game = new Game(antiAircraftPnl);
            _game.PassedTimeChanged += Game_PassedTimeChanged;
        }

      

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _game.Start();
                    break;

                case Keys.Space:
                    _game.Fire();
                    break;

                case Keys.Right:
                    _game.MoveAircraft(Library.Enum.Direction.Right);
                    break;

                case Keys.Left:
                    _game.MoveAircraft(Library.Enum.Direction.Left);
                    break;
            }
        }

        private void Game_PassedTimeChanged(object sender, EventArgs e)
        {
            timerLbl.Text = $"{_game.PassedTime.Minutes}:{_game.PassedTime.Seconds.ToString("D2")}";
        }
    }
}

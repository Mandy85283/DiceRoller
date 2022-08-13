using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DiceRoller.Models;

namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void DisplayOne(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            var i = button.Content;
            i.ToString();



        }

        public void DisplayTwo(object sender, EventArgs args)
        {
            Result2.IsVisible = true;
            if (d4.IsChecked)
            {
                Die chosenDice1 = new Die(4);
                Die chosenDice2 = new Die(4);
                string result1 = chosenDice1.CurrentSide.ToString();
                string result2 = chosenDice2.CurrentSide.ToString();
                Result1.Text = "Die 1: " + result1;
                Result2.Text = "Die 2: " + result2;
            }
            else if (d6.IsChecked)
            {
                Die chosenDice1 = new Die();
                Die chosenDice2 = new Die();
                string result1 = chosenDice1.CurrentSide.ToString();
                string result2 = chosenDice2.CurrentSide.ToString();
                Result1.Text = "Die 1: " + result1;
                Result2.Text = "Die 2: " + result2;
            }
            else if (d8.IsChecked)
            {
                Die chosenDice1 = new Die(8);
                Die chosenDice2 = new Die(8);
                string result1 = chosenDice1.CurrentSide.ToString();
                string result2 = chosenDice2.CurrentSide.ToString();
                Result1.Text = "Die 1: " + result1;
                Result2.Text = "Die 2: " + result2;
            }
            else if (d10.IsChecked)
            {
                Die chosenDice1 = new Die(10);
                Die chosenDice2 = new Die(10);
                string result1 = chosenDice1.CurrentSide.ToString();
                string result2 = chosenDice2.CurrentSide.ToString();
                Result1.Text = "Die 1: " + result1;
                Result2.Text = "Die 2: " + result2;
            }
            else if (d12.IsChecked)
            {
                Die chosenDice1 = new Die(12);
                Die chosenDice2 = new Die(12);
                string result1 = chosenDice1.CurrentSide.ToString();
                string result2 = chosenDice2.CurrentSide.ToString();
                Result1.Text = "Die 1: " + result1;
                Result2.Text = "Die 2: " + result2;
            }
            else if (d20.IsChecked)
            {
                Die chosenDice1 = new Die(20);
                Die chosenDice2 = new Die(20);
                string result1 = chosenDice1.CurrentSide.ToString();
                string result2 = chosenDice2.CurrentSide.ToString();
                Result1.Text = "Die 1: " + result1;
                Result2.Text = "Die 2: " + result2;
            }
            else
            {
                Result1.Text = "Select a die to roll";
            }


        }

        private void DisplayOne(object sender, EventArgs args)
        {
            Result2.IsVisible = false;
            if (d4.IsChecked)
            {
                Die chosenDice = new Die(4);
                string result = chosenDice.CurrentSide.ToString();
                Result1.Text = result;
            }
            else if (d6.IsChecked)
            {
                Die chosenDice = new Die();
                string result = chosenDice.CurrentSide.ToString();
                Result1.Text = result;
            }
            else if (d8.IsChecked)
            {
                Die chosenDice = new Die(8);
                string result = chosenDice.CurrentSide.ToString();
                Result1.Text = result;
            }
            else if (d10.IsChecked)
            {
                Die chosenDice = new Die(10);
                string result = chosenDice.CurrentSide.ToString();
                Result1.Text = result;
            }
            else if (d12.IsChecked)
            {
                Die chosenDice = new Die(12);
                string result = chosenDice.CurrentSide.ToString();
                Result1.Text = result;
            }
            else if (d20.IsChecked)
            {
                Die chosenDice = new Die(20);
                string result = chosenDice.CurrentSide.ToString();
                Result1.Text = result;
            }
            else
            {
                Result1.Text = "Select a die to roll";
            }



        }
    }
}

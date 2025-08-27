using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vilta_Logic.Vilta_Functions;

namespace Vilta_Snippet
{
    public partial class ctrlPasswordCheker : UserControl
    {
        public ctrlPasswordCheker()
        {
            InitializeComponent();
        }

        private void _IsCorrect(bool Value, ref Label Text, ref PictureBox Img)
        {
            if (Value)
            {
                Text.ForeColor = Color.Crimson;
                Img.Image = Image.FromFile(@"D:\Vilta Snippet\Images\Icons\Hover Icons\Wrong.png");
            }
            else
            {
                Text.ForeColor = Color.Green;
                Img.Image = Image.FromFile(@"D:\Vilta Snippet\Images\Icons\Genral\Correct.png");
            }

        }

        public void CheckPasswordConditions(string Password)
        {
            if (clsValidations.CheckPasswordContainNumbers(Password))
                _IsCorrect(false, ref txtNumbers, ref NumbersImg);
            else
                _IsCorrect(true, ref txtNumbers, ref NumbersImg);

            if (clsValidations.CheckPasswordContainCapLetter(Password))
                _IsCorrect(false, ref txtCapLetter, ref CapLetterImg);
            else
                _IsCorrect(true, ref txtCapLetter, ref CapLetterImg);

            if (clsValidations.CheckPasswordContainLowLetter(Password))
                _IsCorrect(false, ref txtLowLetter, ref LowLetterImg);
            else
                _IsCorrect(true, ref txtLowLetter, ref LowLetterImg);

            if (clsValidations.CheckPasswordContainSymbols(Password))
                _IsCorrect(false, ref txtSymbols, ref SymbolsImg);
            else
                _IsCorrect(true, ref txtSymbols, ref SymbolsImg);
        }
    }
}

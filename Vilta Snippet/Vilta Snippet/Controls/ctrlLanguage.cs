using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vilta_Logic.Snippets;

namespace Vilta_Snippet.Controls
{
    public partial class ctrlLanguage : UserControl
    {
        public ctrlLanguage(string LangName, int SnippetsCount)
        {
            InitializeComponent();
            _SetLanguageData(LangName, SnippetsCount);
        }

        private void _SetLanguageData(string LangName, int SnippetsCount)
        {
            Language.Image        = clsViltaUiFunctions.GetLanguageImg(LangName);
            Language.Text         = LangName;
            txtSnippetsCount.Text = SnippetsCount.ToString();
        }
    }
}

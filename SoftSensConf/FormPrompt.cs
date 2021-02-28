using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftSensConf
{
    public partial class FormPrompt : Form
    {
        public FormPrompt()
        {
            InitializeComponent();
        }

        public string promptText { get; set; }

        public void buttonOK_Click(object sender, EventArgs e)
        {
            this.promptText = textBoxPrompt.Text;
        }

        
    }
}

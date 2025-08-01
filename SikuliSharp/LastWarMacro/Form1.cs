using LastWarMacro.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastWarMacro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ScriptManager.Instance.Run(ScriptType.GOLD_ZOMBIE);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ScriptManager.Instance.Stop();
        }
    }
}

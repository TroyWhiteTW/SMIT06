using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0829_GoAhead {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        void SendMail(int i) {
            try {
                if (i == 4) {
                    // Email address format is wrong...
                    Exception ex = new Exception("Email format error");
                    throw ex;
                }

                listBox1.Items.Add(i);
            } catch (Exception e) {
                listBox1.Items.Add(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            for (int i = 1; i <= 9; i++) {
                SendMail(i);
            }
        }
    }
}
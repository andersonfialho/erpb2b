using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://www.youtube.com/watch?v=jzroyypTGoU
//https://pt.stackoverflow.com/questions/46474/como-fazer-um-bot%C3%A3o-com-cantos-arredondados-em-c-winforms?rq=1
//https://www.youtube.com/watch?v=UMhskLXJuq4


namespace PDV_B2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
                        
            //this.Top = 0;
            //this.Left = 0;
            // this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            // this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 800;//Altera a Largura
            this.Height = 600;//Altera a Altura
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 1024;//Altera a Largura
            this.Height = 768;//Altera a Altura
        }
    }
}

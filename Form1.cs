using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sabt_name
{
    public partial class registerform : Form
    {
       
        
        public registerform()
        {
            InitializeComponent();
        }
         
        void sabtname (Human form)
        {
            db databace = new db();

            if (form.age >= 20)
            {
                
                databace.Humans.Add(new Human { name = form.name, family = form.family, age = form.age });
                databace.SaveChanges();
            }
            else if (form.age < 20 )
            {
                MessageBox.Show("sen bayad az 20 bala tar bashe ");
            }
        }      

        private void button1_Click(object sender, EventArgs e)
        {
           
            sabtname(new Human { name = textBox1.Text, family = textBox2.Text, age = Convert.ToByte(textBox3.Text) });
        }

        private void button1_Leave(object sender, EventArgs e)
        {

            MessageBox.Show("32");
        }


        List<Human> hum = new List<Human>() { new Human {age=23,family="moibnn",name="mobin"   } };
    }
    
    
}

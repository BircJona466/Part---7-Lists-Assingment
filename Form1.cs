using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part___7_Lists_Assingment
{
    public partial class ListAssingment : Form
    {List<int> numbers = new List<int>();
            List<string> heroes = new List<string>();
            Random generator = new Random();
        
            
        public ListAssingment()
        {
            InitializeComponent();
            
        }

        private void ListAssingment_Load(object sender, EventArgs e)
        {
            

            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));

            lstNumbers.DataSource = numbers;

            heroes.Add("Superman");
            heroes.Add("Batman");
            RefreshHeroesListbox();
       
            
        }

        private void btnNewList_Click(object sender, EventArgs e)
        {

            numbers.Clear();

            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));

            RefreshNumberListbox();

            lblStatus.Text = "Status : New List Created.";
        }

        private void btnSortList_Click(object sender, EventArgs e)
        {
            
            
            

            numbers.Sort();

            RefreshNumberListbox();

            lblStatus.Text = "Status : Numbers Sorted";
        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {

            if ((int)lstNumbers.SelectedIndex >= 0)
            {
                lblStatus.Text = ("Status : Number Removed");
                numbers.RemoveAt(lstNumbers.SelectedIndex);
                
                RefreshNumberListbox();
            }

            else
            {
                lblStatus.Text = "You havent selected a number!";
            }
            


        }
        private void btnRemoveAllNumbers_Click(object sender, EventArgs e)
        {
            lstNumbers.DataSource = null;
        }

        private void RefreshNumberListbox()
        {
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
        }

        private void RefreshHeroesListbox()
        {
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();

            RefreshHeroesListbox();
        }

        private void btnAddHero_Click(object sender, EventArgs e)
        {
            if (GetIndexIgnoreCase(txtAddHero.Text) != -1)
            {
                lblStatus.Text = "Status : You can't add that!";
            }
             else
            {
                
                heroes.Add((string)txtAddHero.Text);

                RefreshHeroesListbox();

                
            }
        } 
                    
                    
                    
                    
            

        private void btnRemoveHeroes_Click(object sender, EventArgs e)
        {



            heroes.Remove(txtRemoveHeroes.Text);
            lblStatus.Text = "Hero Removed.";


                
            
        }


        private int GetIndexIgnoreCase(string hero)
        {
            for (int i = 0; i < heroes.Count; i++)
            {
                if (heroes[i].Equals(hero, StringComparison.CurrentCultureIgnoreCase))
                    return i;

            }
            return -1;
        }
    }
}

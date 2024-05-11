using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_II
{
    public partial class FUserControlIntrebari : UserControl
    {
        public FUserControlIntrebari()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


//*namespace SlideIntrebariFrecvente
//{
  //  public partial class Form1 : Form
//{
  //  public Form1()
    //{
      //  InitializeComponent();

        // Populează ListBox-ul cu întrebări
        //listBoxIntrebari.Items.Add("Cățelul la Dog Hotel");
        //listBoxIntrebari.Items.Add("Programul de masă al cățeilor");

        // Inițializează răspunsurile
        //AfiseazaRaspuns("Cățelul meu nu a mai fost niciodată într-o pensiune canină. Pot să îl aduc la Dog Hotel?", "Desigur. Pentru toți cățeii există o primă dată...");
    //}

    //private void listBoxIntrebari_SelectedIndexChanged(object sender, EventArgs e)
    //{
        // Obține întrebarea selectată
      //  string intrebare = listBoxIntrebari.SelectedItem.ToString();

        // Afișează răspunsul corespunzător
        //switch (intrebare)
        //{
          //  case "Cățelul la Dog Hotel":
            //    AfiseazaRaspuns("Cățelul meu nu a mai fost niciodată într-o pensiune canină. Pot să îl aduc la Dog Hotel?", "Desigur. Pentru toți cățeii există o primă dată...");
              //  break;
            //case "Programul de masă al cățeilor":
              //  AfiseazaRaspuns("Care este programul de masă al cățeilor?", "În principal, cățeii mănâncă de două ori pe zi...");
               // break;
                // Adaugă cazuri pentru alte întrebări aici, după necesități
       // }
   // }

    //private void AfiseazaRaspuns(string intrebare, string raspuns)
    //{
        // Afișează întrebarea într-un TextBox
      //  textBoxIntrebare.Text = intrebare;

        // Afișează răspunsul în alt TextBox
        //textBoxRaspuns.Text = raspuns;
   // }
//}
//}

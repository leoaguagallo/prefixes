using ConversionArimetica_Infija_Posfija_Prefija.model;
using System;
using System.Windows.Forms;

namespace ConversionArimetica_Infija_Posfija_Prefija
{
    public partial class FrmPosfija : Form
    {
        public FrmPosfija()
        {
            InitializeComponent();
        }

        //TransformacionPosfija posfija;
        TransformacionPosfija2 posfija;
        TransformacionPrefija prefija;

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConversion_Click(object sender, EventArgs e)
        {
            posfija = new TransformacionPosfija2(txtexpresion.Text);
            posfija.ExpresionInfijoToVector();
            posfija.TransformarPostfijo();
            txtPosfija.Text = posfija.getExpresionPOSFIJA();

            Console.WriteLine("OK POSFIJA!!");

            prefija = new TransformacionPrefija(txtexpresion.Text);
            prefija.ExpresionInfijoToVector();
            prefija.TransformarPrefija();
            txtPrefija.Text = prefija.getExpresionPREFIJA();


        }

        private void BtnPrueba_Click(object sender, EventArgs e)
        {
            //posfija.ExpresionInfijoToVector();
            //txtprueba.Text = posfija.getVecInfijo();
        }
    }
}

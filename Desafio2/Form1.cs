using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2
{
    public partial class Desafio2 : Form
    {
        public Desafio2()
        {
            InitializeComponent();

            InicializaComboBox();
        }

        private void InicializaComboBox()
        {
            //Criação dos itens do ComboBox
            Item item1 = new Item("byte", byte.MaxValue, byte.MinValue);
            Item item2 = new Item("sbyte", sbyte.MaxValue, sbyte.MinValue);
            Item item3 = new Item("short", short.MaxValue, short.MinValue);
            Item item4 = new Item("int", int.MaxValue, int.MinValue);

            //Adiciona os itens ao ComboBox
            cbTipos.Items.Add(item1);
            cbTipos.Items.Add(item2);
            cbTipos.Items.Add(item3);
            cbTipos.Items.Add(item4);
        }

        private void cbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itemSelecionado = (Item)cbTipos.SelectedItem;

            txbMinValue.Text = itemSelecionado.valMin.ToString();
            txbMaxValue.Text = itemSelecionado.valMax.ToString();
        }
    }
}

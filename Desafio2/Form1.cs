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
            /** INICIALIZA A JANELA E OS COMPONENTES DA MESMA */
            InitializeComponent();

            InicializaComboBox();
        }

        /** INICIALIZAÇÃO DO COMBOBOX */
        private void InicializaComboBox()
        {
            /** CRIAÇÃO DOS ITENS DO COMBOBOX */
            Item itemByte = new Item("byte", byte.MaxValue, byte.MinValue);
            Item itemSByte = new Item("sbyte", sbyte.MaxValue, sbyte.MinValue);
            Item itemShort = new Item("short", short.MaxValue, short.MinValue);
            Item itemUShort = new Item("ushort", ushort.MaxValue, ushort.MinValue);
            Item itemInt = new Item("int", int.MaxValue, int.MinValue);
            Item itemUInt = new Item("uint", uint.MaxValue, uint.MinValue);
            Item itemLong = new Item("long", long.MaxValue, long.MinValue);
            Item itemULong = new Item("ulong", ulong.MaxValue, ulong.MinValue);
            Item itemFloat = new Item("float", float.MaxValue, float.MinValue);
            Item itemDouble = new Item("double", double.MaxValue, double.MinValue);
            Item itemDecimal = new Item("decimal", decimal.MaxValue, decimal.MinValue);

            /** ADICIONA OS ITENS AO COMBOBOX */
            cbTipos.Items.Add(itemByte);
            cbTipos.Items.Add(itemSByte);
            cbTipos.Items.Add(itemShort);
            cbTipos.Items.Add(itemUShort);
            cbTipos.Items.Add(itemInt);
            cbTipos.Items.Add(itemUInt);
            cbTipos.Items.Add(itemLong);
            cbTipos.Items.Add(itemULong);
            cbTipos.Items.Add(itemFloat);
            cbTipos.Items.Add(itemDouble);
            cbTipos.Items.Add(itemDecimal);
        }

        /** EVENTO DE SELEÇÃO DO COMBOBOX */
        private void cbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            /** PEGA REFERÊNCIA DO ITEM SELECIONADO */
            Item itemSelecionado = (Item)cbTipos.SelectedItem;

            /** ADICIONA VALORES MÁXIMO E MÍNIMO AOS CAMPOS */
            txbMinValue.Text = itemSelecionado.valMin.ToString();
            txbMaxValue.Text = itemSelecionado.valMax.ToString();
        }
    }
}

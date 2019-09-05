using System;

using System.Windows.Forms;
using PizzaFacotry;

namespace PizzaStore
{
    public partial class PizzaStore : Form
    {
        public PizzaStore()
        {
            InitializeComponent();
        }

        private PizzaStoreClass _pizzaStore;

        private void PizzaStore_Load(object sender, EventArgs e)
        {
            SimplePizzaFactory pizzaFactory = new SimplePizzaFactory();
            _pizzaStore = new PizzaStoreClass(pizzaFactory);

            foreach (PizzaType pizza in (PizzaType[]) Enum.GetValues(typeof(PizzaType)))
            {
                ListBoxPizza.Items.Add(pizza.ToString());
            }       
        }

        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            Pizza pizza;

            //pizza = _pizzaStore.orderPizza(ListBoxPizza.GetItemText(ListBoxPizza.SelectedItem));

            if (ListBoxPizza.SelectedItem.ToString() == PizzaType.Cheese.ToString()) pizza = _pizzaStore.orderPizza(PizzaType.Cheese);
            else if (ListBoxPizza.SelectedItem.ToString() == PizzaType.Funghi.ToString()) pizza = _pizzaStore.orderPizza(PizzaType.Funghi);
            else pizza = _pizzaStore.orderPizza(PizzaType.Ham);

            LabelResults.Text = pizza.Bake() + Environment.NewLine +
                                pizza.Prepare() + Environment.NewLine +
                                pizza.Box();
        }
    }
}

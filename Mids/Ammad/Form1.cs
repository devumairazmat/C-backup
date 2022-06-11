namespace Ammad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void form1_load(object sender, EventArgs e)
        {
            lstBox1.Items.Add("Monday");
            lstBox1.Items.Add("Tuesday");
            lstBox1.Items.Add("Wednesday");
            lstBox1.Items.Add("Thursday");
            lstBox1.Items.Add("Fridayday");
            lstBox1.Items.Add("Saturday");
            lstBox1.Items.Add("Sunday");
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Items = "";
            Items = lstBox1.SelectedItem.ToString();
            MessageBox.Show(Items);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Items = "";
            foreach (var Item in lstBox1.SelectedItems)
            {
                Items += Item.ToString();
                Items += "\n";
            }
            MessageBox.Show(Items);
        }
    }
}
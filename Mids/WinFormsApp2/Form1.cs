namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_load(object sender, EventArgs e)
        {
            //lstBox1.Items.Add("Sunday");
            //lstBox1.Items.Add("Monday");
            //lstBox1.Items.Add("Tuesday");
            //lstBox1.Items.Add("Wednesday");
            //lstBox1.Items.Add("Thursday");
            //lstBox1.Items.Add("Friday");
            //lstBox1.Items.Add("Saturday");

            List<string> mylist = new List<string>();
            mylist.Add("Umair");
            mylist.Add("Uzair");
            mylist.Add("Zunair");
            mylist.Add("Tamator");

            lstBox1.DataSource = mylist;

           

            //ListBox lstbox2 = new ListBox();
            //lstbox2.Location = new System.Drawing.Point();
            //lstbox2.Size = new System.Drawing.Size();
            //lstbox2.DataSource = mylist;
            //this.Controls.Add(lstbox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Items = "";
           Items = lstBox1.SelectedItem.ToString();
            MessageBox.Show(Items);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Items = "";
            foreach (var Item in lstBox1.SelectedItems)
            {
                Items += Item.ToString();
                Items += "\n";
            }
            MessageBox.Show(Items);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstBox2.Items.Add(lstBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach(var items in lstBox1.SelectedItems)
            {
                lstBox2.Items.Add(items);
            }

        }
    }
}
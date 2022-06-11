namespace WinFormsApp_class_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode tNode;
                tNode = treeView1.Nodes.Add("GCUF Physical Science Department");

            treeView1.Nodes[0].Nodes.Add("Software Engineering");
            treeView1.Nodes[0].Nodes.Add("Information Technology");
            treeView1.Nodes[0].Nodes.Add("Computer Science");

            treeView1.Nodes[0].Nodes[0].Nodes.Add("2nd Semester");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("4th Semester");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("6th Semester");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("8th Semester");

            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Morning");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Evening");


            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("Morning");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("Evening");


            treeView1.Nodes[0].Nodes[0].Nodes[2].Nodes.Add("Morning");
            treeView1.Nodes[0].Nodes[0].Nodes[2].Nodes.Add("Evening");

            treeView1.Nodes[0].Nodes[0].Nodes[3].Nodes.Add("Morning");
            treeView1.Nodes[0].Nodes[0].Nodes[3].Nodes.Add("Evening");

            treeView1.Nodes[0].Nodes[1].Nodes.Add("2nd Semester");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("4th Semester");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("6th Semester");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("8th Semester");


            treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Morning");
            treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Evening");


            treeView1.Nodes[0].Nodes[1].Nodes[1].Nodes.Add("Morning");
            treeView1.Nodes[0].Nodes[1].Nodes[1].Nodes.Add("Evening");


            treeView1.Nodes[0].Nodes[1].Nodes[2].Nodes.Add("Morning");
            treeView1.Nodes[0].Nodes[1].Nodes[2].Nodes.Add("Evening");

            treeView1.Nodes[0].Nodes[1].Nodes[3].Nodes.Add("Morning");
            treeView1.Nodes[0].Nodes[1].Nodes[3].Nodes.Add("Evening");

            treeView1.Nodes[0].Nodes[2].Nodes.Add("2nd Semester");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("4th Semester");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("6th Semester");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("8th Semester");

            treeView1.Nodes[0].Nodes[2].Nodes[0].Nodes.Add("Morning");
            treeView1.Nodes[0].Nodes[2].Nodes[0].Nodes.Add("Evening");


            treeView1.Nodes[0].Nodes[2].Nodes[1].Nodes.Add("Morning");
            treeView1.Nodes[0].Nodes[2].Nodes[1].Nodes.Add("Evening");


            treeView1.Nodes[0].Nodes[2].Nodes[2].Nodes.Add("Morning");
            treeView1.Nodes[0].Nodes[2].Nodes[2].Nodes.Add("Evening");

            treeView1.Nodes[0].Nodes[2].Nodes[3].Nodes.Add("Morning");
            treeView1.Nodes[0].Nodes[2].Nodes[3].Nodes.Add("Evening");

           

        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             MessageBox.Show(treeView1.SelectedNode.FullPath);
           
        }
    }
}
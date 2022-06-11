using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public string SlectedText
        {
            get { return comboBox1.Text; }
        }
        public string Selectedvalue
        {
            get { return comboBox1.SelectedValue.ToString(); }
        }
        public event EventHandler SelectedIdexChanged;
        public UserControl1()
        {
            
            InitializeComponent();
            this.Load += new EventHandler(UserControl_Load);
            this.comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }

         void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        
            {
                if (SelectedIdexChanged != null)
                    SelectedIdexChanged(sender, e);
            }

            #region User Control Event  
            void UserControl_Load(object sender, EventArgs e)
            {
                BindComboBox();
            }
        private void BindComboBox()
        {
            DataTable dtState = new System.Data.DataTable();
            dtState.Columns.Add("txtPart");
            dtState.Columns.Add("valuePart");
            dtState.Rows.Add("Lahore", "1");//Here Delhi is txtPart and 1 is valuepart  
            dtState.Rows.Add("Faisalabd", "2");
            dtState.Rows.Add("Karachi", "3");
            dtState.Rows.Add("Islamabad", "4");
            comboBox1.DataSource = dtState;
            comboBox1.DisplayMember = "txtPart";
            comboBox1.ValueMember = "ValuePart";
        }
        #endregion 
    }
}

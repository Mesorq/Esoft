using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class FormAgent : Form
    {
        public FormAgent()
        {
            InitializeComponent();
            ShowAgent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormAgent_Load(object sender, EventArgs e)
        {

        }
        void ShowAgent()
        {
            listViewAgent.Items.Clear();
            foreach (agent agentSet in Program.wftDb.agent)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        agentSet.Id.ToString(),
                        agentSet.FirstName,
                        agentSet.MiddleName,
                        agentSet.LastName,
                        Convert.ToString(agentSet.DealShare),
                    });
                item.Tag = agentSet;
                listViewAgent.Items.Add(item);
            }
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        agent addAgent(agent agentSet)
        {
            agentSet.FirstName = textBoxFirstName.Text;
            agentSet.MiddleName = textBoxMiddleName.Text;
            agentSet.LastName = textBoxLastName.Text;
            agentSet.DealShare = Convert.ToInt32(numericUpDownDealShare.Text);
            return agentSet;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            agent agentSet = new agent();

            agentSet = addAgent(agentSet);

            Program.wftDb.agent.Add(agentSet);
            Program.wftDb.SaveChanges();
            ShowAgent();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    agent agentSet = (agent)listViewAgent.SelectedItems[0].Tag;

                    Program.wftDb.agent.Remove(agentSet);
                    Program.wftDb.SaveChanges();
                    ShowAgent();
                }

                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                numericUpDownDealShare.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                agent agentSet = (agent)listViewAgent.SelectedItems[0].Tag;

                agentSet = addAgent(agentSet);

                Program.wftDb.SaveChanges();
                ShowAgent();
            }
        }

        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                agent agentSet = (agent)listViewAgent.SelectedItems[0].Tag;

                textBoxFirstName.Text = agentSet.FirstName;
                textBoxMiddleName.Text = agentSet.MiddleName;
                textBoxLastName.Text = agentSet.LastName;
                numericUpDownDealShare.Text = Convert.ToString(agentSet.DealShare);
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                numericUpDownDealShare.Text = "";
            }
        }
    }
}

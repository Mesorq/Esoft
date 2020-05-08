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
    public partial class FormDemand : Form
    {
        enum EstateType
        {
            apartment,
            home,
            earth
        }
        public FormDemand()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowDemand();
            ShowAgents();
            ShowClients();
        }

        private void FormDemand_Load(object sender, EventArgs e)
        {

        }
        void ShowAgents()
        {
            comboBoxAgent.Items.Clear();
            foreach (agent agentSet in Program.wftDb.agent)
            {
                string[] item = {
                    agentSet.Id.ToString() + ".",
                    agentSet.FirstName, agentSet.MiddleName,
                    agentSet.LastName
                };
                comboBoxAgent.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClients()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientsSet clientSet in Program.wftDb.ClientsSet)
            {
                string[] item = {
                    clientSet.Id.ToString() + ".",
                    clientSet.FirstName, clientSet.MiddleName,
                    clientSet.LastName
                };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxType.SelectedIndex == (int)EstateType.apartment)
            {
                listViewApartment.Visible = true;
                listViewHome.Visible = false;
                listViewEarth.Visible = false;

                numericUpDownMinRooms.Visible = true;
                numericUpDownMaxRooms.Visible = true;
                numericUpDownMinFloor.Visible = true;
                numericUpDownMaxFloor.Visible = true;

                numericUpDownMaxFloors.Visible = false;
                numericUpDownMinFloors.Visible = false;

                labelMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                labelMinFloor.Visible = true;
                labelMaxFloor.Visible = true;

                labelMaxFloors.Visible = false;
                labelMinFloors.Visible = false;
            }
            else if (comboBoxType.SelectedIndex == (int)EstateType.home)
            {
                listViewApartment.Visible = false;
                listViewHome.Visible = true;
                listViewEarth.Visible = false;

                numericUpDownMaxFloors.Visible = true;
                numericUpDownMinFloors.Visible = true;

                numericUpDownMinRooms.Visible = false;
                numericUpDownMaxRooms.Visible = false;
                numericUpDownMinFloor.Visible = false;
                numericUpDownMaxFloor.Visible = false;

                labelMaxFloors.Visible = true;
                labelMinFloors.Visible = true;

                labelMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                labelMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
            }
            else if (comboBoxType.SelectedIndex == (int)EstateType.earth)
            {
                listViewApartment.Visible = false;
                listViewHome.Visible = false;
                listViewEarth.Visible = true;

                numericUpDownMinRooms.Visible = false;
                numericUpDownMaxRooms.Visible = false;
                numericUpDownMinFloor.Visible = false;
                numericUpDownMaxFloor.Visible = false;
                numericUpDownMaxFloors.Visible = false;
                numericUpDownMinFloors.Visible = false;

                labelMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                labelMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                labelMaxFloors.Visible = false;
                labelMinFloors.Visible = false;
            }
            clearAllInput();
        }
        void clearAllInput()
        {
            numericUpDownMinArea.Text = "0";
            numericUpDownMaxArea.Text = "0";
            numericUpDownMinRooms.Text = "0";
            numericUpDownMaxRooms.Text = "0";
            numericUpDownMinFloor.Text = "0";
            numericUpDownMaxFloor.Text = "0";
            numericUpDownMinFloors.Text = "0";
            numericUpDownMaxFloors.Text = "0";
            numericUpDownMinPrice.Text = "0";
            numericUpDownMaxPrice.Text = "0";
        }
        void ShowDemand()
        {
            listViewApartment.Items.Clear();
            listViewHome.Items.Clear();
            listViewEarth.Items.Clear();
            foreach (DemandSet demandSet in Program.wftDb.DemandSet)
            {
                if (demandSet.Type == (int)EstateType.apartment)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         demandSet.Id.ToString(),
                         demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirstName+" "+demandSet.ClientsSet.MiddleName,
                         demandSet.agent.LastName+" "+ demandSet.agent.FirstName+" "+demandSet.agent.MiddleName,
                         demandSet.MinArea.ToString(),
                         demandSet.MaxArea.ToString(),
                         demandSet.MinRooms.ToString(),
                         demandSet.MaxRooms.ToString(),
                         demandSet.MinFloor.ToString(),
                         demandSet.MaxFloor.ToString(),
                         demandSet.MinPrice.ToString(),
                         demandSet.MaxPrice.ToString()
                    });
                    item.Tag = demandSet;
                    listViewApartment.Items.Add(item);
                }
                else if (demandSet.Type == (int)EstateType.home)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         demandSet.Id.ToString(),
                         demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirstName+" "+demandSet.ClientsSet.MiddleName,
                         demandSet.agent.LastName+" "+ demandSet.agent.FirstName+" "+demandSet.agent.MiddleName,
                         demandSet.MinArea.ToString(),
                         demandSet.MaxArea.ToString(),
                         demandSet.MinFloors.ToString(),
                         demandSet.MinFloors.ToString(),
                         demandSet.MinPrice.ToString(),
                         demandSet.MaxPrice.ToString()
                    });
                    item.Tag = demandSet;
                    listViewHome.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         demandSet.Id.ToString(),
                         demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirstName+" "+demandSet.ClientsSet.MiddleName,
                         demandSet.agent.LastName+" "+ demandSet.agent.FirstName+" "+demandSet.agent.MiddleName,
                         demandSet.MinArea.ToString(),
                         demandSet.MaxArea.ToString(),
                         demandSet.MinPrice.ToString(),
                         demandSet.MaxPrice.ToString()
                    });
                    item.Tag = demandSet;
                    listViewEarth.Items.Add(item);
                }
            }
            listViewApartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewHome.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewEarth.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DemandSet demandSet = new DemandSet();

            demandSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
            demandSet.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
            demandSet.MinArea = Convert.ToDouble(numericUpDownMinArea.Text);
            demandSet.MaxArea = Convert.ToDouble(numericUpDownMaxArea.Text);
            demandSet.MinPrice = Convert.ToInt32(numericUpDownMinPrice.Text);
            demandSet.MaxPrice = Convert.ToInt32(numericUpDownMaxPrice.Text);

            if (comboBoxType.SelectedIndex == (int)EstateType.apartment)
            {
                demandSet.Type = (int)EstateType.apartment;
                demandSet.MinFloor = Convert.ToInt32(numericUpDownMinFloor.Text);
                demandSet.MaxFloor = Convert.ToInt32(numericUpDownMaxFloor.Text);
                demandSet.MinRooms = Convert.ToInt32(numericUpDownMinRooms.Text);
                demandSet.MaxRooms = Convert.ToInt32(numericUpDownMaxRooms.Text);
            }
            else if (comboBoxType.SelectedIndex == (int)EstateType.home)
            {
                demandSet.Type = (int)EstateType.home;
                demandSet.MaxFloors = Convert.ToInt32(numericUpDownMaxFloors.Text);
                demandSet.MinFloors = Convert.ToInt32(numericUpDownMinFloors.Text);
            }
            else
            {
                demandSet.Type = (int)EstateType.earth;
            }
            Program.wftDb.DemandSet.Add(demandSet);
            Program.wftDb.SaveChanges();
            ShowDemand();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == (int)EstateType.apartment)
            {
                if (listViewApartment.SelectedItems.Count == 1)
                {
                    DemandSet demandSet = (DemandSet)listViewApartment.SelectedItems[0].Tag;
                    demandSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    demandSet.MinArea = Convert.ToDouble(numericUpDownMinArea.Text);
                    demandSet.MaxArea = Convert.ToDouble(numericUpDownMaxArea.Text);
                    demandSet.MinPrice = Convert.ToInt32(numericUpDownMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt32(numericUpDownMaxPrice.Text);
                    demandSet.Type = (int)EstateType.apartment;
                    demandSet.MinFloor = Convert.ToInt32(numericUpDownMinFloor.Text);
                    demandSet.MaxFloor = Convert.ToInt32(numericUpDownMaxFloor.Text);
                    demandSet.MinRooms = Convert.ToInt32(numericUpDownMinRooms.Text);
                    demandSet.MaxRooms = Convert.ToInt32(numericUpDownMaxRooms.Text);
                    Program.wftDb.SaveChanges();
                    ShowDemand();
                }
            }
            else if (comboBoxType.SelectedIndex == (int)EstateType.home)
            {
                if (listViewHome.SelectedItems.Count == 1)
                {
                    DemandSet demandSet = (DemandSet)listViewHome.SelectedItems[0].Tag;
                    demandSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    demandSet.MinArea = Convert.ToDouble(numericUpDownMinArea.Text);
                    demandSet.MaxArea = Convert.ToDouble(numericUpDownMaxArea.Text);
                    demandSet.MinPrice = Convert.ToInt32(numericUpDownMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt32(numericUpDownMaxPrice.Text);
                    demandSet.Type = (int)EstateType.home;
                    demandSet.MaxFloors = Convert.ToInt32(numericUpDownMaxFloors.Text);
                    demandSet.MinFloors = Convert.ToInt32(numericUpDownMinFloors.Text);
                    Program.wftDb.SaveChanges();
                    ShowDemand();
                }
            }
            else
            {
                if (listViewEarth.SelectedItems.Count == 1)
                {
                    DemandSet demandSet = (DemandSet)listViewEarth.SelectedItems[0].Tag;
                    demandSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    demandSet.MinArea = Convert.ToDouble(numericUpDownMinArea.Text);
                    demandSet.MaxArea = Convert.ToDouble(numericUpDownMaxArea.Text);
                    demandSet.MinPrice = Convert.ToInt32(numericUpDownMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt32(numericUpDownMaxPrice.Text);
                    demandSet.Type = (int)EstateType.earth;
                    Program.wftDb.SaveChanges();
                    ShowDemand();
                }
            }
        }

        private void listViewApartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewApartment.SelectedItems.Count == 1)
            {
                DemandSet demandSet = (DemandSet)listViewApartment.SelectedItems[0].Tag;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(demandSet.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(demandSet.IdClient.ToString());
                numericUpDownMinArea.Text = demandSet.MinArea.ToString();
                numericUpDownMaxArea.Text = demandSet.MaxArea.ToString();
                numericUpDownMinPrice.Text = demandSet.MinPrice.ToString();
                numericUpDownMaxPrice.Text = demandSet.MaxPrice.ToString();
                numericUpDownMinFloor.Text = demandSet.MinFloor.ToString();
                numericUpDownMaxFloor.Text = demandSet.MaxFloor.ToString();
                numericUpDownMinRooms.Text = demandSet.MinRooms.ToString();
                numericUpDownMaxRooms.Text = demandSet.MaxRooms.ToString();
            }
            else
            {
                clearAllInput();
            }
        }

        private void listViewHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHome.SelectedItems.Count == 1)
            {
                DemandSet demandSet = (DemandSet)listViewHome.SelectedItems[0].Tag;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(demandSet.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(demandSet.IdClient.ToString());
                numericUpDownMinArea.Text = demandSet.MinArea.ToString();
                numericUpDownMaxArea.Text = demandSet.MaxArea.ToString();
                numericUpDownMinPrice.Text = demandSet.MinPrice.ToString();
                numericUpDownMaxPrice.Text = demandSet.MaxPrice.ToString();
                numericUpDownMinFloors.Text = demandSet.MinFloors.ToString();
                numericUpDownMaxFloors.Text = demandSet.MaxFloors.ToString();
            }
            else
            {
                clearAllInput();
            }
        }

        private void listViewEarth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEarth.SelectedItems.Count == 1)
            {
                DemandSet demandSet = (DemandSet)listViewEarth.SelectedItems[0].Tag;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(demandSet.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(demandSet.IdClient.ToString());
                numericUpDownMinArea.Text = demandSet.MinArea.ToString();
                numericUpDownMaxArea.Text = demandSet.MaxArea.ToString();
                numericUpDownMinPrice.Text = demandSet.MinPrice.ToString();
                numericUpDownMaxPrice.Text = demandSet.MaxPrice.ToString();
            }
            else
            {
                clearAllInput();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == (int)EstateType.apartment)
                {
                    if (listViewApartment.SelectedItems.Count == 1)
                    {
                        DemandSet demandSet = (DemandSet)listViewApartment.SelectedItems[0].Tag;
                        Program.wftDb.DemandSet.Remove(demandSet);
                        Program.wftDb.SaveChanges();
                        ShowDemand();
                    }
                    clearAllInput();
                }
                else if (comboBoxType.SelectedIndex == (int)EstateType.home)
                {
                    if (listViewHome.SelectedItems.Count == 1)
                    {
                        DemandSet demandSet = (DemandSet)listViewHome.SelectedItems[0].Tag;
                        Program.wftDb.DemandSet.Remove(demandSet);
                        Program.wftDb.SaveChanges();
                        ShowDemand();
                    }
                    clearAllInput();
                }
                else
                {
                    if (listViewEarth.SelectedItems.Count == 1)
                    {
                        DemandSet demandSet = (DemandSet)listViewEarth.SelectedItems[0].Tag;
                        Program.wftDb.DemandSet.Remove(demandSet);
                        Program.wftDb.SaveChanges();
                        ShowDemand();
                    }
                    clearAllInput();
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

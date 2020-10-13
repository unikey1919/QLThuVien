using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.ADMIN
{
    public partial class frmAddGroup : Form
    {
        GROUP gr = new GROUP();
        public frmAddGroup()
        {
            InitializeComponent();
        }
            
            
       private void frmAddGroup_Load(object sender, EventArgs e)
        {
            LoadGroup();
            loadNewGroup();
        } 

        void LoadGroup()
        {
            GROUP group = new GROUP();
            cbGroup.DataSource = gr.GetListGroup();
            cbGroup.DisplayMember = "name";
            cbGroup.ValueMember = "groupid";
        }

        void loadNewGroup()
        {
            GROUP group = new GROUP();
            cbRemoveGroup.DataSource = group.GetListGroup();
            cbRemoveGroup.DisplayMember = "name";
            cbRemoveGroup.ValueMember = "groupid";

        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (txtGroupID.Text == "")
            {
                MessageBox.Show("ID can't blank", "Add contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtGroupName.Text == "")
            {
                MessageBox.Show("Please import group name", "Add contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GROUP gr = new GROUP();
                string name = txtGroupName.Text;
                string id = txtGroupID.Text;
                
                if (!gr.groupExist(name, "add", id))
                {
                    try
                    {
                        if (gr.insertGroup(id, name))
                        {
                            MessageBox.Show("New Group added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            LoadGroup();
                            loadNewGroup();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("Group name already exist", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditGroup_Click(object sender, EventArgs e)
        {
            if (txtGroupNewName.Text == "")
            {
                MessageBox.Show("Please import new group name", "Edit group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GROUP gr = new GROUP();
                try
                {
                    string name = txtGroupNewName.Text;
                    string id = cbGroup.SelectedValue.ToString();

                    if (!gr.groupExist(name, "edit", id))
                    {
                        if (gr.updateGroup(id, name))
                        {
                            MessageBox.Show("Group Edited", "Edit group", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadGroup();
                            loadNewGroup();
                        }
                        else
                            MessageBox.Show("Error", "Edit group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }


                catch
                {
                    MessageBox.Show("Group Exist", "Edit group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
        }

        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to delete this group ?", "delete group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                try
                {
                    string id = cbRemoveGroup.SelectedValue.ToString();

                    GROUP gr = new GROUP();
                    if (gr.deleteGroup(id))
                    {

                        MessageBox.Show("Group already removed", "Remove group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadNewGroup();
                    }
                    else
                        MessageBox.Show("Error", "Remove group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Group Not Exist", "Remove group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

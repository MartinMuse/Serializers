using System;
using System.Windows.Forms;
using Menu_Builder.Class_Managment;

namespace Menu_Builder
{
    public partial class MenuBuilder_form : Form
    {
        private Class_Managment.Class__Managment class_managment;
        public MenuBuilder_form()
        {
            InitializeComponent();
            class_managment = new Class__Managment();
            string[] buf = class_managment.GetClasses();
            ClassesCB.Items.Clear();
            for (int i = 0; i < buf.Length; i++)
            {
                ClassesCB.Items.Add(buf[i]);
            }
            for (int i = 0; i < buf.Length; i++)
            {
                SerializersCB.Items.Add(buf[i]);
            }
            ConfirmBtn.Enabled = false;
            PropsCB.Enabled = false;
            PropsTB.Enabled = false;
        }

        private void UpdateObjs()
        {
            ObjectsLB.Items.Clear();
            int buf = class_managment.GetEditObjNum();
            for (int i=0;i < class_managment.GetObjNum(); i++)
            {
                class_managment.SetActiveObj(i);
                ObjectsLB.Items.Add(class_managment.GetName());
            }
            if (class_managment.GetObjNum() > 0)
            {
                class_managment.SetActiveObj(buf);
                ObjectsLB.SelectedIndex = class_managment.GetEditObjNum();
            }
        }

        private void UpdateProps()
        {
            PropertiesLB.Items.Clear();
            ConfirmBtn.Enabled = false;
            if (ObjectsLB.SelectedIndex!=-1)
            {
                string[] obj_info = class_managment.GetObjPropsTxt();
                for (int i = 0; i < obj_info.Length; i++)
                    PropertiesLB.Items.Add(obj_info[i]);
                PropertiesLB.SelectedIndex = class_managment.GetEditPropNum();
                ConfirmBtn.Enabled = true;
                PropsTB.Enabled = true;
                PropsCB.Enabled = true;
            }
        }
        private void ClassesCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void ObjectsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            class_managment.SetActiveObj(ObjectsLB.SelectedIndex);
            UpdateProps();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (ClassesCB.Text == "")
            {
                MessageBox.Show("Please, choose a class", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                class_managment.CreateObject(ClassesCB.Text);
                class_managment.SetActiveLastObj();
                UpdateObjs();
                ObjectsLB.SelectedIndex = class_managment.GetEditObjNum();

            }
        }

        private void PropertiesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            class_managment.SetActiveProp(PropertiesLB.SelectedIndex);
            PropsCB.Visible = class_managment.IsPropClass();
            PropsTB.Visible = !class_managment.IsPropClass();
            PropsCB.Items.Clear();
            PropsTB.Clear();
            if (PropsCB.Enabled)
            {
                string[] buf = class_managment.GetChildObjectsTxt();
                for (int i = 0; i < buf.Length; i++)
                {
                    PropsCB.Items.Add(buf[i]);
                }
            }
        }

        private void PropsCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (PropsCB.Visible)
                class_managment.SetPropVal(PropsCB.Text, PropsCB.SelectedIndex);
            else
            {
                if (!class_managment.SetPropVal(PropsTB.Text, 0))
                {
                    MessageBox.Show("Wrong value!", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            UpdateObjs();
            UpdateProps();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
                if (ObjectsLB.SelectedIndex == -1)
                    MessageBox.Show("No objects selected!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    class_managment.DeleteObj();
                    UpdateObjs();
                }
            }

        private void MenuBuilder_form_Load(object sender, EventArgs e)
        {

        }

        private void LoadBT_Click(object sender, EventArgs e)
        {
            if (OpenFileD.ShowDialog() == DialogResult.Cancel)
                return;
            if (SerializersCB.Text == "")
            {
                MessageBox.Show("Choose serializer pls!", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            class_managment.Load(OpenFileD.FileName, SerializersCB.Text);
            UpdateObjs();
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            if (SaveFileD.ShowDialog() == DialogResult.Cancel)
                return;
            if (SerializersCB.Text == "" || ObjectsLB.Items.Count == 0)
            {
                MessageBox.Show("Choose serializer and create at least one object pls!", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            class_managment.Save(SaveFileD.FileName, SerializersCB.Text);
        }
    }
}

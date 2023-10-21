using ManagementInternet.Controller;
using ManagementInternet.Function;
using ManagementInternet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace ManagementInternet.View.Working.Management
{
    public partial class Service : Form
    {
        private TypeOfDishController typeOfDishController;
        private DishController dishController;
        private OpenFileDialog openFileDialog;
        private Helper helper;
        private string imagePath;
        private int index = -1;

        public Service()
        {
            this.typeOfDishController = new TypeOfDishController();
            this.dishController = new DishController();
            this.openFileDialog = new OpenFileDialog();
            this.openFileDialog.Filter = "Images|*.png;*.jpg;*.jpeg;*.bmp|All Files|*.*";
            this.helper = new Helper();

            InitializeComponent();
        }

        private void cbTypeAdding_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbTypeDeleting_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbServiceName_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void fillTypeOfDishIntoCbox_Add()
        {
            List<TypeOfDish> list = this.typeOfDishController.getAll();
            list.Insert(0, new TypeOfDish());

            this.cbTypeAdding.DataSource = list;
            this.cbTypeAdding.DisplayMember = "Name";
            this.cbTypeAdding.ValueMember = "Name";
        }

        private void fillTypeOfDishIntoCbox_Delete()
        {
            List<TypeOfDish> list = this.typeOfDishController.getAll();
            list.Insert(0, new TypeOfDish());

            this.cbTypeDeleting.DataSource = list;
            this.cbTypeDeleting.DisplayMember = "Name";
            this.cbTypeDeleting.ValueMember = "Name";
        }

        private void fillTypeOfDishIntoCbox_Management()
        {
            List<TypeOfDish> list = this.typeOfDishController.getAll();
            list.Insert(0, new TypeOfDish());

            this.cbTypeAdding.DataSource = list;
            this.cbTypeAdding.DisplayMember = "Name";
            this.cbTypeAdding.ValueMember = "Name";
        }

        private void fillServiceNameIntoCbox_Delete()
        {
            List<Dish> dishes = this.dishController.getAll();
            dishes.Insert(0, new Dish());

            this.cbServiceName.DataSource = dishes;
            this.cbServiceName.DisplayMember = "Name";
            this.cbServiceName.ValueMember = "Name";
        }

        private void fillTypeOfServiceIntoCBox_Management()
        {
            List<TypeOfDish> typeOfDishes = this.typeOfDishController.getAll();
            typeOfDishes.Insert(0, new TypeOfDish());

            this.cBTypeOfService.DataSource = typeOfDishes;
            this.cBTypeOfService.DisplayMember = "Name";
            this.cBTypeOfService.ValueMember = "Name";
        }

        private void getAllDishesIntoDgv()
        {
            this.dataGridViewService.Rows.Clear();

            List<Dish> dishes = this.dishController.getAll();

            foreach (Dish dish in dishes)
            {
                int index = this.dataGridViewService.Rows.Add();

                this.dataGridViewService.Rows[index].Cells[0].Value = dish.Name;
                this.dataGridViewService.Rows[index].Cells[1].Value = dish.Type;
                this.dataGridViewService.Rows[index].Cells[2].Value = dish.Price.ToString() + ".000";

                string status = "Đang phục vụ";

                if (dish.State == false)
                {
                    status = "Không phục vụ";
                }

                this.dataGridViewService.Rows[index].Cells[3].Value = status;
            }
        }

        private void Service_Load(object sender, EventArgs e)
        {
            fillTypeOfDishIntoCbox_Add();
            fillTypeOfDishIntoCbox_Delete();
            fillTypeOfDishIntoCbox_Management();
            fillServiceNameIntoCbox_Delete();
            fillTypeOfServiceIntoCBox_Management();
            getAllDishesIntoDgv();
        }

        private bool checkEmptyFiels()
        {
            this.error.Clear();

            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                this.error.SetError(this.txtName, "*");
                return false;
            }

            if (string.IsNullOrEmpty(this.txtPrice.Text))
            {
                this.error.SetError(this.txtPrice, "*");
                return false;
            }

            if (string.IsNullOrEmpty(this.imagePath))
            {
                MessageBox.Show("Bạn chưa thêm hình ảnh");
                return false;
            }

            return true;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.imagePath = openFileDialog.FileName;
                    this.pictureBox.Image = Image.FromFile(this.imagePath);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void setDefaultFields()
        {
            this.txtName.Text = string.Empty;
            this.cbTypeAdding.SelectedIndex = 0;
            this.txtPrice.Text = string.Empty;
            this.pictureBox.Image = null;
        }

        private void addDish()
        {
            try
            {
                Dish dish = new Dish();

                string name = this.txtName.Text;
                string nameLowwerCase = name.ToLower();
                string type = this.cbTypeAdding.SelectedValue.ToString();

                dish.Name = nameLowwerCase;
                dish.Type = type;
                dish.State = true;

                MessageBox.Show(type);

                short price = short.Parse(this.txtPrice.Text);

                dish.Price = price;

                if (!string.IsNullOrEmpty(this.imagePath))
                {
                    byte[] imageData = helper.readFile(this.imagePath);

                    dish.Image = imageData;

                    this.imagePath = string.Empty;
                }

                this.dishController.modify(dish);

                Service_Load(null, null);

                setDefaultFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (!checkEmptyFiels())
            {
                return;
            }

            addDish();
        }

        private void addTypeName()
        {
            try
            {
                TypeOfDish typeOfDish = new TypeOfDish();

                string typeName = this.txtTypeName.Text;

                string typeNameLowwerCase = typeName.ToLower();

                typeOfDish.Name = typeNameLowwerCase;

                this.typeOfDishController.add(typeOfDish);

                Service_Load(null, null);
            }
            catch
            {
                MessageBox.Show("Trùng tên");
            }
        }

        private void btnAddTypeService_Click(object sender, EventArgs e)
        {
            this.error.Clear();

            if (string.IsNullOrEmpty(this.txtTypeName.Text))
            {
                this.error.SetError(this.txtTypeName, "*");
                return;
            }

            addTypeName();

            this.txtTypeName.Text = string.Empty;
        }

        private void deleteTypeName()
        {
            try
            {
                string typeName = this.cbTypeDeleting.SelectedValue.ToString();

                this.typeOfDishController.delete(typeName);
            }
            catch
            {
                MessageBox.Show("Loại dịch vụ này không xóa được");
            }
        }

        private void cbTypeDeleting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbTypeDeleting.SelectedIndex != 0)
            {
                this.btnDeleteTypeOfService.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteTypeName();

            this.cbTypeDeleting.SelectedIndex = 0;
            this.btnDeleteTypeOfService.Enabled = false;

            Service_Load(sender, e);
        }

        private void btnCanelAddingTypeOfService_Click(object sender, EventArgs e)
        {
            this.txtTypeName.Text = string.Empty;
        }

        private void btnCancelDeletingTypeOfService_Click(object sender, EventArgs e)
        {
            this.cbTypeDeleting.SelectedIndex = 0;
            this.btnDeleteTypeOfService.Enabled = false;
        }

        private void cbServiceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbServiceName.SelectedIndex != 0)
            {
                this.btnDeleteService.Enabled = true;
            }
        }

        private void deleteService()
        {
            string serviceName = this.cbServiceName.SelectedValue.ToString();

            this.dishController.delete(serviceName);
            this.btnDeleteService.Enabled = false;
            this.cbServiceName.SelectedIndex = 0;
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            deleteService();
        }

        private void btnCancelDeletingService_Click(object sender, EventArgs e)
        {
            this.cbServiceName.SelectedIndex = 0;
            this.btnDeleteService.Enabled = false;
        }

        private void dataGridViewService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.index = e.RowIndex;
                this.btnDeleteM.Enabled = true;

                string nameService = this.dataGridViewService.Rows[this.index].Cells[0].Value.ToString();

                Dish dish = this.dishController.getByName(nameService);

                if (dish.State == true)
                {
                    this.btnCancelServiceM.Enabled = true;
                }
                else
                {
                    this.btnRecancelServiceM.Enabled = true;
                }

                this.txtNameM.Text = dish.Name;
                this.txtTypeNameM.Text = dish.Type.ToString();
                this.txtPriceM.Text = dish.Price.ToString();

                byte[] imageData = (byte[])dish.Image;

                MemoryStream ms = new MemoryStream(imageData);

                this.pBM.Image = Image.FromStream(ms);
            }
            catch
            {
                MessageBox.Show("Bạn đã nhấn vào ô không hợp lệ");
            }
        }

        private void setDefaultFieldsM()
        {
            this.txtNameM.Text = string.Empty;
            this.txtTypeNameM.Text = string.Empty;
            this.txtPriceM.Text = string.Empty;
            this.pBM.Image = null;
        }

        private void delete()
        {
            string serviceName = this.txtNameM.Text;

            this.dishController.delete(serviceName);
            this.btnDeleteM.Enabled = false;

            setDefaultFieldsM();
            Service_Load(null, null);
        }

        private void btnDeleteM_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnCancelM_Click(object sender, EventArgs e)
        {
            this.btnDeleteM.Enabled = false;

            setDefaultFieldsM();
        }

        private void cancelOrNot(bool state)
        {
            string serviceName = this.txtNameM.Text;

            Dish dish = this.dishController.getByName(serviceName);

            dish.State = state;

            this.dishController.modify(dish);
            this.btnCancelServiceM.Enabled = false;

            setDefaultFieldsM();
            Service_Load(null, null);
        }

        private void btnCancelService_Click(object sender, EventArgs e)
        {
            cancelOrNot(false);
        }

        private void btnRecancelServiceM_Click(object sender, EventArgs e)
        {
            cancelOrNot(true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cBTypeOfService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cBTypeOfService.SelectedIndex != 0) {
                this.dataGridViewService.Rows.Clear();

                string typeOfService = this.cBTypeOfService.SelectedValue.ToString();

                List<Dish> dishes = this.dishController.getAllByTypeOfService(typeOfService);

                foreach (Dish dish in dishes)
                {
                    int index = this.dataGridViewService.Rows.Add();

                    this.dataGridViewService.Rows[index].Cells[0].Value = dish.Name;
                    this.dataGridViewService.Rows[index].Cells[1].Value = dish.Type;
                    this.dataGridViewService.Rows[index].Cells[2].Value = dish.Price.ToString() + ".000";

                    string status = "Đang phục vụ";

                    if (dish.State == false)
                    {
                        status = "Không phục vụ";
                    }

                    this.dataGridViewService.Rows[index].Cells[3].Value = status;
                }
            }
        }
    }
}

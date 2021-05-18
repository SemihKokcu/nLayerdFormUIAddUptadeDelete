using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.Nhibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }
            private IProductService _productService;
        private ICategoryService _categoryService;
    
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategoies();
        }

        private void LoadCategoies()
        {
            // birinci için doldurma
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
            // ikinci için doldurma
            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";
            //
            cbxUptadeCategoryId.DataSource = _categoryService.GetAll();
            cbxUptadeCategoryId.DisplayMember = "CategoryName";
            cbxUptadeCategoryId.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch 
            {

               
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);

            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = tbxProductName2.Text,
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStock.Text)



                });
                MessageBox.Show("Ürün Kaydedildi");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cbxUptadeCategoryId.SelectedValue),
                ProductName = tbxUptadeProductName.Text,
                QuantityPerUnit = tbxUptadeQuantityPerUnit.Text,
                UnitPrice = Convert.ToDecimal(tbxUptadeUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(tbxUptadeStock.Text)

            }) ;
            MessageBox.Show("Ürün Güncellendi");
            LoadProducts();
        }
        // gridden seçince gelecekler abone olduk
        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // kısaltma amaçlı
            var row = dgwProduct.CurrentRow;
            cbxUptadeCategoryId.SelectedValue = row.Cells[1].Value;
            tbxUptadeProductName.Text = row.Cells[2].Value.ToString();
            tbxUptadeUnitPrice.Text = row.Cells[3].Value.ToString();
            tbxUptadeQuantityPerUnit.Text = row.Cells[4].Value.ToString();
            tbxUptadeStock.Text = row.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    { // mesajı değiştirmedeki amaç güvenlik amaçlı
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün Silindi");
                    LoadProducts();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
                
            }
        }
    }
}

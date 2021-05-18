using Northwind.Business.Abstract;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using FluentValidation;
using System.Threading.Tasks;
using ValidationException = FluentValidation.ValidationException;
using Northwind.Business.Utilities;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        { // doğrulam
            ValidationTool.Validate(new ProductValidator(), product);
            
            _productDal.Add(product);
        }
        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Uptade(product);
        }
        public void Delete(Product product)
        {// mnormal de freamwork business da olmaz , bağılmılık söz konusudur , ama burada 
            //denemek için baktık
            try
            {
                _productDal.Delete(product);
            }
            catch //(DbUpdateException exception)
            {
                throw new Exception("Silinme gerçekleşemedi");
                
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

       
    }
}

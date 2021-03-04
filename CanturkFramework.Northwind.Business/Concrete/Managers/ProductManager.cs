using Canturk.Framework.Nothwind.DataAccess.Abstract;
using CanturkFramework.Core.CrossCuttingConcerns.Validation.FluentValidation;
using CanturkFramework.Northwind.Business.Abstract;
using CanturkFramework.Northwind.Business.ValidationRules.FluentValidation;
using CanturkFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CanturkFramework.Core.Aspects.Postsharp.ValidationAspects;
using CanturkFramework.Core.DataAccess;
using System.Transactions;
using AutoMapper;
using CanturkFramework.Core.Aspects.Postsharp.AuthorizationAspects;
using CanturkFramework.Core.Aspects.Postsharp.TransactionAspects;
using CanturkFramework.Core.CrossCuttingConcerns.Caching.Microsoft;
using CanturkFramework.Core.Aspects.Postsharp.CacheAspects;
using CanturkFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using CanturkFramework.Core.Aspects.Postsharp.LogAspects;
using CanturkFramework.Core.Aspects.Postsharp.PerformanceAspects;
using CanturkFramework.Core.Utilities.Mappings;
using PostSharp.Aspects.Dependencies;

namespace CanturkFramework.Northwind.Business.Concrete.Managers
{
   
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        private IMapper _mapper;
        private readonly IQueryableRepository<Product> _queryable;

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Add(Product product)
        {
            
           return  _productDal.Add(product);
        }
        [PerformanceCounterAspect(2)]
        [CacheAspect(typeof(MemoryCacheManager))]
        /*[LogAspect(typeof(DatabaseLogger))]*/   //default 60 dk tutar CacheAspect'ten kontrol edilebilir.
        //[SecuredOperation(Roles="Admin,Editor")]
        public List<Product> GetAll()
        {
            //Thread.Sleep(2000); PerformanceCounterAspect test için yazıldı. Outputdan kontrol edilebilir.

            var products = _mapper.Map<List<Product>>(_productDal.GetList());
            //var products = AutoMapperHelper.MapToSameTypeList(_productDal.GetList());
            return products;
        }


        public Product GetById(int id)
        {
           
            return _productDal.Get(p => p.ProductId == id);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Update(Product product)
        {
          return  _productDal.Update(product);
        }

        [TransactionScopeAspect]
        [FluentValidationAspect(typeof(ProductValidator) )]
        public void TransactionalOperation(Product product1, Product product2)
        {
            //using (TransactionScope scope = new TransactionScope())
            //{
               

            //}
            _productDal.Add(product1);

            //Business Codes

            _productDal.Add(product2);



        }
    }
}

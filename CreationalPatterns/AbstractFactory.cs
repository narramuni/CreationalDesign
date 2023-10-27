using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    internal class AbstractFactory
    {
        public abstract class AbstractProductCategoryBeverages
        {
            public abstract void ShowProducts();
        }

        public class Product_Tea : AbstractProductCategoryBeverages

        {
            public override void ShowProducts()
            {
                throw new NotImplementedException();
            }
        }

        public class Product_coffee : AbstractProductCategoryBeverages
        {
            public override void ShowProducts()
            {
                throw new NotImplementedException();
            }
        }

        public abstract class AbstractProductCategorySnacks
        {

        }

        public class Product_Maggi : AbstractProductCategorySnacks
        {

        }
        public class Product_Pasta : AbstractProductCategorySnacks
        {

        }

        public abstract class AbstractFactory1
        {
            public abstract AbstractProductCategoryBeverages CreateProductA1();
            public abstract AbstractProductCategorySnacks CreateProductB1();

        }

        public class client
        {
            private AbstractProductCategoryBeverages _product1_Tea;
            private AbstractProductCategoryBeverages _product1_Coffee;

            private AbstractProductCategorySnacks _product2_Maggi;
            private AbstractProductCategorySnacks _product2_Pasta;

            public void Client(AbstractFactory1 factory1)
            {
                _product1_Tea = factory1.CreateProductA1();
                _product1_Coffee = factory1.CreateProductA1();
                _product2_Maggi = factory1.CreateProductB1();
                _product2_Pasta = factory1.CreateProductB1();

            }


        }

        public class ConcreateFactoryA1 : AbstractFactory1
        {
            public override AbstractProductCategoryBeverages CreateProductA1()
            {
                throw new NotImplementedException();
            }

            public override AbstractProductCategorySnacks CreateProductB1()
            {
                throw new NotImplementedException();
            }
        }
        public class ConcreateFactoryB1 : AbstractFactory1
        {
            public override AbstractProductCategoryBeverages CreateProductA1()
            {
                throw new NotImplementedException();
            }

            public override AbstractProductCategorySnacks CreateProductB1()
            {
                throw new NotImplementedException();
            }
        }
    }
}

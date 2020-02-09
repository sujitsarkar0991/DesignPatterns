using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp
{
    interface Product
    {
        void Show();
    }
    class ProductA : Product
    {
        public void Show()
        {
            Console.WriteLine("Product A Created");
        }
    }
    class ProductB : Product
    {
        public void Show()
        {
            Console.WriteLine("Product B Created");
        }
    }

    class ProductC : Product
    {
        public void Show()
        {
            Console.WriteLine("Product C Created");
        }
    }
    class Factory
    {
        private static  Product p;
        public static Product GetProduct(int productType)
        {
            switch (productType)
            {
                case 1:
                    p = new ProductA();
                    break;
                case 2:
                    p = new ProductB();
                    break;
                case 3:
                    p = new ProductC();
                    break;
                default:
                    p = null;
                    break;
            }

            return p;
        }
    }
}

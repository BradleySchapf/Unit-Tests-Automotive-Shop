using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schapf.Bradley.Business.Testing
{
    [TestClass]
    public class CarWashInvoiceTesting
    {
        [TestMethod]
        public void Constructor1_ProvincialSalesTax_Initalize()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);

            //verify
            decimal expected = 0.15M; 
            decimal actual = carWashInvoice1.ProvincialSalesTax;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeProvincialSalesTax_Exception()
        {
            //setup
            decimal provincialSalesTax = -0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_ProvincialSalesTaxGreaterThanOne_Exception()
        {
            //setup
            decimal provincialSalesTax = 1.15M;
            decimal goodsAndServicesTaxRate = 0.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);
        }

        [TestMethod]
        public void Constructor1_GoodsAndServicesTaxRate_Initalize()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);

            //verify
            decimal expected = 0.15M; 
            decimal actual = carWashInvoice1.GoodsAndServicesTaxRate;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeGoodsAndServicesTaxRate_Exception()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = -0.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_GoodsAndServicesTaxRateGreaterThanOne_Exception()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 1.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);
        }

        [TestMethod]
        public void Constructor1_FragranceCost_Initalize()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);

            //verify
            decimal expected = 0; 
            decimal actual = carWashInvoice1.FragranceCost;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor1_PackageCost_Initalize()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);

            //verify
            decimal expected = 0; 
            decimal actual = carWashInvoice1.PackageCost;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor1_PackageCost_StateUpdated()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);
            carWashInvoice1.PackageCost = 1500;

            //verify
            decimal expected = 1500;
            decimal actual = carWashInvoice1.PackageCost;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_SetNegativePackageCost_Exception()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);
            carWashInvoice1.PackageCost = -1500;
        }

        [TestMethod]
        public void Constructor1_FragranceCost_StateUpdated()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);
            carWashInvoice1.FragranceCost = 1500;

            //verify
            decimal expected = 1500;
            decimal actual = carWashInvoice1.FragranceCost;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_SetNegativeFragranceCost_Exception()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);
            carWashInvoice1.FragranceCost = -1500;
        }

        [TestMethod]
        public void Constructor1_ProvincialSalesTaxCharged_ReturnState()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);

            //verify
            decimal expected = 0;
            decimal actual = carWashInvoice1.ProvincialSalesTaxCharged;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor1_SubTotal_ReturnState()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);

            //verify
            decimal expected = 0;
            decimal actual = carWashInvoice1.SubTotal;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor1_GoodsAndServicesTaxCharged_ReturnState()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate);

            //verify
            decimal expected = 0;
            decimal actual = carWashInvoice1.GoodsAndServicesTaxCharged;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        //Constructor 2 
        [TestMethod]
        public void Constructor2_ProvincialSalesTax_Initalize()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //verify
            decimal expected = 0.15M;
            decimal actual = carWashInvoice1.ProvincialSalesTax;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_NegativeProvincialSalesTax_Exception()
        {
            //setup
            decimal provincialSalesTax = -0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_ProvincialSalesTaxGreaterThanOne_Exception()
        {
            //setup
            decimal provincialSalesTax = 1.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);
        }

        [TestMethod]
        public void Constructor2_GoodsAndServicesTaxRate_Initalize()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //verify
            decimal expected = 0.15M;
            decimal actual = carWashInvoice1.GoodsAndServicesTaxRate;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_NegativeGoodsAndServicesTaxRate_Exception()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = -0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_GoodsAndServicesTaxRateGreaterThanOne_Exception()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 1.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);
        }

        [TestMethod]
        public void Constructor2_PackageCost_Initalize()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //verify
            decimal expected = 100M;
            decimal actual = carWashInvoice1.PackageCost;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_NegativePackageCost_Exception()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = -100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);
        }

        [TestMethod]
        public void Constructor2_FragranceCost_Initalize()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //verify
            decimal expected = 200M;
            decimal actual = carWashInvoice1.FragranceCost;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_NegativeFragranceCost_Exception()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = -200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);
        }

        [TestMethod]
        public void Constructor2_PackageCost_StateUpdated()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);
            carWashInvoice1.PackageCost = 200;

            //verify
            decimal expected = 200M;
            decimal actual = carWashInvoice1.PackageCost;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_SetNegativePackageCost_Exception()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);
            carWashInvoice1.PackageCost = -200;
        }

        [TestMethod]
        public void Constructor2_FragranceCost_StateUpdated()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);
            carWashInvoice1.FragranceCost = 100;

            //verify
            decimal expected = 100M;
            decimal actual = carWashInvoice1.FragranceCost;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_SetNegativeFragranceCost_Exception()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);
            carWashInvoice1.FragranceCost = -200;
        }

        [TestMethod]
        public void Constructor2_ProvincialSalesTaxCharged_ReturnState()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //verify
            decimal expected = 0;
            decimal actual = carWashInvoice1.ProvincialSalesTaxCharged;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor2_SubTotal_ReturnState()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //verify
            decimal expected = 300;
            decimal actual = carWashInvoice1.SubTotal;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor2_GoodsAndServicesTaxCharged_ReturnState()
        {
            //setup
            decimal provincialSalesTax = 0.15M;
            decimal goodsAndServicesTaxRate = 0.15M;
            decimal packageCost = 100;
            decimal fragranceCost = 200;

            //Invoke
            CarWashInvoice carWashInvoice1 = new CarWashInvoice(provincialSalesTax, goodsAndServicesTaxRate, packageCost, fragranceCost);

            //verify
            decimal expected = 45;
            decimal actual = carWashInvoice1.GoodsAndServicesTaxCharged;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Schapf.Bradley.Business;
using System.ComponentModel;

namespace Schapf.Bradley.Business.Testing
{
    [TestClass]
    public class SalesQuoteTesting
    {
        [TestMethod]
        public void Constructor1_vehicleSalePrice_Initalize()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //verify
            decimal expected = 1000;
            decimal actual = salesQuote1.VehicleSalePrice;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor1_tradeInAmount_Initalize()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //verify
            decimal expected = 500;
            decimal actual = salesQuote1.TradeInAmount;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeVehicleSalePrice_Exception()
        {
            //setup
            decimal vehicleSalePrice = -1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeTradeInAmount_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = -500;
            decimal salesTaxRate = 0.15M;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeSalesTaxRate_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = -0.15M;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_GreaterThanOneVehicleSalePrice_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 1.15M;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
        }

        [TestMethod]
        public void Constructor1_VehicleSalePrice_StateUpdated()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //invoke
            salesQuote1.VehicleSalePrice = 5000;

            //verify
            decimal expected = 5000;
            decimal actual = salesQuote1.VehicleSalePrice;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_SetNegativeVehicleSalePrice_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //invoke
            salesQuote1.VehicleSalePrice = -5000;
        }

        [TestMethod]
        public void Constructor1_TradeInAmount_StateUpdated()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //invoke
            salesQuote1.TradeInAmount = 5000;

            //verify
            decimal expected = 5000;
            decimal actual = salesQuote1.TradeInAmount;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_SetNegativeTradeInAmount_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //invoke
            salesQuote1.TradeInAmount = -5000;
        }

        [TestMethod]
        public void Constructor1_AccessoriesChosen_StateUpdated()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //invoke
            salesQuote1.AccesoriesChosen = Accessories.StereoAndNavigation;

            //verify
            Accessories expected = Accessories.StereoAndNavigation;
            Accessories actual = salesQuote1.AccesoriesChosen;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void Constructor1_InvalidAccessoriesChosen_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //invoke
            salesQuote1.AccesoriesChosen = (Accessories)99;
        }

        [TestMethod]
        public void Constructor1_ExteriorFinishChosen_StateUpdated()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //invoke
            salesQuote1.ExteriorFinishChosen = ExteriorFinish.Standard;

            //verify
            ExteriorFinish expected = ExteriorFinish.Standard;
            ExteriorFinish actual = salesQuote1.ExteriorFinishChosen;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void Constructor1_InvalidExteriorFinishChosen_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //invoke
            salesQuote1.ExteriorFinishChosen = (ExteriorFinish)99;
        }

        [TestMethod]
        public void Constructor1_AccessoryCostNone_StateUpdated()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            //invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //verify
            decimal expected = 0;
            decimal actual = salesQuote1.AccessoryCost;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor1_FinishCostNone_StateUpdated()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            //invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //verify
            decimal expected = 0M;
            decimal actual = salesQuote1.FinishCost;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor1_TotalOptions_ReturnState()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            //invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            salesQuote1.AccesoriesChosen = Accessories.StereoSystem;
            salesQuote1.ExteriorFinishChosen = ExteriorFinish.Standard;

            //verify
            decimal expected = 707.07M;
            decimal actual = salesQuote1.TotalOptions;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor1_SubTotal_ReturnState()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            //invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            salesQuote1.AccesoriesChosen = Accessories.StereoSystem;
            salesQuote1.ExteriorFinishChosen = ExteriorFinish.Standard;

            //verify
            decimal expected = 1707.07M;
            decimal actual = salesQuote1.SubTotal;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor1_SalesTax_ReturnState()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            //invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            salesQuote1.AccesoriesChosen = Accessories.StereoSystem;
            salesQuote1.ExteriorFinishChosen = ExteriorFinish.Standard;

            //verify
            decimal expected = 256.0605M;
            decimal actual = salesQuote1.SalesTax;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor1_Total_ReturnState()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            //invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            salesQuote1.AccesoriesChosen = Accessories.StereoSystem;
            salesQuote1.ExteriorFinishChosen = ExteriorFinish.Standard;

            //verify
            decimal expected = 1963.1305M;
            decimal actual = salesQuote1.Total;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor1_AmountDue_ReturnState()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;

            //invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            salesQuote1.AccesoriesChosen = Accessories.StereoSystem;
            salesQuote1.ExteriorFinishChosen = ExteriorFinish.Standard;

            //verify
            decimal expected = 1463.1305M;
            decimal actual = salesQuote1.AmountDue;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected: {0}/nActual: {1}", expected, actual);
        }


        //Constructor 2

        [TestMethod]
        public void Constructor2_vehicleSalePrice_Initalize()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            //verify
            decimal expected = 1000;
            decimal actual = salesQuote1.VehicleSalePrice;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor2_tradeInAmount_Initalize()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            //verify
            decimal expected = 500;
            decimal actual = salesQuote1.TradeInAmount;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor2_accessoriesChosen_Initalize()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            //verify
            Accessories expected = Accessories.All;
            Accessories actual = salesQuote1.AccesoriesChosen;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor2_exteriorFinishChosen_Initalize()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            //verify
            ExteriorFinish expected = ExteriorFinish.Pearlized;
            ExteriorFinish actual = salesQuote1.ExteriorFinishChosen;

            Assert.AreEqual(expected, actual);

            Console.WriteLine("Expected: {0},/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_NegativeVehicleSalePrice_Exception()
        {
            //setup
            decimal vehicleSalePrice = -1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_NegativeTradeInAmount_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = -500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_NegativeSalesTaxRate_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = -0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_GreaterThanOneSalesTaxRate_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 1.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void Constructor2_InvalidAccessoriesChosen_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = (Accessories)99;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void Constructor2_InvalidExteriorFinishChosen_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = (ExteriorFinish)99;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        [TestMethod]
        public void Constructor2_VehicleSalePrice_StateUpdated()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            salesQuote1.VehicleSalePrice = 5000;

            //verify
            decimal expected = 5000;
            decimal actual = salesQuote1.VehicleSalePrice; 

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_SetNegativeVehicleSalePrice_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            salesQuote1.VehicleSalePrice = -1000;

            //verify
            decimal expected = -1000;
            decimal actual = salesQuote1.VehicleSalePrice;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor2_TradeInAmount_StateUpdated()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            salesQuote1.TradeInAmount = 5000;

            //verify
            decimal expected = 5000;
            decimal actual = salesQuote1.TradeInAmount;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor2_SetNegativeTradeInAmount_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            salesQuote1.TradeInAmount = -1000;

            //verify
            decimal expected = -1000;
            decimal actual = salesQuote1.TradeInAmount;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor2_AccessoriesChosen_StateUpdated()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            salesQuote1.AccesoriesChosen = Accessories.ComputerNavigation;

            //verify
            Accessories expected = Accessories.ComputerNavigation;
            Accessories actual = salesQuote1.AccesoriesChosen;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void Constructor2_SetInvalidAccessoriesChosen_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            salesQuote1.AccesoriesChosen = (Accessories)99;
        }

        [TestMethod]
        public void Constructor2_ExteriorFinishChosen_StateUpdated()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            salesQuote1.ExteriorFinishChosen = ExteriorFinish.None;

            //verify
            ExteriorFinish expected = ExteriorFinish.None;
            ExteriorFinish actual = salesQuote1.ExteriorFinishChosen;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void Constructor2_SetInvalidExteriorFinishChosen_Exception()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            salesQuote1.ExteriorFinishChosen = (ExteriorFinish)99;
        }

        [TestMethod]
        public void Constructor2_AccessoryCost_ReturnState()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            //verify
            decimal expected = 3030.3M;
            decimal actual = salesQuote1.AccessoryCost;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }
        [TestMethod]
        public void Constructor2_FinishCost_ReturnState()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            //verify
            decimal expected = 404.04M;
            decimal actual = salesQuote1.FinishCost;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor2_TotalOptions_ReturnState()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            //verify
            decimal expected = 3434.34M;
            decimal actual = salesQuote1.TotalOptions;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor2_SubTotal_ReturnState()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            //verify
            decimal expected = 4434.34M;
            decimal actual = salesQuote1.SubTotal;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor2_SalesTax_ReturnState()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            //verify
            decimal expected = 665.151M;
            decimal actual = salesQuote1.SalesTax;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor2_Total_ReturnState()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            //verify
            decimal expected = 5099.491M;
            decimal actual = salesQuote1.Total;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void Constructor2_AmountDue_ReturnState()
        {
            //setup
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 500;
            decimal salesTaxRate = 0.15M;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoke
            SalesQuote salesQuote1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            //verify
            decimal expected = 4599.491M;
            decimal actual = salesQuote1.AmountDue;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schapf.Bradley.Business.Testing
{
    [TestClass]
    public class FinancialTesting
    {

        [TestMethod]
        public void GetPayment_RateGreaterThanZero_ReturnState()
        {
            //setup
            decimal rate = 0.15M;
            int numberOfPaymentPeriods = 5;
            decimal presentValue = 100;

            //invoke
            decimal financialTest = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);

            //verify
            decimal expected = 29.83M;
            decimal actual = financialTest;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        public void GetPayment_RateZero_ReturnState()
        {
            //setup
            decimal rate = 0;
            int numberOfPaymentPeriods = 5;
            decimal presentValue = 100;

            //invoke
            decimal financialTest = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);

            //verify
            decimal expected = 20;
            decimal actual = financialTest;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("Expected: {0}/nActual: {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_NegativeRate_Exception()
        {
            //setup
            decimal rate = -0.15M;
            int numberOfPaymentPeriods = 5;
            decimal presentValue = 100;

            //invoke
            decimal financialTest = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_RateGreaterThanOne_Exception()
        {
            //setup
            decimal rate = 1.15M;
            int numberOfPaymentPeriods = 5;
            decimal presentValue = 100;

            //invoke
            decimal financialTest = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_NumberOfPaymentsZero_Exception()
        {
            //setup
            decimal rate = 0.15M;
            int numberOfPaymentPeriods = 0;
            decimal presentValue = 100;

            //invoke
            decimal financialTest = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_NegativeNumberOfPayments_Exception()
        {
            //setup
            decimal rate = 0.15M;
            int numberOfPaymentPeriods = -1;
            decimal presentValue = 100;

            //invoke
            decimal financialTest = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_PresentValueZero_Exception()
        {
            //setup
            decimal rate = 0.15M;
            int numberOfPaymentPeriods = 1;
            decimal presentValue = 0;

            //invoke
            decimal financialTest = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_NegativePresentValue_Exception()
        {
            //setup
            decimal rate = 0.15M;
            int numberOfPaymentPeriods = 1;
            decimal presentValue = -100;

            //invoke
            decimal financialTest = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }
    }
}

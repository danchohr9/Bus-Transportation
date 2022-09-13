using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusTransportationTest
{
    [TestClass]
    public class UnitTest1
    {
        //Bus Testing
        [TestMethod]
        public void Test_IfBusDoesntExist()
        {
            BusTransportation.BusForm form = new BusTransportation.BusForm();

            string plate = "CC9696CA";
            bool actual = form.checkIfBusDoesntExists(plate);
            Assert.AreEqual(false, actual);

            plate = "asdasdasdas";
            actual = form.checkIfBusDoesntExists(plate);
            Assert.AreEqual(true, actual);
        }

        //Edit Ticket Testing
        [TestMethod]
        public void Test_getIdByUsername()
        {
            BusTransportation.EditTicket form = new BusTransportation.EditTicket();

            string user = "a";
            string actual = form.getIdByUsername(user);
            Assert.AreEqual("13", actual);
        }

        [TestMethod]
        public void Test_getUser()
        {
            BusTransportation.EditTicket form = new BusTransportation.EditTicket();

            string userId = "13";
            string actual = form.getUser(userId);
            Assert.AreEqual("13: a", actual);
        }

        [TestMethod]
        public void Test_getTransport()
        {
            BusTransportation.EditTicket form = new BusTransportation.EditTicket();

            string transportId = "1";
            string actual = form.getTransport(transportId);
            Assert.AreEqual("1: Благоевград->Кюстендил(5/1/2022 12:12:51 PM)", actual);
        }

        [TestMethod]
        public void Test_searchBus()
        {
            BusTransportation.EditTicket form = new BusTransportation.EditTicket();

            string transportId = "1";
            int actual = form.searchBus(transportId);
            Assert.AreEqual(1, actual); //maluk
        }

        [TestMethod]
        public void Test_getTransportPrice()
        {
            BusTransportation.EditTicket form = new BusTransportation.EditTicket();

            string transportId = "1";
            string actual = form.getTransportPrice(transportId);
            Assert.AreEqual("22", actual);
        }

        //Register testing

        [TestMethod]
        public void Test_isValidEmail()
        {
            BusTransportation.Form1 form = new BusTransportation.Form1();

            string email = "testemail@abv.bg";
            bool actual = form.isValidEmail(email);
            Assert.AreEqual(true, actual);

            email = "incorrectemail";
            actual = form.isValidEmail(email);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Test_checkIfUserDoesntExist()
        {
            BusTransportation.Form1 form = new BusTransportation.Form1();

            string user = "a";
            bool actual = form.checkIfUserDoesntExist(user);
            Assert.AreEqual(false, actual);   //it exists

            user = "doesntexist";
            actual = form.checkIfUserDoesntExist(user);
            Assert.AreEqual(true, actual);
        }



    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mail_API.Models.Db.Tests
{
    [TestClass()]
    public class MailTests
    {
        private Mail mailtest = new Mail();
        [TestMethod()]
        public void NoValidReceiver()
        {
            mailtest.Body = "body";
            mailtest.Receiver = "Robin";
            mailtest.Sender = "Robin@winlas.se";
            Assert.IsFalse(mailtest.IsValid());
        }

        [TestMethod()]
        public void NoValidSender()
        {
            mailtest.Body = "Body";
            mailtest.Receiver = "robin@winlas.se";
            mailtest.Sender = "Robin";
            Assert.IsFalse(mailtest.IsValid());
        }

        [TestMethod()]
        public void NoValidBody()
        {
            mailtest.Body = "";
            mailtest.Receiver = "robin@winlas.se";
            mailtest.Sender = "robin@winlas.se";
            Assert.IsFalse(mailtest.IsValid());
        }

        [TestMethod()]
        public void IsValidBody()
        {
            mailtest.Body = "Body";
            mailtest.Receiver = "Robin@winlas.se";
            mailtest.Sender = "Robin@winlas.se";
            Assert.IsTrue(mailtest.IsValid());
        }

        [TestMethod()]
        public void IsValidSender()
        {
            mailtest.Body = "Body";
            mailtest.Receiver = "Robin@winlas.se";
            mailtest.Sender = "Robin@winlas.se";
            Assert.IsTrue(mailtest.IsValid());
        }
        [TestMethod()]
        public void IsValidReceiver()
        {
            mailtest.Body = "Body";
            mailtest.Receiver = "Robin@winlas.se";
            mailtest.Sender = "Robin@Winlas.se";
            Assert.IsTrue(mailtest.IsValid());
        }
    }
}
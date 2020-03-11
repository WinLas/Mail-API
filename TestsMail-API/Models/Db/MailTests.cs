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
            mailtest.Body = "Body";
            mailtest.Receiver = "fredrik";
            mailtest.Sender = "Fredrik";
        }

       [TestMethod()]
        public void NoValidBody()
        {
            mailtest.Body = "";
            mailtest.Receiver = "fredrik@winlas.se";
            mailtest.Sender = "Fredrik";
            Assert.IsFalse(mailtest.IsValid());
        }

        [TestMethod()]
        public void IsValidMail()
        {
            mailtest.Body = "Body";
            mailtest.Receiver = "fredrik@winlas.se";
            mailtest.Sender = "Fredrik";
            Assert.IsFalse(mailtest.IsValid());
        }
    }
}
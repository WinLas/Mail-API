using System;
using Mail_API.Controllers;
using Mail_API.Models;
using Mail_API.Models.Db;
using Xunit;

namespace XUnitTestMail_Api
{
    public class IsValidTest
    {
        private Mail mailtest = new Mail();

        [Fact]
        public void NoValidReceiver()
        {
            mailtest.Body = "body";
            mailtest.Receiver = "Robin";
            mailtest.Sender = "Robin@winlas.se";
            Assert.False(mailtest.IsValid());
        }

        [Fact]
        public void NoValidSender()
        {
            mailtest.Body = "Body";
            mailtest.Receiver = "robin@winlas.se";
            mailtest.Sender = "Robin";
            Assert.False(mailtest.IsValid());
        }

        [Fact]
        public void NoValidBody()
        {
            mailtest.Body = "";
            mailtest.Receiver = "robin@winlas.se";
            mailtest.Sender = "robin@winlas.se";
            Assert.False(mailtest.IsValid());
        }

        [Fact]
        public void IsValidBody()
        {
            mailtest.Body = "Body";
            mailtest.Receiver = "Robin@winlas.se";
            mailtest.Sender = "Robin@winlas.se";
            Assert.True(mailtest.IsValid());
        }

        [Fact]
        public void IsValidSender()
        {
            mailtest.Body = "Body";
            mailtest.Receiver = "Robin@winlas.se";
            mailtest.Sender = "Robin@winlas.se";
            Assert.True(mailtest.IsValid());
        }

        [Fact]
        public void IsValidReceiver()
        {
            mailtest.Body = "Body";
            mailtest.Receiver = "Robin@winlas.se";
            mailtest.Sender = "Robin@Winlas.se";
            Assert.True(mailtest.IsValid());
        }

    }
}

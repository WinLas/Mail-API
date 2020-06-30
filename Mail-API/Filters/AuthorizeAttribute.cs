using Microsoft.AspNetCore.Mvc;
using System;

namespace Mail_API.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class BasicAuthAttribute : TypeFilterAttribute
    {
        public BasicAuthAttribute(string realm = @"My Realm") : base(typeof(BasicAuthFilter))
        {
            Arguments = new object[] { realm };
        }
    }
}
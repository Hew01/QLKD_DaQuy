using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Tests
{
    [TestClass()]
    public class DB_QLKDTests
    {
        [TestMethod()]
        public void CheckStateTest()
        {
            Assert.IsTrue(DB_QLKD.CheckState("Chưa Giao"));
            Assert.IsTrue(DB_QLKD.CheckState("Đã Giao"));
            Assert.IsFalse(DB_QLKD.CheckState("abcd"));
        }
    }
}
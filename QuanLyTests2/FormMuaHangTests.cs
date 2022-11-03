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
    public class FormMuaHangTests
    {
        [TestMethod()]
        public void CheckSoPhieu_PMHTest()
        {
            FormMuaHang FMH = new FormMuaHang();
            Assert.IsTrue(FMH.CheckSoPhieu_PMH("0"));
            Assert.IsTrue(FMH.CheckSoPhieu_PMH("111"));
            Assert.IsFalse(FMH.CheckSoPhieu_PMH("-2"));
            Assert.IsFalse(FMH.CheckSoPhieu_PMH("0.5"));
            Assert.IsFalse(FMH.CheckSoPhieu_PMH("aBcD123"));
        }

        [TestMethod()]
        public void CheckSoLuong_PMHTest()
        {
            FormMuaHang FMH = new FormMuaHang();
            Assert.IsFalse(FMH.CheckSoLuong_PMH("0"));
            Assert.IsTrue(FMH.CheckSoLuong_PMH("1"));
            Assert.IsTrue(FMH.CheckSoLuong_PMH("14"));
            Assert.IsFalse(FMH.CheckSoLuong_PMH("-1"));
            Assert.IsFalse(FMH.CheckSoLuong_PMH("0.5"));
            Assert.IsFalse(FMH.CheckSoLuong_PMH("aBcD123"));
        }
    }
}
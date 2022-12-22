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
    public class FormBanHangTests
    {
        [TestMethod()]
        public void IsSPMuaValidTest()
        {
            FormBanHang FBH = new FormBanHang();
            Assert.IsTrue(FBH.IsSPMuaValid("Diamond", "1", "5"));
            Assert.IsFalse(FBH.IsSPMuaValid("", "", ""));
        }

        [TestMethod()]
        public void IsCustomerInfoValidTest()
        {
            FormBanHang FBH = new FormBanHang();
            FBH.TB_TenKH.Text = "John";
            Assert.IsTrue(FBH.IsCustomerInfoValid(FBH.TB_TenKH.Text));

            FBH.TB_TenKH.Text = "";
            Assert.IsFalse(FBH.IsCustomerInfoValid(FBH.TB_TenKH.Text));
        }
    }
}
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMvcDemo.Extend;
using MyMvcDemo.Models;

namespace BaseFeatureTest.MyMVCTest.ControllerTest
{
    [TestClass]
    public class HomeTest
    {
        
        [TestMethod]
        public void XmlStrInjectionTest()
        {
            var ms = ControllerHelper.GetIndexModules();
        }  

    }
}

using Craps.ApiDataHandlers;
using Craps.EntityControllers.CrapsObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Craps_Test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void GetCrapsResult()
        {
            //Array
            CrapsController testedController = new CrapsController(new RollDataHandler());
            CrapsResultModel inputModel = new CrapsResultModel();
            inputModel.FirstRollValue = 3;
            inputModel.SecondRollValue = 4;
            string result = null;

            //Act
            result = testedController.GetCrapsResult(inputModel.RollSum, inputModel.GameResult, inputModel.Point);

            //Assert
            Assert.AreEqual("win", result);
        }
    }
}

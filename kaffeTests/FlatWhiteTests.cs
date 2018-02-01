using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffeTests
{
    class FlatWhiteTests
    {
            [TestMethod()]
            public void prisTestFlatWhite()
            {
                //Arrange
                var flatWhite = new FlatWhite();

                //Act
                int pris = flatWhite.Pris();

                //assert
                Assert.AreEqual(45, pris);

            }
        

        [TestMethod()]
        public void styrkeTestFlatWhite()
        {
            //Arrange
            var flatWhite = new FlatWhite();
            //Act
            string styrke = flatWhite.Styrke();
            //Assert
            Assert.AreEqual("Mild", styrke);
        }

        [TestMethod()]
        public void MililiterTest()
        {
            //Arrange
            var flatWhite = new FlatWhite();

            //Act
            int mlLiter = flatWhite.MlMælk();

            //assert
            Assert.AreEqual(160, mlLiter);

        }

    }
}

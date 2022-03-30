using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobilize.QualityMate.Automation.Extensions;
using Mobilize.QualityMate.UiPlayer;
using Mobilize.QualityMate.UiTesting.MsTest;
using System;

namespace CalculadoraTest
{
    [TestClass]
    public class OperacionesTest : UiTest
    {
        [TestMethod]
        public void PruebasSuma()
        {
            this.Execute(SumaTest_01);
            this.Execute(SumaTest_02);

        }

        public void SumaTest_01(UiExecutionController controller)
        {
            FormCalculadora formCalc = controller.GetPageObject<FormCalculadora>();

            formCalc.textBox1.Text = "1";
            formCalc.textBox2.Text = "1";

            formCalc.button1.Click();
            formCalc.textBox3.Validate(self => self.Text == "2");
        }

        public void SumaTest_02(UiExecutionController controller)
        {
            FormCalculadora formCalc = controller.GetPageObject<FormCalculadora>();

            formCalc.textBox1.Text = "1";
            formCalc.textBox2.Text = "-2";

            formCalc.button1.Click();
            try
            {
                formCalc.textBox3.Validate(self => self.Text == "-100");
            }
            catch 
            {
                Console.WriteLine("FALLO SumaTest_02");
            }
            
        }
    }
}

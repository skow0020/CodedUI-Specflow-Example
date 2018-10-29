using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;

namespace CodedUIExample.Pages.PageObjectCommonClasses
{
    public partial class PageObjectCommon
    {
        public WinButton numberButton => UICalculatorWindow.UIItemWindow.UINumberButton;
        public WinButton addButton => UICalculatorWindow.UIItemWindow1.UIAddButton;
        public WinButton equalsButton => UICalculatorWindow.UIItemWindow2.UIEqualsButton;
        public WinText resultField => UICalculatorWindow.UIItem0Window.UIResultField;

        public void ClearField(WinControl field)
        {
            Mouse.Click(field);
            Keyboard.SendKeys("^(a){DELETE}");
        }

        public void EnterValue(string number)
        {
            foreach (char c in number) {
                numberButton.SearchProperties[WinWindow.PropertyNames.Name] = c.ToString();
                Mouse.Click(numberButton);
            }          
        }

        public void VerifyResultIs(string expectedResult)
        {
            Assert.AreEqual(expectedResult, resultField.DisplayText);
        }

        public void DoSomethingCoolWith(string exampleParam)
        {
            // TO BE IMPLEMENTED
        }

        public void VerifySomethingExciting()
        {
            // TO BE IMPLEMENTED
        }
    }
}

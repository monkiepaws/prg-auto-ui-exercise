namespace CodedUITestProject1
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {

        public UIMap()
        {
            this.UIAutoUITestingExercisWindow.UIStartButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "buttonA";
        }

        /// <summary>
        /// SimpleAppTest - Use 'SimpleAppTestParams' to pass parameters into this method.
        /// </summary>
        public void ModifiedSimpleAppTest()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIAutoUITestingExercisWindow.UIStartButton;
            WpfCheckBox uICheckboxCheckBox = this.UIAutoUITestingExercisWindow.UICheckboxCheckBox;
            WinTitleBar uIAutoUITestingExercisTitleBar = this.UIAutoUITestingExercisWindow1.UIAutoUITestingExercisTitleBar;
            #endregion

            // Launch '%USERPROFILE%\source\repos\prg-auto-ui-exercise\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
            ApplicationUnderTest uIAutoUITestingExercisWindow = ApplicationUnderTest.Launch(this.SimpleAppTestParams.UIAutoUITestingExercisWindowExePath, this.SimpleAppTestParams.UIAutoUITestingExercisWindowAlternateExePath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(157, 20));

            // Added as part of UI testing tutorial
            uICheckboxCheckBox.WaitForControlEnabled();

            // Select 'Checkbox' check box
            uICheckboxCheckBox.Checked = this.SimpleAppTestParams.UICheckboxCheckBoxChecked;

            // Click 'Auto UI Testing Exercise - Richard Sims - 9633324' title bar
            Mouse.Click(uIAutoUITestingExercisTitleBar, new Point(759, 12));
        }

        public virtual SimpleAppTestParams SimpleAppTestParams
        {
            get
            {
                if ((this.mSimpleAppTestParams == null))
                {
                    this.mSimpleAppTestParams = new SimpleAppTestParams();
                }
                return this.mSimpleAppTestParams;
            }
        }

        private SimpleAppTestParams mSimpleAppTestParams;
    }
    /// <summary>
    /// Parameters to be passed into 'SimpleAppTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class SimpleAppTestParams
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\source\repos\prg-auto-ui-exercise\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIAutoUITestingExercisWindowExePath = "C:\\Users\\Richard\\source\\repos\\prg-auto-ui-exercise\\SimpleWPFApp\\bin\\Debug\\SimpleW" +
            "PFApp.exe";

        /// <summary>
        /// Launch '%USERPROFILE%\source\repos\prg-auto-ui-exercise\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIAutoUITestingExercisWindowAlternateExePath = "%USERPROFILE%\\source\\repos\\prg-auto-ui-exercise\\SimpleWPFApp\\bin\\Debug\\SimpleWPFA" +
            "pp.exe";

        /// <summary>
        /// Select 'Checkbox' check box
        /// </summary>
        public bool UICheckboxCheckBoxChecked = true;
        #endregion
    }
}

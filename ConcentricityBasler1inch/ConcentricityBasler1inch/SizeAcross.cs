﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace ConcentricityBasler1inch
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SizeAcross recording.
    /// </summary>
    [TestModule("5ebbedc3-84d2-4149-b54b-b56a8b1226a6", ModuleType.Recording, 1)]
    public partial class SizeAcross : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ConcentricityBasler1inchRepository repository.
        /// </summary>
        public static ConcentricityBasler1inchRepository repo = ConcentricityBasler1inchRepository.Instance;

        static SizeAcross instance = new SizeAcross();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SizeAcross()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SizeAcross Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TitleBar' at Center.", repo.SnapXUntitled.TitleBarInfo, new RecordItemIndex(0));
            repo.SnapXUntitled.TitleBar.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(1));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(2));
            Keyboard.Press("f");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'o'.", new RecordItemIndex(3));
            Keyboard.Press("o");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(4));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationConcentricity\\Routine\\SizeAcross_Basler1.mxy'.", new RecordItemIndex(5));
            Keyboard.Press("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationConcentricity\\Routine\\SizeAcross_Basler1.mxy");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(6));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TitleBar' at Center.", repo.SnapXUntitled.TitleBarInfo, new RecordItemIndex(7));
            repo.SnapXUntitled.TitleBar.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(8));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(9));
            Keyboard.Press("f");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'r'.", new RecordItemIndex(10));
            Keyboard.Press("r");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ButtonOK' at 50;10.", repo.SnapXUntitled.ButtonOKInfo, new RecordItemIndex(11));
            repo.SnapXUntitled.ButtonOK.Click("50;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Finish' at 81;9.", repo.SnapXUntitled.FinishInfo, new RecordItemIndex(12));
            repo.SnapXUntitled.Finish.Click("81;9");
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(13));
            Delay.Duration(10000, false);

            string strSizeAcrossValues = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationConcentricity\\Reports\\SizeAcross.STA";       
            string strHardcodedValues = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationConcentricity\\Reports\\HardcodedSizeAcross.STA";
            UtilityRun.RunSizeAcross(strSizeAcrossValues, strHardcodedValues);
            Delay.Duration(2000);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TitleBar' at Center.", repo.SnapXUntitled.TitleBarInfo, new RecordItemIndex(7));
            repo.SnapXUntitled.TitleBar.Click();
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(8));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(9));
            Keyboard.Press("f");
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'n'.", new RecordItemIndex(10));
            Keyboard.Press("n");
            Delay.Milliseconds(300);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ButtonGo' at 55;155.", repo.SnapXUntitled.ButtonGoInfo, new RecordItemIndex(0));
            repo.SnapXUntitled.ButtonGo.Click("55;155");
            Delay.Milliseconds(200);




        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 1/3/24
 * Time: 12:31
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace OpenCart
{
    /// <summary>
    /// Description of WatchAutoComplete.
    /// </summary>
    [TestModule("1A490014-6EF6-45FF-895F-A6E3356FF6C0", ModuleType.UserCode, 1)]
    public class WatchAutoComplete : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WatchAutoComplete()
        {
            // Do not delete - a parameterless constructor is required!
        }
        public static Ranorex.PopupWatcher DoWatchAutoComplete = new Ranorex.PopupWatcher();

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}

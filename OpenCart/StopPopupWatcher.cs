/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 1/3/24
 * Time: 12:56
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
    /// Description of StopPopupWatcher.
    /// </summary>
    [TestModule("105B9B88-F98C-4D2F-9AB8-AEF717B582EA", ModuleType.UserCode, 1)]
    public class StopPopupWatcher : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StopPopupWatcher()
        {
            // Do not delete - a parameterless constructor is required!
        }

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
            //Stops the pop-up watcher class from monitoring anymore pop-ups
            WatchAutoComplete.DoWatchAutoComplete.Stop();
        }
    }
}

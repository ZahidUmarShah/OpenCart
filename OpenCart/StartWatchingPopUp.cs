/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 1/3/24
 * Time: 11:13
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
    /// Description of StartWatchingPopUp.
    /// </summary>
    [TestModule("A056AB60-6228-4E6B-8FB9-27AC312095BE", ModuleType.UserCode, 1)]
    public class StartWatchingPopUp : ITestModule
    {
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartWatchingPopUp()
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
            
            //Here method WatchAndClick from Class PopupWatcher takes two arguments 1. Folder which is supposed to be the actual pop-up dialog, 2. And the Button on it to 
            //close that pop-up i.e., (OpenCartRepository.Instance.MyAccountGoogleChrome And OpenCartRepository.Instance.MyAccountGoogleChrome.BtnCloseInfo); in which
            // MyAccountGoogleChrome is the object in the object repository taken for the pop-up dialog and BtnCloseInfo is the close button on that pop-up
            
            WatchAutoComplete.DoWatchAutoComplete.WatchAndClick (OpenCartRepository.Instance.MyAccountGoogleChrome,OpenCartRepository.Instance.MyAccountGoogleChrome.BtnCloseInfo);
            WatchAutoComplete.DoWatchAutoComplete.Start(); //Starts the PopupWatcher class to monitor the popup if that appears 
        }
    }
}

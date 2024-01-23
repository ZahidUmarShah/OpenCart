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

namespace OpenCart
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddToCart recording.
    /// </summary>
    [TestModule("3bfe5bef-fb88-4c2f-b96e-f640e05572bb", ModuleType.Recording, 1)]
    public partial class AddToCart : ITestModule
    {
        /// <summary>
        /// Holds an instance of the OpenCartRepository repository.
        /// </summary>
        public static OpenCartRepository repo = OpenCartRepository.Instance;

        static AddToCart instance = new AddToCart();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddToCart()
        {
            NumOfProductsAdded = "";
            EnteredQuantity = "2";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddToCart Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumOfProductsAdded;

        /// <summary>
        /// Gets or sets the value of variable NumOfProductsAdded.
        /// </summary>
        [TestVariable("7a8ab84d-cfcd-45de-ae37-69cd45cec901")]
        public string NumOfProductsAdded
        {
            get { return _NumOfProductsAdded; }
            set { _NumOfProductsAdded = value; }
        }

        string _EnteredQuantity;

        /// <summary>
        /// Gets or sets the value of variable EnteredQuantity.
        /// </summary>
        [TestVariable("94fc07a2-660e-4896-9c48-63fc30c76644")]
        public string EnteredQuantity
        {
            get { return _EnteredQuantity; }
            set { _EnteredQuantity = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Quantity.
        /// </summary>
        [TestVariable("7f26a93d-6f1a-4181-8d2d-6df3471ccad7")]
        public string Quantity
        {
            get { return repo.Quantity; }
            set { repo.Quantity = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.CartPage.InputQuantity'.", repo.ApplicationUnderTest.CartPage.InputQuantityInfo, new RecordItemIndex(0));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.CartPage.InputQuantity);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EnteredQuantity' with focus on 'ApplicationUnderTest.CartPage.InputQuantity'.", repo.ApplicationUnderTest.CartPage.InputQuantityInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.CartPage.InputQuantity.PressKeys(EnteredQuantity);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CartPage.ButtonCart' at Center.", repo.ApplicationUnderTest.CartPage.ButtonCartInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.CartPage.ButtonCart.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.CartPage.Label_AddToCard_Number'.", repo.ApplicationUnderTest.CartPage.Label_AddToCard_NumberInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.CartPage.Label_AddToCard_Number.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.CartPage.Label_AddToCard_Number' and assigning its value to variable 'NumOfProductsAdded'.", repo.ApplicationUnderTest.CartPage.Label_AddToCard_NumberInfo, new RecordItemIndex(4));
            NumOfProductsAdded = repo.ApplicationUnderTest.CartPage.Label_AddToCard_Number.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", NumOfProductsAdded, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$EnteredQuantity) on item 'ApplicationUnderTest.CartPage.Label_AddToCard_Number'.", repo.ApplicationUnderTest.CartPage.Label_AddToCard_NumberInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.ApplicationUnderTest.CartPage.Label_AddToCard_NumberInfo, "InnerText", EnteredQuantity);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

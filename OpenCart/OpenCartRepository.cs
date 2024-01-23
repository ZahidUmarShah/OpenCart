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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace OpenCart
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the OpenCartRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("ab95428f-0452-45cb-bb73-061bf2b40f97")]
    public partial class OpenCartRepository : RepoGenBaseFolder
    {
        static OpenCartRepository instance = new OpenCartRepository();
        OpenCartRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        OpenCartRepositoryFolders.YourStoreAppFolder _yourstore;
        OpenCartRepositoryFolders.MyAccountGoogleChromeAppFolder _myaccountgooglechrome;

        /// <summary>
        /// Gets the singleton class instance representing the OpenCartRepository element repository.
        /// </summary>
        [RepositoryFolder("ab95428f-0452-45cb-bb73-061bf2b40f97")]
        public static OpenCartRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public OpenCartRepository() 
            : base("OpenCartRepository", "/", null, 0, false, "ab95428f-0452-45cb-bb73-061bf2b40f97", ".\\RepositoryImages\\OpenCartRepositoryab95428f.rximgres")
        {
            _applicationundertest = new OpenCartRepositoryFolders.ApplicationUnderTestAppFolder(this);
            _yourstore = new OpenCartRepositoryFolders.YourStoreAppFolder(this);
            _myaccountgooglechrome = new OpenCartRepositoryFolders.MyAccountGoogleChromeAppFolder(this);
        }

#region Variables

        string _Quantity = " 1";

        /// <summary>
        /// Gets or sets the value of variable Quantity.
        /// </summary>
        [TestVariable("7f26a93d-6f1a-4181-8d2d-6df3471ccad7")]
        public string Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("ab95428f-0452-45cb-bb73-061bf2b40f97")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("04a0c008-7b36-4054-97df-3e79d2f7e9e7")]
        public virtual OpenCartRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The YourStore folder.
        /// </summary>
        [RepositoryFolder("cdcc8494-5bfd-430f-8afb-6be7303578fe")]
        public virtual OpenCartRepositoryFolders.YourStoreAppFolder YourStore
        {
            get { return _yourstore; }
        }

        /// <summary>
        /// The MyAccountGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("328217ed-36c9-4e10-a449-66b2036286dc")]
        public virtual OpenCartRepositoryFolders.MyAccountGoogleChromeAppFolder MyAccountGoogleChrome
        {
            get { return _myaccountgooglechrome; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class OpenCartRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("04a0c008-7b36-4054-97df-3e79d2f7e9e7")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            OpenCartRepositoryFolders.LoginFolder _login;
            OpenCartRepositoryFolders.SelectProductFolder _selectproduct;
            OpenCartRepositoryFolders.CartPageFolder _cartpage;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='demo.opencart.com']", parentFolder, 30000, null, false, "04a0c008-7b36-4054-97df-3e79d2f7e9e7", "")
            {
                _login = new OpenCartRepositoryFolders.LoginFolder(this);
                _selectproduct = new OpenCartRepositoryFolders.SelectProductFolder(this);
                _cartpage = new OpenCartRepositoryFolders.CartPageFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("04a0c008-7b36-4054-97df-3e79d2f7e9e7")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("04a0c008-7b36-4054-97df-3e79d2f7e9e7")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Login folder.
            /// </summary>
            [RepositoryFolder("a2fb4039-b3a0-4f33-a69e-e647b6e05829")]
            public virtual OpenCartRepositoryFolders.LoginFolder Login
            {
                get { return _login; }
            }

            /// <summary>
            /// The SelectProduct folder.
            /// </summary>
            [RepositoryFolder("66d0f63a-d97b-4042-8bde-8d3a61b5cce2")]
            public virtual OpenCartRepositoryFolders.SelectProductFolder SelectProduct
            {
                get { return _selectproduct; }
            }

            /// <summary>
            /// The CartPage folder.
            /// </summary>
            [RepositoryFolder("4a75169e-8843-41d6-8d45-76db5e682de1")]
            public virtual OpenCartRepositoryFolders.CartPageFolder CartPage
            {
                get { return _cartpage; }
            }
        }

        /// <summary>
        /// The LoginFolder folder.
        /// </summary>
        [RepositoryFolder("a2fb4039-b3a0-4f33-a69e-e647b6e05829")]
        public partial class LoginFolder : RepoGenBaseFolder
        {
            RepoItemInfo _inputemailInfo;
            RepoItemInfo _inputpasswordInfo;
            RepoItemInfo _btnloginInfo;

            /// <summary>
            /// Creates a new Login  folder.
            /// </summary>
            public LoginFolder(RepoGenBaseFolder parentFolder) :
                    base("Login", "", parentFolder, 0, null, false, "a2fb4039-b3a0-4f33-a69e-e647b6e05829", "")
            {
                _inputemailInfo = new RepoItemInfo(this, "InputEmail", ".//input[@placeholder='E-Mail Address']", 30000, null, "7bdd9ecb-d8ef-4b51-9839-415be84ac473");
                _inputpasswordInfo = new RepoItemInfo(this, "InputPassword", ".//input[@type='password']", 30000, null, "75992f99-109b-4d28-b2a0-28af020429e4");
                _btnloginInfo = new RepoItemInfo(this, "BtnLogin", ".//form[#'form-login']/button[@innertext='Login']", 30000, null, "1d183f2d-9f42-4534-a6ab-31f4dfa83b9e");
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a2fb4039-b3a0-4f33-a69e-e647b6e05829")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The InputEmail item.
            /// </summary>
            [RepositoryItem("7bdd9ecb-d8ef-4b51-9839-415be84ac473")]
            public virtual Ranorex.InputTag InputEmail
            {
                get
                {
                    return _inputemailInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The InputEmail item info.
            /// </summary>
            [RepositoryItemInfo("7bdd9ecb-d8ef-4b51-9839-415be84ac473")]
            public virtual RepoItemInfo InputEmailInfo
            {
                get
                {
                    return _inputemailInfo;
                }
            }

            /// <summary>
            /// The InputPassword item.
            /// </summary>
            [RepositoryItem("75992f99-109b-4d28-b2a0-28af020429e4")]
            public virtual Ranorex.InputTag InputPassword
            {
                get
                {
                    return _inputpasswordInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The InputPassword item info.
            /// </summary>
            [RepositoryItemInfo("75992f99-109b-4d28-b2a0-28af020429e4")]
            public virtual RepoItemInfo InputPasswordInfo
            {
                get
                {
                    return _inputpasswordInfo;
                }
            }

            /// <summary>
            /// The BtnLogin item.
            /// </summary>
            [RepositoryItem("1d183f2d-9f42-4534-a6ab-31f4dfa83b9e")]
            public virtual Ranorex.ButtonTag BtnLogin
            {
                get
                {
                    return _btnloginInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The BtnLogin item info.
            /// </summary>
            [RepositoryItemInfo("1d183f2d-9f42-4534-a6ab-31f4dfa83b9e")]
            public virtual RepoItemInfo BtnLoginInfo
            {
                get
                {
                    return _btnloginInfo;
                }
            }
        }

        /// <summary>
        /// The SelectProductFolder folder.
        /// </summary>
        [RepositoryFolder("66d0f63a-d97b-4042-8bde-8d3a61b5cce2")]
        public partial class SelectProductFolder : RepoGenBaseFolder
        {
            RepoItemInfo _productmenuInfo;
            RepoItemInfo _productcategoryInfo;
            RepoItemInfo _productInfo;
            RepoItemInfo _productitemInfo;

            /// <summary>
            /// Creates a new SelectProduct  folder.
            /// </summary>
            public SelectProductFolder(RepoGenBaseFolder parentFolder) :
                    base("SelectProduct", "", parentFolder, 0, null, false, "66d0f63a-d97b-4042-8bde-8d3a61b5cce2", "")
            {
                _productmenuInfo = new RepoItemInfo(this, "ProductMenu", ".//div[#'narbar-menu']/ul/?/?/a[@innertext='Components']", 30000, null, "8dcf4966-0f41-4ef6-b08b-8fcd7b6f5e27");
                _productcategoryInfo = new RepoItemInfo(this, "ProductCategory", ".//div[#'narbar-menu']/ul//div/?/?/ul//a[@innertext>'Monitors']", 30000, null, "13470f37-7a26-45c1-83fa-7403d7406aeb");
                _productInfo = new RepoItemInfo(this, "Product", ".//div//form//h4/a[@innertext='Samsung SyncMaster 941BW']", 30000, null, "70a6195a-e36d-4a6f-a593-cb22681f0e2e");
                _productitemInfo = new RepoItemInfo(this, "ProductItem", ".//div/div[1]/?/?/h1[@innertext='Samsung SyncMaster 941BW']", 30000, null, "902d0c3a-943e-4a2c-94ed-accea9c88965");
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("66d0f63a-d97b-4042-8bde-8d3a61b5cce2")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ProductMenu item.
            /// </summary>
            [RepositoryItem("8dcf4966-0f41-4ef6-b08b-8fcd7b6f5e27")]
            public virtual Ranorex.ATag ProductMenu
            {
                get
                {
                    return _productmenuInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ProductMenu item info.
            /// </summary>
            [RepositoryItemInfo("8dcf4966-0f41-4ef6-b08b-8fcd7b6f5e27")]
            public virtual RepoItemInfo ProductMenuInfo
            {
                get
                {
                    return _productmenuInfo;
                }
            }

            /// <summary>
            /// The ProductCategory item.
            /// </summary>
            [RepositoryItem("13470f37-7a26-45c1-83fa-7403d7406aeb")]
            public virtual Ranorex.ATag ProductCategory
            {
                get
                {
                    return _productcategoryInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ProductCategory item info.
            /// </summary>
            [RepositoryItemInfo("13470f37-7a26-45c1-83fa-7403d7406aeb")]
            public virtual RepoItemInfo ProductCategoryInfo
            {
                get
                {
                    return _productcategoryInfo;
                }
            }

            /// <summary>
            /// The Product item.
            /// </summary>
            [RepositoryItem("70a6195a-e36d-4a6f-a593-cb22681f0e2e")]
            public virtual Ranorex.ATag Product
            {
                get
                {
                    return _productInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Product item info.
            /// </summary>
            [RepositoryItemInfo("70a6195a-e36d-4a6f-a593-cb22681f0e2e")]
            public virtual RepoItemInfo ProductInfo
            {
                get
                {
                    return _productInfo;
                }
            }

            /// <summary>
            /// The ProductItem item.
            /// </summary>
            [RepositoryItem("902d0c3a-943e-4a2c-94ed-accea9c88965")]
            public virtual Ranorex.H1Tag ProductItem
            {
                get
                {
                    return _productitemInfo.CreateAdapter<Ranorex.H1Tag>(true);
                }
            }

            /// <summary>
            /// The ProductItem item info.
            /// </summary>
            [RepositoryItemInfo("902d0c3a-943e-4a2c-94ed-accea9c88965")]
            public virtual RepoItemInfo ProductItemInfo
            {
                get
                {
                    return _productitemInfo;
                }
            }
        }

        /// <summary>
        /// The CartPageFolder folder.
        /// </summary>
        [RepositoryFolder("4a75169e-8843-41d6-8d45-76db5e682de1")]
        public partial class CartPageFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttoncartInfo;
            RepoItemInfo _label_addtocard_numberInfo;
            RepoItemInfo _inputquantityInfo;

            /// <summary>
            /// Creates a new CartPage  folder.
            /// </summary>
            public CartPageFolder(RepoGenBaseFolder parentFolder) :
                    base("CartPage", "", parentFolder, 0, null, false, "4a75169e-8843-41d6-8d45-76db5e682de1", "")
            {
                _buttoncartInfo = new RepoItemInfo(this, "ButtonCart", ".//button[@innertext='Add to Cart']", 30000, null, "4495bcc1-c2a8-4b2e-9a1b-6ba6385ff99f");
                _label_addtocard_numberInfo = new RepoItemInfo(this, "Label_AddToCard_Number", ".//div[#'header-cart']/?/?/button[@innertext~$Quantity]", 30000, null, "78808d28-7090-4fef-830e-27e2b3111f46");
                _inputquantityInfo = new RepoItemInfo(this, "InputQuantity", ".//input[@name='quantity']", 30000, null, "c35b98b8-8d6f-4015-976f-4260077d0ac0");
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("4a75169e-8843-41d6-8d45-76db5e682de1")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonCart item.
            /// </summary>
            [RepositoryItem("4495bcc1-c2a8-4b2e-9a1b-6ba6385ff99f")]
            public virtual Ranorex.ButtonTag ButtonCart
            {
                get
                {
                    return _buttoncartInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The ButtonCart item info.
            /// </summary>
            [RepositoryItemInfo("4495bcc1-c2a8-4b2e-9a1b-6ba6385ff99f")]
            public virtual RepoItemInfo ButtonCartInfo
            {
                get
                {
                    return _buttoncartInfo;
                }
            }

            /// <summary>
            /// The Label_AddToCard_Number item.
            /// </summary>
            [RepositoryItem("78808d28-7090-4fef-830e-27e2b3111f46")]
            public virtual Ranorex.ButtonTag Label_AddToCard_Number
            {
                get
                {
                    return _label_addtocard_numberInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The Label_AddToCard_Number item info.
            /// </summary>
            [RepositoryItemInfo("78808d28-7090-4fef-830e-27e2b3111f46")]
            public virtual RepoItemInfo Label_AddToCard_NumberInfo
            {
                get
                {
                    return _label_addtocard_numberInfo;
                }
            }

            /// <summary>
            /// The InputQuantity item.
            /// </summary>
            [RepositoryItem("c35b98b8-8d6f-4015-976f-4260077d0ac0")]
            public virtual Ranorex.InputTag InputQuantity
            {
                get
                {
                    return _inputquantityInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The InputQuantity item info.
            /// </summary>
            [RepositoryItemInfo("c35b98b8-8d6f-4015-976f-4260077d0ac0")]
            public virtual RepoItemInfo InputQuantityInfo
            {
                get
                {
                    return _inputquantityInfo;
                }
            }
        }

        /// <summary>
        /// The YourStoreAppFolder folder.
        /// </summary>
        [RepositoryFolder("cdcc8494-5bfd-430f-8afb-6be7303578fe")]
        public partial class YourStoreAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _myaccountInfo;
            RepoItemInfo _listitemloginInfo;

            /// <summary>
            /// Creates a new YourStore  folder.
            /// </summary>
            public YourStoreAppFolder(RepoGenBaseFolder parentFolder) :
                    base("YourStore", "/dom[@domain='demo.opencart.com']", parentFolder, 30000, null, false, "cdcc8494-5bfd-430f-8afb-6be7303578fe", "")
            {
                _myaccountInfo = new RepoItemInfo(this, "MyAccount", ".//?/?/a[@href>'https://demo.opencart.com']/span[@innertext='My Account']", 30000, null, "90c4adc6-6b3f-490e-8f3a-a4b84563b896");
                _listitemloginInfo = new RepoItemInfo(this, "ListItemLogin", ".//nav[#'top']/div[2]/div[2]/ul/li[2]/?/?/ul//a[@innertext='Login']", 30000, null, "81e551c5-71ef-4ae9-ba09-df95e5940693");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("cdcc8494-5bfd-430f-8afb-6be7303578fe")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("cdcc8494-5bfd-430f-8afb-6be7303578fe")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MyAccount item.
            /// </summary>
            [RepositoryItem("90c4adc6-6b3f-490e-8f3a-a4b84563b896")]
            public virtual Ranorex.SpanTag MyAccount
            {
                get
                {
                    return _myaccountInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The MyAccount item info.
            /// </summary>
            [RepositoryItemInfo("90c4adc6-6b3f-490e-8f3a-a4b84563b896")]
            public virtual RepoItemInfo MyAccountInfo
            {
                get
                {
                    return _myaccountInfo;
                }
            }

            /// <summary>
            /// The ListItemLogin item.
            /// </summary>
            [RepositoryItem("81e551c5-71ef-4ae9-ba09-df95e5940693")]
            public virtual Ranorex.ATag ListItemLogin
            {
                get
                {
                    return _listitemloginInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ListItemLogin item info.
            /// </summary>
            [RepositoryItemInfo("81e551c5-71ef-4ae9-ba09-df95e5940693")]
            public virtual RepoItemInfo ListItemLoginInfo
            {
                get
                {
                    return _listitemloginInfo;
                }
            }
        }

        /// <summary>
        /// The MyAccountGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("328217ed-36c9-4e10-a449-66b2036286dc")]
        public partial class MyAccountGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _chrome_popupInfo;
            RepoItemInfo _btncloseInfo;

            /// <summary>
            /// Creates a new MyAccountGoogleChrome  folder.
            /// </summary>
            public MyAccountGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MyAccountGoogleChrome", "/form[@title>'My Account - Google Chrom']/container/form[@accessiblename>'Check your saved password']/container/container[@accessiblerole='Pane']", parentFolder, 30000, null, true, "328217ed-36c9-4e10-a449-66b2036286dc", "")
            {
                _chrome_popupInfo = new RepoItemInfo(this, "Chrome_Popup", "container[@accessiblename>'My Account - Google Chrom']/form/container/container[@accessiblerole='Pane']", 30000, null, "9dc24563-cfaa-4642-9f4c-61e41e4d81aa");
                _btncloseInfo = new RepoItemInfo(this, "BtnClose", "container[@accessiblerole='Pane']/?/?/button[@accessiblename='Close']", 30000, null, "40bb6f94-33f7-4788-ab52-4e4241cf26ef");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("328217ed-36c9-4e10-a449-66b2036286dc")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("328217ed-36c9-4e10-a449-66b2036286dc")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Chrome_Popup item.
            /// </summary>
            [RepositoryItem("9dc24563-cfaa-4642-9f4c-61e41e4d81aa")]
            public virtual Ranorex.Container Chrome_Popup
            {
                get
                {
                    return _chrome_popupInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Chrome_Popup item info.
            /// </summary>
            [RepositoryItemInfo("9dc24563-cfaa-4642-9f4c-61e41e4d81aa")]
            public virtual RepoItemInfo Chrome_PopupInfo
            {
                get
                {
                    return _chrome_popupInfo;
                }
            }

            /// <summary>
            /// The BtnClose item.
            /// </summary>
            [RepositoryItem("40bb6f94-33f7-4788-ab52-4e4241cf26ef")]
            public virtual Ranorex.Button BtnClose
            {
                get
                {
                    return _btncloseInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnClose item info.
            /// </summary>
            [RepositoryItemInfo("40bb6f94-33f7-4788-ab52-4e4241cf26ef")]
            public virtual RepoItemInfo BtnCloseInfo
            {
                get
                {
                    return _btncloseInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}

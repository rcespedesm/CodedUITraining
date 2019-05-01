﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITrainingProjectA
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// mRemoteNGTest - Use 'mRemoteNGTestParams' to pass parameters into this method.
        /// </summary>
        public void mRemoteNGTest()
        {
            #region Variable Declarations
            WinTitleBar uIMRemoteNGconfConsxmlTitleBar = this.UIMRemoteNGconfConsxmlWindow.UIMRemoteNGconfConsxmlTitleBar;
            WinListItem uIAMZListItem = this.UIMRemoteNGconfConsxmlWindow.UIOlvConnectionsWindow.UIAMZListItem;
            WinRow uINameRow = this.UIMRemoteNGconfConsxmlWindow.UIPropertyGridViewWindow.UIPropertyGridViewTable.UINameRow;
            WinRow uIDescriptionRow = this.UIMRemoteNGconfConsxmlWindow.UIPropertyGridViewWindow.UIPropertyGridViewTable.UIDescriptionRow;
            #endregion

            // Click 'mRemoteNG - confCons.xml' title bar
            Mouse.Click(uIMRemoteNGconfConsxmlTitleBar, new Point(95, 19));

            // Double-Click 'AMZ' list item
            Mouse.DoubleClick(uIAMZListItem, new Point(65, 11));

            // Click 'Name' row
            Mouse.Click(uINameRow, new Point(156, 3));

            // Type 'Shift + {Left}' in 'Name' row
            Keyboard.SendKeys(uINameRow, this.mRemoteNGTestParams.UINameRowSendKeys, ModifierKeys.Shift);

            // Type 'Shift + {Left}' in 'Name' row
            Keyboard.SendKeys(uINameRow, this.mRemoteNGTestParams.UINameRowSendKeys1, ModifierKeys.Shift);

            // Type 'Shift + {Left}' in 'Name' row
            Keyboard.SendKeys(uINameRow, this.mRemoteNGTestParams.UINameRowSendKeys2, ModifierKeys.Shift);

            // Type 'Shift + {Left}' in 'Name' row
            Keyboard.SendKeys(uINameRow, this.mRemoteNGTestParams.UINameRowSendKeys3, ModifierKeys.Shift);

            // Type '{Back}{RShiftKey}AMZ{RShiftKey}Test' in 'Name' row
            Keyboard.SendKeys(uINameRow, this.mRemoteNGTestParams.UINameRowSendKeys4, ModifierKeys.None);

            // Click 'Description' row
            Mouse.Click(uIDescriptionRow, new Point(172, 3));
        }
        
        /// <summary>
        /// additionTwoValues
        /// </summary>
        public void additionTwoValues()
        {
            #region Variable Declarations
            WpfButton uIItem5Button = this.UIMyCalculatorv1Window.UIItem5Button;
            WpfButton uIItem8Button = this.UIMyCalculatorv1Window.UIItem8Button;
            WpfButton uIItem7Button = this.UIMyCalculatorv1Window.UIItem7Button;
            WpfButton uIItemButton = this.UIMyCalculatorv1Window.UIItemButton;
            WpfButton uIItem2Button = this.UIMyCalculatorv1Window.UIItem2Button;
            WpfButton uIItemButton1 = this.UIMyCalculatorv1Window.UIItemButton1;
            #endregion

            // Click '5' button
            Mouse.Click(uIItem5Button, new Point(24, 8));

            // Click '8' button
            Mouse.Click(uIItem8Button, new Point(28, 18));

            // Click '7' button
            Mouse.Click(uIItem7Button, new Point(33, 20));

            // Click '*' button
            Mouse.Click(uIItemButton, new Point(30, 18));

            // Click '2' button
            Mouse.Click(uIItem2Button, new Point(16, 13));

            // Click '=' button
            Mouse.Click(uIItemButton1, new Point(61, 12));
        }
        
        /// <summary>
        /// AssertMultiplication - Use 'AssertMultiplicationExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMultiplication()
        {
            #region Variable Declarations
            WpfEdit uITBEdit = this.UIMyCalculatorv1Window.UITBEdit;
            #endregion

            // Verify that the 'Text' property of 'tb' text box contains '500*2=1000'
            StringAssert.Contains(uITBEdit.Text, this.AssertMultiplicationExpectedValues.UITBEditText, "There is no Operation in the output field");
        }
        
        /// <summary>
        /// 500*2
        /// </summary>
        public void MethodToMultiply()
        {
            #region Variable Declarations
            WpfButton uIItem5Button = this.UIMyCalculatorv1Window.UIItem5Button;
            WpfButton uIItem0Button = this.UIMyCalculatorv1Window.UIItem0Button;
            WpfButton uIItemButton = this.UIMyCalculatorv1Window.UIItemButton;
            WpfButton uIItem2Button = this.UIMyCalculatorv1Window.UIItem2Button;
            WpfButton uIItemButton1 = this.UIMyCalculatorv1Window.UIItemButton1;
            #endregion

            // Click '5' button
            Mouse.Click(uIItem5Button, new Point(24, 12));

            // Double-Click '0' button
            Mouse.DoubleClick(uIItem0Button, new Point(35, 12));

            // Click '*' button
            Mouse.Click(uIItemButton, new Point(27, 16));

            // Click '2' button
            Mouse.Click(uIItem2Button, new Point(27, 19));

            // Click '=' button
            Mouse.Click(uIItemButton1, new Point(41, 12));
        }
        
        /// <summary>
        /// CleanResultField
        /// </summary>
        public void CleanResultField()
        {
            #region Variable Declarations
            WpfButton uIDelButton = this.UIMyCalculatorv1Window.UIDelButton;
            #endregion

            // Click 'Del' button
            Mouse.Click(uIDelButton, new Point(25, 14));
        }
        
        #region Properties
        public virtual mRemoteNGTestParams mRemoteNGTestParams
        {
            get
            {
                if ((this.mmRemoteNGTestParams == null))
                {
                    this.mmRemoteNGTestParams = new mRemoteNGTestParams();
                }
                return this.mmRemoteNGTestParams;
            }
        }
        
        public virtual AssertMultiplicationExpectedValues AssertMultiplicationExpectedValues
        {
            get
            {
                if ((this.mAssertMultiplicationExpectedValues == null))
                {
                    this.mAssertMultiplicationExpectedValues = new AssertMultiplicationExpectedValues();
                }
                return this.mAssertMultiplicationExpectedValues;
            }
        }
        
        public UIMRemoteNGconfConsxmlWindow UIMRemoteNGconfConsxmlWindow
        {
            get
            {
                if ((this.mUIMRemoteNGconfConsxmlWindow == null))
                {
                    this.mUIMRemoteNGconfConsxmlWindow = new UIMRemoteNGconfConsxmlWindow();
                }
                return this.mUIMRemoteNGconfConsxmlWindow;
            }
        }
        
        public UIMyCalculatorv1Window UIMyCalculatorv1Window
        {
            get
            {
                if ((this.mUIMyCalculatorv1Window == null))
                {
                    this.mUIMyCalculatorv1Window = new UIMyCalculatorv1Window();
                }
                return this.mUIMyCalculatorv1Window;
            }
        }
        #endregion
        
        #region Fields
        private mRemoteNGTestParams mmRemoteNGTestParams;
        
        private AssertMultiplicationExpectedValues mAssertMultiplicationExpectedValues;
        
        private UIMRemoteNGconfConsxmlWindow mUIMRemoteNGconfConsxmlWindow;
        
        private UIMyCalculatorv1Window mUIMyCalculatorv1Window;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'mRemoteNGTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class mRemoteNGTestParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'Shift + {Left}' in 'Name' row
        /// </summary>
        public string UINameRowSendKeys = "{Left}";
        
        /// <summary>
        /// Type 'Shift + {Left}' in 'Name' row
        /// </summary>
        public string UINameRowSendKeys1 = "{Left}";
        
        /// <summary>
        /// Type 'Shift + {Left}' in 'Name' row
        /// </summary>
        public string UINameRowSendKeys2 = "{Left}";
        
        /// <summary>
        /// Type 'Shift + {Left}' in 'Name' row
        /// </summary>
        public string UINameRowSendKeys3 = "{Left}";
        
        /// <summary>
        /// Type '{Back}{RShiftKey}AMZ{RShiftKey}Test' in 'Name' row
        /// </summary>
        public string UINameRowSendKeys4 = "{Back}{RShiftKey}AMZ{RShiftKey}Test";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMultiplication'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class AssertMultiplicationExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Text' property of 'tb' text box contains '500*2=1000'
        /// </summary>
        public string UITBEditText = "500*2=1000";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMRemoteNGconfConsxmlWindow : WinWindow
    {
        
        public UIMRemoteNGconfConsxmlWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "mRemoteNG - confCons.xml";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("mRemoteNG - confCons.xml");
            this.WindowTitles.Add("mRemoteNG - confCons.xml - AMZ");
            #endregion
        }
        
        #region Properties
        public WinTitleBar UIMRemoteNGconfConsxmlTitleBar
        {
            get
            {
                if ((this.mUIMRemoteNGconfConsxmlTitleBar == null))
                {
                    this.mUIMRemoteNGconfConsxmlTitleBar = new WinTitleBar(this);
                    #region Search Criteria
                    this.mUIMRemoteNGconfConsxmlTitleBar.WindowTitles.Add("mRemoteNG - confCons.xml");
                    #endregion
                }
                return this.mUIMRemoteNGconfConsxmlTitleBar;
            }
        }
        
        public UIOlvConnectionsWindow UIOlvConnectionsWindow
        {
            get
            {
                if ((this.mUIOlvConnectionsWindow == null))
                {
                    this.mUIOlvConnectionsWindow = new UIOlvConnectionsWindow(this);
                }
                return this.mUIOlvConnectionsWindow;
            }
        }
        
        public UIPropertyGridViewWindow UIPropertyGridViewWindow
        {
            get
            {
                if ((this.mUIPropertyGridViewWindow == null))
                {
                    this.mUIPropertyGridViewWindow = new UIPropertyGridViewWindow(this);
                }
                return this.mUIPropertyGridViewWindow;
            }
        }
        #endregion
        
        #region Fields
        private WinTitleBar mUIMRemoteNGconfConsxmlTitleBar;
        
        private UIOlvConnectionsWindow mUIOlvConnectionsWindow;
        
        private UIPropertyGridViewWindow mUIPropertyGridViewWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIOlvConnectionsWindow : WinWindow
    {
        
        public UIOlvConnectionsWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "olvConnections";
            this.WindowTitles.Add("mRemoteNG - confCons.xml");
            this.WindowTitles.Add("mRemoteNG - confCons.xml - AMZ");
            #endregion
        }
        
        #region Properties
        public WinListItem UIAMZListItem
        {
            get
            {
                if ((this.mUIAMZListItem == null))
                {
                    this.mUIAMZListItem = new WinListItem(this);
                    #region Search Criteria
                    this.mUIAMZListItem.SearchProperties[WinListItem.PropertyNames.Name] = "AMZ";
                    this.mUIAMZListItem.WindowTitles.Add("mRemoteNG - confCons.xml");
                    #endregion
                }
                return this.mUIAMZListItem;
            }
        }
        #endregion
        
        #region Fields
        private WinListItem mUIAMZListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIPropertyGridViewWindow : WinWindow
    {
        
        public UIPropertyGridViewWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "PropertyGridView";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("mRemoteNG - confCons.xml - AMZ");
            #endregion
        }
        
        #region Properties
        public UIPropertyGridViewTable UIPropertyGridViewTable
        {
            get
            {
                if ((this.mUIPropertyGridViewTable == null))
                {
                    this.mUIPropertyGridViewTable = new UIPropertyGridViewTable(this);
                }
                return this.mUIPropertyGridViewTable;
            }
        }
        #endregion
        
        #region Fields
        private UIPropertyGridViewTable mUIPropertyGridViewTable;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIPropertyGridViewTable : WinTable
    {
        
        public UIPropertyGridViewTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinTable.PropertyNames.Name] = "Properties Window";
            this.WindowTitles.Add("mRemoteNG - confCons.xml - AMZ");
            #endregion
        }
        
        #region Properties
        public WinRow UINameRow
        {
            get
            {
                if ((this.mUINameRow == null))
                {
                    this.mUINameRow = new WinRow(this);
                    #region Search Criteria
                    this.mUINameRow.SearchProperties[WinRow.PropertyNames.Name] = "Name";
                    this.mUINameRow.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                    this.mUINameRow.WindowTitles.Add("mRemoteNG - confCons.xml - AMZ");
                    #endregion
                }
                return this.mUINameRow;
            }
        }
        
        public WinRow UIDescriptionRow
        {
            get
            {
                if ((this.mUIDescriptionRow == null))
                {
                    this.mUIDescriptionRow = new WinRow(this);
                    #region Search Criteria
                    this.mUIDescriptionRow.SearchProperties[WinRow.PropertyNames.Name] = "Description";
                    this.mUIDescriptionRow.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                    this.mUIDescriptionRow.WindowTitles.Add("mRemoteNG - confCons.xml - AMZ");
                    #endregion
                }
                return this.mUIDescriptionRow;
            }
        }
        #endregion
        
        #region Fields
        private WinRow mUINameRow;
        
        private WinRow mUIDescriptionRow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMyCalculatorv1Window : WpfWindow
    {
        
        public UIMyCalculatorv1Window()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "MyCalculator v1";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MyCalculator v1");
            #endregion
        }
        
        #region Properties
        public WpfButton UIItem5Button
        {
            get
            {
                if ((this.mUIItem5Button == null))
                {
                    this.mUIItem5Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItem5Button.SearchProperties[WpfButton.PropertyNames.Name] = "5";
                    this.mUIItem5Button.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItem5Button;
            }
        }
        
        public WpfButton UIItem8Button
        {
            get
            {
                if ((this.mUIItem8Button == null))
                {
                    this.mUIItem8Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItem8Button.SearchProperties[WpfButton.PropertyNames.Name] = "8";
                    this.mUIItem8Button.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItem8Button;
            }
        }
        
        public WpfButton UIItem7Button
        {
            get
            {
                if ((this.mUIItem7Button == null))
                {
                    this.mUIItem7Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItem7Button.SearchProperties[WpfButton.PropertyNames.Name] = "7";
                    this.mUIItem7Button.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItem7Button;
            }
        }
        
        public WpfButton UIItemButton
        {
            get
            {
                if ((this.mUIItemButton == null))
                {
                    this.mUIItemButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItemButton.SearchProperties[WpfButton.PropertyNames.Name] = "*";
                    this.mUIItemButton.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItemButton;
            }
        }
        
        public WpfButton UIItem2Button
        {
            get
            {
                if ((this.mUIItem2Button == null))
                {
                    this.mUIItem2Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItem2Button.SearchProperties[WpfButton.PropertyNames.Name] = "2";
                    this.mUIItem2Button.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItem2Button;
            }
        }
        
        public WpfButton UIItemButton1
        {
            get
            {
                if ((this.mUIItemButton1 == null))
                {
                    this.mUIItemButton1 = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItemButton1.SearchProperties[WpfButton.PropertyNames.Name] = "=";
                    this.mUIItemButton1.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItemButton1;
            }
        }
        
        public WpfEdit UITBEdit
        {
            get
            {
                if ((this.mUITBEdit == null))
                {
                    this.mUITBEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUITBEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "tb";
                    this.mUITBEdit.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUITBEdit;
            }
        }
        
        public WpfButton UIItem0Button
        {
            get
            {
                if ((this.mUIItem0Button == null))
                {
                    this.mUIItem0Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItem0Button.SearchProperties[WpfButton.PropertyNames.Name] = "0";
                    this.mUIItem0Button.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItem0Button;
            }
        }
        
        public WpfButton UIDelButton
        {
            get
            {
                if ((this.mUIDelButton == null))
                {
                    this.mUIDelButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIDelButton.SearchProperties[WpfButton.PropertyNames.Name] = "Del";
                    this.mUIDelButton.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIDelButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUIItem5Button;
        
        private WpfButton mUIItem8Button;
        
        private WpfButton mUIItem7Button;
        
        private WpfButton mUIItemButton;
        
        private WpfButton mUIItem2Button;
        
        private WpfButton mUIItemButton1;
        
        private WpfEdit mUITBEdit;
        
        private WpfButton mUIItem0Button;
        
        private WpfButton mUIDelButton;
        #endregion
    }
}

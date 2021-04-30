using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.WinUI.myUserControls.Controls
{
    [ToolboxItem(true)]
    public class myEposta : myTextEdit
    {
        public myEposta()
        {
            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            Properties.Mask.EditMask = @"((((\w+-*)|(-*\w+))+\.*((\w+-*)|(-*\w+))+)|(((\w+-*)|(-*\w+))+))+@((((\w+-*)|(-*\w+))+\.*((\w+-*)|(-*\w+))+)|(((\w+-*)|(-*\w+))+))+\.[A-Za-z]+";
        
        }
    }
}

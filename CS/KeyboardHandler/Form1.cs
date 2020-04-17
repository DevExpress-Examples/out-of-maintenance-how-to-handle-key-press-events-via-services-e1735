using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Portable.Input;
#region #usings
using DevExpress.Services;
using DevExpress.XtraRichEdit;
#endregion #usings

namespace KeyboardHandler {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            labelControl1.Text = "CTRL-C, CTRL-INS, CTRL-X key combinations are blocked for the RichEdit control";
            richEditControl1.LoadDocument("sample_document.rtf", DocumentFormat.Rtf);
            SubstituteKeyboardService();
        }
#region #substservice
        // ...
        private void SubstituteKeyboardService() {
            IKeyboardHandlerService service = 
                richEditControl1.GetService<IKeyboardHandlerService>();
            MyKeyboardHandlerServiceWrapper wrapper = 
                new MyKeyboardHandlerServiceWrapper(service);
            richEditControl1.RemoveService(typeof(IKeyboardHandlerService));
            richEditControl1.AddService(typeof(IKeyboardHandlerService), wrapper);
        }
        //...
        #endregion #substservice
    }
    #region #myservice
    public class MyKeyboardHandlerServiceWrapper : KeyboardHandlerServiceWrapper {
        public MyKeyboardHandlerServiceWrapper(IKeyboardHandlerService service) 
            : base(service) { }

        public override void OnKeyDown(PortableKeyEventArgs e) {
            if(((e.KeyCode == PortableKeys.C) || (e.KeyCode == PortableKeys.X) || 
                (e.KeyCode == PortableKeys.Insert)) && e.Control) {
                return;
            }
            base.OnKeyDown(e);
        }
    }
    #endregion #myservice





}
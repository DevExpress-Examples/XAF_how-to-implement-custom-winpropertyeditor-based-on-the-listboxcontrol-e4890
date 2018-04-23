using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.ExpressApp;
using DevExpress.XtraEditors;

namespace CustomListBoxPropertyEditor.Module.Win.Editors {
    [PropertyEditor(typeof(Object), false)]
    public class CustomListBoxEditor : WinPropertyEditor, IComplexViewItem {
        private IObjectSpace theObjectSpace;
        private ListBoxControl listBox;
        public IObjectSpace ObjectSpace {
            get { return theObjectSpace; }
        }

        public CustomListBoxEditor(Type objectType, IModelMemberViewItem info)
            : base(objectType, info) { }

        //Customize ListBoxControl properties in the CreateControlCore method to support Model properties, such as LookupProperty.
        protected override object CreateControlCore() {
            ControlBindingProperty = "SelectedItem";
            listBox = new ListBoxControl() { ValueMember = Model.LookupProperty };
            if(ImmediatePostData)
                listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            listBox.Items.Clear();
            listBox.DataSource = ObjectSpace.CreateCollection(Model.ModelMember.Type);
            listBox.DisplayMember = Model.LookupProperty;
            return listBox;
        }
        void listBox_SelectedIndexChanged(object sender, EventArgs e) {
            (sender as ListBoxControl).DataBindings["SelectedItem"].WriteValue();
        }
        protected override void Dispose(bool disposing) {
            if(disposing && listBox != null) {
                listBox.SelectedIndexChanged -= listBox_SelectedIndexChanged;
                listBox = null;
            }
            base.Dispose(disposing);
        }
        public void Setup(IObjectSpace objectSpace, XafApplication application) {
            theObjectSpace = objectSpace;
        }
    }
}

<!-- default file list -->
*Files to look at*:

* [Updater.cs](./CS/CustomListBoxPropertyEditor.Module.Win/DatabaseUpdate/Updater.cs) (VB: [Updater.vb](./VB/CustomListBoxPropertyEditor.Module.Win/DatabaseUpdate/Updater.vb))
* [CustomListBoxEditor.cs](./CS/CustomListBoxPropertyEditor.Module.Win/Editors/CustomListBoxEditor.cs) (VB: [CustomListBoxEditor.vb](./VB/CustomListBoxPropertyEditor.Module.Win/Editors/CustomListBoxEditor.vb))
<!-- default file list end -->
# How to implement custom WinPropertyEditor based on the ListBoxControl


<p><strong>Scenario</strong> </p><p>This example illustrates how to implement a custom <a href="http://documentation.devexpress.com/#xaf/clsDevExpressExpressAppWinEditorsWinPropertyEditortopic"><u>WinPropertyEditor</u></a> with <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsListBoxControltopic"><u>ListBoxControl</u></a> to <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3572"><u>edit reference properties</u></a> in DetailView:</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-implement-custom-winpropertyeditor-based-on-the-listboxcontrol-e4890/13.1.9+/media/0da2843c-7788-4cb5-a9b7-c6477e88af1b.png"></p><p><strong><br />
Steps to implement</strong></p><p><strong>1.</strong> Add a new class inherited from the <a href="http://documentation.devexpress.com/#xaf/clsDevExpressExpressAppWinEditorsWinPropertyEditortopic"><u>WinPropertyEditor</u></a> as shown in the <i>Module.Win\Editors\CustomListBoxEditor.</i><i>xx </i>file.</p><p>This editor is inherited from <a href="http://documentation.devexpress.com/#xaf/clsDevExpressExpressAppWinEditorsWinPropertyEditortopic"><u>WinPropertyEditor</u></a> not to configure data bindings manually.<br />
<strong>2.</strong> In the Model Editor, set the <strong>PropertyEditorType</strong> attribute to the custom editor type for a required reference property node, as shown in the example's<i> Model.XAFML</i> file.</p><p><strong>Important notes<br />
1. ListBoxControl</strong> cannot correctly work with the <a href="http://documentation.devexpress.com/#Xaf/DevExpressExpressAppEditorsPropertyEditor_ImmediatePostDatatopic"><u>ImmediatePostData</u></a> property, because it does not contain the <strong>SelectedItemChanged </strong>event. Without this event, ListBoxControl does not send a notification to the binding mechanism when item selection is changed. This behavior was inherited from the default ListBox control. To avoid this behavior, subscribe to the <strong>ListBoxControl.SelectedIndexChanged</strong> and send notifications to the binding manually as shown in the <i>Module.Win\Editors\CustomListBoxEditor</i><i>.xx</i> file .</p><p><strong>2.</strong> This editor is designed to work only in DetailView.</p><p><strong>See also:</strong></p><p><a href="http://documentation.devexpress.com/#xaf/CustomDocument2679"><u>How to: Implement a Property Editor Based on a Custom Control (Windows Forms)</u></a></p>

<br/>



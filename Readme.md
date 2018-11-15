<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/KeyboardHandler/Form1.cs) (VB: [Form1.vb](./VB/KeyboardHandler/Form1.vb))
* [Program.cs](./CS/KeyboardHandler/Program.cs) (VB: [Program.vb](./VB/KeyboardHandler/Program.vb))
<!-- default file list end -->
# How to handle key press events via services


<p>This example illustrates the use of the <strong>KeyboardHandlerService</strong> service substitution to intercept key press events. A new<strong> IKeyboardHandlerService</strong> descendant is created which traps CTRL-C, CTRL-X, CTRL-INS key combinations so they do not work in the RichEditControl.</p>

<br/>



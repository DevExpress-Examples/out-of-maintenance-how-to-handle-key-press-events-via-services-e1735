<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128610306/20.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1735)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/KeyboardHandler/Form1.cs) (VB: [Form1.vb](./VB/KeyboardHandler/Form1.vb))
* [Program.cs](./CS/KeyboardHandler/Program.cs) (VB: [Program.vb](./VB/KeyboardHandler/Program.vb))
<!-- default file list end -->
# How to handle key press events via services


<p>This example illustrates the use of the <strong>KeyboardHandlerService</strong> service substitution to intercept key press events. A new<strong> IKeyboardHandlerService</strong> descendant is created which traps CTRL-C, CTRL-X, CTRL-INS key combinations so they do not work in the RichEditControl.</p>

<br/>



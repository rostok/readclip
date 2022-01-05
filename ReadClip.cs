using System;
using System.Reflection;
using System.Windows.Forms;

[assembly: AssemblyTitle("ReadClip")]
[assembly: AssemblyDescription("reads clipboard text contents and prints it to console")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("rostok - https://github.com/rostok/")]
[assembly: AssemblyProduct("ReadClip")]
[assembly: AssemblyCopyright("Copyright © 2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

namespace ReadClip
{

	public class App
	{
        [STAThread]
		static void Main(string[] args)
		{
             Console.Write(Clipboard.GetText()); // no TextDataFormat.Text parameter as default returns  UnicodeText 
        }
	}
}

using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System;

[assembly: AssemblyTitle("ReadClip")]
[assembly: AssemblyDescription("copies file to clipboard (as a file)")]
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
             Console.Write(Clipboard.GetText(TextDataFormat.Text));
        }
	}
}

using System;
using Gtk;
// https://github.com/marcglx/SimpleTextEditor.git
namespace SimpleTextEditor
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}

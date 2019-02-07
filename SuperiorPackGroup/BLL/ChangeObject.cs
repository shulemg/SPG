//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace SuperiorPackGroup
{
	public class ChangeObject
	{
		public string PropertyName {get; set;}
		public string PrevValue {get; set;}
		public string NewValue {get; set;}
		public int ChangeID {get; set;}
		public DateTime DateChanged {get; set;}
		public int RecordID {get; set;}
	}

	public struct ChangeObjectLookUpKey
	{
		public int ChangeID;
		public string ProperyName;
	}
}
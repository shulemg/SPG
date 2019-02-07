//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;

namespace SuperiorPackGroup
{
	public class Utilities
	{

		public static string FilterQuote(string value)
		{

			return value.Replace("'", "''");

		}

		public static void MakeFormReadOnly(Control container, bool setReadOnly)
		{

			try
			{
//INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
//				Dim control As Control
				foreach (Control control in container.Controls)
				{
					if (control.ToString() == "DevExpress.XtraEditors.GroupControl")
					{
						MakeFormReadOnly(control, setReadOnly);
					}
					try
					{
						((BaseEdit)control).Properties.ReadOnly = setReadOnly;
						continue;
					}
					catch
					{
						continue;
					}
				}
			}
			finally
			{

			}

		}

		public static void MakeGridReadOnly(GridView container, bool setReadOnly)
		{

			try
			{
//INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
//				Dim column As DevExpress.XtraGrid.Columns.GridColumn
				foreach (DevExpress.XtraGrid.Columns.GridColumn column in container.Columns)
				{
					try
					{
						column.OptionsColumn.ReadOnly = setReadOnly;
						continue;
					}
					catch (Exception exception1)
					{
						continue;
					}
				}
			}
			finally
			{

			}

		}

		public static object ChangeType(object value, Type conversionType)
		{

			if (conversionType == null)
			{
				throw new ArgumentNullException("conversionType");
			}

			//If it's not a nullable type, just pass through the parameters to Convert.ChangeType
			if ((conversionType.IsGenericType()) && conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
			{
				// It's a nullable type, so instead of calling Convert.ChangeType directly which would throw a
				// InvalidCastException (per http://weblogs.asp.net/pjohnson/archive/2006/02/07/437631.aspx),
				// determine what the underlying type is
				// If it's null, it won't convert to the underlying type, but that's fine since nulls don't really
				// have a type--so just return null
				// Note: We only do this check if we're converting to a nullable type, since doing it outside
				// would diverge from Convert.ChangeType's behavior, which throws an InvalidCastException if
				// value is null and conversionType is a value type.
				if (value == null)
				{
					return null;
				}

				// It's a nullable type, and not null, so that means it can be converted to its underlying type,
				// so overwrite the passed-in conversion type with this underlying type
				conversionType = Nullable.GetUnderlyingType(conversionType);
			}


			//theType.GetGenericTypeDefinition().Equals(GetType(Nullable(Of )))
			//andalso conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>))
			//Now that we've guaranteed conversionType is something Convert.ChangeType can handle (i.e. not a
			// nullable type), pass the call on to Convert.ChangeType
			return Convert.ChangeType(value, conversionType);

		}

		public static T ChangeType<T>(object value)
		{

			Type conversionType = typeof(T);
			if (conversionType.IsGenericType() && conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
			{
				if (value == null || Convert.IsDBNull(value) || string.IsNullOrEmpty((value == null ? null : Convert.ToString(value))))
				{
					return default(T);
				}
				conversionType = Nullable.GetUnderlyingType(conversionType);
			}
			return ((T)Convert.ChangeType(value, conversionType));

		}



	}

}
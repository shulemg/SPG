//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System;
using static SuperiorPackGroup.Utilities;

namespace SuperiorPackGroup
{
	public partial class LoginXtraForm
	{

		public LoginXtraForm()
		{
			InitializeComponent();
		}

		private int m_Wrong = 0;
		protected UsersBLL m_Users;

		private void okSimpleButton_Click(System.Object sender, EventArgs e)
		{

			try
			{
				m_Users = new UsersBLL();

				string securityLevel = m_Users.GetUserSecurityLevel(FilterQuote(userNameTextEdit.Text), FilterQuote(passwordTextEdit.Text));

				if (string.IsNullOrEmpty(securityLevel))
				{
					m_Wrong += 1;
					if (m_Wrong >= 4)
					{
						MessageBox.Show("Wrong User Name or Password", "Incorrect Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.Close();
						return;
					}
					else
					{
						MessageBox.Show("Wrong User Name or Password", "Incorrect Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
						passwordTextEdit.Text = "";
						userNameTextEdit.Focus();
						userNameTextEdit.SelectionLength = userNameTextEdit.Text.Length;
						return;
					}
				}
				else
				{
					Properties.Settings.Default.UserName = userNameTextEdit.Text;
					Properties.Settings.Default.UserSecurityLevel = securityLevel;
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Encounterd", MessageBoxButtons.OK);
			}

		}

		private void cancelSimpleButton_Click(System.Object sender, EventArgs e)
		{

			this.Close();

		}

        private void LoginXtraForm_Load(object sender, EventArgs e)
        {
            userNameTextEdit.Focus();
        }
    }
}
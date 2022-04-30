/*
 * Created by SharpDevelop.
 * User: student
 * Date: 13-Dec-19
 * Time: 09:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PrimeNumbersInterval
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		bool PrimeNumbers(int x)
		{
			if (x==0||x==1)
			{
				return false;
			}
			for (int i = 2; i <=x/2; i++)
			{

				if (x%i==0)
				{
					return false;
				}
			}
			return true;
		}
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			label4.Text="";
			int a=Convert.ToInt32(textBox1.Text);
			int b=Convert.ToInt32(textBox2.Text);
			for (int i = a; i <=b; i++)
			{
				if(PrimeNumbers(i))
				{
					label4.Text+=i.ToString()+" ";
				}
			}
		}
	}
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TerraMap
{
	public class AboutWindowViewModel : ViewModelBase
	{
		public AboutWindowViewModel()
			: base()
		{
			var assembly = Assembly.GetEntryAssembly();
			var assemblyName = assembly.GetName();

			this.Version = assemblyName.Version.ToString();

			int year = DateTime.Now.Year;
			this.Year = "2014" + (year == 2014 ? null : " - " + year);

			var attr = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
			if (attr.Length > 0)
				this.Description = ((AssemblyDescriptionAttribute)attr[0]).Description;
		}

		private string version;

		public string Version
		{
			get { return version; }
			set
			{
				version = value;
				RaisePropertyChanged();
			}
		}

		private string description;

		public string Description
		{
			get { return description; }
			set
			{
				description = value;
				RaisePropertyChanged();
			}
		}

		private string year;

		public string Year
		{
			get { return year; }
			set
			{
				year = value;
				RaisePropertyChanged();
			}
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteType : DMYOModel
	{
		private string m_description;

		public WasteType()
		{

		}

		public string Description
		{
			get
			{
				return m_description;
			}
			set
			{
				m_description = value;
			}
		}
	}	
}

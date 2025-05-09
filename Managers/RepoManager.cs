﻿using dmyo_oop_final_assigment.Repositories;

namespace dmyo_oop_final_assigment.Managers
{
	public static class RepoManager
	{
		public static WasteTypeRepo m_wasteType = new WasteTypeRepo();

		public static WasteUnitRepo m_wasteUnit = new WasteUnitRepo();

		//

		public static WasteTypeRepo WasteType
		{
			get
			{
				return m_wasteType;
			}
		}

		public static WasteUnitRepo WasteUnit
		{
			get
			{
				return m_wasteUnit;
			}
		}
	}
}

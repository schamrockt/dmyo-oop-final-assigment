﻿using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Repositories
{
	public class WasteUnitRepo : DMYORepo<WasteUnit>
	{
		public override string Name => "WasteUnit";

		public override string[] Params => new string[] { "name", "abbreviation" };

		public override void SetParameters(WasteUnit wasteUnit, SqlCommand command)
		{
			command.Parameters.AddWithValue("@name", wasteUnit.Name);
			command.Parameters.AddWithValue("@abbreviation", wasteUnit.Abbreviation);
		}

		public override WasteUnit GetModel(SqlDataReader reader)
		{
			return new WasteUnit()
			{
				Name = reader.GetString(1),
				Abbreviation = reader.GetString(2)
			};
		}
	}
}
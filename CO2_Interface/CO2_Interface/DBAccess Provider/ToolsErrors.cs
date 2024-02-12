using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; // fournisseur de la bdd access

namespace CO2_Interface.DBAccess_Provider
{
	class ToolsErrors
	{
		internal static OleDbDataAdapter AdapterErrors = new OleDbDataAdapter();

		internal static OleDbConnection connexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;"
																			+
																		@"Data Source=..\..\..\DB_UserAccess.accdb;Cache Authentication=True"); // connexion a la bdd

		internal static void Config()
		{
			string InsertError_Command = "INSERT into ErrorsTable(Ref,Type,_Date, Description) values(@Ref, @Type, @_Date, @Description);";


			OleDbCommand Insert_Command = new OleDbCommand(InsertError_Command, connexion);
			// associer les commandes aux adapteurs correspondants
			AdapterErrors.InsertCommand = Insert_Command;
			//  mapping -> la table de bdd usertable est lié a la table local usertable
			AdapterErrors.TableMappings.Add("ErrorsTable", "Errors");
			// définition des types dans la bdd 
			AdapterErrors.InsertCommand.Parameters.Add("@Ref", OleDbType.Integer, 40, "Ref");
			AdapterErrors.InsertCommand.Parameters.Add("@Type", OleDbType.Integer, 40, "Type");
			AdapterErrors.InsertCommand.Parameters.Add("@_Date", OleDbType.Date, 100, "_Date");
			AdapterErrors.InsertCommand.Parameters.Add("@Description", OleDbType.VarChar, 100, "Description");
	}
}
}


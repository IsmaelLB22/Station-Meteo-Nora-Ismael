using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System;

namespace CO2_Interface.DBAccess_Provider
{
	class Adapter
	{
		internal static void Insert(string Name, string Pass, int Rights)
		{
			// mettre les données insérées par l'utilisateur donc le nom + pass + droits d'accès
			Tools.Adapter.InsertCommand.Parameters[0].Value = Name;
			Tools.Adapter.InsertCommand.Parameters[1].Value = Pass;
			Tools.Adapter.InsertCommand.Parameters[2].Value = Rights;

			try
			{
				// insertion de l'user dans la bdd
				Tools.connexion.Open();

				int buffer = Tools.Adapter.InsertCommand.ExecuteNonQuery();

				//Deconexion afin d'viter les conflits
				Tools.connexion.Close();

				if (buffer != 0) MessageBox.Show("User successfully inserted");
				else MessageBox.Show("User not inserted");


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " file:ADAPTER");

				/************* CODE EXAMEN: DEBUT *************/

				Data.Errors err = new Data.Errors(4, ex.Message + " file:DataReader");
				SerialDataHandler.Reception.LoadErrors(err, Data.Tables.DataErrors);

				/************* CODE EXAMEN: FIN **************/
			}
			finally
			{
				Tools.connexion.Close();
			}
		}

		/************* CODE EXAMEN: DEBUT *************/
		internal static void InsertErrors(int reference, int type, string date, string description)
		{
			// mettre les données insérées par l'utilisateur donc le nom + pass + droits d'accès
			ToolsErrors.AdapterErrors.InsertCommand.Parameters[0].Value = reference;
			ToolsErrors.AdapterErrors.InsertCommand.Parameters[1].Value = type;
			ToolsErrors.AdapterErrors.InsertCommand.Parameters[2].Value = date;
			ToolsErrors.AdapterErrors.InsertCommand.Parameters[3].Value = description;

			try
			{
				// insertion de l'user dans la bdd
				ToolsErrors.connexion.Open();

				int buffer = ToolsErrors.AdapterErrors.InsertCommand.ExecuteNonQuery();

				//Deconexion afin d'viter les conflits
				ToolsErrors.connexion.Close();

				if (buffer != 0) MessageBox.Show("Error successfully inserted");
				else MessageBox.Show("Error not inserted");


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " file:ADAPTER");


				Data.Errors err = new Data.Errors(4, ex.Message + " file:DataReader");
				SerialDataHandler.Reception.LoadErrors(err, Data.Tables.DataErrors);

				
			}
			finally
			{
				ToolsErrors.connexion.Close();
			}
		}
		/************* CODE EXAMEN: FIN **************/
		internal static void Delete(String Name)
		{
			Tools.Adapter.DeleteCommand.Parameters[0].Value = Name;

			try
			{
				//Supprimer l'user de la bdd -> dmd si faut l'implémenter dans le projet
				Tools.connexion.Open();

				int buffer = Tools.Adapter.DeleteCommand.ExecuteNonQuery();

				if (buffer != 0) MessageBox.Show("User successfully deleted");
				else MessageBox.Show("User not found");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " file:Adapter");

				/************* CODE EXAMEN: DEBUT *************/

				Data.Errors err = new Data.Errors(4, ex.Message + " file:DataReader");
				SerialDataHandler.Reception.LoadErrors(err, Data.Tables.DataErrors);

				
			}
			finally
			{
				Tools.connexion.Close();
			}
		}

		/************* CODE EXAMEN: FIN **************/
		internal static void Fill(DataSet dataset, string TableName, string DB_Table, DataGridView Grid)
		{
			//ajouter les lignes présentes dans le data set dans la bdd
			dataset.Tables["Users"].Clear();

			Tools.Adapter.SelectCommand = new OleDbCommand("SELECT * from " + DB_Table + ";", Tools.connexion);

			try
			{
				Tools.connexion.Open();

				Tools.Adapter.Fill(dataset.Tables["Users"]);

				Grid.DataSource = dataset.Tables["Users"];
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

				/************* CODE EXAMEN: DEBUT *************/

				Data.Errors err = new Data.Errors(4, ex.Message + " file:DataReader");
				SerialDataHandler.Reception.LoadErrors(err, Data.Tables.DataErrors);

				/************* CODE EXAMEN: FIN **************/
			}
			finally
			{
				Tools.connexion.Close();
			}
		}
		internal static void Update(DataTable Table)
		{
			// maj des données en faisant un insert,update ou delete pour chaque lignes insérées maj ou supprimées
			try
			{
				Tools.connexion.Open();

				Tools.Adapter.Update(Table);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

				/************* CODE EXAMEN: DEBUT *************/

				Data.Errors err = new Data.Errors(4, ex.Message + " file:DataReader");
				SerialDataHandler.Reception.LoadErrors(err, Data.Tables.DataErrors);

				/************* CODE EXAMEN: FIN **************/
			}
			finally
			{
				Tools.connexion.Close();
			}
		}
	}
}

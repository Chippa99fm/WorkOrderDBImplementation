using System.Windows.Forms;

namespace DBImplementation
{
	public partial class HR : Form
	{
		public HR(string connectionStr)
		{
			InitializeComponent();
			string query = "SELECT workers.id, full_name, position_types.name as position, service_stations.name as stantion FROM db_new.workers" +
				" JOIN db_new.position_types ON position_types.id = workers.position_id " +
				"JOIN db_new.service_stations ON service_stations.id = workers.station_id";
			workersTable.DataSource = MysqlManager.executeAdapter(connectionStr, query);
		}
	}
}

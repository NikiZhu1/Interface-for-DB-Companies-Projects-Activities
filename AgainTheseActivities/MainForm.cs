using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AgainTheseActivities
{
    public partial class MainForm : Form
    {
        private readonly string userLogin;

        public MainForm(string userLogin)
        {
            InitializeComponent();
            this.userLogin = userLogin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new();
                db.OpenConnection();

                MySqlCommand command = new(
                    @"SELECT id, title FROM companies",
                    db.GetConnection()
                );

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Загружаем компании
                    var companyNode = new TreeNode(reader["title"].ToString());
                    treeView.Nodes.Add(companyNode);
                    companyNode.ContextMenuStrip = CompanyContextMenu;

                    //Загружаем проекты
                    LoadProjects(Convert.ToInt32(reader["id"]), companyNode);
                }

                reader.Close();
                db.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка при загрузке компаний!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadProjects(int companyId, TreeNode companyNode)
        {
            try
            {
                DB db = new();
                db.OpenConnection();

                MySqlCommand command = new(
                    @"SELECT * FROM projects 
                      WHERE company_id = @companyId",
                    db.GetConnection()
                );
                command.Parameters.Add("@companyId", MySqlDbType.VarChar).Value = companyId;

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Загружаем проекты
                    var projectNode = new TreeNode(reader["title"].ToString());
                    companyNode.Nodes.Add(projectNode);
                    projectNode.ContextMenuStrip = ProjectContextMenu;

                    // Загружаем активности для этого проекта
                    LoadActivities(Convert.ToInt32(reader["id"]), projectNode);
                }

                reader.Close();
                db.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка при загрузке проектов!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadActivities(int projectId, TreeNode projectNode)
        {
            try
            {
                DB db = new();
                db.OpenConnection();

                MySqlCommand command = new(
                    @"SELECT * FROM activities 
                      WHERE project_id = @projectId",
                    db.GetConnection()
                );
                command.Parameters.Add("@projectId", MySqlDbType.VarChar).Value = projectId;

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var activityNode = new TreeNode(reader["title"].ToString());
                    projectNode.Nodes.Add(activityNode);
                    activityNode.ContextMenuStrip = ProjectContextMenu;
                }

                reader.Close();
                db.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка при загрузке активностей!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

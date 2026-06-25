using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Human_Resource_Management_System
{
    public partial class ucDepartment : UserControl
    {
        // Ito 'yung connection string papunta sa Aiven Cloud database niyo.
        // Naka-set na dito 'yung user, password, at kung anong database ang gagamitin (infomanagement).
        MySqlConnection con = new MySqlConnection("Server=mysql-pupacadportal-pupacadportal.h.aivencloud.com;Port=15204;Database=infomanagement;Uid=avnadmin;Pwd=AVNS_NkQkMQ8Xz4LbsPhB0h7;SslMode=Required;");

        public ucDepartment()
        {
            InitializeComponent();
        }

        private void ucDepartment_Load(object sender, EventArgs e)
        {
            // Kapag nag-load 'yung screen, tatawagin agad 'yung LoadData para may laman na 'yung table
            LoadData();
        }


        // 1. LOAD DATA GAMIT ANG STORED PROCEDURE
        private void LoadData()
        {
            try
            {
                con.Open(); // Buksan ang connection sa database

                // Tatawagin natin dito 'yung SP_GetAllDepartment na ginawa natin sa MySQL Workbench
                MySqlCommand cmd = new MySqlCommand("SP_GetAllDepartment", con);

                // Sabihin sa C# na Stored Procedure ang gagamitin natin, hindi raw SQL string
                cmd.CommandType = CommandType.StoredProcedure;

                // Kukunin 'yung data at ilalagay sa DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // I-di-display 'yung nakuha nating data doon sa DataGridView sa UI
                dgwDepartmentlist.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); } // Laging i-close ang connection pagkatapos
        }

        // Function para i-clear 'yung mga textboxes kapag nag-add o nag-delete na
        private void ClearFields()
        {
            txtboxID.Clear();
            txtboxName.Clear();
            cmbLocation.SelectedIndex = -1;
            txtboxIDupdate.Clear();
            txtboxNameupdate.Clear();
            cmbLocationupdate.SelectedIndex = -1;
        }


        // VALIDATION FUNCTIONS (Pang-check kung may blanko)

        private bool IsAddInputValid()
        {
            // Bawal ang blankong ID at Name
            if (string.IsNullOrWhiteSpace(txtboxID.Text) || string.IsNullOrWhiteSpace(txtboxName.Text))
            {
                MessageBox.Show("Please fill in all the required text fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Dapat may napili na location sa dropdown
            if (cmbLocation.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbLocation.Text))
            {
                MessageBox.Show("Please select a valid Location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsUpdateInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtboxIDupdate.Text) || string.IsNullOrWhiteSpace(txtboxNameupdate.Text))
            {
                MessageBox.Show("Please select a department from the list or fill in the text fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbLocationupdate.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbLocationupdate.Text))
            {
                MessageBox.Show("Please select a valid Location to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // BUTTON CLICK EVENTS (Dito nagaganap 'yung CRUD)

        // 2. ADD RECORD BUTTON
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsAddInputValid()) return; // Pag may blanko, wag ituloy

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SP_AddDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Importante: Dapat tugma 'yung parameter names ("p_DeptID") dito sa ginawa nating variables doon sa Workbench
                cmd.Parameters.AddWithValue("p_DeptID", txtboxID.Text);
                cmd.Parameters.AddWithValue("p_DeptName", txtboxName.Text);
                cmd.Parameters.AddWithValue("p_Loc", cmbLocation.Text);

                cmd.ExecuteNonQuery(); // I-run 'yung query para ma-save
                MessageBox.Show("Record Added Successfully!");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally
            {
                con.Close();
                LoadData(); // I-refresh 'yung table para lumabas 'yung bagong add
                ClearFields(); // I-reset 'yung textboxes
            }
        }

        // 3. UPDATE RECORD BUTTON
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!IsUpdateInputValid()) return;

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SP_UpdateDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Ipapasa natin 'yung bagong laman ng textboxes papunta sa database
                cmd.Parameters.AddWithValue("p_DeptID", txtboxIDupdate.Text);
                cmd.Parameters.AddWithValue("p_DeptName", txtboxNameupdate.Text);
                cmd.Parameters.AddWithValue("p_Loc", cmbLocationupdate.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully!");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally
            {
                con.Close();
                LoadData(); // I-refresh 'yung table
            }
        }

        // 4. DELETE RECORD BUTTON
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SP_DeleteDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // ID lang ang kailangan para mag-delete ng row
                cmd.Parameters.AddWithValue("p_DeptID", txtboxIDupdate.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully!");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally
            {
                con.Close();
                LoadData();
                ClearFields();
            }
        }

        // CLEAR BUTTON (Manual na pag-clear ng textboxes)
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Kapag may kinlick na row sa listahan, mapupunta 'yung data sa Update textboxes
        private void dgwDepartmentlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgwDepartmentlist.Rows[e.RowIndex];
                txtboxIDupdate.Text = row.Cells[0].Value?.ToString();
                txtboxNameupdate.Text = row.Cells[1].Value?.ToString();
                cmbLocationupdate.Text = row.Cells[2].Value?.ToString();
            }
        }

        private void label1_Click_2(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}
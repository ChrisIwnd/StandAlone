using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone
{
    public partial class MainForm : Form
    {
        ///Querrys

        /// <summary>
        /// The querryes that are nessecary for our form.
        /// </summary>
        string SqlUsers = "SELECT * FROM users";
        string SqlUsersTypes = "SELECT * FROM users_types";
        string SqlLogin = "SELECT * FROM login";
        string SqlProvince = "SELECT * FROM province";
        string SqlBusinesses_Types = "SELECT * FROM businesses_types";
        string SqlDays = "SELECT * FROM days";
        string SqlLocation = "SELECT * FROM location";
        string SqlWorkHours = "SELECT * FROM work_hours";
        string SqlBusiness = "SELECT * FROM businesses";
        string SqlRatings = "SELECT * FROM ratings";
        string SqlReservation = "SELECT * FROM reservation";
        string SqlMunicipality = "SELECT * FROM municipality";

        ///Constructor

        /// <summary>
        /// In form constractor the connection is created.
        /// Then the DataGridView of the form(MainGridView) is fill up with the users table from databse.
        /// </summary>
        public MainForm()
        {
            DCom.Connect();
            

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.DialogResult == DialogResult.No)
            {
                loginForm.Dispose();
                DCom.Close();
                Environment.Exit(1);
            }
            else
            {
                InitializeComponent();
                MainGridView.DataSource = DCom.GetData(SqlUsers);

            }
        }

        ///User Tools
        
        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any user type exist. If a user type exists the form for the creation
        /// of a user(AddUser) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the AddUser form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIAddUser_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("users_types") == false)
            {
                MessageBox.Show("There are no users types that reqiured to create a user.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserForms.AddUser AddUser = new UserForms.AddUser();
                AddUser.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlUsers);
                AddUser.Dispose();
            }
        }

        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any user exist. If a user exists the form for the edit
        /// of a user(EditUser) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the EditUser form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIEditUser_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("users") == false)
            {
                MessageBox.Show("There are no users to edit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserForms.EditUser EditUser = new UserForms.EditUser();
                EditUser.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlUsers);
                EditUser.Dispose();
            }
        }

        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any user exist. If a user exists the form for the delete
        /// of a user(DeleteUser) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the DeleteUser form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIDeleteUser_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("users") == false)
            {
                MessageBox.Show("There are no users to delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserForms.DeleteUser DeleteUser = new UserForms.DeleteUser();
                DeleteUser.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlUsers);
                DeleteUser.Dispose();
            }
        }

        ///User Types Tools

        /// <summary>
        /// When the client clicks this Menu Item the form for the creation
        /// of a user type(AddUsersTypes) is opening for any actions.
        /// Then refill the MainGridView and then dispose the EditUser form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIAddUserT_Click(object sender, EventArgs e)
        {
            UserTypesForms.AddUsersTypes AddUsersTypes = new UserTypesForms.AddUsersTypes();
            AddUsersTypes.ShowDialog();
            MainGridView.DataSource = DCom.GetData(SqlUsersTypes);
            AddUsersTypes.Dispose();
        }

        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any user type exist. If a user type exists the form for the edit
        /// of a user type(EditUsersTypes) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the EditUsersTypes form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIEditUserT_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("users_types") == false)
            {
                MessageBox.Show("There are no users types to edit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserTypesForms.EditUsersTypes EditUsersTypes = new UserTypesForms.EditUsersTypes();
                EditUsersTypes.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlUsersTypes);
                EditUsersTypes.Dispose();
            }
        }

        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any user type exist. If a user type exists the form for the delete
        /// of a user type(DeleteUsersTypes) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the DeleteUsersTypes form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIDeleteUserT_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("users_types") == false)
            {
                MessageBox.Show("There are no users types to delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserTypesForms.DeleteUsersTypes DeleteUsersTypes = new UserTypesForms.DeleteUsersTypes();
                DeleteUsersTypes.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlUsersTypes);
                DeleteUsersTypes.Dispose();
            }
        }

        ///Login Tools

        /// <summary>
        /// When the client clicks this Menu Item the form for the creation
        /// of a login info(AddLogin) is opening for any actions.
        /// Then refill the MainGridView and then dispose the AddLogin form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIAddLogin_Click(object sender, EventArgs e)
        {
            DataTable DT = DCom.GetData("SELECT count(*) FROM users where users.Username NOT IN (SELECT login.Username FROM login)");

            if (DCom.CountCheckTable("users") == false)
            {
                MessageBox.Show("There are no users to create a login account.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((long)DT.Rows[0][0] == 0)
            {
                MessageBox.Show("All the users have a login account.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoginForms.AddLogin AddLogin = new LoginForms.AddLogin();
                AddLogin.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlLogin);
                AddLogin.Dispose();
            }
        }

        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any login info exist. If a login info exists the form for the delete
        /// of a login(DeleteLogin) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the DeleteLogin form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIDeleteLogin_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("login") == false)
            {
                MessageBox.Show("There are no login info to delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoginForms.DeleteLogin DeleteLogin = new LoginForms.DeleteLogin();
                DeleteLogin.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlLogin);
                DeleteLogin.Dispose();
            }
        }

        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any user type exist. If a login info exists the form for the edit
        /// of a login info(EditLogin) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the EditUsersTypes form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIEditLogin_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("login") == false)
            {
                MessageBox.Show("There are no login info to edit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoginForms.EditLogin EditLogin = new LoginForms.EditLogin();
                EditLogin.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlLogin);
                EditLogin.Dispose();
            }
        }

        ///Province Tools

        /// <summary>
        /// When the client clicks this Menu Item the form for the creation
        /// of a province(AddProvince) is opening for any actions.
        /// Then refill the MainGridView and then dispose the EditUser form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIAddProvince_Click(object sender, EventArgs e)
        {
            ProvinceForms.AddProvince AddProvince = new ProvinceForms.AddProvince();
            AddProvince.ShowDialog();
            MainGridView.DataSource = DCom.GetData(SqlProvince);
            AddProvince.Dispose();
        }

        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any province exist. If a province exists the form for the edit
        /// of a province(EditProvince) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the EditProvince form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIEditProvince_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("province") == false)
            {
                MessageBox.Show("There are no province to edit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ProvinceForms.EditProvince EditProvince = new ProvinceForms.EditProvince();
                EditProvince.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlProvince);
                EditProvince.Dispose();
            }
        }

        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any province exist. If a province exists the form for the delete
        /// of a province(DeleteProvince) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the DeleteProvince form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIDeleteProvince_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("province") == false)
            {
                MessageBox.Show("There are no province to edit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ProvinceForms.DeleteProvince DeleteProvince = new ProvinceForms.DeleteProvince();
                DeleteProvince.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlProvince);
                DeleteProvince.Dispose();
            }
        }

        ///Businesses Types Tools

        /// <summary>
        ///When the client clicks this Menu Item the form for the creation
        /// of a businesses type(AddBusinessesTypes) is opening for any actions.
        /// Then refill the MainGridView and then dispose the AddBusinessesTypes form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIAddBusinessesTypes_Click(object sender, EventArgs e)
        {
            Businesses_Types.AddBusinessesTypes AddBusinesses_Types = new Businesses_Types.AddBusinessesTypes();
            AddBusinesses_Types.ShowDialog();
            MainGridView.DataSource = DCom.GetData(SqlBusinesses_Types);
            AddBusinesses_Types.Dispose();
        }

        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any businesses types exist. If a businesses types exists the form for the delete
        /// of a businesses types(DeleteBusinessesTypes) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the DeleteBusinessesTypes form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIDeleteBusinessesTypes_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("businesses_types") == false)
            {
                MessageBox.Show("There are no businesses types to delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Businesses_Types.DeleteBusinessesTypes DeleteBusinessesTypes = new Businesses_Types.DeleteBusinessesTypes();
                DeleteBusinessesTypes.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlBusinesses_Types);
                DeleteBusinessesTypes.Dispose();
            }
        }

        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any businesses types exist. If a businesses types exists the form for the edit
        /// of a businesses types(EditBusinessesTypes) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the EditBusinessesTypes form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIEditBusinessesTypes_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("businesses_types") == false)
            {
                MessageBox.Show("There are no businesses types to edit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Businesses_Types.EditBusinessesTypes EditBusinessesTypes = new Businesses_Types.EditBusinessesTypes();
                EditBusinessesTypes.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlBusinesses_Types);
                EditBusinessesTypes.Dispose();
            }
        }

        ///Days Tools

        /// <summary>
        /// When the client clicks this Menu Item the form for the creation
        /// of a day(AddDays) is opening for any actions.
        /// Then refill the MainGridView and then dispose the AddDays form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIAddDays_Click(object sender, EventArgs e)
        {
            DaysForms.AddDays AddDays = new DaysForms.AddDays();
            AddDays.ShowDialog();
            MainGridView.DataSource = DCom.GetData(SqlDays);
            AddDays.Dispose();
        }

        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any day exist. If a day exists the form for the delete
        /// of a day(DeleteDays) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the DeleteDays form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIDeleteDays_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("days") == false)
            {
                MessageBox.Show("There are no days to delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DaysForms.DeleteDays DeleteDays = new DaysForms.DeleteDays();
                DeleteDays.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlDays);
                DeleteDays.Dispose();
            }
        }

        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any day exist. If a day exists the form for the edit
        /// of a day(EditDays) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the EditDays form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIEditDays_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("days") == false)
            {
                MessageBox.Show("There are no days to edit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DaysForms.EditDays EditDays = new DaysForms.EditDays();
                EditDays.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlDays);
                EditDays.Dispose();
            }
        }

        ///Location Tools

        /// <summary>
        /// When the client clicks this Menu Item the form for the creation
        /// of a location(AddLocation) is opening for any actions.
        /// Then refill the MainGridView and then dispose the Location form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIAddLocation_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("municipality") == false)
            {
                MessageBox.Show("There are no municipality to create a location.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LocationForms.AddLocation AddLocation = new LocationForms.AddLocation();
                AddLocation.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlLocation);
                AddLocation.Dispose();
            }
        }

        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any day exist. If a day exists the form for the delete
        /// of a location(DeleteLocation) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the DeleteLocation form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIDeleteLocation_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("location") == false)
            {
                MessageBox.Show("There are no location to delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LocationForms.DeleteLocation DeleteLocation = new LocationForms.DeleteLocation();
                DeleteLocation.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlLocation);
                DeleteLocation.Dispose();
            }
        }

        /// <summary>
        /// When the client clicks this Menu Item the system first checks if
        /// any day exist. If a day exists the form for the edit
        /// of a location(EditLocation) is opening for any actions.
        /// Else shows a error message.
        /// Then refill the MainGridView and then dispose the EdiLocation form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIEditLocation_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("location") == false)
            {
                MessageBox.Show("There are no location to edit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LocationForms.EditLocation EditLocation = new LocationForms.EditLocation();
                EditLocation.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlLocation);
                EditLocation.Dispose();
            }
        }

        ///Work Hours Tools

        private void MIAddWorkHours_Click(object sender, EventArgs e)
        {
            WorkHoursForms.AddWorkHours AddWorkHours = new WorkHoursForms.AddWorkHours();
            AddWorkHours.ShowDialog();
            MainGridView.DataSource = DCom.GetData(SqlWorkHours);
            AddWorkHours.Dispose();
        }

        private void MIDeleteWorkHours_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("work_hours") == false)
            {
                MessageBox.Show("There are no work hours to delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                WorkHoursForms.DeleteWorkHours DeleteWorkHours = new WorkHoursForms.DeleteWorkHours();
                DeleteWorkHours.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlWorkHours);
                DeleteWorkHours.Dispose();
            }
        }

        private void MIEditWorkHours_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("work_hours") == false)
            {
                MessageBox.Show("There are no work hours to edit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                WorkHoursForms.EditWorkHours EditWorkHours = new WorkHoursForms.EditWorkHours();
                EditWorkHours.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlWorkHours);
                EditWorkHours.Dispose();
            }
        }

        ///Business Tools

        private void MIAddBusiness_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("businesses_types") == false)
            {
                MessageBox.Show("There are no businesses types to create a business.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DCom.CountCheckTable("location") == false)
            {
                MessageBox.Show("There are no location to create a business.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DCom.CountCheckTable("work_hours") == false)
            {
                MessageBox.Show("There are no work hours to create a business.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DCom.CountCheckTable("users") == false)
            {
                MessageBox.Show("There are no users to create a business.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BusinessForms.AddBusinessForm AddBusinessForm = new BusinessForms.AddBusinessForm();
                AddBusinessForm.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlBusiness);
                AddBusinessForm.Dispose();
            }
          
        }

        private void MIDeleteBusiness_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("businesses") == false)
            {
                MessageBox.Show("There are no business to delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BusinessForms.DeleteBusinessForm DeleteBusinessForm = new BusinessForms.DeleteBusinessForm();
                DeleteBusinessForm.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlBusiness);
                DeleteBusinessForm.Dispose();
            }
        }

        private void MIEditBusiness_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("businesses") == false)
            {
                MessageBox.Show("There are no business to edit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BusinessForms.EdiBusinessForm EdiBusinessForm = new BusinessForms.EdiBusinessForm();
                EdiBusinessForm.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlBusiness);
                EdiBusinessForm.Dispose();
            }          
        }

        ///Ratings Tools

        private void MIAddRatings_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("users") == false)
            {
                MessageBox.Show("There are no user to create a rating.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RatingsForms.AddRatingsForm AddRatingsForms = new RatingsForms.AddRatingsForm();
                AddRatingsForms.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlRatings);
                AddRatingsForms.Dispose();
            }
        }

        private void MIDeleteRatings_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("ratings") == false)
            {
                MessageBox.Show("There are no ratings to delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RatingsForms.DeleteRatingsForm DeleteRatingsForm = new RatingsForms.DeleteRatingsForm();
                DeleteRatingsForm.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlRatings);
                DeleteRatingsForm.Dispose();
            }
        }

        private void MIEditRatings_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("ratings") == false)
            {
                MessageBox.Show("There are no ratings to delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RatingsForms.EditRatingsForm EditRatingsForm = new RatingsForms.EditRatingsForm();
                EditRatingsForm.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlRatings);
                EditRatingsForm.Dispose();
            }
        }

        ///Reservation Tools

        private void MIAddReservation_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("users") == false)
            {
                MessageBox.Show("There are no users to create a reservation.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DCom.CountCheckTable("businesses") == false)
            {
                MessageBox.Show("There are no businesses to create a reservation.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReservationForms.AddReservationForm AddReservationForm = new ReservationForms.AddReservationForm();
                AddReservationForm.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlReservation);
                AddReservationForm.Dispose();
            }
        }

        private void MIDeleteReservation_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("reservation") == false)
            {
                MessageBox.Show("There are no reservations to delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReservationForms.DeleteReservationForm DeleteReservationForm = new ReservationForms.DeleteReservationForm();
                DeleteReservationForm.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlReservation);
                DeleteReservationForm.Dispose();
            }
        }

        private void MIEditReservation_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("reservation") == false)
            {
                MessageBox.Show("There are no reservations to edit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReservationForms.EditReservationForm EditReservationForm = new ReservationForms.EditReservationForm();
                EditReservationForm.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlReservation);
                EditReservationForm.Dispose();
            }

        }

        //Municipality Tools

        private void MIAddMunicipality_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("province") == false)
            {
                MessageBox.Show("There are no provinces to create a municipality.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Municipality.AddMunicipality addMunicipality = new Municipality.AddMunicipality();
                addMunicipality.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlMunicipality);
                addMunicipality.Dispose();
            }
        }

        private void MIDeleteMunicipality_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("muminipality") == false)
            {
                MessageBox.Show("There are no municipalities to delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Municipality.DeleteMunicipality DeleteMunicipality = new Municipality.DeleteMunicipality();
                DeleteMunicipality.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlMunicipality);
                DeleteMunicipality.Dispose();
            }
        }

        private void MIEditMunicipality_Click(object sender, EventArgs e)
        {
            if (DCom.CountCheckTable("muminipality") == false)
            {
                MessageBox.Show("There are no municipalities to edit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Municipality.EditMunicipality EditMunicipality = new Municipality.EditMunicipality();
                EditMunicipality.ShowDialog();
                MainGridView.DataSource = DCom.GetData(SqlMunicipality);
                EditMunicipality.Dispose();
            }
        }

        ///View Tools

        /// <summary>
        /// When the client clicks this Menu Item the source
        /// of DataGridView fills this the table users from Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIViewUsers_Click(object sender, EventArgs e)
        {
            MainGridView.DataSource = DCom.GetData(SqlUsers);
        }

        /// <summary>
        /// When the client clicks this Menu Item the source
        /// of DataGridView fills this the table users_types from Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIViewUserTypes_Click(object sender, EventArgs e)
        {
            MainGridView.DataSource = DCom.GetData(SqlUsersTypes);
        }

        /// <summary>
        /// When the client clicks this Menu Item the source
        /// of DataGridView fills this the table login from Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIViewLogin_Click(object sender, EventArgs e)
        {
            MainGridView.DataSource = DCom.GetData(SqlLogin);
        }

        /// <summary>
        /// When the client clicks this Menu Item the source
        /// of DataGridView fills this the table province from Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIViewProvince_Click(object sender, EventArgs e)
        {
            MainGridView.DataSource = DCom.GetData(SqlProvince);
        }

        /// <summary>
        /// When the client clicks this Menu Item the source
        /// of DataGridView fills this the table businesses_types from Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIViewBusinessesTypes_Click(object sender, EventArgs e)
        {
            MainGridView.DataSource = DCom.GetData(SqlBusinesses_Types);
        }

        /// <summary>
        /// When the client clicks this Menu Item the source
        /// of DataGridView fills this the table Days from Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIViewDays_Click(object sender, EventArgs e)
        {
            MainGridView.DataSource = DCom.GetData(SqlDays);
        }

        /// <summary>
        /// When the client clicks this Menu Item the source
        /// of DataGridView fills this the table Location from Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIViewLocation_Click(object sender, EventArgs e)
        {
            MainGridView.DataSource = DCom.GetData(SqlLocation);
        }

        /// <summary>
        /// When the client clicks this Menu Item the source
        /// of DataGridView fills this the table WorkHours from Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIViewWorkHours_Click(object sender, EventArgs e)
        {
            MainGridView.DataSource = DCom.GetData(SqlWorkHours);
        }

        /// <summary>
        /// When the client clicks this Menu Item the source
        /// of DataGridView fills this the table Businesses from Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIViewBusinesses_Click(object sender, EventArgs e)
        {
            MainGridView.DataSource = DCom.GetData(SqlBusiness);
        }

        /// <summary>
        /// When the client clicks this Menu Item the source
        /// of DataGridView fills this the table Ratings from Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIViewRatings_Click(object sender, EventArgs e)
        {
            MainGridView.DataSource = DCom.GetData(SqlRatings);
        }

        /// <summary>
        /// When the client clicks this Menu Item the source
        /// of DataGridView fills this the table Reservation from Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIViewReservation_Click(object sender, EventArgs e)
        {
            MainGridView.DataSource = DCom.GetData(SqlReservation);
        }
    }
}

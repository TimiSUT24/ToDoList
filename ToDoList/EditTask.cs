﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ToDoList
{
    public partial class EditTask : Form
    {
        private string currentUser { get; set; }
        private string task { get; set; }
        private string description { get; set; }
        private string priority { get; set; }
        private DateTime dateStart { get; set; }
        private DateTime dateEnd { get; set; }
        public EditTask(string userName, string Task)
        {
            InitializeComponent();
            currentUser = userName;
            task = Task;
            TaskLabel.Text = "Current Task: \n" + task;
            ShowDetailsInText();
        }
        public void ShowDetailsInText()
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
            {
                conn.Open();
                string ShowDetails = "SELECT DESCRIPTION,PRIORITY,DATESTART,DATEEND FROM TASKS WHERE TASK = @TASK";
                using (SqlCommand cmd = new SqlCommand(ShowDetails, conn))
                {
                    cmd.Parameters.AddWithValue("@TASK", task);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DescriptionText.Text = reader["DESCRIPTION"].ToString();
                            PriorityList.Text = reader["PRIORITY"].ToString();
                            DateStart.Value = Convert.ToDateTime(reader["DATESTART"]).Date;
                            DateEnd.Value = Convert.ToDateTime(reader["DATEEND"]).Date;
                        }
                    }
                }
            }
        }      
        private void EditTasks()
        {          
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
            {
                conn.Open();
                string editTask = "UPDATE TASKS SET DESCRIPTION = @DESCRIPTION, PRIORITY = @PRIORITY, DATESTART = @DATESTART, DATEEND = @DATEEND WHERE TASK = @TASK";

                using (SqlCommand cmd = new SqlCommand(editTask, conn))
                {
                    cmd.Parameters.AddWithValue("@TASK", task);
                    cmd.Parameters.AddWithValue("@DESCRIPTION", description);
                    cmd.Parameters.AddWithValue("@PRIORITY", priority);
                    cmd.Parameters.AddWithValue("@DATESTART", dateStart);
                    cmd.Parameters.AddWithValue("@DATEEND", dateEnd);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void EditsTask_Click(object sender, EventArgs e)
        {
            EdittedDetails();
            EditTasks();
            MessageBox.Show(task, description);
        }      
        private void EdittedDetails()
        {
            description = DescriptionText.Text;
            priority = PriorityList.Text;
            dateStart = DateStart.Value.Date;
            dateEnd = DateEnd.Value.Date;           
        }
        
    }
}

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using lab8IsHere.Models;

namespace lab8IsHere.Pages
{
    public class IndexModel : PageModel
    {
        private readonly string _connStr;

        public List<Teacher> TeachersList { get; set; } = new List<Teacher>();

        [BindProperty]
        public Teacher EditingTeacher { get; set; }

        public bool IsEditing { get; set; } = false;

        public IndexModel(IConfiguration configuration)
        {
            _connStr = configuration.GetConnectionString("DefaultConnection");
        }

        public void OnGet()
        {
            LoadData();
        }

        public IActionResult OnPostSave(int code, string fullName, string position, string department, string degree, string discipline, bool isUpdating)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                string query;

                if (isUpdating)
                {
                    query = "UPDATE Teachers SET FullName = @FIO, Position = @Pos, Department = @Dep, Degree = @Deg, Discipline = @Disc " +
                            "WHERE TeacherCode = @Code";
                }
                else
                {
                    query = "INSERT INTO Teachers (TeacherCode, FullName, Position, Department, Degree, Discipline) " +
                            "VALUES (@Code, @FIO, @Pos, @Dep, @Deg, @Disc)";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.AddWithValue("@FIO", fullName);
                cmd.Parameters.AddWithValue("@Pos", position);
                cmd.Parameters.AddWithValue("@Dep", department);
                cmd.Parameters.AddWithValue("@Deg", string.IsNullOrEmpty(degree) ? DBNull.Value : (object)degree);
                cmd.Parameters.AddWithValue("@Disc", discipline);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            return RedirectToPage();
        }

        public IActionResult OnPostDelete(int codeToDelete)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Teachers WHERE TeacherCode = @Code", conn);
                cmd.Parameters.AddWithValue("@Code", codeToDelete);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            return RedirectToPage();
        }

        public void OnPostEdit(int codeToEdit, string fullName, string position, string department, string degree, string discipline)
        {
            IsEditing = true;
            EditingTeacher = new Teacher
            {
                TeacherCode = codeToEdit,
                FullName = fullName,
                Position = position,
                Department = department,
                Degree = degree,
                Discipline = discipline
            };

            LoadData();
        }

        private void LoadData()
        {
            TeachersList.Clear();
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Teachers", conn);
                conn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        TeachersList.Add(new Teacher
                        {
                            TeacherCode = dr.GetInt32(0),
                            FullName = dr.GetString(1),
                            Position = dr.GetString(2),
                            Department = dr.GetString(3),
                            Degree = dr.IsDBNull(4) ? "" : dr.GetString(4),
                            Discipline = dr.GetString(5)
                        });
                    }
                }
            }
        }
    }
}
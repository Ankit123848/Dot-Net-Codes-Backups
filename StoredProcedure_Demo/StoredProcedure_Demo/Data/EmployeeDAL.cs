using StoredProcedure_Demo.Models;
using System.Data;
using System.Data.SqlClient;

namespace StoredProcedure_Demo.Data
{
	public class EmployeeDAL
	{
		private readonly string connectionString;

		public EmployeeDAL(IConfiguration configuration)
		{
			connectionString = configuration.GetConnectionString("DefaultConnection");
		}

		public DataTable GetEmployees()
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				using (SqlCommand cmd = new SqlCommand("GetEmployees", conn))
				{
					cmd.CommandType = CommandType.StoredProcedure;

					using (SqlDataAdapter da = new SqlDataAdapter(cmd))
					{
						DataTable dt = new DataTable();
						da.Fill(dt);
						return dt;
					}
				}
			}
		}
        public void CreateEmployee(string firstName, string lastName, string department)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("dbo.CreateEmployee", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Department", department);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEmployee(int employeeId, string firstName, string lastName, string department)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("UpdateEmployee", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Department", department);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("DeleteEmployee", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Employee GetEmployeeById(int employeeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetEmployeeById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Map the data to an Employee object
                            Employee employee = new Employee
                            {
                                EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
                                FirstName = Convert.ToString(reader["FirstName"]),
                                LastName = Convert.ToString(reader["LastName"]),
                                Department = Convert.ToString(reader["Department"])
                            };

                            return employee;
                        }
                    }
                }
            }

            return null; // Return null if the employee with the given ID is not found
        }

    }
}

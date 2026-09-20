using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Retainer
{
    public static class db
    {
        public static bool InsertRecord(
                    string date,
                    string eyes,
                    string oralCavity,
                    string kidneys,
                    string liver,
                    string stomach,
                    string intestines,
                    string circulatorySystem,
                    string respiratoryTract,
                    string head,
                    string heart)
        {
            try
            {
                string dbPath = Path.Combine("..", "..", "db", "health.db");
                dbPath = Path.GetFullPath(dbPath);
                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();
                    string sql = @"INSERT INTO symptoms (
                        date,
                        eyes,
                        oral_cavity,
                        kidneys,
                        liver,
                        stomach,
                        intestines,
                        circulatory_system,
                        respiratory_tract,
                        head,
                        heart
                    ) VALUES (
                        @date,
                        @eyes,
                        @oral_cavity,
                        @kidneys,
                        @liver,
                        @stomach,
                        @intestines,
                        @circulatory_system,
                        @respiratory_tract,
                        @head,
                        @heart
                    );";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        // Привязка параметров к переданным значениям
                        command.Parameters.AddWithValue("@date", string.IsNullOrEmpty(date) ? (object)DBNull.Value : date);
                        command.Parameters.AddWithValue("@eyes", string.IsNullOrEmpty(eyes) ? (object)DBNull.Value : eyes);
                        command.Parameters.AddWithValue("@oral_cavity", string.IsNullOrEmpty(oralCavity) ? (object)DBNull.Value : oralCavity);
                        command.Parameters.AddWithValue("@kidneys", string.IsNullOrEmpty(kidneys) ? (object)DBNull.Value : kidneys);
                        command.Parameters.AddWithValue("@liver", string.IsNullOrEmpty(liver) ? (object)DBNull.Value : liver);
                        command.Parameters.AddWithValue("@stomach", string.IsNullOrEmpty(stomach) ? (object)DBNull.Value : stomach);
                        command.Parameters.AddWithValue("@intestines", string.IsNullOrEmpty(intestines) ? (object)DBNull.Value : intestines);
                        command.Parameters.AddWithValue("@circulatory_system", string.IsNullOrEmpty(circulatorySystem) ? (object)DBNull.Value : circulatorySystem);
                        command.Parameters.AddWithValue("@respiratory_tract", string.IsNullOrEmpty(respiratoryTract) ? (object)DBNull.Value : respiratoryTract);
                        command.Parameters.AddWithValue("@head", string.IsNullOrEmpty(head) ? (object)DBNull.Value : head);
                        command.Parameters.AddWithValue("@heart", string.IsNullOrEmpty(heart) ? (object)DBNull.Value : heart);

                        command.ExecuteNonQuery();
                       
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            return true;
                            //MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            return false;
                            //MessageBox.Show("Не удалось сохранить данные.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Произошла ошибка: {e.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }        
    }
}

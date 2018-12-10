using domain.interfaces.dal;
using domain.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dal.contexts
{
    public class UserContext : IUserRepository
    {
        ConnectionDB connectionDB = new ConnectionDB();

        public void create(User entity)
        {
            throw new NotImplementedException();
        }

        public void delete(User entity)
        {
            throw new NotImplementedException();
        }

        public void deleteById(int id)
        {
            throw new NotImplementedException();
        }

        public User login(string username, string password)
        {
            User output;
            try
            {
                using (MySqlConnection conn = connectionDB.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT `Name`, `Password` FROM `user` WHERE `user`.`Name` = @username AND `user`.`Password` = @password";

                    MySqlParameter[] parameters = {
                        new MySqlParameter("@username", username),
                        new MySqlParameter("@password", password)
                    };

                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.Add(parameters);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User read(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> readAll()
        {
            throw new NotImplementedException();
        }

        public void udate(User entity)
        {
            throw new NotImplementedException();
        }
    }
}

﻿using Airlines.Models;
using Airlines.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Airlines.Services
{
    public class Server
    {
        private static Server? _instance;

        public static Server GetServer()
        {
            if (_instance == null)
            {
                _instance = new Server();
            }

            return _instance;
        }

        public Role GetRole(int roleID)
        {
            var connection = DatabaseState.GetDatabaseState().GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT `id`, `name`, `level` FROM `role` WHERE `id` = @id";
            command.Parameters.AddWithValue("@id", roleID);

            var reader = command.ExecuteReader();

            reader.Read();

            string name = reader.GetString("name");
            RoleLevel level = (RoleLevel)reader.GetInt32("level");

            reader.Close();
            connection.Close();

            return new Role() 
            {
                Id = roleID,
                Name = name,
                Level = level
            };
        }

        public User GetUser(int userID)
        {
            var connection = DatabaseState.GetDatabaseState().GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT `id`, `username`, `password_hash`, `role_id`, " +
                "`surname`, `name`, `middlename` FROM `user` WHERE `id` = @id";
            command.Parameters.AddWithValue("@id", userID);

            var reader = command.ExecuteReader();

            reader.Read();

            string username = reader.GetString("username");
            string passwordHash = reader.GetString("password_hash");
            int roleID = reader.GetInt32("role_id");
            string surname = reader.GetString("surname");
            string name = reader.GetString("name");
            string middlename = reader.GetString("middlename");

            reader.Close();
            connection.Close();

            var role = GetRole(roleID);

            return new User()
            {
                Id = userID,
                Username = username,
                PasswordHash = passwordHash,
                Role = role,
                Surname = surname,
                Name = name,
                Middlename = middlename
            };
        }

        public User Login(string username, string password)
        {
            var connection = DatabaseState.GetDatabaseState().GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT `id` FROM `user` WHERE `username` LIKE @username";
            command.Parameters.AddWithValue("@username", username);

            var reader = command.ExecuteReader();

            reader.Read();

            if (!reader.HasRows)
            {
                reader.Close();
                throw new LoginFailedException();
            }

            int userID = reader.GetInt32("id");
            var user = GetUser(userID);
            var passwordHash = Utils.CreateMD5(password);

            reader.Close();

            if (user.PasswordHash != passwordHash)
            {
                throw new LoginFailedException();
            }

            return user;
        }

        public User CreateUser(CreateUser createUser)
        {
            var connection = DatabaseState.GetDatabaseState().GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO user " +
                "(`username`, `password_hash`, `surname`, `name`, `middlename`)" +
                "VALUES (@username, @password_hash, @surname, @name, @middlename)";

            command.Parameters.AddWithValue("@username", createUser.Username);
            command.Parameters.AddWithValue("@password_hash", Utils.CreateMD5(createUser.Password));
            command.Parameters.AddWithValue("@surname", createUser.Surname);
            command.Parameters.AddWithValue("@name", createUser.Name);
            command.Parameters.AddWithValue("@middlename", createUser.Middlename);

            command.ExecuteNonQuery();
            connection.Close();

            int userID = (int)command.LastInsertedId;

            return GetUser(userID);
        }
    }
}

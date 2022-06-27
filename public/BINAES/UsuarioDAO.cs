﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BCrypt;

namespace BINAES
{
    public static class UsuarioDAO
    {
        // Validación del Login
        public static Usuario Login (Usuario usuario)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    string query = "SELECT U.nombre, U.contrasenia, R.rol 'rol' FROM USUARIO U INNER JOIN ROL R ON U.id_rol = R.id WHERE nombre = @nombre";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@nombre", usuario.nombre);
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!BCrypt.Net.BCrypt.Verify(usuario.contrasenia, reader["contrasenia"].ToString()))
                            {
                                usuario = null;
                            }
                            else
                            {
                                usuario.rol = reader["rol"].ToString();
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception e)
            {

            }
            return usuario;
        }

        // CREATE

        public static bool Crear(Usuario user)
        {
            bool exito = true;
            try
            {
                user.contrasenia = BCrypt.Net.BCrypt.HashPassword(user.contrasenia);
                string cadena = Properties.Resources.CadenaConexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "INSERT INTO USUARIO (nombre, institucion, direccion, telefono, fotografia, email, contrasenia, id_rol, id_ocupacion) VALUES (@nombre, @institucion, @direccion, @telefono, @fotografia, @email, @contrasenia, @id_rol, @id_ocupacion)";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@nombre", user.nombre);
                    command.Parameters.AddWithValue("@institucion", user.institucion);
                    command.Parameters.AddWithValue("@direccion", user.direccion);
                    command.Parameters.AddWithValue("@telefono", user.telefono);
                    command.Parameters.AddWithValue("@fotografia", user.fotografia);
                    command.Parameters.AddWithValue("@email", user.email);
                    command.Parameters.AddWithValue("@contrasenia", user.contrasenia);
                    command.Parameters.AddWithValue("@id_rol", user.id_rol);
                    command.Parameters.AddWithValue("@id_ocupacion", user.id_ocupacion);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                exito = false;
                Console.WriteLine(e.Message);
            }
            return exito;
        }

        // READ
        public static List<Usuario> Leer()
        {
            List<Usuario> list = new List<Usuario>();
            try
            {
                
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    string query = @"SELECT U.id, U.nombre, U.institucion, U.direccion, U.telefono, U.fotografia, U.email, R.rol, O.ocupacion FROM USUARIO U
                        INNER JOIN ROL R
                            ON R.id = U.id_rol
                        INNER JOIN OCUPACION_USUARIO O
                            ON O.id = U.id_ocupacion";
                    SqlCommand command = new SqlCommand(query, conn);
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.id = Convert.ToInt32(reader["id"]);
                                usuario.nombre = reader["nombre"].ToString();
                                usuario.institucion = reader["institucion"].ToString();
                                usuario.direccion = reader["direccion"].ToString();
                                usuario.telefono = reader["telefono"].ToString();
                                usuario.fotografia = reader["fotografia"].ToString();
                                usuario.email = reader["email"].ToString();
                                usuario.rol = reader["rol"].ToString();
                                usuario.ocupacion = reader["ocupacion"].ToString();
                                list.Add(usuario);
                            }
                            DataGridViewComposer.GetNullProperties(list[0]);
                        }
                    }
                    conn.Close();
                }
            } 
            catch (Exception e)
            {

            }
            return list;
        }
        public static Usuario LeerPorId(int id)
        {
            Usuario usuario = new Usuario();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    string query = "SELECT * FROM USUARIO";
                    SqlCommand command = new SqlCommand(query, conn);
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                usuario.id = Convert.ToInt32(reader["id"]);
                                usuario.nombre = reader["nombre"].ToString();
                                usuario.institucion = reader["institucion"].ToString();
                                usuario.direccion = reader["direccion"].ToString();
                                usuario.telefono = reader["telefono"].ToString();
                                usuario.fotografia = reader["fotografia"].ToString();
                                usuario.email = reader["email"].ToString();
                                usuario.id_rol = reader["id_rol"].ToString();
                                usuario.id_ocupacion = Convert.ToInt32(reader["id_ocupacion"]);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception e)
            {

            }
            return usuario;
        }

        // UPDATE

        public static bool Editar(Usuario user)
        {
            bool exito = true;
            try
            {
                string cadena = Properties.Resources.CadenaConexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "UPDATE USUARIO SET nombre = @nombre, institucion = @institucion, direccion = @direccion, telefono = @telefono, fotografia = @fotografia, email = @email, id_rol = @id_rol, id_ocupacion = @id_ocupacion WHERE id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", user.nombre);
                    command.Parameters.AddWithValue("@institucion", user.institucion);
                    command.Parameters.AddWithValue("@direccion", user.direccion);
                    command.Parameters.AddWithValue("@telefono", user.telefono);
                    command.Parameters.AddWithValue("@fotografia", user.fotografia);
                    command.Parameters.AddWithValue("@email", user.email);
                    command.Parameters.AddWithValue("@id_rol", user.id_rol);
                    command.Parameters.AddWithValue("@id_ocupacion", user.id_ocupacion);
                    command.Parameters.AddWithValue("@id", user.id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                exito = false;
            }
            return exito;
        }
    }
}



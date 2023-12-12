using Biblioteca_de_Clases;
using MySql.Data.MySqlClient;

namespace DataAgencia
{
    public class Agencia_Ado
    {
        private static string connectionString;
        private static MySqlConnection connection;
        private static MySqlCommand command;

        static Agencia_Ado()
        {
            Agencia_Ado.connectionString = "Server=localhost;Database=agencia_de_turismo;Uid=root;Pwd=;";
            Agencia_Ado.connection = new MySqlConnection(Agencia_Ado.connectionString);
            Agencia_Ado.command = new MySqlCommand();
            Agencia_Ado.command.CommandType = System.Data.CommandType.Text;
            Agencia_Ado.command.Connection = Agencia_Ado.connection;
        }

        #region PASAJERO

        // --------------- INSERT ---------------
        public static bool AltaPasajero(Pasajero unPasajero)
        {
            bool resultado = true;

            try
            {
                string query = "INSERT INTO pasajero(DNI, Apellido, Nombre, Edad, Genero, Email, Estado) " +
                    "VALUES (@dni, @apellido, @nombre, @edad, @genero, @email, @estado)";

                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@dni", unPasajero.DNI);
                command.Parameters.AddWithValue("@apellido", unPasajero.Apellido);
                command.Parameters.AddWithValue("@nombre", unPasajero.Nombre);
                command.Parameters.AddWithValue("@edad", unPasajero.Edad);
                command.Parameters.AddWithValue("@genero", unPasajero.Genero);
                command.Parameters.AddWithValue("@email", unPasajero.Email);
                command.Parameters.AddWithValue("@estado", unPasajero.Estado);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"ERROR: {ex.Message}");
                resultado = false;
            }
            finally
            {
                connection.Close();
            }

            return resultado;
        }

        // --------------- SELECT ---------------        
        public static List<Pasajero> MostrarPasajeros()
        {
            List<Pasajero> lista = new List<Pasajero>();

            try
            {
                string query = "SELECT * FROM pasajero";
                connection.Open();
                command.CommandText = query;

                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        int id_Pasajero = dataReader.GetInt32(0);
                        int dni = dataReader.GetInt32(1);
                        string apellido = dataReader.GetString(2);
                        string nombre = dataReader.GetString(3);
                        int edad = dataReader.GetInt32(4);
                        string genero = dataReader.GetString(5);
                        string email = dataReader.GetString(6);
                        string estado = dataReader.GetString(7);

                        Pasajero nuevoPasajero = new Pasajero(id_Pasajero, dni, apellido, nombre, edad, genero, email, estado);

                        lista.Add(nuevoPasajero);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"POSIBLE ERROR EN CONECCION, Consulte listados en Backup " +
                    $"e informe a un representante de sistemas el siguiente error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return lista;
        }        

        public static Pasajero SeleccionarPasajeroPorId(int idFiltro)
        {
            Pasajero unPasajero = new Pasajero();

            try
            {
                string query = "SELECT* FROM pasajero WHERE Id_Pasajero = @id_Pasajero";
                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id_Pasajero", idFiltro);

                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        int id_Pasajero = dataReader.GetInt32(0);
                        int dni = dataReader.GetInt32(1);
                        string apellido = dataReader.GetString(2);
                        string nombre = dataReader.GetString(3);
                        int edad = dataReader.GetInt32(4);
                        string genero = dataReader.GetString(5);
                        string email = dataReader.GetString(6);
                        string estado = dataReader.GetString(7);

                        unPasajero.Id_Pasajero = id_Pasajero;
                        unPasajero.DNI = dni;
                        unPasajero.Apellido = apellido;
                        unPasajero.Nombre = nombre;
                        unPasajero.Edad = edad;
                        unPasajero.Genero = genero;
                        unPasajero.Email = email;
                        unPasajero.Estado = estado;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return unPasajero;
        }

        public static Pasajero SeleccionarPorPasajero(Pasajero unPasajero)
        {
            try
            {
                string query = "SELECT* FROM pasajero WHERE DNI = @dni OR Id_Pasajero = @id_Pasajero";
                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@id_Pasajero", unPasajero.Id_Pasajero);
                command.Parameters.AddWithValue("@dni", unPasajero.DNI);

                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        int id_Pasajero = dataReader.GetInt32(0);
                        int dni = dataReader.GetInt32(1);
                        string apellido = dataReader.GetString(2);
                        string nombre = dataReader.GetString(3);
                        int edad = dataReader.GetInt32(4);
                        string genero = dataReader.GetString(5);
                        string email = dataReader.GetString(6);
                        string estado = dataReader.GetString(7);

                        unPasajero.Id_Pasajero = id_Pasajero;
                        unPasajero.DNI = dni;
                        unPasajero.Apellido = apellido;
                        unPasajero.Nombre = nombre;
                        unPasajero.Edad = edad;
                        unPasajero.Genero = genero;
                        unPasajero.Email = email;
                        unPasajero.Estado = estado;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return unPasajero;
        }

        public static int MostrarProxIdPasajero()
        {
            int proxId = -1;
            try
            {
                string query = "SELECT AUTO_INCREMENT FROM information_schema.tables " +
                    "WHERE table_schema = 'agencia_de_turismo' AND TABLE_NAME = 'pasajero';";

                connection.Open();
                command.CommandText = query;

                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        proxId = dataReader.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"ERROR EN CLASE ADO: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return proxId;
        }

        // --------------- UPDATE ---------------        
        public static bool ModificarPasajero(Pasajero unPasajero)
        {
            bool resultado = true;

            try
            {
                string query = "UPDATE pasajero SET DNI = @dni, Apellido = @apellido, Nombre = @nombre," +
                    " Edad = @edad, Genero = @genero, Email = @email, Estado = @estado " +
                    "WHERE DNI = @dni OR Id_Pasajero = @id_Pasajero";

                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@id_Pasajero", unPasajero.Id_Pasajero);
                command.Parameters.AddWithValue("@dni", unPasajero.DNI);
                command.Parameters.AddWithValue("@apellido", unPasajero.Apellido);
                command.Parameters.AddWithValue("@nombre", unPasajero.Nombre);
                command.Parameters.AddWithValue("@edad", unPasajero.Edad);
                command.Parameters.AddWithValue("@genero", unPasajero.Genero);
                command.Parameters.AddWithValue("@email", unPasajero.Email);
                command.Parameters.AddWithValue("@estado", unPasajero.Estado);


                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
                resultado = false;
            }
            finally
            {
                connection.Close();
            }

            return resultado;
        }
                         
        public static bool InactivarEstadoPasajero(Pasajero unPasajero)
        {
            bool resultado = true;

            try
            {
                string query = "UPDATE pasajero SET Estado = 'Inactivo' WHERE Id_Pasajero = @id_Pasajero OR DNI = @dni;";

                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@dni", unPasajero.DNI);
                command.Parameters.AddWithValue("@apellido", unPasajero.Apellido);
                command.Parameters.AddWithValue("@nombre", unPasajero.Nombre);
                command.Parameters.AddWithValue("@edad", unPasajero.Edad);
                command.Parameters.AddWithValue("@genero", unPasajero.Genero);
                command.Parameters.AddWithValue("@email", unPasajero.Email);
                command.Parameters.AddWithValue("@estado", unPasajero.Estado);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
                resultado = false;
            }
            finally
            {
                connection.Close();
            }

            return resultado;
        }

        // --------------- DELETE ---------------
        public static bool EliminarPasajero(int dniBorrar)
        {
            bool resultado = true;

            try
            {
                string query = "DELETE FROM pasajero WHERE DNI = @dni";

                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@dni", dniBorrar);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"ERROR: {ex.Message}");
                resultado = false;
            }
            finally
            {
                connection.Close();
            }

            return resultado;
        }

        public static bool EliminarPasajero(Pasajero unPasajero)
        {
            bool resultado = true;

            try
            {
                string query = "DELETE FROM pasajero WHERE Id_Pasajero = @id_Pasajero OR DNI = @dni";

                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@id_Pasajero", unPasajero.Id_Pasajero);
                command.Parameters.AddWithValue("@dni", unPasajero.DNI);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
                resultado = false;
            }
            finally
            {
                connection.Close();
            }

            return resultado;
        }

        #endregion

        #region PASAJERO_INACTIVO

        // --------------- INSERT ---------------
        public static bool AltaPasajeroInactivo(Pasajero unPasajero)
        {
            bool resultado = true;

            try
            {
                string query = "INSERT INTO pasajero_inactivo (Id_Pasajero, DNI, Apellido, Nombre, Edad, Genero, Email, Estado) " +
                    "VALUES (@id_Pasajero, @dni, @apellido, @nombre, @edad, @genero, @email, @estado)";

                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@id_Pasajero", unPasajero.Id_Pasajero);
                command.Parameters.AddWithValue("@dni", unPasajero.DNI);
                command.Parameters.AddWithValue("@apellido", unPasajero.Apellido);
                command.Parameters.AddWithValue("@nombre", unPasajero.Nombre);
                command.Parameters.AddWithValue("@edad", unPasajero.Edad);
                command.Parameters.AddWithValue("@genero", unPasajero.Genero);
                command.Parameters.AddWithValue("@email", unPasajero.Email);
                command.Parameters.AddWithValue("@estado", unPasajero.Estado);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"ERROR: {ex.Message}");
                resultado = false;
            }
            finally
            {
                connection.Close();
            }

            return resultado;
        }

        // --------------- SELECT ---------------
        public static List<Pasajero> MostrarPasajerosInactivos()
        {
            List<Pasajero> lista = new List<Pasajero>();

            try
            {
                string query = "SELECT * FROM pasajero_inactivo";
                connection.Open();
                command.CommandText = query;

                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        int id_Pasajero = dataReader.GetInt32(0);
                        int dni = dataReader.GetInt32(1);
                        string apellido = dataReader.GetString(2);
                        string nombre = dataReader.GetString(3);
                        int edad = dataReader.GetInt32(4);
                        string genero = dataReader.GetString(5);
                        string email = dataReader.GetString(6);
                        string estado = dataReader.GetString(7);

                        Pasajero nuevoPasajero = new Pasajero(id_Pasajero, dni, apellido, nombre, edad, genero, email, estado);

                        lista.Add(nuevoPasajero);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"POSIBLE ERROR EN CONECCION, Consulte listados en Backup " +
                    $"e informe a un representante de sistemas el siguiente error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return lista;
        }

        // --------------- UPDATE ---------------
        public static bool ModificarPasajeroInactivo(Pasajero unPasajero)
        {
            bool resultado = true;

            try
            {
                string query = "UPDATE pasajero_inactivo SET DNI = @dni, Apellido = @apellido, Nombre = @nombre," +
                    " Edad = @edad, Genero = @genero, Email = @email, Estado = @estado " +
                    "WHERE DNI = @dni OR Id_Pasajero = @id_Pasajero";

                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@id_Pasajero", unPasajero.Id_Pasajero);
                command.Parameters.AddWithValue("@dni", unPasajero.DNI);
                command.Parameters.AddWithValue("@apellido", unPasajero.Apellido);
                command.Parameters.AddWithValue("@nombre", unPasajero.Nombre);
                command.Parameters.AddWithValue("@edad", unPasajero.Edad);
                command.Parameters.AddWithValue("@genero", unPasajero.Genero);
                command.Parameters.AddWithValue("@email", unPasajero.Email);
                command.Parameters.AddWithValue("@estado", unPasajero.Estado);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
                resultado = false;
            }
            finally
            {
                connection.Close();
            }

            return resultado;
        }

        #endregion

        #region PROYECCIONES

        // --------------- SELECT ---------------        
        public static List<Pasajero> MostrarTodosPasajeros()
        {
            List<Pasajero> lista = new List<Pasajero>();

            try
            {
                string query = "SELECT * FROM pasajero, pasajero_inactivo";
                connection.Open();
                command.CommandText = query;

                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        int id_Pasajero = dataReader.GetInt32(0);
                        int dni = dataReader.GetInt32(1);
                        string apellido = dataReader.GetString(2);
                        string nombre = dataReader.GetString(3);
                        int edad = dataReader.GetInt32(4);
                        string genero = dataReader.GetString(5);
                        string email = dataReader.GetString(6);
                        string estado = dataReader.GetString(7);

                        Pasajero nuevoPasajero = new Pasajero(id_Pasajero, dni, apellido, nombre, edad, genero, email, estado);

                        lista.Add(nuevoPasajero);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"POSIBLE ERROR EN CONECCION, Consulte listados en Backup " +
                    $"e informe a un representante de sistemas el siguiente error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return lista;
        }








        //SELECT* FROM pasajero ORDER BY Id_Pasajero ASC
        //SELECT* FROM pasajero ORDER BY Id_Pasajero DESC
        //SELECT* FROM pasajero ORDER BY Apellido ASC
        //SELECT* FROM pasajero ORDER BY Apellido DESC
        //SELECT* FROM pasajero WHERE Edad<18


        /*ID y descripción de los paquetes que se lleven a cabo en Puerto Madryn. 
         * +Ordenarlos de modo descendente por su precio base*/
        /*SELECT PT.Id_paquete, PT.Descripcion
        FROM paquete_turistico AS PT
        WHERE PT.Descripcion LIKE "%Puerto Madryn%"
        ORDER BY PT.Precio_base DESC*/

        /*Recaudación acumulada agrupada por paquete turístico.
        Detallarlos y ordenar los totales de manera descendente*/
        /*SELECT SUM(C.Precio_final) AS Total, PT.Descripcion
        FROM contratacion AS C
        JOIN paquete_turistico AS PT ON C.Id_paquete=PT.Id_paquete
        GROUP BY PT.Id_paquete
        ORDER BY Total DESC*/

        /*Apellido, nombre y Email de los pasajeros que hayan realizado una
        contratación con tarjeta de crédito. Ordenar por apellido.*/
        /*SELECT P.Apellido, P.Nombre, P.Email
        FROM pasajero AS P
        JOIN contratacion AS C ON P.Id_Pasajero=C.Id_pasajero
        WHERE C.Medio_pago="Tarjeta credito"
        ORDER BY P.Apellido*/

        /*Descripcióny fecha de excursiones que corresponden al paquete
        turístico con ID 8 .
        SELECT E.Descripcion, E.Fecha_excursion
        FROM excursion as E
        JOIN anexo_excursion as A on E.Id_excursion=A.Id_excursion
        WHERE A.Id_paquete = 8*/

        /*Cantidad de paquetes realizados por mujeres en el mes de Mayo.
        SELECT COUNT(C.Id_paquete)
        FROM contratacion AS C
        JOIN pasajero AS P on C.Id_pasajero=P.Id_Pasajero
        JOIN paquete_turistico AS PT on C.Id_paquete=PT.Id_paquete
        WHERE P.Genero="Femenino" AND month(PT.Fecha)=5*/

        /*ID, Apellido y edad de los pasajeros entre 20 y 40 años que
        abonaron en efectivo detallando descripción del paquete turístico
        y ordenados de forma descendente según su edad.
        SELECT P.Id_Pasajero,P.Apellido,P.Edad, PT.Descripcion
        FROM pasajero as P
        JOIN contratacion as C on P.Id_Pasajero=C.Id_pasajero
        JOIN paquete_turistico as PT ON C.Id_paquete=PT.Id_paquete
        WHERE P.Edad BETWEEN 20 AND 40 AND C.Medio_pago="Efectivo"
        ORDER by P.Edad DESC*/
        #endregion

    }
}

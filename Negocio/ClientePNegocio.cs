﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Negocio
{
    public class ClientePNegocio
    {
        public List<ClienteP> Listar()
        {
            ClienteP aux;
            List<ClienteP> lstClientesP = new List<ClienteP>();
            AccesoDB conexion = null;

            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT NOMBRE, APELLIDO, IDCLIENTE, DNICUIT, EMAIL FROM CLIENTES " +
                    "WHERE ACTIVO = 1 AND TIPOCLIENTE = 'P'");

                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new ClienteP { Datos = new Contacto() };
                    aux.Datos.Nombre = (string)conexion.Lector["NOMBRE"];
                    aux.Datos.Apellido = (string)conexion.Lector["APELLIDO"];
                    aux.IdCliente = (int)conexion.Lector["IDCLIENTE"];
                    aux.Datos.IdContacto = aux.IdCliente;
                    aux.Datos.Dni = (int)Convert.ToInt64(conexion.Lector["DNICUIT"]);
                    aux.Datos.Email = (string)conexion.Lector["EMAIL"];

                    lstClientesP.Add(aux);
                }
                return lstClientesP;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.CheckearConexion() == true)
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public void Agregar(ClienteP nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO CLIENTES(NOMBRE,APELLIDO,DNICUIT,EMAIL,TIPOCLIENTE,ACTIVO) VALUES (@nombre, @apellido, @dni, @email, 'P', 1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Datos.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", nuevo.Datos.Apellido);
                conexion.Comando.Parameters.AddWithValue("@dni", nuevo.Datos.Dni);
                conexion.Comando.Parameters.AddWithValue("@email", nuevo.Datos.Email);

                conexion.AbrirConexion();
                conexion.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.CheckearConexion() == true)
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public void Modificar(ClienteP c)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE CLIENTES SET NOMBRE = @nombre, APELLIDO = @apellido, DNICUIT = @dni, EMAIL = @email WHERE IDCLIENTE = @idcliente");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", c.Datos.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", c.Datos.Apellido);
                conexion.Comando.Parameters.AddWithValue("@dni", c.Datos.Dni);
                conexion.Comando.Parameters.AddWithValue("@email", c.Datos.Email);
                conexion.Comando.Parameters.AddWithValue("@idcliente", c.IdCliente);

                conexion.AbrirConexion();
                conexion.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.CheckearConexion() == true)
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public void EliminarFisico(int id)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("DELETE FROM CLIENTES WHERE IDCLIENTE = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.AbrirConexion();
                conexion.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.CheckearConexion() == true)
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public void EliminarLogico(int id)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE CLIENTES SET ACTIVO = 0 WHERE IDCLIENTE = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.AbrirConexion();
                conexion.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conexion.CheckearConexion() == true)
                {
                    conexion.CerrarConexion();
                }
            }
        }
    }
}

/*
CREATE TABLE CLIENTES
(
	IDCLIENTE INT NOT NULL IDENTITY(30000000,1) PRIMARY KEY,
	DNICUIT BIGINT NOT NULL,
	EMPRESA VARCHAR(60),
	NOMBRE VARCHAR(60),
	APELLIDO VARCHAR(60),
	TIPOCLIENTE VARCHAR(2) NOT NULL,
	EMAIL VARCHAR(60),
	ACTIVO BIT NOT NULL
)
*/

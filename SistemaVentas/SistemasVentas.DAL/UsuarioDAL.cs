﻿using DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioDAL
    {
        public DataTable ListarUsuariosDal()
        {
            string consulta = "select * from usuario";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "insert into usuario values (" + usuario.IdPersona+ "," +
                                                          "'" + usuario.NombreUser+ "'," +
                                                          "'" + usuario.Contraeña+ "'," +
                                                          "'" + usuario.Fecha + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);

        }
        public DataTable ListarUsuarioDatosDal()
        {
            string consulta = "SELECT USUARIO.IDUSUARIO, (PERSONA.NOMBRE+' '+PERSONA.APELLIDO) NOMBRECOMPLETO, USUARIO.NOMBREUSER, " +
                              "ROL.NOMBRE AS NOMBREROL, USUARIOROL.FECHAASIGNA " +
                              "FROM  PERSONA INNER JOIN " +
                         "USUARIO ON PERSONA.IDPERSONA = USUARIO.IDPERSONA INNER JOIN " +
                         "USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO INNER JOIN " +
                         "ROL ON USUARIOROL.IDROL = ROL.IDROL";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}

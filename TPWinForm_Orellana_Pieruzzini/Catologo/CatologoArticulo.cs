﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Catologo
{
    public class CatologoArticulo
    {
        public List<Articulos> Listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Articulos> lista = new List<Articulos>();

            conexion.ConnectionString = "data source= DESKTOP-GPR5PDL\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select P.Id, P.Codigo, P.Nombre, P.Descripcion, C.Descripcion, D.Descripcion from ARTICULOS P, CATEGORIAS C, MARCAS D WHERE(P.Id = C.Id) and(P.Id = D.Id)";
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();

            while(lector.Read())
            {
                Articulos aux = new Articulos();
                aux.Codigo = lector.GetString(1);
                aux.Nombre = lector.GetString(2);
                aux.Descripcion = lector.GetString(3);

                Marcas marcas = new Marcas();
                aux.marca = lector.GetString(4);

                Categoria categoria = new Categoria();
                aux.categoria = lector.GetString(5);
                
                
                lista.Add(aux);

            }

            conexion.Close();
            return lista;

        }

        
        
    }
     

}

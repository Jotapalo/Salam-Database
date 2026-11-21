using Salam_Database.Data;
using Salam_Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Salam_Database.Repositories
{
    public class ProductRepository
    {
        public static List<ProductoDTO> ObtenerTodos()
        {
            List<ProductoDTO> productos = new List<ProductoDTO>();

            string sql = @"
                SELECT
                    p.id_producto,
                    p.codigo,
                    p.nombre,
                    c.nombre AS categoria,
                    s.nombre AS subcategoria,
                    m.nombre AS marca,
                    p.color,
                    p.material,
                    p.capacidad,
                    p.unidad_capacidad,
                    p.estado
                FROM producto p
                LEFT JOIN subcategoria s
                    ON p.id_subcategoria = s.id_subcategoria
                LEFT JOIN categoria c
                    ON s.id_categoria = c.id_categoria
                LEFT JOIN marca m
                    ON p.id_marca = m.id_marca
                ORDER BY p.nombre;
            ";

            using (SQLiteConnection connection = Database.GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                // Obtener ordinals una sola vez
                int idxId = reader.GetOrdinal("id_producto");
                int idxCodigo = reader.GetOrdinal("codigo");
                int idxNombre = reader.GetOrdinal("nombre");
                int idxCategoria = reader.GetOrdinal("categoria");
                int idxSubcategoria = reader.GetOrdinal("subcategoria");
                int idxMarca = reader.GetOrdinal("marca");
                int idxColor = reader.GetOrdinal("color");
                int idxMaterial = reader.GetOrdinal("material");
                int idxCapacidad = reader.GetOrdinal("capacidad");
                int idxUnidad = reader.GetOrdinal("unidad_capacidad");
                int idxEstado = reader.GetOrdinal("estado");

                while (reader.Read())
                {
                    ProductoDTO producto = new ProductoDTO();

                    producto.IdProducto = reader.IsDBNull(idxId) ? 0 : reader.GetInt32(idxId);
                    producto.Codigo = reader.IsDBNull(idxCodigo) ? "" : reader.GetString(idxCodigo);
                    producto.Nombre = reader.IsDBNull(idxNombre) ? "" : reader.GetString(idxNombre);
                    producto.Categoria = reader.IsDBNull(idxCategoria) ? "" : reader.GetString(idxCategoria);
                    producto.Subcategoria = reader.IsDBNull(idxSubcategoria) ? "" : reader.GetString(idxSubcategoria);
                    producto.Marca = reader.IsDBNull(idxMarca) ? "" : reader.GetString(idxMarca);
                    producto.Color = reader.IsDBNull(idxColor) ? "" : reader.GetString(idxColor);
                    producto.Material = reader.IsDBNull(idxMaterial) ? "" : reader.GetString(idxMaterial);
                    producto.Capacidad = reader.IsDBNull(idxCapacidad) ? 0m : Convert.ToDecimal(reader.GetValue(idxCapacidad));
                    producto.UnidadCapacidad = reader.IsDBNull(idxUnidad) ? "" : reader.GetString(idxUnidad);
                    producto.Estado = reader.IsDBNull(idxEstado) ? 0 : Convert.ToInt32(reader.GetValue(idxEstado));

                    // Rellenar InfoParcial (usado en DisplayMember)
                    producto.InfoParcial = string.IsNullOrWhiteSpace(producto.Codigo)
                        ? producto.Nombre
                        : $"{producto.Codigo} - {producto.Nombre}";

                    productos.Add(producto);
                }
            }

            return productos;
        }

        public static int InsertarProducto(
            string codigo,
            string nombre,
            string subcategoriaParam,
            string marcaParam,
            string descripcion,
            string color,
            string material,
            decimal capacidad,
            string unidadCapacidad)
        {
            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Determinar categoría y subcategoría
                        string categoriaNombre;
                        string subcategoriaNombre;

                        if (string.IsNullOrWhiteSpace(subcategoriaParam))
                        {
                            categoriaNombre = "General";
                            subcategoriaNombre = "General";
                        }
                        else
                        {
                            char[] separadores = new char[] { '>', '/', '|', '\\' };
                            string[] partes = subcategoriaParam.Split(separadores, 2, StringSplitOptions.RemoveEmptyEntries);
                            if (partes.Length == 2)
                            {
                                categoriaNombre = partes[0].Trim();
                                subcategoriaNombre = partes[1].Trim();
                            }
                            else
                            {
                                categoriaNombre = "General";
                                subcategoriaNombre = subcategoriaParam.Trim();
                            }
                        }

                        // Obtener o crear categoría
                        int idCategoria;
                        string sqlFindCategoria = "SELECT id_categoria FROM categoria WHERE nombre = @nombre COLLATE NOCASE LIMIT 1;";
                        using (var cmdFindCat = new SQLiteCommand(sqlFindCategoria, connection, transaction))
                        {
                            cmdFindCat.Parameters.AddWithValue("@nombre", categoriaNombre);
                            object res = cmdFindCat.ExecuteScalar();
                            if (res != null && res != DBNull.Value)
                            {
                                idCategoria = Convert.ToInt32(res);
                            }
                            else
                            {
                                string sqlInsertCat = "INSERT INTO categoria (nombre) VALUES (@nombre); SELECT last_insert_rowid();";
                                using (var cmdInsCat = new SQLiteCommand(sqlInsertCat, connection, transaction))
                                {
                                    cmdInsCat.Parameters.AddWithValue("@nombre", categoriaNombre);
                                    idCategoria = Convert.ToInt32(cmdInsCat.ExecuteScalar());
                                }
                            }
                        }

                        // Obtener o crear subcategoría (por nombre y id_categoria) - uso parámetros claros y COLLATE NOCASE
                        int idSubcategoria;
                        string sqlFindSub = "SELECT id_subcategoria FROM subcategoria WHERE nombre = @subnombre COLLATE NOCASE AND id_categoria = @id_categoria LIMIT 1;";
                        using (var cmdFindSub = new SQLiteCommand(sqlFindSub, connection, transaction))
                        {
                            cmdFindSub.Parameters.AddWithValue("@subnombre", subcategoriaNombre);
                            cmdFindSub.Parameters.AddWithValue("@id_categoria", idCategoria);
                            object res = cmdFindSub.ExecuteScalar();
                            if (res != null && res != DBNull.Value)
                            {
                                idSubcategoria = Convert.ToInt32(res);
                            }
                            else
                            {
                                string sqlInsertSub = "INSERT INTO subcategoria (nombre, id_categoria) VALUES (@subnombre, @id_categoria); SELECT last_insert_rowid();";
                                using (var cmdInsSub = new SQLiteCommand(sqlInsertSub, connection, transaction))
                                {
                                    cmdInsSub.Parameters.AddWithValue("@subnombre", subcategoriaNombre);
                                    cmdInsSub.Parameters.AddWithValue("@id_categoria", idCategoria);
                                    idSubcategoria = Convert.ToInt32(cmdInsSub.ExecuteScalar());
                                }
                            }
                        }

                        // Obtener o crear marca (si viene nombre)
                        int? idMarca = null;
                        if (!string.IsNullOrWhiteSpace(marcaParam))
                        {
                            string marcaNombre = marcaParam.Trim();
                            string sqlFindMarca = "SELECT id_marca FROM marca WHERE nombre = @nombre COLLATE NOCASE LIMIT 1;";
                            using (var cmdFindMarca = new SQLiteCommand(sqlFindMarca, connection, transaction))
                            {
                                cmdFindMarca.Parameters.AddWithValue("@nombre", marcaNombre);
                                object res = cmdFindMarca.ExecuteScalar();
                                if (res != null && res != DBNull.Value)
                                {
                                    idMarca = Convert.ToInt32(res);
                                }
                                else
                                {
                                    string sqlInsertMarca = "INSERT INTO marca (nombre) VALUES (@nombre); SELECT last_insert_rowid();";
                                    using (var cmdInsMarca = new SQLiteCommand(sqlInsertMarca, connection, transaction))
                                    {
                                        cmdInsMarca.Parameters.AddWithValue("@nombre", marcaNombre);
                                        idMarca = Convert.ToInt32(cmdInsMarca.ExecuteScalar());
                                    }
                                }
                            }
                        }

                        // Insertar producto
                        string sqlInsertProducto = @"
            INSERT INTO producto
            (
                codigo,
                nombre,
                id_subcategoria,
                id_marca,
                descripcion,
                color,
                material,
                capacidad,
                unidad_capacidad
            )
            VALUES
            (
                @codigo,
                @nombre,
                @idSubcategoria,
                @idMarca,
                @descripcion,
                @color,
                @material,
                @capacidad,
                @unidadCapacidad
            );

            SELECT last_insert_rowid();
        ";

                        using (SQLiteCommand cmdInsProd = new SQLiteCommand(sqlInsertProducto, connection, transaction))
                        {
                            cmdInsProd.Parameters.AddWithValue("@codigo", string.IsNullOrWhiteSpace(codigo) ? (object)DBNull.Value : codigo);
                            cmdInsProd.Parameters.AddWithValue("@nombre", nombre);
                            cmdInsProd.Parameters.AddWithValue("@idSubcategoria", idSubcategoria);

                            if (idMarca.HasValue)
                                cmdInsProd.Parameters.AddWithValue("@idMarca", idMarca.Value);
                            else
                                cmdInsProd.Parameters.AddWithValue("@idMarca", DBNull.Value);
                            cmdInsProd.Parameters.AddWithValue("@descripcion", string.IsNullOrEmpty(descripcion) ? (object)DBNull.Value : descripcion);
                            cmdInsProd.Parameters.AddWithValue("@color", string.IsNullOrEmpty(color) ? (object)DBNull.Value : color);
                            cmdInsProd.Parameters.AddWithValue("@material", string.IsNullOrEmpty(material) ? (object)DBNull.Value : material);
                            cmdInsProd.Parameters.AddWithValue("@capacidad", capacidad);
                            cmdInsProd.Parameters.AddWithValue("@unidadCapacidad", string.IsNullOrEmpty(unidadCapacidad) ? (object)DBNull.Value : unidadCapacidad);

                            int nuevoId = Convert.ToInt32(cmdInsProd.ExecuteScalar());

                            transaction.Commit();
                            return nuevoId;
                        }
                    }
                    catch
                    {
                        transaction.Rollback();
                        return -1; // Indicar error
                    }
                }
            }
        }
    }
}
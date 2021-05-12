using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_AWS_Dynamo_Usuarios.Models
{
    [DynamoDBTable("usuario")]
    public class Usuario
    {
        [DynamoDBProperty("idusuario")]
        [DynamoDBHashKey]
        public int idusuario { get; set; }

        [DynamoDBProperty("nombre")]
        public String nombre { get; set; }

        [DynamoDBProperty("descripcion")]
        public String descripcion { get; set; }

        [DynamoDBProperty("fechaalta")]
        public String fechaalta { get; set; }

        [DynamoDBProperty("imagenes")]
        public List<Imagen> Imagen { get; set; }
    }
}

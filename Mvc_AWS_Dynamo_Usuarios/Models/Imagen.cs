using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_AWS_Dynamo_Usuarios.Models
{
    public class Imagen
    {
        [DynamoDBProperty("titulo")]
        public String titulo { get; set; }

        [DynamoDBProperty("imagen")]
        public String imagen { get; set; }
    }
}

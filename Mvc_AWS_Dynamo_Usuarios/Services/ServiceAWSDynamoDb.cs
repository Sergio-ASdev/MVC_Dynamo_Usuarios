using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Mvc_AWS_Dynamo_Usuarios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_AWS_Dynamo_Usuarios.Services
{
    public class ServiceAWSDynamoDb
    {
        private DynamoDBContext context;

        public ServiceAWSDynamoDb()
        {
            AmazonDynamoDBClient client = new AmazonDynamoDBClient();
            this.context = new DynamoDBContext(client);
        }

        public async Task CreateUsuario(Usuario user)
        {
            await this.context.SaveAsync<Usuario>(user);
        }

        public async Task UpdateUsuario(Usuario user)
        {
            await this.context.SaveAsync<Usuario>(user);
        }

        public async Task<List<Usuario>> GetUsuarios()
        {
            //PRIMERO DEBEMOS RECUPERAR LA TABLA
            //LA RECUPERACION DE LA TABLA ES SUPER SENCILLA
            //PARA RECUPERAR LA TABLA, BASTA CON HABER MAPEADO
            //EL MODEL CON [DynamoDBTable]
            var tabla = this.context.GetTargetTable<Usuario>();
            var scanOptions = new ScanOperationConfig();
            //scanOptions.PaginationToken = "";
            var results = tabla.Scan(scanOptions);
            //LOS DATOS QUE RECUPERAMOS SON Document
            //Y DEVUELVE UNA COLECCION
            List<Document> data = await results.GetNextSetAsync();
            //DEBEMOS TRANSFORMAR DICHOS DATOS A SU TIPADO
            //ESTO ES AUTOMATICO MEDIANTE UN METODO
            IEnumerable<Usuario> usuarios = this.context.FromDocuments<Usuario>(data);

            return usuarios.ToList();
        }

        public async Task<List<Usuario>> BuscarUsuarios(string coso)
        {
            int n;
            bool isNumeric = int.TryParse(coso, out n);
            List<Usuario> usuarios = new List<Usuario>();

            if (isNumeric)
            {
                usuarios.Add(await this.context.LoadAsync<Usuario>(int.Parse(coso)));
                return usuarios;
            }
            else
            {
                Table table = Table.LoadTable(new AmazonDynamoDBClient(), "usuario");
                ScanFilter scanFilter = new ScanFilter();
                scanFilter.AddCondition("nombre", ScanOperator.Contains, coso);
                //scanFilter.AddCondition("modelo", ScanOperator.Contains, modelo);

                Search search = table.Scan(scanFilter);

                List<Document> data = new List<Document>();
                data = await search.GetNextSetAsync();
                IEnumerable<Usuario> usuarios2 = this.context.FromDocuments<Usuario>(data);

                return usuarios2.ToList();

                /*
                var conditions = new List<ScanCondition>();
                conditions.Add(new ScanCondition("marca", ScanOperator.Contains, coso));

                return await context.ScanAsync<Coche>(conditions).GetRemainingAsync();

                */


            }

        }

        public async Task<Usuario> FindUser(int id)
        {
            //SI ESTAMOS BUSCANDO POR PARTITION KEY (PRIMARY KEY)
            //HASHKEY SOLAMENTE DEBEMOS HACERLO CON LOAD
            //ESTO ES EQUIVALENTE A BUSCAR CON CONSULTA
            return await this.context.LoadAsync<Usuario>(id);
        }

        public async Task DeleteUser(int id)
        {
            await this.context.DeleteAsync<Usuario>(id);
        }
    }
}

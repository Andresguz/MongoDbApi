using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MongoDbApi.Models
{
    public class Pedido
    {
       [BsonId]
        public ObjectId Id { get; set; }
        public int NumPedido { get; set; }
        public string Apellido { get; set; }
      
        public int codPlato { get; set; }
     
        public int codCliente { get; set; }   
        public int cantidad { get; set; }

        public DateTime fecha { get; set; }
        public string Nit { get; set; }
    }
}

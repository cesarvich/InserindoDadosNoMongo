
using DnsClient.Protocol;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using MongoDB.Driver.Core;


namespace inserindoDocs {

    class program
    {

        static void Main(string[] args)
        {

            var dbCliente = new MongoClient("mongodb://localhost:27017");

            IMongoDatabase db = dbCliente.GetDatabase("Teste");

            var carros = db.GetCollection<BsonDocument>("Carros");

            var documento = new BsonDocument
            {


                {"Nome","HONDA CIVIC 2017" },
                {"Condicao","Usado" },
                {"Kilometragem",150 },
                {"Estado de Origem","Rio Grande do Sul" },
                {"Origem da Revenda","Leilao Detran" },
                {"Estado de Multa","Liquidado" },
                {"Ano",2017 },
                {"Comprado em",2020 },
                {"Preco",350000}


            };
            carros.InsertOne(documento);

            Console.WriteLine("\nDocumento inserido");

 }

    }

         }

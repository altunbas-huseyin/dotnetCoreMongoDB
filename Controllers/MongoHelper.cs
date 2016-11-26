using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Driver;

public class MongoHelper
    {
        public static readonly string connectionString = "Servers=127.0.0.1:27017;ConnectTimeout=30000;ConnectionLifetime=300000;MinimumPoolSize=8;MaximumPoolSize=256;Pooled=true";
        public static readonly string database = "demoDb";

        public static void InsertOne<T>(T entity) where T : class
        {
                MongoClient   mongo = new MongoClient();
                IMongoDatabase friends = mongo.GetDatabase(database);
                IMongoCollection<T> _IMongoCollection = friends.GetCollection<T>(entity.GetType().Name);
                _IMongoCollection.InsertOne(entity);

            
        }
       
    }
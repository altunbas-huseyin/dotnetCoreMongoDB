using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Galeri.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
       
        public ValuesController()
        {
            
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

             PostModel postModel = new PostModel();
             postModel.name="testppppppppp";
             // _repository.InsertPost(postModel);
           
           //MongoManager g = new MongoManager();
           //g.eGetMongoClient(postModel);


           // MongoRepository<PostModel> rr = new MongoRepository<PostModel>("test");
            //InsertOne("kkkk",postModel);

            MongoHelper.InsertOne(postModel);
            return "value1111";
        }

 public  void InsertOne<T>(string collectionName, T entity) where T : class
        {
            
                MongoClient   mongo = new MongoClient();
                IMongoDatabase friends = mongo.GetDatabase("demoDb");
                IMongoCollection<T> categories = friends.GetCollection<T>("posts");
                categories.InsertOne(entity);
        

            
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

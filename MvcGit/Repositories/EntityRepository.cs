using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MvcGit.Database;
using MvcGit.Models;

namespace MvcGit.Repositories
{
    public class EntityRepository
    {
        private readonly IDbProvider _db;

        public EntityRepository(IDbProvider db)
        {
            _db = db;
        }

        public void LoadEntityByName(string name)
        {
            var aa = _db.Find<Entity>(name);
            
            return;

        }
    }
}
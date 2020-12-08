using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Ze_Delivery_Domain.Interfaces;

namespace Ze_Delivery_Infra.Database
{
    [ExcludeFromCodeCoverage]
    public class MongoConnection<T> : IMongoConnection<T>
    {
        private IMongoCollection<T> _mongoCollection;

        public MongoConnection(IPartnerDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _mongoCollection = database.GetCollection<T>(settings.CollectionName);
        }

        public List<T> SelectList(Expression<Func<T, bool>> filter) =>
            _mongoCollection.Find(filter).ToList();

        public T Select(Expression<Func<T, bool>> filter) =>
            _mongoCollection.Find<T>(filter).FirstOrDefault();

        public bool Exists(Expression<Func<T, bool>> filter) =>
            _mongoCollection.Find<T>(filter).Any();

        public void Insert(T t) =>
            _mongoCollection.InsertOne(t);

        public void Update(Expression<Func<T, bool>> filter, T tIn) =>
            _mongoCollection.ReplaceOne(filter, tIn);

        public void Delete(Expression<Func<T, bool>> filter) =>
            _mongoCollection.DeleteOne(filter);
    }
}
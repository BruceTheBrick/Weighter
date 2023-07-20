﻿using Weighter.Core.Constants;
using Weighter.Core.Databases.Interfaces;
using Weighter.Core.Models.Database;
using Weighter.Core.Services.Interfaces;

namespace Weighter.Core.Databases
{
    public class WeighterDatabase : IWeighterDatabase
    {
        private readonly ISqlClientService _db;
        public WeighterDatabase(ISqlClientService db)
        {
            _db = db;
        }

        public void Initialize()
        {
            _db.SetConnectionString(DbConstants.DbName);
            _db.CreateTable<UserModel>();
            _db.CreateTable<WeightModel>();
            _db.CreateTable<UserSettingsModel>();
        }
    }
}
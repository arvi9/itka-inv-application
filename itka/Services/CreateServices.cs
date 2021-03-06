﻿using itka.Data;
using System;
using System.Linq;
using itka.Models;
using itka.ViewModels;

namespace itka.Services
{
    public class CreateServices
    {
        private readonly DbContext _db;
        public CreateServices() : this(new DbContext()) { }

        public CreateServices(DbContext agendaContext)
        {
            _db = agendaContext;
        }
        public bool SaveProduct(ProductViewModel model)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    _db.Products.Add(model.Product);                   
                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }
        public bool SaveUnit(tblUnit model)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    _db.Units.Add(model);
                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }
        public bool SaveClient(tblClient model)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    _db.Clients.Add(model);
                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }
        public bool SaveSupplier(tblSupplier model)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    _db.Suppliers.Add(model);
                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }
        public bool SaveWarehouse(tblWarehouse model)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    _db.Warehouses.Add(model);
                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }
    }
}
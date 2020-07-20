using Binding;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Models.Entities;

namespace Services
{
    public interface IPositionService
    {
        bool Add(Position model);
    }
    public class PositionService : IPositionService
    {
        public readonly DB _db;
        public PositionService(DB db)
        {
            _db = db;
        }
        public bool Add(Position model)
        {
            var pos = _db.positions.Where(x => x.PositionName.Equals(model.PositionName) || x.Id.Equals(model.Id)).FirstOrDefault();

            if (pos == null)
            {
                
                try
                {
                    _db.Add(model);
                    _db.SaveChanges();
                }
                catch (System.Exception)
                {
                    return false;
                }
            }
            return true;

        }
    }
}

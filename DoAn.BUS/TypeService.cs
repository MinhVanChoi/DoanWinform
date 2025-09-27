using DoAn.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BUS
{
    public class TypeService
    {
        public List<type> getAllTypes()
        {
            ShoeModel shoeModel = new ShoeModel();
            return shoeModel.types.ToList();

        }


        public type findType(string typeId)
        {
            ShoeModel shoeModel = new ShoeModel();
            return shoeModel.types.FirstOrDefault(t => t.idName == typeId);
        }




        public void InsertType(type type)
        {
            ShoeModel shoeModel = new ShoeModel();
            shoeModel.types.AddOrUpdate(type);
            shoeModel.SaveChanges();
        }

        public void DeleteProduct(string typeId)
        {
            ShoeModel shoeModel = new ShoeModel();
            type type = shoeModel.types.FirstOrDefault(t => t.idName == typeId);
            shoeModel.types.Remove(type);
            shoeModel.SaveChanges();
        }

    }
}

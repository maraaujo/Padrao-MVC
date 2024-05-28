using ProvaA1.DAL;
using ProvaA1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaA1.BLL
{
    public class BicicletaBLL
    {
        private BicicletaDAL dal = new BicicletaDAL();

        public void Create(Bicicleta bicicleta)
        {
            dal.Create(bicicleta);
        }
    

        public List<Bicicleta> Read()
        {
            return dal.Get();
        }

        public void Update(Bicicleta bicicleta)
        {
            dal.Update(bicicleta);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }
    }
}


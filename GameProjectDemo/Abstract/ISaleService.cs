using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    interface ISaleService
    {
        void Save(Sale sale);
        void Update(Sale sale);
        void Delete(Sale sale);
    }
}

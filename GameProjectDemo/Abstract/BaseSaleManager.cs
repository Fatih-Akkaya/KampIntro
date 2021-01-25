using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public abstract class BaseSaleManager : ISaleService
    {
        public void Delete(Sale sale)
        {
            Console.WriteLine("Oyuncu oyununu iade etti.");
        }

        public void Save(Sale sale)
        {
            Console.WriteLine("Satış gerçekleşti");
        }

        public void Update(Sale sale)
        {
            Console.WriteLine("Sipariş güncellendi.");
        }
    }
}

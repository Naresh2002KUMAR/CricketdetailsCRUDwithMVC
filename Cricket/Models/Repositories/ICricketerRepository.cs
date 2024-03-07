using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cricket.Models.Repositories
{
    public interface ICricketerRepository
    {
        public void InsertPlayer(Cricketer details);
        public List<Cricketer> ReadPlayer();
        public Cricketer ReadPlayerById(long cricketerId);
        public void UpdatePlayer(long number, Cricketer edit);
        public void DeletePlayer(long cricketerId);
    }
}

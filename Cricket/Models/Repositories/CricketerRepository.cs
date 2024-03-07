using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cricket.Models.Repositories
{
    public class CricketerRepository:ICricketerRepository
    {
        private readonly DBCricket _con;
        public CricketerRepository(DBCricket con)
        {
            _con = con;
        }



        public void InsertPlayer(Cricketer details)
        {
            try
            {
                _con.Database.ExecuteSqlRaw($"exec InsertPlayer @CricketerName='{details.CricketerName}', @TotalODI={details.TotalODI}, @TotalScore={details.TotalScore}, @Fifties={details.Fifties},@Hundreds={details.Hundreds}"); 
            }
            catch (Exception )
            {
                throw;
            }
        }

        public List<Cricketer> ReadPlayer()
        {
            try
            {
                var result = _con.CricketerDetail.FromSqlRaw($"exec ReadPlayer").ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Cricketer ReadPlayerById(long cricketerId)
        {
            try
            {
                var result = _con.CricketerDetail.FromSqlRaw<Cricketer>($"exec ReadPlayerById {cricketerId}");
                return result.ToList().FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdatePlayer(long CricketerId, Cricketer edit)
        {
            try
            {
                var result = _con.Database.ExecuteSqlRaw($"exec UpdatePlayer  {CricketerId},'{edit.CricketerName}',{edit.TotalODI},{edit.TotalScore},{edit.Fifties},{edit.Hundreds}");
            }
            catch (Exception )
            {
                throw;
            }
        }
        public void DeletePlayer(long cricketerId)
        {
            try
            {
                _con.Database.ExecuteSqlRaw($"exec DeletePlayer {cricketerId}");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

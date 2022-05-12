using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrasturcture.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetTop30GrossingMovies()
        {
            // SQL Database
            // data access logic
            // ADO.NET (Microsoft) SQLConnection, SQLCommand
            // Dapper (ORM) -> StackOverflow
            // Entity Frammework Core => LINQ
            // SELECT top 30 * FROM Movie ORDER BY Revenue
            // movies.orderbydescnding(m=> m.Revenue).Take(30)
            throw new NotImplementedException();
        }
    }
}

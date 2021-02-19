using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;

namespace Web.Models
{
    public class MovieModel
    {
        public  int Id { get; set; }
        public string Movie_name { get; set; }
        public int Movie_year { get; set; }
        public string Sipnosis { get; set; }

        public List<MovieModel> GetAllMovie()
        {
            var cn = DBConnection.ConnectionMySql.GetConnectionToDB();
            string query = "SELECT * FROM movie";
            var result = cn.Query<MovieModel>(query).ToList();
            return result;
        }

        public bool Insert(MovieModel model)
        {
            var cn = DBConnection.ConnectionMySql.GetConnectionToDB();
            string query = "INSERT INTO movie(movie_name, movie_year, sipnosis) VALUES(@Movie_name, @Movie_year, @Sipnosis)";

            if (cn.Execute(query, model) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Edit(MovieModel model)
        {
            var cn = DBConnection.ConnectionMySql.GetConnectionToDB();
            string query = "UPDATE movie SET movie_name=@Movie_name, movie_year=@Movie_year, sipnosis=@Sipnosis WHERE id = @Id";

            if (cn.Execute(query, model) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(MovieModel model)
        {
            var cn = DBConnection.ConnectionMySql.GetConnectionToDB();
            string query = "DELETE FROM movie WHERE id = @Id";
            
            if (cn.Execute(query, model) > 0)
            {
                return true;
            }
            return false;
        }

    }
}
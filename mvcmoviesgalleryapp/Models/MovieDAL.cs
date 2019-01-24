using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using mvcmoviesgalleryapp.Models;
namespace mvcmoviesgalleryapp.Models
{
    public class MovieDAL
    {
        SqlConnection con = new SqlConnection("user id=sa;password=123;database=mvcbatch47;data source=MUKTAR");
        SqlCommand cmd = new SqlCommand();

        public void AddMovie(MovieModel m)
        {
            
            cmd.CommandText = "insert into movie values(@mid,@mname,@mfile)";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@mid",m.movieid);
            cmd.Parameters.AddWithValue("@mname", m.moviename);
            cmd.Parameters.AddWithValue("@mfile",m.moviefile);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public List<MovieModel> GetMovies()
        {
            List<MovieModel> movies = new List<MovieModel>();
            cmd.CommandText = "select * from movie";
            cmd.Connection = con;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                MovieModel m = new MovieModel();
                m.moviename = dr["movieid"].ToString();
                m.moviename = dr["moviename"].ToString();
                m.moviefile = dr["moviefile"].ToString();
                movies.Add(m);
            }
            dr.Close();
            con.Close();

            return movies;
        }


        public void DeleteMovie(string mid)
        {
            cmd.CommandText = "delete from movie where movieid = @movieid";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@movieid",mid);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }




    }
}
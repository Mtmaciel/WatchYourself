using Ftec.ProjWeb.WatchYourself.Domain.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Ftec.ProjWeb.WatchYourself.Repository.Repositorys
{
    public class GoalsRepository
    {
        //todo Setar conection string no app config
        //todo criar interfaces
        private const string ConectionString = "Server=localhost; Port=5432; Database=WatchYourself; User Id=postgres; Password=Gcon123;";

        public static Goal Select(Guid id)
        {
            Goal goal = null;
            using (NpgsqlConnection con = new NpgsqlConnection(ConectionString))
            {
                con.Open();
                NpgsqlCommand sql = new NpgsqlCommand("select * from goals where id=@id");
                sql.Connection = con;
                sql.Parameters.AddWithValue("id", id);
                NpgsqlDataReader rd = sql.ExecuteReader();
                if(rd.Read())
                {
                    goal = new Goal(){
                        Title = rd["title"].ToString(),
                        Type = Convert.ToInt32(rd["type"].ToString()),
                        Difficulty = Convert.ToInt32(rd["difficulty"].ToString()),
                        DashBoardType = Convert.ToInt32(rd["dashboardtype"].ToString()),
                        StartDate = Convert.ToDateTime(rd["startdate"].ToString()),
                        EndDate = Convert.ToDateTime(rd["enddate"].ToString()),
                        Id = Guid.Parse(rd["id"].ToString()) 
                    };

                }
            }
            return goal;
        }

        public static List<Goal> List()
        {
            List<Goal> goals = new List<Goal>();
            using (NpgsqlConnection con = new NpgsqlConnection(ConectionString))
            {
                con.Open();
                NpgsqlCommand sql = new NpgsqlCommand("select * from goals", con);
                NpgsqlDataReader rd = sql.ExecuteReader();
                while (rd.Read())
                {
                    goals.Add(new Goal()
                    {
                        Title = rd["title"].ToString(),
                        Type = Convert.ToInt32(rd["type"].ToString()),
                        Difficulty = Convert.ToInt32(rd["difficulty"].ToString()),
                        DashBoardType = Convert.ToInt32(rd["dashboardtype"].ToString()),
                        StartDate = Convert.ToDateTime(rd["startdate"].ToString()),
                        Id = Guid.Parse(rd["id"].ToString())
                    });

                }
            }
            return goals;
        }

        /*public static Guid Insert(Goal goal)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(ConectionString))
            {
                con.Open();
                NpgsqlCommand sql = new NpgsqlCommand(@"insert 
                                                          into goals
                                                        values(@id,@user_id,)", con);
                NpgsqlDataReader rd = sql.ExecuteReader();
                while (rd.Read())
                {
                    goals.Add(new Goal()
                    {
                        Title = rd["title"].ToString(),
                        Type = Convert.ToInt32(rd["type"].ToString()),
                        Difficulty = Convert.ToInt32(rd["difficulty"].ToString()),
                        DashBoardType = Convert.ToInt32(rd["dashboardtype"].ToString()),
                        StartDate = Convert.ToDateTime(rd["startdate"].ToString()),
                        Id = Guid.Parse(rd["id"].ToString())
                    });

                }
            }
            return goals;
        }*/
    }
}

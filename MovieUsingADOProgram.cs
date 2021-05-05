using System;
using System.Data.SqlClient;

namespace ADOExampleProject
{
    class Program
    {
        string conString;
        SqlConnection con;
        SqlCommand cmd;
        public Program()
        {
            conString = @"server=LAPTOP-874O3SVO\SQLEXPRESS;Integrated security= true;Initial catalog=pubs";
            con = new SqlConnection(conString);
        }
       public  void FetchMoivesFromDatabase()
        {
            //string strCmd = "Select* from authors";
            string strCmd = "Select * from tblMovie";
            cmd = new SqlCommand(strCmd, con);
            //try
            //{
            //    con.Open();
            //    SqlDataReader drAuthors = cmd.ExecuteReader();
            //    while (drAuthors.Read())
            //    {
            //        Console.WriteLine("Authors Id: "+drAuthors[0]);
            //        Console.WriteLine("Author First Name "+drAuthors[1]);
            //        Console.WriteLine("Author Last Name "+ drAuthors[2]);
            //        Console.WriteLine("Author Phone "+ drAuthors[3]);
            //        Console.WriteLine("- - - - - - - - - - - - - - - -");
            //    }
            //}
            //catch (SqlException sqlException)

            //{
            //    Console.WriteLine(sqlException.Message);

            //}

            try
            {
                con.Open();
                SqlDataReader drMovies = cmd.ExecuteReader();
                while(drMovies.Read())
                {
                    Console.WriteLine("Movie Id : "+drMovies[0].ToString());
                    Console.WriteLine("Movie Name : " + drMovies[1]);
                    Console.WriteLine("Movie Duration : " + drMovies[2].ToString());
                    Console.WriteLine("_ _ _ _ _ _ _ _ _ __  __ _ _");
                }
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
            finally//will get executed if there is or if there is no exception
            {
                con.Close();
                Console.ReadKey();
            }
           
        }
        void AddMovies()
        {
            Console.WriteLine("Please enter the movie name");
            string mName = Console.ReadLine();
            Console.WriteLine("Please enter the movie Duration");
            float mDur = (float)Math.Round(float.Parse(Console.ReadLine())); 
            string strCmd = "insert into tblMovie(Name,Duration) values (@mname,@mdur)";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mname", mName);
            cmd.Parameters.AddWithValue("@mdur", mDur);
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Movie Inserted");
                }
                else
                {
                    Console.WriteLine("not inserted");
                }
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
            finally
            {
                con.Close();
            }

        }
        void UpdateMovieDuration()
        {
            Console.WriteLine("Please enter the movie Id");
            string id = Console.ReadLine();
            Console.WriteLine("Please enter the movie Duration");
            float mDur = (float)Math.Round(float.Parse(Console.ReadLine()), 2);
            string strCmd = "Update tblMovie set duration=@mdur where id=@mid";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mid", id);
            cmd.Parameters.AddWithValue("@mdur", mDur);
            

            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Movie Updated");
                }
                else
                {
                    Console.WriteLine("not Updated");
                }
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public void FetchOneMovieFromDatabase()
        {
            //string strCmd = "Select * from authors";
            string strCmd = "Select * from tblMovie where id=@mid";
            cmd = new SqlCommand(strCmd, con);
           

            try
            {
                con.Open();
                Console.WriteLine("please enter the Id");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd.Parameters.Add("@mid", System.Data.SqlDbType.Int);
                cmd.Parameters[0].Value = id;
                SqlDataReader drMovies = cmd.ExecuteReader();
                while (drMovies.Read()) 
                {
                    Console.WriteLine("Movie Id : " + drMovies[0].ToString());
                    Console.WriteLine("Movie Name : " + drMovies[1]);
                    Console.WriteLine("Movie Duration : " + drMovies[2].ToString());
                    Console.WriteLine("_ _ _ _ _ _ _ _ _ __  __ _ _");
                }
            }
            catch (SqlException sqlexception)
            {

                Console.WriteLine(sqlexception.Message);
            }
            finally//will get executed if there is or if there is no exception
            {
                con.Close();
               
            }

        }
        public void DeleteMovie()
        //DELETE FROM table_name WHERE condition;

        {

            Console.WriteLine("Please enter the movie Id");
            float mid = Convert.ToInt32(Console.ReadLine());
            string strCmd = "Delete from tblMovie where Id = @Mid ";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@Mid", mid);

            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Movie Deleted");
                }
                else
                {
                    Console.WriteLine("not deleted");
                }
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
            finally
            {
                con.Close();
            }
        }

            void PrintMenu()
            {
            int choice = 0;
            do
            {
                Console.WriteLine("Choose the option");
                Console.WriteLine("1.Add Movie");
                Console.WriteLine("2.Update Duration");
                Console.WriteLine("3.Print One movie By Id");
                Console.WriteLine("4.Print all the Movie");
                Console.WriteLine("5.Delete Movie By Id");
                Console.WriteLine("6.Exit the Application");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddMovies();
                        break;
                    case 2:
                        UpdateMovieDuration();
                        break;
                    case 3:
                        FetchOneMovieFromDatabase();
                        break;
                    case 4:
                        FetchMoivesFromDatabase();
                        break;
                    case 5:
                        DeleteMovie();
                        break;
                    default:
                        Console.WriteLine("Enter 1 to 5");
                        break;
                }
            } while (choice != 6);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();


            // new Program().AddMovies();
            //new Program().FetchAuthorsFromDatabase();
            //program.UpdateMovieDuration();
            //program.FetchOneMovieFromDatabase();
            program.PrintMenu();
            Console.ReadKey();
        }
    }
}

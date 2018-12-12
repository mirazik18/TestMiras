using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Common;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
    
            DbProviderFactory dbProviderFactory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["provideConnection"].ProviderName);
            using (var client = new WebClient())
            {
                string result = client.DownloadString("https://swapi.co/api/people/1");
                Person person = JsonConvert.DeserializeObject<Person>(result);
                string result2 = client.DownloadString("https://swapi.co/api/planets/3");
                Planet planet = JsonConvert.DeserializeObject<Planet>(result2);
                string result3 = client.DownloadString("https://swapi.co/api/starships/9");
                Starship starship = JsonConvert.DeserializeObject<Starship>(result3);
                starship.Id = 1;
                planet.Id = 1;

        person.Id = 1;
              
                using (var connection = dbProviderFactory.CreateConnection())
                {

                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["StarWarsConnectionString"].ConnectionString;
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            var command = connection.CreateCommand();
                            command.Connection = connection;
                            command.Transaction = transaction;
                            command.CommandText = $"Insert into People values (@personId, @personName, @personHeight, @personMass, @personHaircolor, @personSkincolor, @personEyecolor, @personBirthYear, @personGender, @personHomeWorld, @personFilm, @personSpecies, @personVehicle, @personStarship )";
                            command.CommandText = $"Insert into Planet values('{planet.Id}', '{planet.name}', '{planet.rotation_period}')";
                            command.CommandText = $"Insert into Starship values('{starship.Id}', '{starship.name}', '{starship.model}')";
                            var personIdParameter = command.CreateParameter();
                            var personNameParameter = command.CreateParameter();
                            var personHeightParameter = command.CreateParameter();
                            var personMassParameter = command.CreateParameter();
                            var personHaircolorParameter = command.CreateParameter();
                            var personSkincolorParameter = command.CreateParameter();
                            var personEyecolorParameter = command.CreateParameter();
                            var personBirthYearParameter = command.CreateParameter();
                            var personHomeWorldParameter = command.CreateParameter();
                            var personVehicle = command.CreateParameter();
                            var personStarship = command.CreateParameter();
                            var personSpeciesParameter = command.CreateParameter();
                            var personFilm = command.CreateParameter();
                            personIdParameter.DbType = DbType.Int32;
                            personIdParameter.ParameterName = "@personId";
                            personIdParameter.Value = person.Id;
                            personIdParameter.IsNullable = false;

                            personVehicle.DbType = DbType.String;
                            personVehicle.ParameterName = "@personVehicle";
                            personVehicle.Value = person.vehicles;
                            personVehicle.IsNullable = false;

                            personStarship.DbType = DbType.String;
                            personStarship.ParameterName = "@personStarship";
                            personStarship.Value = person.starships;
                            personStarship.IsNullable = false;

                            personSpeciesParameter.DbType = DbType.String;
                            personSpeciesParameter.ParameterName = "@personSpecies";
                            personSpeciesParameter.Value = person.species;
                            personSpeciesParameter.IsNullable = false;

                            personFilm.DbType = DbType.String;
                            personFilm.ParameterName = "@personFilm";
                            personFilm.Value = person.films;
                            personFilm.IsNullable = false;

                            personHomeWorldParameter.DbType = DbType.String;
                            personHomeWorldParameter.ParameterName = "@personHomeWorld";
                            personHomeWorldParameter.Value = person.homeworld;
                            personHomeWorldParameter.IsNullable = false;

                            personNameParameter.DbType = DbType.String;
                            personNameParameter.ParameterName = "@personName";
                            personNameParameter.Value = person.name;
                            personNameParameter.IsNullable = false;

                            personHeightParameter.DbType = DbType.Int32;
                            personHeightParameter.ParameterName = "@personHeight";
                            personHeightParameter.Value = person.height;
                            personHeightParameter.IsNullable = false;

                            personMassParameter.DbType = DbType.Int32;
                            personMassParameter.ParameterName = "@personMass";
                            personMassParameter.Value = person.mass;
                            personMassParameter.IsNullable = false;

                            personHaircolorParameter.DbType = DbType.String;
                            personHaircolorParameter.ParameterName = "@personHaircolor";
                            personHaircolorParameter.Value = person.hair_color;
                            personHaircolorParameter.IsNullable = false;

                            personSkincolorParameter.DbType = DbType.String;
                            personSkincolorParameter.ParameterName = "@personSkincolor";
                            personSkincolorParameter.Value = person.hair_color;
                            personSkincolorParameter.IsNullable = false;


                            personEyecolorParameter.DbType = DbType.String;
                            personEyecolorParameter.ParameterName = "@personEyecolor";
                            personEyecolorParameter.Value = person.eye_color;
                            personEyecolorParameter.IsNullable = false;


                            personBirthYearParameter.DbType = DbType.String;
                            personBirthYearParameter.ParameterName = "@personBirthYear";
                            personBirthYearParameter.Value = person.birth_year;
                            personBirthYearParameter.IsNullable = false;



                            //command.ExecuteNonQuery  для insert, select, 
                            //command.ExecuteScalar вернуть скалярнок типо count


                            DbCommand selectCommand = connection.CreateCommand();
                            selectCommand.Connection = connection;
                            selectCommand.CommandText = "select*from people";
                            DbDataReader reader = selectCommand.ExecuteReader();
                            while (reader.NextResult())
                            {
                                Person getPerson = new Person
                                {
                                    name = reader["name"].ToString(),
                                    height = reader["height"].ToString(),

                                };
                            }
                            command.ExecuteNonQuery();
                        }
                        catch (DbException exception)
                        {
                            Console.WriteLine(exception.Message);
                            transaction.Rollback();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception.Message);
                            transaction.Rollback();
                        }


                    }
                    ExecuteInTransaction(connection, connection.CreateCommand(), connection.CreateCommand(), connection.CreateCommand(), connection.CreateCommand());
                }
            }
        }
            public static bool ExecuteInTransaction(DbConnection connection, params DbCommand[] commands)
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var command in commands)
                        {
                            command.Transaction = transaction;
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        return true;
                    }

                    catch (DbException exception)
                    {
                        Console.WriteLine(exception.Message);
                        transaction.Rollback(); return false;
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                        transaction.Rollback(); return false;
                    }
                }
            }
        
    }
}

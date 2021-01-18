using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using RadzenClientSide.Data;
using RadzenClientSide.Models.PersonInformation;

namespace RadzenClientSide.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatabaseController: ControllerBase
    {
        private readonly ConfigurationData _configurationData = ConfigurationData.Instance;
        
        [HttpGet("person/{city}/{state}/{cityCode}")]
        public List<Person> GetPeople(string city, string state, string cityCode)
        {
            var queryString = _configurationData.PersonQueryString.
                Replace(":city", city == "æ€æ" ? "" : city).
                Replace(":state", state == "æ€æ" ? "" : state).
                Replace(":plz", cityCode == "æ€æ" ? "" : cityCode);
            var result = new List<Person>();
            try
            {
                var connection = new MySqlConnection("Server=localhost;Port=3306;Database=test;Uid=root;Pwd=;");
                connection.Open();
                var command = new MySqlCommand(queryString, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Person()
                    {
                        City = reader.GetString("city"),
                        CityCode = reader.GetString("zip_code"),
                        Forename = reader.GetString("forename"),
                        Id = reader.GetInt32("ID"),
                        State = reader.GetString("state"),
                        Surname = reader.GetString("surname")
                    });
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        [HttpGet("meeting/{id}")]
        public List<Meeting> GetMeetings(int id)
        {
            var queryString = _configurationData.MeetingQueryString.Replace(":personID", id.ToString());
            var result = new List<Meeting>();
            try
            {
                var connection = new MySqlConnection("Server=localhost;Port=3306;Database=test;Uid=root;Pwd=;");
                connection.Open();
                var command = new MySqlCommand(queryString, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var otherId = reader.GetInt32("person1");
                    otherId = id == otherId ? reader.GetInt32("person2") : otherId;
                    result.Add(new Meeting()
                    {
                        Id = reader.GetInt32("ID"),
                        Date = reader.GetDateTime("date"),
                        PersonInformation = otherId.ToString()
                    });
                }
                reader.Close();
                foreach (var meeting in result)
                {
                    command = new MySqlCommand($"SELECT * from Person WHERE ID = {int.Parse(meeting.PersonInformation)}", connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    meeting.PersonInformation = reader.GetString("forename") + " " + reader.GetString("surname") +
                                                " (" + reader.GetString("zip_code") + " " +
                                                reader.GetString("city") + ")";
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }
    }
}
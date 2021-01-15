﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using IniParser;
using MySql.Data.MySqlClient;
using Radzen;
using Radzen.Blazor;

namespace RadzenServerSide.Pages
{
    public class Person
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string CityCode { get; set; }
        public string State { get; set; }
    }

    public class Meeting
    {
        public int Id { get; set; }
        public string PersonInformation { get; set; }
        public DateTime Date { get; set; }
    }

    public class Filter
    {
        public string Title { get; set; }
        public List<string> DefaultValues { get; set; }
        public string QueryLabel { get; set; }
    }

    public partial class PersonInformationComponent
    {
        private void ReadConfigFile()
        {
            var configFile = new FileIniDataParser().ReadFile("wwwroot/config.ini");
            foreach (var section in configFile.Sections)
            {
                if (section.SectionName == "SQLStrings")
                {
                    PersonQueryString = section.Keys["FetchPersons"];
                    MeetingQueryString = section.Keys["FetchMeetings"];
                }
                else if (section.SectionName.StartsWith("Filter"))
                {
                    Filters.Add(new Filter
                    {
                        Title = section.Keys["Title"],
                        DefaultValues = section.Keys["DefaultValues"].Split(",").ToList(),
                        QueryLabel = section.Keys["QueryStatementLabel"]
                    });
                    FilterValues[section.Keys["QueryStatementLabel"]] = "";
                }
            }
        }

        public void FetchPeople()
        {
            var query = new string(PersonQueryString);
            foreach (var key in FilterValues.Keys)
            {
                Console.WriteLine(key);
                query = query.Replace(key, FilterValues[key]);
            }

            try
            {
                var connection = new MySqlConnection("Server=localhost;Port=3306;Database=test;Uid=root;Pwd=;");
                connection.Open();
                var command = new MySqlCommand(query, connection);
                Console.WriteLine(query);
                var reader = command.ExecuteReader();
                PersonData = new List<Person>();
                while (reader.Read())
                {
                    PersonData.Add(new Person()
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
        }

        public void FetchMeetings()
        {
            var query = MeetingQueryString.Replace(":personID", SelectedPerson.ToString());
            
            try
            {
                var connection = new MySqlConnection("Server=localhost;Port=3306;Database=test;Uid=root;Pwd=;");
                connection.Open();
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();
                var meetings = new List<Meeting>();
                while (reader.Read())
                {
                    var otherId = reader.GetInt32("person1");
                    otherId = SelectedPerson == otherId ? reader.GetInt32("person2") : otherId;
                    meetings.Add(new Meeting()
                    {
                        Id = reader.GetInt32("ID"),
                        Date = reader.GetDateTime("date"),
                        PersonInformation = otherId.ToString()
                    });
                }
                reader.Close();
                foreach (var meeting in meetings)
                {
                    command = new MySqlCommand($"SELECT * from Person WHERE ID = {int.Parse(meeting.PersonInformation)}", connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    meeting.PersonInformation = reader.GetString("forename") + " " + reader.GetString("surname") +
                                                " (" + reader.GetString("zip_code") + " " +
                                                reader.GetString("city") + ")";
                    reader.Close();
                }
                MeetingData = meetings;
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

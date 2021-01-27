package data;

import models.Meeting;
import models.Person;

import java.sql.*;
import java.util.LinkedList;
import java.util.List;

public class DatabaseConnection {
    public static final DatabaseConnection INSTANCE = new DatabaseConnection();

    private DatabaseConnection() {}

    public List<Person> getPeople(String city, String zipCode, String state) {
        List<Person> result = new LinkedList<>();
        try {
            Class.forName("org.mariadb.jdbc.Driver");
            Connection connection = DriverManager.getConnection("jdbc:mariadb://localhost:3306/test", "root", "");
            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery(INIConnection.INSTANCE.getPersonQuery().
                    replace(":city", city).
                    replace(":plz", zipCode).
                    replace(":state", state));
            while (resultSet.next()) {
                result.add(new Person(
                        resultSet.getInt("ID"),
                        resultSet.getString("forename"),
                        resultSet.getString("surname"),
                        resultSet.getString("city"),
                        resultSet.getString("zip_code"),
                        resultSet.getString("state")
                ));
            }
            resultSet.close();
            statement.close();
            connection.close();
        } catch (SQLException | ClassNotFoundException exception) {
            exception.printStackTrace();
        }
        return result;
    }

    public List<Meeting> getMeetings(int id) {
        List<Meeting> result = new LinkedList<>();
        Connection connection = null;
        try {
            Class.forName("org.mariadb.jdbc.Driver");
            connection = DriverManager.getConnection("jdbc:mariadb://localhost:3306/test", "root", "");
            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery(INIConnection.INSTANCE.getMeetingQuery().
                    replace(":personID", String.valueOf(id)));
            while (resultSet.next()) {
                int otherId = resultSet.getInt("person1");
                otherId = otherId == id ? resultSet.getInt("person2") : otherId;
                result.add(new Meeting(resultSet.getInt("ID"), String.valueOf(otherId), resultSet.getDate("date")));
            }
            resultSet.close();
            for (Meeting meeting : result) {
                resultSet = statement.executeQuery("SELECT * FROM Person WHERE ID = " + meeting.getPersonInformation());
                resultSet.next();
                meeting.setPersonInformation(resultSet.getString("forename") + " " + resultSet.getString("surname") + " (" + resultSet.getString("zip_code") + " " + resultSet.getString("city") + ")");
            }
            resultSet.close();
            statement.close();
            connection.close();
        } catch (SQLException | ClassNotFoundException exception) {
            exception.printStackTrace();
        }
        return result;
    }
}

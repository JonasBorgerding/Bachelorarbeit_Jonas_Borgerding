package models;

public class Person {

    private final int ID;
    private final String forename;
    private final String surname;
    private final String city;
    private final String zipCode;
    private final String state;

    public Person(int ID, String forename, String surname, String city, String zipCode, String state){
        this.ID = ID;
        this.forename = forename;
        this.surname = surname;
        this.city = city;
        this.zipCode = zipCode;
        this.state = state;
    }

    public int getID() {
        return ID;
    }

    public String getForename() {
        return forename;
    }

    public String getSurname() {
        return surname;
    }

    public String getCity() {
        return city;
    }

    public String getZipCode() {
        return zipCode;
    }

    public String getState() {
        return state;
    }
}

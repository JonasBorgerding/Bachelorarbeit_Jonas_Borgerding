package models;

import java.util.Date;

public class Meeting {
    private final int ID;
    private String personInformation;
    private final Date date;

    public Meeting(int ID, String personInformation, Date date){

        this.ID = ID;
        this.personInformation = personInformation;
        this.date = date;
    }

    public int getID() {
        return ID;
    }

    public Date getDate() {
        return date;
    }

    public String getPersonInformation() {
        return personInformation;
    }

    public void setPersonInformation(String personInformation) {
        this.personInformation = personInformation;
    }
}

import groovy.sql.Sql

import java.sql.DriverManager
import java.sql.SQLException

class Database_Performance_Test {
    class UnicodeEntry {
        //Auto private with getter and setter
        int ID
        char UnicodeCharacter
        int PREVIOUS
        int NEXT
    }

    void executeTest() {
        List<UnicodeEntry> unicodeEntryList = new LinkedList<>()

        try {
            Sql.newInstance("jdbc:sqlite:unicode.sqlite", "org.sqlite.JDBC").with {
                query('select * from unicode') {rs ->
                    while (rs.next()) {
                        String resultChar = rs.getString("CHAR")
                        char CHAR = resultChar.size() > 0 ? resultChar.charAt(0) : (char) 0
                        unicodeEntryList += new UnicodeEntry(
                                ID: rs.getInt("ID"),
                                UnicodeCharacter: CHAR,
                                PREVIOUS: rs.getInt("PREVIOUS"),
                                NEXT: rs.getInt("NEXT")
                        )
                    }
                }
                close()
            }
        }
        catch (SQLException e){
            e.printStackTrace()
        }
    }
}
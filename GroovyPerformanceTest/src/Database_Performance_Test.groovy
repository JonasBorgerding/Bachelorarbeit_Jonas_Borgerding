import groovy.sql.Sql

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
            Sql.newInstance("jdbc:sqlite:unicode.sqlite").
                    query("select * from unicode;") {
                    while (it.next()) {
                        String resultChar = it.getString("CHAR")
                        char CHAR = resultChar.size() > 0 ? resultChar.charAt(0) : 0
                        unicodeEntryList << new UnicodeEntry(
                                ID: it.getInt("ID"),
                                UnicodeCharacter: CHAR,
                                PREVIOUS: it.getInt("PREVIOUS"),
                                NEXT: it.getInt("NEXT")
                        )
                    }
                }
            }
        catch (SQLException e){
            e.printStackTrace()
        }
    }
}
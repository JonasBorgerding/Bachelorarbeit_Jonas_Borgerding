import java.sql.*;
import java.util.LinkedList;
import java.util.List;

class Database_Performance_Test {
    static class UnicodeEntry {
        private int ID;
        private char UnicodeCharacter;
        private int PREVIOUS;
        private int NEXT;

        UnicodeEntry(int ID, char UnicodeCharacter, int PREVIOUS, int NEXT) {
            this.ID = ID;
            this.UnicodeCharacter = UnicodeCharacter;
            this.PREVIOUS = PREVIOUS;
            this.NEXT = NEXT;
        }

        public int getID() {
            return ID;
        }

        public void setID(int ID) {
            this.ID = ID;
        }

        public char getUnicodeCharacter() {
            return UnicodeCharacter;
        }

        public void setUnicodeCharacter(char unicodeCharacter) {
            UnicodeCharacter = unicodeCharacter;
        }

        public int getPREVIOUS() {
            return PREVIOUS;
        }

        public void setPREVIOUS(int PREVIOUS) {
            this.PREVIOUS = PREVIOUS;
        }

        public int getNEXT() {
            return NEXT;
        }

        public void setNEXT(int NEXT) {
            this.NEXT = NEXT;
        }
    }

    void executeTest(){
        List<UnicodeEntry> unicodeEntryList = new LinkedList<>();
        try (Connection connection = DriverManager.getConnection("jdbc:sqlite:unicode.sqlite")) {
            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM unicode;");
            while (resultSet.next()){
                String resultChar = resultSet.getString("CHAR");
                char CHAR = resultChar.length() > 0 ? resultChar.charAt(0) : 0;
                unicodeEntryList.add(
                        new UnicodeEntry(
                                resultSet.getInt("ID"),
                                CHAR,
                                resultSet.getInt("PREVIOUS"),
                                resultSet.getInt("NEXT")
                        )
                );
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
    }
}
import java.sql.DriverManager

class Database_Performance_Test {
    data class UnicodeEntry (var ID: Int, var CHAR: Char, var PREVIOUS: Int, var NEXT: Int)

    fun execute(){
        val unicodeEntryList = mutableListOf<UnicodeEntry>()
        DriverManager.getConnection("jdbc:sqlite:unicode.sqlite", "postgres", "1234").also { connection ->
            connection.createStatement().also {statement ->
                statement.executeQuery("SELECT * from unicode;").run {
                    while (next()) {
                        unicodeEntryList += UnicodeEntry(
                            getInt("ID"),
                            getString("CHAR").getOrElse(0){ ' ' },
                            getInt("PREVIOUS"),
                            getInt("NEXT")
                        )
                    }
                }
            }
        }
    }
}
import java.sql.{Connection, DriverManager, ResultSet, SQLException, Statement}
import scala.+:
import scala.collection.LinearSeq
import scala.collection.mutable.ListBuffer

class Database_Performance_Test {
  class UnicodeEntry(var ID: Int, var UnicodeCharacter: Char, var PREVIOUS: Int, var NEXT: Int) {
    def getID: Int = ID

    def setID(ID: Int): Unit = {
      this.ID = ID
    }

    def getPREVIOUS: Int = PREVIOUS

    def setPREVIOUS(PREVIOUS: Int): Unit = {
      this.PREVIOUS = PREVIOUS
    }

    def getNEXT: Int = NEXT

    def setNEXT(NEXT: Int): Unit = {
      this.NEXT = NEXT
    }

    def getUnicodeCharacter: Char = UnicodeCharacter

    def setUnicodeCharacter(UnicodeCharacter: Char): Unit = {
      this.UnicodeCharacter = UnicodeCharacter
    }
  }

  def execute(): Unit = {
    var unicodeEntryList = new ListBuffer[UnicodeEntry]
    try {
      val connection: Connection = DriverManager.getConnection("jdbc:sqlite:unicode.sqlite")
      val statement: Statement = connection.createStatement()
      val resultSet: ResultSet = statement.executeQuery("SELECT * FROM unicode")
      while (resultSet.next()) {
        val resultChar: String = resultSet.getString("CHAR")
        val CHAR: Char = if (resultChar.nonEmpty) resultChar.charAt(0) else ' '
        unicodeEntryList += new UnicodeEntry(
          ID = resultSet.getInt("ID"),
          UnicodeCharacter = CHAR,
          PREVIOUS = resultSet.getInt("PREVIOUS"),
          NEXT = resultSet.getInt("NEXT")
        )
      }
    }
    catch{
      case e: SQLException => e.printStackTrace()
    }
  }
}

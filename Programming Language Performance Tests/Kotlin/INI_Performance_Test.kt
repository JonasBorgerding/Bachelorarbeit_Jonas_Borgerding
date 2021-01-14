import java.io.FileReader
import java.io.FileWriter
import java.lang.Exception
import org.ini4j.Ini

class INI_Performance_Test {
    data class IniEntry(var SECTION: String, var KEY: String, var VALUE: String)

    fun execute() {
        val iniEntries = mutableListOf<IniEntry>()
        try {
            Ini(FileReader("performance_test.ini")).run {
                val sections = keys
                for (sectionName in sections) {
                    for (i in 1..5) {
                        iniEntries += IniEntry(sectionName, sectionName + i, get(sectionName, sectionName + i))
                    }
                    val lastEntry = iniEntries.last()
                    put(lastEntry.SECTION, lastEntry.KEY, "Testing around")
                    store(FileWriter("performance_test.ini"))
                    put(lastEntry.SECTION, lastEntry.KEY, lastEntry.VALUE)
                    store(FileWriter("performance_test.ini"))
                }
            }
        } catch (e: Exception) {
            e.printStackTrace()
        }
    }
}

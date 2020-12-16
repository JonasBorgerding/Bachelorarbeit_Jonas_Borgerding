import java.io.FileReader
import java.io.FileWriter
import java.lang.Exception

class INI_Performance_Test {
    data class IniEntry(var SECTION: String, var KEY: String, var VALUE: String)

    fun execute() {
        val iniEntries = mutableListOf<IniEntry>()
        try {
            val ini = Ini(FileReader("performance_test.ini")).run {
                val sections = keySet()
                for (sectionName: String in sections) {
                    for (i in 1..6) {
                        iniEntries += IniEntry(sectionName, sectionName + i, ini.get(sectionName, sectionName + i))
                    }
                    val lastEntry = iniEntries.last()
                    ini.put(lastEntry.SECTION, lastEntry.KEY, "Testing around")
                    ini.store(FileWriter("performance_test.ini"))
                    ini.put(lastEntry.SECTION, lastEntry.KEY, lastEntry.VALUE)
                    ini.store(FileWriter("performance_test.ini"))
                }
            }
        } catch (e: Exception) {
            e.printStackTrace()
        }
    }
}
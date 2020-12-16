import org.ini4j.Ini

class INI_Performance_Test {
    class IniEntry {
        String SECTION
        String KEY
        String VALUE
    }

    void executeTest() {
        def iniEntries = []
        try {
            def ini = new Ini(new FileReader("performance_test.ini"))
            def section = ini.keySet()
            for (def sectionName: section) {
                for (def i = 1; i < 6; i++) {
                    iniEntries += new IniEntry(SECTION: sectionName, KEY: sectionName + i, VALUE: ini.get(sectionName, sectionName+i))
                }
                IniEntry lastEntry = iniEntries.last() as IniEntry
                ini.put(lastEntry.getSECTION(), lastEntry.getKEY(), "Testing around")
                ini.store(new FileWriter("performance_test.ini"))
                ini.put(lastEntry.getSECTION(), lastEntry.getKEY(), lastEntry.getVALUE())
                ini.store(new FileWriter("performance_test.ini"))
            }
        }
        catch (IOException e) {
            e.printStackTrace()
        }
    }
}

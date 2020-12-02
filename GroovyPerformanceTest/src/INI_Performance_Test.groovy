import org.ini4j.Ini

class INI_Performance_Test {
    class IniEntry {
        String SECTION
        String KEY
        String VALUE
    }

    void executeTest() {
        LinkedList<IniEntry> iniEntries = new LinkedList<>()
        try {
            Ini ini = new Ini(new FileReader("performance_test.ini"))
        }
        catch (IOException e) {
            e.printStackTrace()
        }
    }
}

import org.ini4j.Ini;

import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.LinkedList;
import java.util.Set;

public class INI_Performance_Test {
    static class IniEntry {
        private String SECTION;
        private String KEY;
        private String VALUE;

        IniEntry(String SECTION, String KEY, String VALUE) {
            this.SECTION = SECTION;
            this.KEY = KEY;
            this.VALUE = VALUE;
        }

        public String getVALUE() {
            return VALUE;
        }

        public void setVALUE(String VALUE) {
            this.VALUE = VALUE;
        }

        public String getKEY() {
            return KEY;
        }

        private void setKEY(String KEY) {
            this.KEY = KEY;
        }

        public String getSECTION() {
            return SECTION;
        }

        private void setSECTION(String SECTION) {
            this.SECTION = SECTION;
        }
    }

    void executeTest() {
        LinkedList<IniEntry> iniEntries = new LinkedList<>();
        try {
            Ini ini = new Ini(new FileReader("../performance_test.ini"));
            Set<String> sections = ini.keySet();
            for (String sectionName: sections) {
                for (int i = 1; i < 6; i++) {
                    iniEntries.add(new IniEntry(sectionName, sectionName+i, ini.get(sectionName, sectionName+i)));
                }
                IniEntry lastEntry = iniEntries.getLast();
                ini.put(lastEntry.getSECTION(), lastEntry.getKEY(), "Testing around");
                ini.store(new FileWriter("../performance_test.ini"));
                ini.put(lastEntry.getSECTION(), lastEntry.getKEY(), lastEntry.getVALUE());
                ini.store(new FileWriter("../performance_test.ini"));
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

import java.util.LinkedList;

public class Performance_Test {
    public static void main(String[] args) {
        LinkedList<Long> databaseTimes = new LinkedList<>();
        LinkedList<Long> iniFileTimes = new LinkedList<>();
        new Database_Performance_Test().executeTest(); //To "warm up"
        for (int i = 0; i < 500; i++) {
            long start = System.currentTimeMillis();
            new Database_Performance_Test().executeTest();
            databaseTimes.add(System.currentTimeMillis() - start);
        }
        float databaseAverage = databaseTimes.stream().mapToLong(x -> x).sum();
        databaseAverage /= databaseTimes.size();
        System.out.printf("Die durchschnittliche Zeit für die Datenbankabfrage beträgt: %f Sekunden\n", databaseAverage/1000.0);

        new INI_Performance_Test().executeTest();
        for (int i = 0; i < 500; i++) {
            long start = System.currentTimeMillis();
            new INI_Performance_Test().executeTest();
            iniFileTimes.add(System.currentTimeMillis() - start);
        }
        float iniAverage = iniFileTimes.stream().mapToLong(x -> x).sum();
        iniAverage /= iniFileTimes.size();
        System.out.printf("Die durchschnittliche Zeit für die INI Datei einlesen und ändern beträgt: %f Sekunden\n", iniAverage/1000.0);
    }
}

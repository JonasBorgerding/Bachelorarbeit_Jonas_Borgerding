package data;

import models.Filter;
import org.ini4j.Ini;
import org.ini4j.Profile;

import java.io.File;
import java.io.IOException;
import java.util.Arrays;
import java.util.LinkedList;
import java.util.List;

public class INIConnection {
    private INIConnection() {}

    public static final INIConnection INSTANCE = new INIConnection();

    private List<Filter> filter;
    private String personQuery;
    private String meetingQuery;

    public List<Filter> getFilter() {
        if (filter != null)
            return filter;
        try {
            Ini ini = new Ini(new File("config.ini"));
            int i = 1;
            filter = new LinkedList<>();
            Profile.Section currentFilter = ini.get("Filter" + i);
            while (currentFilter != null) {
                i++;
                filter.add(new Filter(currentFilter.get("Title"), Arrays.asList(currentFilter.get("DefaultValues").split(",")), currentFilter.get("QueryStatementLabel")));
                currentFilter = ini.get("Filter" + i);
            }
            return filter;
        } catch (IOException e) {
            e.printStackTrace();
        }
        return new LinkedList<>();
    }

    public String getPersonQuery() {
        if (personQuery != null)
            return personQuery;
        try {
            personQuery = new Ini(new File("config.ini")).get("SQLStrings", "FetchPersons");
            return personQuery;
        } catch (IOException e) {
            e.printStackTrace();
        }
        return "";
    }

    public String getMeetingQuery() {
        if (meetingQuery != null)
            return meetingQuery;
        try {
            meetingQuery = new Ini(new File("config.ini")).get("SQLStrings", "FetchMeetings");
            return meetingQuery;
        } catch (IOException e) {
            e.printStackTrace();
        }
        return "";
    }
}

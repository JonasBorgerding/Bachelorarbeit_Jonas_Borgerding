package models;

import java.util.List;

public class Filter {
    private final String title;
    private final List<String> defaultValues;
    private final String queryLabel;

    public Filter(String title, List<String> defaultValues, String queryLabel) {

        this.title = title;
        this.defaultValues = defaultValues;
        this.queryLabel = queryLabel;
    }

    public String getTitle() {
        return title;
    }

    public List<String> getDefaultValues() {
        return defaultValues;
    }

    public String getQueryLabel() {
        return queryLabel;
    }
}

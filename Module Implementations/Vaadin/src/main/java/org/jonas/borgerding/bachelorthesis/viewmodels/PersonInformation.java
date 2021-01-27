package org.jonas.borgerding.bachelorthesis.viewmodels;

import com.vaadin.flow.component.UI;
import com.vaadin.flow.component.button.Button;
import com.vaadin.flow.component.combobox.ComboBox;
import com.vaadin.flow.component.grid.Grid;
import com.vaadin.flow.component.html.Label;
import com.vaadin.flow.component.orderedlayout.HorizontalLayout;
import com.vaadin.flow.component.orderedlayout.VerticalLayout;
import com.vaadin.flow.component.polymertemplate.Id;
import com.vaadin.flow.dom.Element;
import com.vaadin.flow.router.Route;
import com.vaadin.flow.templatemodel.TemplateModel;
import com.vaadin.flow.component.Tag;
import com.vaadin.flow.component.dependency.JsModule;
import com.vaadin.flow.component.polymertemplate.PolymerTemplate;
import data.DatabaseConnection;
import data.INIConnection;
import models.Filter;
import models.Meeting;
import models.Person;
import org.vaadin.klaudeta.PaginatedGrid;

import java.util.Arrays;
import java.util.Dictionary;
import java.util.Hashtable;
import java.util.LinkedList;

/**
 * A Designer generated component for the person-information template.
 *
 * Designer will add and remove fields with @Id mappings but
 * does not overwrite or otherwise change this file.
 */
@Tag("person-information")
@JsModule("./src/person-information.js")
@Route("")
public class PersonInformation extends PolymerTemplate<PersonInformation.PersonInformationModel> {
    private final Dictionary<String, ComboBox<String>> queryStringLabelFilterDictionary;
    private PaginatedGrid<Meeting> meetingGrid;
    private PaginatedGrid<Person> personGrid;

    @Id("menu-toggle")
    private Button menuToggle;
    @Id("route-person-information")
    private Button routePersonInformation;
    @Id("filter-container")
    private VerticalLayout filterContainer;
    @Id("person-filter")
    private Button personFilter;
    @Id("main-content")
    private VerticalLayout mainContent;
    @Id("menu-list")
    private VerticalLayout menuList;
    @Id("person-grid-container")
    private VerticalLayout personGridContainer;
    @Id("meeting-grid-container")
    private VerticalLayout meetingGridContainer;

    /**
     * Creates a new PersonInformation.
     */
    public PersonInformation() {
        queryStringLabelFilterDictionary = new Hashtable<>();

        registerButtonEvents();
        registerGrids();
        registerGridEvents();
        registerFilter();
    }

    private void registerButtonEvents() {
        routePersonInformation.addClickListener(buttonClickEvent -> UI.getCurrent().navigate(PersonInformation.class));

        menuToggle.addClickListener(buttonClickEvent -> {
            if (menuList.getStyle().get("display") == null) {
                menuList.getStyle().set("display", "none");
            } else {
                menuList.getStyle().set("display", null);
            }
        });

        personFilter.addClickListener(buttonClickEvent -> personGrid.setItems(DatabaseConnection.INSTANCE.getPeople(
                queryStringLabelFilterDictionary.get(":city").getValue(),
                queryStringLabelFilterDictionary.get(":plz").getValue(),
                queryStringLabelFilterDictionary.get(":state").getValue()
        )));
    }

    private void registerGridEvents() {
        personGrid.addItemClickListener(personItemClickEvent -> {
            meetingGrid.setItems(DatabaseConnection.INSTANCE.getMeetings(personItemClickEvent.getItem().getID()));
        });
    }

    private void registerGrids() {
        personGrid = new PaginatedGrid<>();
        personGrid.addColumn(Person::getForename).setHeader("Vorname").setSortable(true).setWidth("20%");
        personGrid.addColumn(Person::getSurname).setHeader("Nachname").setSortable(true).setWidth("20%");
        personGrid.addColumn(Person::getCity).setHeader("Stadt").setSortable(true).setWidth("20%");
        personGrid.addColumn(Person::getZipCode).setHeader("PLZ").setSortable(true).setWidth("15%");
        personGrid.addColumn(Person::getState).setHeader("Bundesland").setSortable(true).setWidth("25%");
        personGrid.setPaginatorSize(5);
        personGrid.setPageSize(100);
        personGrid.getStyle().set("height", "calc(50vh - 75px)");
        personGrid.getStyle().set("width", "100%");
        personGridContainer.add(personGrid);

        meetingGrid = new PaginatedGrid<>();
        meetingGrid.addColumn(Meeting::getPersonInformation).setHeader("Personen Information").setSortable(true).setWidth("75%");
        meetingGrid.addColumn(Meeting::getDate).setHeader("Datum").setSortable(true).setWidth("25%");
        meetingGrid.setPaginatorSize(5);
        meetingGrid.setPageSize(100);
        meetingGrid.getStyle().set("height", "calc(47vh - 125px)");
        meetingGrid.getStyle().set("width", "100%");
        meetingGrid.getStyle().set("padding-top", "50px");
        meetingGridContainer.add(meetingGrid);
    }

    private void registerFilter() {
        for (Filter filter : INIConnection.INSTANCE.getFilter()) {
            Label label = new Label();
            label.getStyle().set("font-weight", "bold");
            label.setText(filter.getTitle());
            filterContainer.add(label);
            ComboBox<String> comboBox = new ComboBox<>();
            comboBox.setItems(filter.getDefaultValues());
            comboBox.addCustomValueSetListener(comboBoxCustomValueSetEvent -> {
                String comboBoxValue = comboBoxCustomValueSetEvent.getDetail();
                comboBox.setValue(comboBoxValue == null ? "" : comboBoxValue);
            });
            comboBox.addValueChangeListener(comboBoxStringComponentValueChangeEvent -> {
                if (comboBoxStringComponentValueChangeEvent.getValue() == null)
                    comboBox.setValue("");
            });
            filterContainer.add(comboBox);
            comboBox.setValue("");
            queryStringLabelFilterDictionary.put(filter.getQueryLabel(), comboBox);
        }
    }

    /**
     * This model binds properties between PersonInformation and person-information
     */
    public interface PersonInformationModel extends TemplateModel {
        // Add setters and getters for template properties here.
    }
}

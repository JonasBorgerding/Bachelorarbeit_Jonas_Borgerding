package org.jonas.borgerding.bachelorthesis;

import com.vaadin.flow.component.button.Button;
import com.vaadin.flow.component.polymertemplate.Id;
import com.vaadin.flow.dom.Element;
import com.vaadin.flow.router.Route;
import com.vaadin.flow.templatemodel.TemplateModel;
import com.vaadin.flow.component.Tag;
import com.vaadin.flow.component.dependency.JsModule;
import com.vaadin.flow.component.polymertemplate.PolymerTemplate;

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

    @Id("menu-toggle")
    private Button menuToggle;
    @Id("menu-list")
    private Element menuList;

    /**
     * Creates a new PersonInformation.
     */
    public PersonInformation() {
        menuToggle.addClickListener(buttonClickEvent -> {
            if (menuList.getStyle().has("display"))
                menuList.getStyle().remove("display");
            else
                menuList.getStyle().set("display", "none");
        });
    }

    /**
     * This model binds properties between PersonInformation and person-information
     */
    public interface PersonInformationModel extends TemplateModel {
        // Add setters and getters for template properties here.
    }
}

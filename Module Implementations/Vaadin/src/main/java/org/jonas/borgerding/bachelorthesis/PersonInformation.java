package org.jonas.borgerding.bachelorthesis;

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
@JsModule("./person-information.js")
public class PersonInformation extends PolymerTemplate<PersonInformation.PersonInformationModel> {

    /**
     * Creates a new PersonInformation.
     */
    public PersonInformation() {
        // You can initialise any data required for the connected UI components here.
    }

    /**
     * This model binds properties between PersonInformation and person-information
     */
    public interface PersonInformationModel extends TemplateModel {
        // Add setters and getters for template properties here.
    }
}

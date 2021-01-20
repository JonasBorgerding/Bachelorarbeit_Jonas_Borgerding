package org.jonas.borgerding.bachelorthesis;

import com.vaadin.flow.templatemodel.TemplateModel;
import com.vaadin.flow.component.Tag;
import com.vaadin.flow.component.dependency.JsModule;
import com.vaadin.flow.component.polymertemplate.PolymerTemplate;

/**
 * A Designer generated component for the dropdown-input template.
 *
 * Designer will add and remove fields with @Id mappings but
 * does not overwrite or otherwise change this file.
 */
@Tag("dropdown-input")
@JsModule("./src/dropdown-input.js")
public class DropdownInput extends PolymerTemplate<DropdownInput.DropdownInputModel> {

    /**
     * Creates a new DropdownInput.
     */
    public DropdownInput() {
        // You can initialise any data required for the connected UI components here.
    }

    /**
     * This model binds properties between DropdownInput and dropdown-input
     */
    public interface DropdownInputModel extends TemplateModel {
        // Add setters and getters for template properties here.
    }
}

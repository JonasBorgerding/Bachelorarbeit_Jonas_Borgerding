import {html, PolymerElement} from '@polymer/polymer/polymer-element.js';
import '@vaadin/vaadin-combo-box/src/vaadin-combo-box-dropdown-wrapper.js';

class DropdownInput extends PolymerElement {

    static get template() {
        return html`
<style include="shared-styles">
                :host {
                    display: block;
                    height: 100%;
                }
            </style>
<vaadin-combo-box-dropdown-wrapper></vaadin-combo-box-dropdown-wrapper>
`;
    }

    static get is() {
        return 'dropdown-input';
    }

    static get properties() {
        return {
            // Declare your properties here.
        };
    }
}

customElements.define(DropdownInput.is, DropdownInput);

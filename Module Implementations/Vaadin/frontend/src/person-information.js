import {html, PolymerElement} from '@polymer/polymer/polymer-element.js';
import '@vaadin/vaadin-ordered-layout/src/vaadin-horizontal-layout.js';
import '@polymer/iron-icon/iron-icon.js';
import '@vaadin/vaadin-button/src/vaadin-button.js';
import '@vaadin/vaadin-ordered-layout/src/vaadin-vertical-layout.js';
import './dropdown-input.js';

class PersonInformation extends PolymerElement {

    static get template() {
        return html`
<style include="shared-styles">
                :host {
                    display: block;
                    height: 100%;
                }
            </style>
<vaadin-vertical-layout style="width: 100%; height: 100%;">
 <vaadin-horizontal-layout class="header" style="width: 100%; flex-basis: var(--lumo-size-l); flex-shrink: 0; background-color: var(--lumo-contrast-10pct); height: 50px;">
  <vaadin-button theme="icon" aria-label="Add new" id="menu-toggle">
   <iron-icon icon="lumo:menu"></iron-icon>
  </vaadin-button>
 </vaadin-horizontal-layout>
 <vaadin-horizontal-layout style="width: 100%; flex-grow: 1; flex-shrink: 1; flex-basis: auto;">
  <vaadin-vertical-layout class="sidebar" style="flex-basis: calc(7*var(--lumo-size-s)); flex-shrink: 0; background-color: var(--lumo-contrast-5pct); width: 250px;" id="menu-list">
   <vaadin-button style="align-self: stretch;">
     Personen Information 
   </vaadin-button>
  </vaadin-vertical-layout>
  <vaadin-vertical-layout class="content" style="flex-grow: 1; flex-shrink: 1; flex-basis: auto; width: calc(100%-250px); height: calc(100%-105px);" id="main-content">
   <vaadin-horizontal-layout theme="spacing" style="width: calc(100%-250px);">
    <dropdown-input></dropdown-input>
   </vaadin-horizontal-layout>
  </vaadin-vertical-layout>
 </vaadin-horizontal-layout>
 <vaadin-horizontal-layout class="footer" style="width: 100%; flex-basis: var(--lumo-size-l); flex-shrink: 0; background-color: var(--lumo-contrast-10pct); height: 56px;">
  <label style="align-self: center;">Jonas Borgerding, Copyright Ⓒ 2021</label>
 </vaadin-horizontal-layout>
</vaadin-vertical-layout>
`;
    }

    static get is() {
        return 'person-information';
    }

    static get properties() {
        return {
            // Declare your properties here.
        };
    }
}

customElements.define(PersonInformation.is, PersonInformation);

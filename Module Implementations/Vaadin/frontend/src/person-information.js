import {html, PolymerElement} from '@polymer/polymer/polymer-element.js';
import '@polymer/iron-icon/iron-icon.js';
import '@vaadin/vaadin-button/src/vaadin-button.js';
import '@vaadin/vaadin-ordered-layout/src/vaadin-vertical-layout.js';
import '@vaadin/vaadin-ordered-layout/src/vaadin-horizontal-layout.js';

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
   <vaadin-button style="width: 100%;" id="route-person-information">
     Personen Information 
   </vaadin-button>
  </vaadin-vertical-layout>
  <vaadin-vertical-layout class="content" style="flex-grow: 1; flex-shrink: 1; flex-basis: auto; width: 100%; height: calc(100%-105px);padding: 0 0 0 0;" id="main-content">
   <vaadin-horizontal-layout style="width: 100%; height: 60%;">
    <vaadin-vertical-layout style="height: 100%; width: 75%; flex-shrink: 0; max-width: 75%;" id="person-grid-container"></vaadin-vertical-layout>
    <vaadin-vertical-layout style="height: 100%; width: 25%; flex-shrink: 0; padding: 0 0 0 5px; margin-top: 2vh;">
     <vaadin-vertical-layout id="filter-container" style="width: 100%; padding: 0 0 0 0;"></vaadin-vertical-layout>
     <vaadin-button id="person-filter" style="align-self: stretch;">
       Filtern 
     </vaadin-button>
    </vaadin-vertical-layout>
   </vaadin-horizontal-layout>
   <vaadin-horizontal-layout style="width: 100%; height: 40%; margin-top: -5vh;">
    <vaadin-vertical-layout theme="spacing" id="meeting-grid-container" style="width: 100%; height: 100%;"></vaadin-vertical-layout>
   </vaadin-horizontal-layout>
  </vaadin-vertical-layout>
 </vaadin-horizontal-layout>
 <vaadin-horizontal-layout class="footer" style="width: 100%; flex-basis: var(--lumo-size-l); flex-shrink: 0; background-color: var(--lumo-contrast-10pct); height: 56px; padding: 0 0 0 0;">
  <label style="align-self: center; margin-left:5px">Jonas Borgerding, Copyright Ⓒ 2021</label>
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

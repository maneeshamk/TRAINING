import {
  TestBed,
  init_testing
} from "./chunk-GHPYXVWF.js";
import {
  Component,
  __decorate,
  init_core,
  init_tslib_es6
} from "./chunk-UJO3R2K5.js";
import {
  __async,
  __commonJS,
  __esm
} from "./chunk-TTULUY32.js";

// angular:jit:template:src\app\component\htmlform\htmlform.component.html
var htmlform_component_default;
var init_htmlform_component = __esm({
  "angular:jit:template:src\\app\\component\\htmlform\\htmlform.component.html"() {
    htmlform_component_default = `<form #feedbackForm="ngForm" (ngSubmit)="onSubmit(feedbackForm)">
  <!-- Name Field -->
  <label for="name">Name:</label>
  <input 
    type="text" 
    id="name" 
    name="name" 
    ngModel 
    #name="ngModel" 
    required
    minlength="3"
  >
  <div *ngIf="name.invalid && name.touched" style="color: red;">
    <small *ngIf="name.errors?.['required']">Name is required.</small>
    <small *ngIf="name.errors?.['minlength']">Name must be at least 3 characters long.</small>
  </div>
  <br/>

  <!-- Email Field -->
  <label for="email">Email:</label>
  <input 
    type="email" 
    id="email" 
    name="email" 
    ngModel 
    #email="ngModel" 
    required 
    email
  >
  <div *ngIf="email.invalid && email.touched" style="color: red;">
    <small *ngIf="email.errors?.['required']">Email is required.</small>
    <small *ngIf="email.errors?.['email']">Enter a valid email address.</small>
  </div>
  <br/>

  <!-- Message Field -->
  <label for="message">Message:</label>
  <textarea 
    id="message" 
    name="message" 
    ngModel 
    #message="ngModel" 
    required
    minlength="10"
  ></textarea>
  <div *ngIf="message.invalid && message.touched" style="color: red;">
    <small *ngIf="message.errors?.['required']">Message is required.</small>
    <small *ngIf="message.errors?.['minlength']">Message must be at least 10 characters long.</small>
  </div>
  <br/>

  <!-- Submit Button -->
  <button type="submit" [disabled]="feedbackForm.invalid">Submit</button>
</form>
`;
  }
});

// angular:jit:style:src\app\component\htmlform\htmlform.component.css
var htmlform_component_default2;
var init_htmlform_component2 = __esm({
  "angular:jit:style:src\\app\\component\\htmlform\\htmlform.component.css"() {
    htmlform_component_default2 = "/* src/app/component/htmlform/htmlform.component.css */\n/*# sourceMappingURL=htmlform.component.css.map */\n";
  }
});

// src/app/component/htmlform/htmlform.component.ts
var HtmlformComponent;
var init_htmlform_component3 = __esm({
  "src/app/component/htmlform/htmlform.component.ts"() {
    "use strict";
    init_tslib_es6();
    init_htmlform_component();
    init_htmlform_component2();
    init_core();
    HtmlformComponent = class HtmlformComponent2 {
      onSubmit(form) {
        console.log("Form submitted:", form.value);
      }
    };
    HtmlformComponent = __decorate([
      Component({
        selector: "app-htmlform",
        standalone: false,
        template: htmlform_component_default,
        styles: [htmlform_component_default2]
      })
    ], HtmlformComponent);
  }
});

// src/app/component/htmlform/htmlform.component.spec.ts
var require_htmlform_component_spec = __commonJS({
  "src/app/component/htmlform/htmlform.component.spec.ts"(exports) {
    init_testing();
    init_htmlform_component3();
    describe("HtmlformComponent", () => {
      let component;
      let fixture;
      beforeEach(() => __async(null, null, function* () {
        yield TestBed.configureTestingModule({
          declarations: [HtmlformComponent]
        }).compileComponents();
        fixture = TestBed.createComponent(HtmlformComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
      }));
      it("should create", () => {
        expect(component).toBeTruthy();
      });
    });
  }
});
export default require_htmlform_component_spec();
//# sourceMappingURL=spec-htmlform.component.spec.js.map

import {
  TestBed,
  init_testing
} from "./chunk-GHPYXVWF.js";
import {
  Component,
  Input,
  __decorate,
  init_core,
  init_tslib_es6
} from "./chunk-UJO3R2K5.js";
import {
  __async,
  __commonJS,
  __esm
} from "./chunk-TTULUY32.js";

// angular:jit:template:src\app\component\body\body.component.html
var body_component_default;
var init_body_component = __esm({
  "angular:jit:template:src\\app\\component\\body\\body.component.html"() {
    body_component_default = `<p>body works!/p>
{{content}}

<div *ngIf="link=='hobby'">
  <app-hobbies [myhobbies]="myhobbies"></app-hobbies>
    </div>
    <div *ngIf="link=='fav'">
      <app-favourite></app-favourite>
    </div>`;
  }
});

// angular:jit:style:src\app\component\body\body.component.css
var body_component_default2;
var init_body_component2 = __esm({
  "angular:jit:style:src\\app\\component\\body\\body.component.css"() {
    body_component_default2 = "/* src/app/component/body/body.component.css */\n/*# sourceMappingURL=body.component.css.map */\n";
  }
});

// src/app/component/body/body.component.ts
var BodyComponent;
var init_body_component3 = __esm({
  "src/app/component/body/body.component.ts"() {
    "use strict";
    init_tslib_es6();
    init_body_component();
    init_body_component2();
    init_core();
    BodyComponent = class BodyComponent2 {
      link = "";
      myhobbies = [];
      content = "";
      ngOnChanges() {
        switch (this.link) {
          case "hobby":
            this.content = "My hobbies include reading, travelling, and coding.";
            break;
          case "new":
            this.content = "I am exploring new hobbies like painting and hiking.";
            break;
          case "fav":
            this.content = "My favorite hobby is reading mystery novels.";
            break;
          default:
            this.content = "Please select a hobby from the menu.";
        }
      }
      static propDecorators = {
        link: [{ type: Input }],
        myhobbies: [{ type: Input }]
      };
    };
    BodyComponent = __decorate([
      Component({
        selector: "app-body",
        standalone: false,
        template: body_component_default,
        styles: [body_component_default2]
      })
    ], BodyComponent);
  }
});

// src/app/component/body/body.component.spec.ts
var require_body_component_spec = __commonJS({
  "src/app/component/body/body.component.spec.ts"(exports) {
    init_testing();
    init_body_component3();
    describe("BodyComponent", () => {
      let component;
      let fixture;
      beforeEach(() => __async(null, null, function* () {
        yield TestBed.configureTestingModule({
          declarations: [BodyComponent]
        }).compileComponents();
        fixture = TestBed.createComponent(BodyComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
      }));
      it("should create", () => {
        expect(component).toBeTruthy();
      });
    });
  }
});
export default require_body_component_spec();
//# sourceMappingURL=spec-body.component.spec.js.map

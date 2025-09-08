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

// angular:jit:template:src\app\component\register\register.component.html
var register_component_default;
var init_register_component = __esm({
  "angular:jit:template:src\\app\\component\\register\\register.component.html"() {
    register_component_default = '<p style="background-color: rgb(245, 231, 220);">register works! {{title}}</p>\n\n\n';
  }
});

// angular:jit:style:src\app\component\register\register.component.css
var register_component_default2;
var init_register_component2 = __esm({
  "angular:jit:style:src\\app\\component\\register\\register.component.css"() {
    register_component_default2 = "/* src/app/component/register/register.component.css */\np {\n  background-color: brown;\n}\n/*# sourceMappingURL=register.component.css.map */\n";
  }
});

// src/app/component/register/register.component.ts
var RegisterComponent;
var init_register_component3 = __esm({
  "src/app/component/register/register.component.ts"() {
    "use strict";
    init_tslib_es6();
    init_register_component();
    init_register_component2();
    init_core();
    RegisterComponent = class RegisterComponent2 {
      title = "hello world";
    };
    RegisterComponent = __decorate([
      Component({
        selector: "app-register",
        standalone: false,
        template: register_component_default,
        styles: [register_component_default2]
      })
    ], RegisterComponent);
  }
});

// src/app/component/register/register.component.spec.ts
var require_register_component_spec = __commonJS({
  "src/app/component/register/register.component.spec.ts"(exports) {
    init_testing();
    init_register_component3();
    describe("RegisterComponent", () => {
      let component;
      let fixture;
      beforeEach(() => __async(null, null, function* () {
        yield TestBed.configureTestingModule({
          declarations: [RegisterComponent]
        }).compileComponents();
        fixture = TestBed.createComponent(RegisterComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
      }));
      it("should create", () => {
        expect(component).toBeTruthy();
      });
    });
  }
});
export default require_register_component_spec();
//# sourceMappingURL=spec-register.component.spec.js.map

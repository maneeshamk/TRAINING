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

// angular:jit:template:src\app\component\style2\style2.component.html
var style2_component_default;
var init_style2_component = __esm({
  "angular:jit:template:src\\app\\component\\style2\\style2.component.html"() {
    style2_component_default = `<h2>ngStyle Example</h2>

<p [ngStyle]="{'color': textColor, 'font-size': fontSize + 'px'}">
  This text changes color and size dynamically
</p>

<button (click)="changeColor()">Change Color</button>
<button (click)="increaseFont()">Increase Font Size</button>`;
  }
});

// angular:jit:style:src\app\component\style2\style2.component.css
var style2_component_default2;
var init_style2_component2 = __esm({
  "angular:jit:style:src\\app\\component\\style2\\style2.component.css"() {
    style2_component_default2 = "/* src/app/component/style2/style2.component.css */\n/*# sourceMappingURL=style2.component.css.map */\n";
  }
});

// src/app/component/style2/style2.component.ts
var Style2Component;
var init_style2_component3 = __esm({
  "src/app/component/style2/style2.component.ts"() {
    "use strict";
    init_tslib_es6();
    init_style2_component();
    init_style2_component2();
    init_core();
    Style2Component = class Style2Component2 {
      textColor = "blue";
      fontSize = 16;
      changeColor() {
        this.textColor = this.textColor === "blue" ? "red" : "blue";
      }
      increaseFont() {
        this.fontSize += 2;
      }
    };
    Style2Component = __decorate([
      Component({
        selector: "app-style2",
        standalone: false,
        template: style2_component_default,
        styles: [style2_component_default2]
      })
    ], Style2Component);
  }
});

// src/app/component/style2/style2.component.spec.ts
var require_style2_component_spec = __commonJS({
  "src/app/component/style2/style2.component.spec.ts"(exports) {
    init_testing();
    init_style2_component3();
    describe("Style2Component", () => {
      let component;
      let fixture;
      beforeEach(() => __async(null, null, function* () {
        yield TestBed.configureTestingModule({
          declarations: [Style2Component]
        }).compileComponents();
        fixture = TestBed.createComponent(Style2Component);
        component = fixture.componentInstance;
        fixture.detectChanges();
      }));
      it("should create", () => {
        expect(component).toBeTruthy();
      });
    });
  }
});
export default require_style2_component_spec();
//# sourceMappingURL=spec-style2.component.spec.js.map

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

// angular:jit:template:src\app\component\stylesample\stylesample.component.html
var stylesample_component_default;
var init_stylesample_component = __esm({
  "angular:jit:template:src\\app\\component\\stylesample\\stylesample.component.html"() {
    stylesample_component_default = `<h2>ngClass Example</h2>

<!-- Add a class conditionally -->
<p [ngClass]="isSpecial ? 'special-text' : 'normal-text'">
  This text changes style based on isSpecial
</p>

<!-- Add multiple classes conditionally -->
<p [ngClass]="{'special-text': isSpecial, 'highlight': isHighlighted}">
  This text can have multiple classes
</p>

<button (click)="toggleSpecial()">Toggle Special</button>
<button (click)="toggleHighlight()">Toggle Highlight</button>`;
  }
});

// angular:jit:style:src\app\component\stylesample\stylesample.component.css
var stylesample_component_default2;
var init_stylesample_component2 = __esm({
  "angular:jit:style:src\\app\\component\\stylesample\\stylesample.component.css"() {
    stylesample_component_default2 = "/* src/app/component/stylesample/stylesample.component.css */\n.special-text {\n  color: green;\n  font-weight: bold;\n}\n.normal-text {\n  color: gray;\n}\n.highlight {\n  background-color: yellow;\n}\n/*# sourceMappingURL=stylesample.component.css.map */\n";
  }
});

// src/app/component/stylesample/stylesample.component.ts
var StylesampleComponent;
var init_stylesample_component3 = __esm({
  "src/app/component/stylesample/stylesample.component.ts"() {
    "use strict";
    init_tslib_es6();
    init_stylesample_component();
    init_stylesample_component2();
    init_core();
    StylesampleComponent = class StylesampleComponent2 {
      isSpecial = true;
      isHighlighted = false;
      toggleSpecial() {
        this.isSpecial = !this.isSpecial;
      }
      toggleHighlight() {
        this.isHighlighted = !this.isHighlighted;
      }
    };
    StylesampleComponent = __decorate([
      Component({
        selector: "app-stylesample",
        standalone: false,
        template: stylesample_component_default,
        styles: [stylesample_component_default2]
      })
    ], StylesampleComponent);
  }
});

// src/app/component/stylesample/stylesample.component.spec.ts
var require_stylesample_component_spec = __commonJS({
  "src/app/component/stylesample/stylesample.component.spec.ts"(exports) {
    init_testing();
    init_stylesample_component3();
    describe("StylesampleComponent", () => {
      let component;
      let fixture;
      beforeEach(() => __async(null, null, function* () {
        yield TestBed.configureTestingModule({
          declarations: [StylesampleComponent]
        }).compileComponents();
        fixture = TestBed.createComponent(StylesampleComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
      }));
      it("should create", () => {
        expect(component).toBeTruthy();
      });
    });
  }
});
export default require_stylesample_component_spec();
//# sourceMappingURL=spec-stylesample.component.spec.js.map

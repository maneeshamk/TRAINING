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

// angular:jit:template:src\app\component\favourite\favourite.component.html
var favourite_component_default;
var init_favourite_component = __esm({
  "angular:jit:template:src\\app\\component\\favourite\\favourite.component.html"() {
    favourite_component_default = '<p style="background-color: blueviolet;">favourite works!</p>\n';
  }
});

// angular:jit:style:src\app\component\favourite\favourite.component.css
var favourite_component_default2;
var init_favourite_component2 = __esm({
  "angular:jit:style:src\\app\\component\\favourite\\favourite.component.css"() {
    favourite_component_default2 = "/* src/app/component/favourite/favourite.component.css */\np {\n  background-color: blue !important;\n}\n/*# sourceMappingURL=favourite.component.css.map */\n";
  }
});

// src/app/component/favourite/favourite.component.ts
var FavouriteComponent;
var init_favourite_component3 = __esm({
  "src/app/component/favourite/favourite.component.ts"() {
    "use strict";
    init_tslib_es6();
    init_favourite_component();
    init_favourite_component2();
    init_core();
    FavouriteComponent = class FavouriteComponent2 {
    };
    FavouriteComponent = __decorate([
      Component({
        selector: "app-favourite",
        standalone: false,
        template: favourite_component_default,
        styles: [favourite_component_default2]
      })
    ], FavouriteComponent);
  }
});

// src/app/component/favourite/favourite.component.spec.ts
var require_favourite_component_spec = __commonJS({
  "src/app/component/favourite/favourite.component.spec.ts"(exports) {
    init_testing();
    init_favourite_component3();
    describe("FavouriteComponent", () => {
      let component;
      let fixture;
      beforeEach(() => __async(null, null, function* () {
        yield TestBed.configureTestingModule({
          declarations: [FavouriteComponent]
        }).compileComponents();
        fixture = TestBed.createComponent(FavouriteComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
      }));
      it("should create", () => {
        expect(component).toBeTruthy();
      });
    });
  }
});
export default require_favourite_component_spec();
//# sourceMappingURL=spec-favourite.component.spec.js.map

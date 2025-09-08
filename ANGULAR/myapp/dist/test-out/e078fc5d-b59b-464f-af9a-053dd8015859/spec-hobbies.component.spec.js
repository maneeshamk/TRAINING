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

// angular:jit:template:src\app\component\hobbies\hobbies.component.html
var hobbies_component_default;
var init_hobbies_component = __esm({
  "angular:jit:template:src\\app\\component\\hobbies\\hobbies.component.html"() {
    hobbies_component_default = `<p>hobbies works!</p>
<div *ngFor="let hobby of myhobbies">
  <p>{{hobby.name}} - {{hobby.fav}}</p>
  <button (click)="toggleFavorite(hobby)">{{hobby.fav ? 'Unfavorite' : 'Favorite'}}</button>    `;
  }
});

// angular:jit:style:src\app\component\hobbies\hobbies.component.css
var hobbies_component_default2;
var init_hobbies_component2 = __esm({
  "angular:jit:style:src\\app\\component\\hobbies\\hobbies.component.css"() {
    hobbies_component_default2 = "/* src/app/component/hobbies/hobbies.component.css */\n/*# sourceMappingURL=hobbies.component.css.map */\n";
  }
});

// src/app/component/hobbies/hobbies.component.ts
var HobbiesComponent;
var init_hobbies_component3 = __esm({
  "src/app/component/hobbies/hobbies.component.ts"() {
    "use strict";
    init_tslib_es6();
    init_hobbies_component();
    init_hobbies_component2();
    init_core();
    HobbiesComponent = class HobbiesComponent2 {
      myhobbies = [];
      toggleFavorite(hobby) {
        hobby.fav = !hobby.fav;
        console.log(`${hobby.name} is now ${hobby.fav ? "a favorite" : "not a favorite"}.`);
      }
      static propDecorators = {
        myhobbies: [{ type: Input }]
      };
    };
    HobbiesComponent = __decorate([
      Component({
        selector: "app-hobbies",
        standalone: false,
        template: hobbies_component_default,
        styles: [hobbies_component_default2]
      })
    ], HobbiesComponent);
  }
});

// src/app/component/hobbies/hobbies.component.spec.ts
var require_hobbies_component_spec = __commonJS({
  "src/app/component/hobbies/hobbies.component.spec.ts"(exports) {
    init_testing();
    init_hobbies_component3();
    describe("HobbiesComponent", () => {
      let component;
      let fixture;
      beforeEach(() => __async(null, null, function* () {
        yield TestBed.configureTestingModule({
          declarations: [HobbiesComponent]
        }).compileComponents();
        fixture = TestBed.createComponent(HobbiesComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
      }));
      it("should create", () => {
        expect(component).toBeTruthy();
      });
    });
  }
});
export default require_hobbies_component_spec();
//# sourceMappingURL=spec-hobbies.component.spec.js.map

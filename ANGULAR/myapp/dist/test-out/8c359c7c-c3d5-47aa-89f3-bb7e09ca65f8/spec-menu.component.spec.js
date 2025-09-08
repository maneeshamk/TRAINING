import {
  TestBed,
  init_testing
} from "./chunk-GHPYXVWF.js";
import {
  Component,
  EventEmitter,
  Output,
  __decorate,
  init_core,
  init_tslib_es6
} from "./chunk-UJO3R2K5.js";
import {
  __async,
  __commonJS,
  __esm
} from "./chunk-TTULUY32.js";

// angular:jit:template:src\app\component\menu\menu.component.html
var menu_component_default;
var init_menu_component = __esm({
  "angular:jit:template:src\\app\\component\\menu\\menu.component.html"() {
    menu_component_default = `<button (click)="onMenuItemClick('hobby')">My hobby</button> <button (click)="onMenuItemClick('new')">New hobby</button> <button (click)="onMenuItemClick('fav')">Favourite hobby</button>`;
  }
});

// angular:jit:style:src\app\component\menu\menu.component.css
var menu_component_default2;
var init_menu_component2 = __esm({
  "angular:jit:style:src\\app\\component\\menu\\menu.component.css"() {
    menu_component_default2 = "/* src/app/component/menu/menu.component.css */\n/*# sourceMappingURL=menu.component.css.map */\n";
  }
});

// src/app/component/menu/menu.component.ts
var MenuComponent;
var init_menu_component3 = __esm({
  "src/app/component/menu/menu.component.ts"() {
    "use strict";
    init_tslib_es6();
    init_menu_component();
    init_menu_component2();
    init_core();
    init_core();
    MenuComponent = class MenuComponent2 {
      menu = new EventEmitter();
      onMenuItemClick(item) {
        console.log("Menu item clicked: ", item);
        this.menu.emit(item);
      }
      static propDecorators = {
        menu: [{ type: Output }]
      };
    };
    MenuComponent = __decorate([
      Component({
        selector: "app-menu",
        standalone: false,
        template: menu_component_default,
        styles: [menu_component_default2]
      })
    ], MenuComponent);
  }
});

// src/app/component/menu/menu.component.spec.ts
var require_menu_component_spec = __commonJS({
  "src/app/component/menu/menu.component.spec.ts"(exports) {
    init_testing();
    init_menu_component3();
    describe("MenuComponent", () => {
      let component;
      let fixture;
      beforeEach(() => __async(null, null, function* () {
        yield TestBed.configureTestingModule({
          declarations: [MenuComponent]
        }).compileComponents();
        fixture = TestBed.createComponent(MenuComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
      }));
      it("should create", () => {
        expect(component).toBeTruthy();
      });
    });
  }
});
export default require_menu_component_spec();
//# sourceMappingURL=spec-menu.component.spec.js.map

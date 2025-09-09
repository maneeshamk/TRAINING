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

// angular:jit:template:src\app\component\lifecycle\lifecycle.component.html
var lifecycle_component_default;
var init_lifecycle_component = __esm({
  "angular:jit:template:src\\app\\component\\lifecycle\\lifecycle.component.html"() {
    lifecycle_component_default = "<p>{{data}}</p>\n";
  }
});

// angular:jit:style:src\app\component\lifecycle\lifecycle.component.css
var lifecycle_component_default2;
var init_lifecycle_component2 = __esm({
  "angular:jit:style:src\\app\\component\\lifecycle\\lifecycle.component.css"() {
    lifecycle_component_default2 = "/* src/app/component/lifecycle/lifecycle.component.css */\n/*# sourceMappingURL=lifecycle.component.css.map */\n";
  }
});

// src/app/component/lifecycle/lifecycle.component.ts
var LifecycleComponent;
var init_lifecycle_component3 = __esm({
  "src/app/component/lifecycle/lifecycle.component.ts"() {
    "use strict";
    init_tslib_es6();
    init_lifecycle_component();
    init_lifecycle_component2();
    init_core();
    LifecycleComponent = class LifecycleComponent2 {
      data;
      constructor() {
        console.log("Constructor: Child created");
      }
      ngOnChanges() {
        console.log("ngOnChanges: Input data changed");
      }
      ngOnInit() {
        console.log("ngOnInit: Component initialized");
      }
      ngDoCheck() {
        console.log("ngDoCheck: Change detection run");
      }
      ngAfterContentInit() {
        console.log("ngAfterContentInit: Content projected");
      }
      ngAfterContentChecked() {
        console.log("ngAfterContentChecked: Projected content checked");
      }
      ngAfterViewInit() {
        console.log("ngAfterViewInit: View initialized");
      }
      ngAfterViewChecked() {
        console.log("ngAfterViewChecked: View checked");
      }
      ngOnDestroy() {
        console.log("ngOnDestroy: Component is being destroyed");
      }
      static ctorParameters = () => [];
      static propDecorators = {
        data: [{ type: Input }]
      };
    };
    LifecycleComponent = __decorate([
      Component({
        selector: "app-lifecycle",
        standalone: false,
        template: lifecycle_component_default,
        styles: [lifecycle_component_default2]
      })
    ], LifecycleComponent);
  }
});

// src/app/component/lifecycle/lifecycle.component.spec.ts
var require_lifecycle_component_spec = __commonJS({
  "src/app/component/lifecycle/lifecycle.component.spec.ts"(exports) {
    init_testing();
    init_lifecycle_component3();
    describe("LifecycleComponent", () => {
      let component;
      let fixture;
      beforeEach(() => __async(null, null, function* () {
        yield TestBed.configureTestingModule({
          declarations: [LifecycleComponent]
        }).compileComponents();
        fixture = TestBed.createComponent(LifecycleComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
      }));
      it("should create", () => {
        expect(component).toBeTruthy();
      });
    });
  }
});
export default require_lifecycle_component_spec();
//# sourceMappingURL=spec-lifecycle.component.spec.js.map

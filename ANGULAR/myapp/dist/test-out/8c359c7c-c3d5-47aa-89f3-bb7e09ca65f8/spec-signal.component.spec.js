import {
  TestBed,
  init_testing
} from "./chunk-GHPYXVWF.js";
import {
  Component,
  __decorate,
  init_core,
  init_tslib_es6,
  signal
} from "./chunk-UJO3R2K5.js";
import {
  __async,
  __commonJS,
  __esm
} from "./chunk-TTULUY32.js";

// angular:jit:template:src\app\component\signal\signal.component.html
var signal_component_default;
var init_signal_component = __esm({
  "angular:jit:template:src\\app\\component\\signal\\signal.component.html"() {
    signal_component_default = '{{count()}}\n\n<button (click)="increment()">Increment</button>\n<button (click)="decrement()">Decrement</button> \n<button (click)="reset()">Reset</button>';
  }
});

// angular:jit:style:src\app\component\signal\signal.component.css
var signal_component_default2;
var init_signal_component2 = __esm({
  "angular:jit:style:src\\app\\component\\signal\\signal.component.css"() {
    signal_component_default2 = "/* src/app/component/signal/signal.component.css */\n/*# sourceMappingURL=signal.component.css.map */\n";
  }
});

// src/app/component/signal/signal.component.ts
var SignalComponent;
var init_signal_component3 = __esm({
  "src/app/component/signal/signal.component.ts"() {
    "use strict";
    init_tslib_es6();
    init_signal_component();
    init_signal_component2();
    init_core();
    SignalComponent = class SignalComponent2 {
      count = signal(0);
      increment() {
        this.count.update((value) => value + 1);
      }
      decrement() {
        this.count.update((value) => value - 1);
      }
      reset() {
        this.count.set(0);
      }
    };
    SignalComponent = __decorate([
      Component({
        selector: "app-signal",
        standalone: false,
        template: signal_component_default,
        styles: [signal_component_default2]
      })
    ], SignalComponent);
  }
});

// src/app/component/signal/signal.component.spec.ts
var require_signal_component_spec = __commonJS({
  "src/app/component/signal/signal.component.spec.ts"(exports) {
    init_testing();
    init_signal_component3();
    describe("SignalComponent", () => {
      let component;
      let fixture;
      beforeEach(() => __async(null, null, function* () {
        yield TestBed.configureTestingModule({
          declarations: [SignalComponent]
        }).compileComponents();
        fixture = TestBed.createComponent(SignalComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
      }));
      it("should create", () => {
        expect(component).toBeTruthy();
      });
    });
  }
});
export default require_signal_component_spec();
//# sourceMappingURL=spec-signal.component.spec.js.map

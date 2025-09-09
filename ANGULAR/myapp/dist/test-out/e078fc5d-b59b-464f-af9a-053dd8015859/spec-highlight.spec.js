import {
  Directive,
  __decorate,
  init_core,
  init_tslib_es6
} from "./chunk-UJO3R2K5.js";
import "./chunk-TTULUY32.js";

// src/app/directives/highlight.ts
init_tslib_es6();
init_core();
var Highlight = class Highlight2 {
  constructor() {
  }
  static ctorParameters = () => [];
};
Highlight = __decorate([
  Directive({
    selector: "[appHighlight]",
    standalone: false
  })
], Highlight);

// src/app/directives/highlight.spec.ts
describe("Highlight", () => {
  it("should create an instance", () => {
    const directive = new Highlight();
    expect(directive).toBeTruthy();
  });
});
//# sourceMappingURL=spec-highlight.spec.js.map

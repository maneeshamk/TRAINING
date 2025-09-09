import {
  Directive,
  ElementRef,
  HostListener,
  Input,
  __decorate,
  init_core,
  init_tslib_es6
} from "./chunk-UJO3R2K5.js";
import "./chunk-TTULUY32.js";

// src/app/directives/highlight.directive.ts
init_tslib_es6();
init_core();
var HighlightDirective = class HighlightDirective2 {
  el;
  appHighlight = "";
  constructor(el) {
    this.el = el;
  }
  onMouseEnter() {
    this.highlight(this.appHighlight || "yellow");
  }
  onMouseLeave() {
    this.highlight("");
  }
  highlight(color) {
    this.el.nativeElement.style.backgroundColor = color;
  }
  static ctorParameters = () => [
    { type: ElementRef }
  ];
  static propDecorators = {
    appHighlight: [{ type: Input }],
    onMouseEnter: [{ type: HostListener, args: ["mouseenter"] }],
    onMouseLeave: [{ type: HostListener, args: ["mouseleave"] }]
  };
};
HighlightDirective = __decorate([
  Directive({
    selector: "[appHighlight]",
    // Use as an attribute selector
    standalone: false
    // Mark as standalone directive
  })
], HighlightDirective);

// src/app/directives/highlight.directive.spec.ts
describe("HighlightDirective", () => {
  it("should create an instance", () => {
    const elementRefMock = { nativeElement: document.createElement("div") };
    const directive = new HighlightDirective(elementRefMock);
    expect(directive).toBeTruthy();
  });
});
//# sourceMappingURL=spec-highlight.directive.spec.js.map

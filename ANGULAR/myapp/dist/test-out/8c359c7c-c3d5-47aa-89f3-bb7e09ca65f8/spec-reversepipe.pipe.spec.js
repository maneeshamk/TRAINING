import {
  Pipe,
  __decorate,
  init_core,
  init_tslib_es6
} from "./chunk-UJO3R2K5.js";
import "./chunk-TTULUY32.js";

// src/app/pipes/reversepipe.pipe.ts
init_tslib_es6();
init_core();
var ReversepipePipe = class ReversepipePipe2 {
  transform(value) {
    return value.split("").reverse().join("");
  }
};
ReversepipePipe = __decorate([
  Pipe({
    name: "reversepipe",
    standalone: false
  })
], ReversepipePipe);

// src/app/pipes/reversepipe.pipe.spec.ts
describe("ReversepipePipe", () => {
  it("create an instance", () => {
    const pipe = new ReversepipePipe();
    expect(pipe).toBeTruthy();
  });
});
//# sourceMappingURL=spec-reversepipe.pipe.spec.js.map

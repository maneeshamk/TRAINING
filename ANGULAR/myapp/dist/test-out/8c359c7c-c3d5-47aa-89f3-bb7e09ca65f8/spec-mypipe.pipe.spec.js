import {
  Pipe,
  __decorate,
  init_core,
  init_tslib_es6
} from "./chunk-UJO3R2K5.js";
import "./chunk-TTULUY32.js";

// src/app/pipes/mypipe.pipe.ts
init_tslib_es6();
init_core();
var MypipePipe = class MypipePipe2 {
  transform(value, ...args) {
    return null;
  }
};
MypipePipe = __decorate([
  Pipe({
    name: "mypipe",
    standalone: false
  })
], MypipePipe);

// src/app/pipes/mypipe.pipe.spec.ts
describe("MypipePipe", () => {
  it("create an instance", () => {
    const pipe = new MypipePipe();
    expect(pipe).toBeTruthy();
  });
});
//# sourceMappingURL=spec-mypipe.pipe.spec.js.map

import {
  TestBed,
  init_testing
} from "./chunk-GHPYXVWF.js";
import {
  Injectable,
  __decorate,
  init_core,
  init_tslib_es6
} from "./chunk-UJO3R2K5.js";
import "./chunk-TTULUY32.js";

// src/app/service/herservice.service.spec.ts
init_testing();

// src/app/service/herservice.service.ts
init_tslib_es6();
init_core();
var HerserviceService = class HerserviceService2 {
  constructor() {
  }
  static ctorParameters = () => [];
};
HerserviceService = __decorate([
  Injectable({
    providedIn: "root"
  })
], HerserviceService);

// src/app/service/herservice.service.spec.ts
describe("HerserviceService", () => {
  let service;
  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HerserviceService);
  });
  it("should be created", () => {
    expect(service).toBeTruthy();
  });
});
//# sourceMappingURL=spec-herservice.service.spec.js.map

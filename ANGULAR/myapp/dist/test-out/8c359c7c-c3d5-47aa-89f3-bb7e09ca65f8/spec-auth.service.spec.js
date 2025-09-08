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

// src/app/service/auth.service.spec.ts
init_testing();

// src/app/service/auth.service.ts
init_tslib_es6();
init_core();
var AuthService = class AuthService2 {
  constructor() {
  }
  static ctorParameters = () => [];
};
AuthService = __decorate([
  Injectable({
    providedIn: "root"
  })
], AuthService);

// src/app/service/auth.service.spec.ts
describe("AuthService", () => {
  let service;
  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AuthService);
  });
  it("should be created", () => {
    expect(service).toBeTruthy();
  });
});
//# sourceMappingURL=spec-auth.service.spec.js.map

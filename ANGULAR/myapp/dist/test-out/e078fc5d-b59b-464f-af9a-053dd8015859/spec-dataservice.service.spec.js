import {
  DataserviceService,
  init_dataservice_service
} from "./chunk-JCRRTR37.js";
import "./chunk-ASGJW333.js";
import "./chunk-5POXWGQG.js";
import {
  TestBed,
  init_testing
} from "./chunk-GHPYXVWF.js";
import "./chunk-UJO3R2K5.js";
import "./chunk-TTULUY32.js";

// src/app/service/dataservice.service.spec.ts
init_testing();
init_dataservice_service();
describe("DataserviceService", () => {
  let service;
  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DataserviceService);
  });
  it("should be created", () => {
    expect(service).toBeTruthy();
  });
});
//# sourceMappingURL=spec-dataservice.service.spec.js.map

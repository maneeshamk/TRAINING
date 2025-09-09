import {
  FileService,
  init_file_service
} from "./chunk-T27IWYAC.js";
import "./chunk-ASGJW333.js";
import "./chunk-5POXWGQG.js";
import {
  TestBed,
  init_testing
} from "./chunk-GHPYXVWF.js";
import "./chunk-UJO3R2K5.js";
import "./chunk-TTULUY32.js";

// src/app/service/file.service.spec.ts
init_testing();
init_file_service();
describe("FileService", () => {
  let service;
  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FileService);
  });
  it("should be created", () => {
    expect(service).toBeTruthy();
  });
});
//# sourceMappingURL=spec-file.service.spec.js.map

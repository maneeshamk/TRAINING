import {
  HttpClient,
  init_http
} from "./chunk-ASGJW333.js";
import {
  Injectable,
  __decorate,
  init_core,
  init_tslib_es6
} from "./chunk-UJO3R2K5.js";
import {
  __esm
} from "./chunk-TTULUY32.js";

// src/app/service/file.service.ts
var FileService;
var init_file_service = __esm({
  "src/app/service/file.service.ts"() {
    "use strict";
    init_tslib_es6();
    init_http();
    init_core();
    FileService = class FileService2 {
      http;
      baseUrl = "http://localhost:5000";
      constructor(http) {
        this.http = http;
      }
      write(content) {
        return this.http.post(`${this.baseUrl}/write`, { content });
      }
      read() {
        return this.http.get(`${this.baseUrl}/read`);
      }
      delete() {
        return this.http.delete(`${this.baseUrl}/delete`);
      }
      rename(newName) {
        return this.http.post(`${this.baseUrl}/rename`, { newName });
      }
      static ctorParameters = () => [
        { type: HttpClient }
      ];
    };
    FileService = __decorate([
      Injectable({
        providedIn: "root"
      })
    ], FileService);
  }
});

export {
  FileService,
  init_file_service
};
//# sourceMappingURL=chunk-T27IWYAC.js.map

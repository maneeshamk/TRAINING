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
import {
  Component,
  __decorate,
  init_core,
  init_tslib_es6
} from "./chunk-UJO3R2K5.js";
import {
  __async,
  __commonJS,
  __esm
} from "./chunk-TTULUY32.js";

// angular:jit:template:src\app\component\file-ops\file-ops.component.html
var file_ops_component_default;
var init_file_ops_component = __esm({
  "angular:jit:template:src\\app\\component\\file-ops\\file-ops.component.html"() {
    file_ops_component_default = '<div class="container">\n  <h2>\u{1F4DD} File Operations App</h2>\n\n  <textarea [(ngModel)]="content" rows="5" placeholder="Enter file content"></textarea>\n  <button class="btn btn-primary" (click)="handleWrite()">Write</button>\n  <button class="btn btn1" (click)="handleRead()">Read</button>\n  <button class="btn btn-info"  (click)="handleDelete()">Delete</button>\n\n  <input style="background-color: aqua;" type="text" [(ngModel)]="newName" placeholder="New file name" />\n  <button class="badge text-bg-danger" (click)="handleRename()">Rename</button>\n\n  <p><strong>Status:</strong> {{ message }}</p>\n</div>\n';
  }
});

// src/app/component/file-ops/file-ops.component.ts
var FileOpsComponent;
var init_file_ops_component2 = __esm({
  "src/app/component/file-ops/file-ops.component.ts"() {
    "use strict";
    init_tslib_es6();
    init_file_ops_component();
    init_core();
    init_file_service();
    FileOpsComponent = class FileOpsComponent2 {
      fileService;
      content = "";
      newName = "";
      message = "";
      constructor(fileService) {
        this.fileService = fileService;
      }
      handleWrite() {
        this.fileService.write(this.content).subscribe({
          next: (res) => this.message = res.message,
          error: (err) => this.message = err.error?.error || "Error writing file"
        });
      }
      handleRead() {
        this.fileService.read().subscribe({
          next: (res) => {
            this.content = res.content;
            this.message = "File read successfully";
          },
          error: (err) => this.message = err.error?.error || "Error reading file"
        });
      }
      handleDelete() {
        this.fileService.delete().subscribe({
          next: (res) => this.message = res.message,
          error: (err) => this.message = err.error?.error || "Error deleting file"
        });
      }
      handleRename() {
        this.fileService.rename(this.newName).subscribe({
          next: (res) => this.message = res.message,
          error: (err) => this.message = err.error?.error || "Error renaming file"
        });
      }
      static ctorParameters = () => [
        { type: FileService }
      ];
    };
    FileOpsComponent = __decorate([
      Component({
        selector: "app-file-ops",
        template: file_ops_component_default,
        standalone: false
      })
    ], FileOpsComponent);
  }
});

// src/app/component/file-ops/file-ops.component.spec.ts
var require_file_ops_component_spec = __commonJS({
  "src/app/component/file-ops/file-ops.component.spec.ts"(exports) {
    init_testing();
    init_file_ops_component2();
    describe("FileOpsComponent", () => {
      let component;
      let fixture;
      beforeEach(() => __async(null, null, function* () {
        yield TestBed.configureTestingModule({
          declarations: [FileOpsComponent]
        }).compileComponents();
        fixture = TestBed.createComponent(FileOpsComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
      }));
      it("should create", () => {
        expect(component).toBeTruthy();
      });
    });
  }
});
export default require_file_ops_component_spec();
//# sourceMappingURL=spec-file-ops.component.spec.js.map

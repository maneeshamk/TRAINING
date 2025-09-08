import {
  TestBed,
  init_testing
} from "./chunk-GHPYXVWF.js";
import {
  Component,
  EventEmitter,
  Input,
  Output,
  __decorate,
  init_core,
  init_tslib_es6
} from "./chunk-UJO3R2K5.js";
import {
  __async,
  __commonJS,
  __esm
} from "./chunk-TTULUY32.js";

// angular:jit:template:src\app\component\login\login.component.html
var login_component_default;
var init_login_component = __esm({
  "angular:jit:template:src\\app\\component\\login\\login.component.html"() {
    login_component_default = '<p>{{caption}}</p>\n\n<input type="text" [(ngModel)]="username" placeholder="Username"><br/>\n<input type="password" [(ngModel)]="password" placeholder="Password"><br/>\n<button (click)="onLogin()">Login</button>\n\n\n';
  }
});

// angular:jit:style:src\app\component\login\login.component.css
var login_component_default2;
var init_login_component2 = __esm({
  "angular:jit:style:src\\app\\component\\login\\login.component.css"() {
    login_component_default2 = "/* src/app/component/login/login.component.css */\n/*# sourceMappingURL=login.component.css.map */\n";
  }
});

// src/app/component/login/login.component.ts
var LoginComponent;
var init_login_component3 = __esm({
  "src/app/component/login/login.component.ts"() {
    "use strict";
    init_tslib_es6();
    init_login_component();
    init_login_component2();
    init_core();
    LoginComponent = class LoginComponent2 {
      caption = "";
      login = new EventEmitter();
      img = "https://angular.io/assets/images/logos/angular/angular.png";
      username = "";
      password = "";
      col = 2;
      user = {};
      onLogin() {
        this.user = {
          username: this.username,
          password: this.password
        };
        console.log("Username: ", this.username, "Password: ", this.password);
        this.login.emit(this.user);
      }
      static propDecorators = {
        caption: [{ type: Input }],
        login: [{ type: Output }]
      };
    };
    LoginComponent = __decorate([
      Component({
        selector: "app-login",
        standalone: false,
        template: login_component_default,
        styles: [login_component_default2]
      })
    ], LoginComponent);
  }
});

// src/app/component/login/login.component.spec.ts
var require_login_component_spec = __commonJS({
  "src/app/component/login/login.component.spec.ts"(exports) {
    init_testing();
    init_login_component3();
    describe("LoginComponent", () => {
      let component;
      let fixture;
      beforeEach(() => __async(null, null, function* () {
        yield TestBed.configureTestingModule({
          declarations: [LoginComponent]
        }).compileComponents();
        fixture = TestBed.createComponent(LoginComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
      }));
      it("should create", () => {
        expect(component).toBeTruthy();
      });
    });
  }
});
export default require_login_component_spec();
//# sourceMappingURL=spec-login.component.spec.js.map

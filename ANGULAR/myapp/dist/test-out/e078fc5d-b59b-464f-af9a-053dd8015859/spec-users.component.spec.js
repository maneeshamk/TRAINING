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
import {
  Component,
  Input,
  __decorate,
  init_core,
  init_tslib_es6
} from "./chunk-UJO3R2K5.js";
import {
  __async,
  __commonJS,
  __esm
} from "./chunk-TTULUY32.js";

// angular:jit:template:src\app\component\users\users.component.html
var users_component_default;
var init_users_component = __esm({
  "angular:jit:template:src\\app\\component\\users\\users.component.html"() {
    users_component_default = '<button (click)="getusers()">Get users</button>\n<label>User name</label><input type="text" name="firstName" placeholder="new user" [(ngModel)]="firstName"/>\n{{ firstName }}<br/>\n<br/>\n<label>Age</label>\n<input type="number" name="age" placeholder="age" [(ngModel)]="age"/><br/>\n<button (click)="addUser()">Add User</button>\n<button (click)="updateUser(user)">Update User</button>\n<br/><br/><br/>\n<ul>\n  <li *ngFor="let user of users">\n    {{ user.firstName }} - {{ user.age }} <button (click)="deleteUser(user.id)">Delete</button> <button (click)="editUser(user)">Edit</button>\n  </li>\n  </ul>\n\n   <div *ngIf="errorMessage" class="error">{{ errorMessage }}</div>\n';
  }
});

// angular:jit:style:src\app\component\users\users.component.css
var users_component_default2;
var init_users_component2 = __esm({
  "angular:jit:style:src\\app\\component\\users\\users.component.css"() {
    users_component_default2 = "/* src/app/component/users/users.component.css */\n/*# sourceMappingURL=users.component.css.map */\n";
  }
});

// src/app/component/users/users.component.ts
var UsersComponent;
var init_users_component3 = __esm({
  "src/app/component/users/users.component.ts"() {
    "use strict";
    init_tslib_es6();
    init_users_component();
    init_users_component2();
    init_core();
    init_dataservice_service();
    UsersComponent = class UsersComponent2 {
      dataService;
      title = "";
      users = [];
      firstName = "";
      age = 0;
      user = {};
      userId = 0;
      errorMessage = "";
      constructor(dataService) {
        this.dataService = dataService;
      }
      ngOnInit() {
        this.dataService.getPosts().subscribe({
          next: (data) => console.log("Data received:", data),
          // error: (err) => console.error('Final error after retries:', err),
          error: (error) => {
            this.errorMessage = error.message;
          }
        });
      }
      getusers() {
        this.dataService.getUsers().subscribe({
          next: (users) => this.users = users,
          complete: () => console.log("Users fetched successfully"),
          error: (err) => console.error("Error fetching users:", err)
        });
      }
      addUser() {
        this.user = {
          id: Math.random().toString(36).substring(2, 15),
          firstName: this.firstName,
          age: this.age
        };
        console.log("Adding user:", this.user);
        this.dataService.addUser(this.user).subscribe({
          next: (user) => {
            console.log("User added successfully:", user);
            this.users.push(user);
            this.firstName = "";
            this.age = 0;
          },
          error: (err) => console.error("Error adding user:", err)
        });
      }
      updateUser(user) {
        console.log("Updating user:", user);
        this.dataService.updateUser(user).subscribe({
          next: (updatedUser) => {
            console.log("User updated successfully:", updatedUser);
            const index = this.users.findIndex((u) => u.id === user.id);
            if (index !== -1) {
              this.users[index] = updatedUser;
            }
          },
          error: (err) => console.error("Error updating user:", err)
        });
      }
      editUser(user) {
        this.userId = user.id;
        this.firstName = user.firstName;
        this.age = user.age;
        this.user = { id: this.userId, firstName: this.firstName, age: this.age };
        console.log("Editing user:", this.user);
      }
      deleteUser(id) {
        this.dataService.deleteUser(id).subscribe({
          next: () => {
            console.log("User deleted successfully");
            this.users = this.users.filter((user) => user.id !== id);
          },
          error: (err) => console.error("Error deleting user:", err)
        });
      }
      static ctorParameters = () => [
        { type: DataserviceService }
      ];
      static propDecorators = {
        title: [{ type: Input }]
      };
    };
    UsersComponent = __decorate([
      Component({
        selector: "app-users",
        standalone: false,
        template: users_component_default,
        styles: [users_component_default2]
      })
    ], UsersComponent);
  }
});

// src/app/component/users/users.component.spec.ts
var require_users_component_spec = __commonJS({
  "src/app/component/users/users.component.spec.ts"(exports) {
    init_testing();
    init_users_component3();
    describe("UsersComponent", () => {
      let component;
      let fixture;
      beforeEach(() => __async(null, null, function* () {
        yield TestBed.configureTestingModule({
          declarations: [UsersComponent]
        }).compileComponents();
        fixture = TestBed.createComponent(UsersComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
      }));
      it("should create", () => {
        expect(component).toBeTruthy();
      });
    });
  }
});
export default require_users_component_spec();
//# sourceMappingURL=spec-users.component.spec.js.map

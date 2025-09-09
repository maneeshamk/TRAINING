import {
  HttpClient,
  init_http
} from "./chunk-ASGJW333.js";
import {
  Injectable,
  __decorate,
  catchError,
  init_core,
  init_esm,
  init_tslib_es6,
  retry,
  throwError
} from "./chunk-UJO3R2K5.js";
import {
  __esm
} from "./chunk-TTULUY32.js";

// src/app/service/dataservice.service.ts
var DataserviceService;
var init_dataservice_service = __esm({
  "src/app/service/dataservice.service.ts"() {
    "use strict";
    init_tslib_es6();
    init_core();
    init_http();
    init_esm();
    DataserviceService = class DataserviceService2 {
      http;
      apiUrl = "https://jsonplaceholder.typicode.com/posts";
      constructor(http) {
        this.http = http;
      }
      getPosts() {
        return this.http.get(this.apiUrl).pipe(
          retry(3),
          // Retry up to 3 times if the request fails
          // catchError((error) => {
          //   console.error('Error after 3 retries:', error);
          //   throw error;
          // })
          catchError(this.handleError)
        );
      }
      handleError(error) {
        let errorMessage = "An unknown error occurred!";
        if (error.error instanceof ErrorEvent) {
          errorMessage = `Client-side error: ${error.error.message}`;
        } else {
          errorMessage = `Backend error: ${error.status} - ${error.message}`;
        }
        console.error(errorMessage);
        return throwError(() => new Error(errorMessage));
      }
      getUser(id) {
        return this.http.get("http://localhost:3000/users/" + id);
      }
      getUsers() {
        return this.http.get("http://localhost:3000/users");
      }
      addUser(user) {
        return this.http.post("http://localhost:3000/users", user);
      }
      updateUser(user) {
        console.log("Updating user api:", user);
        return this.http.put("http://localhost:3000/users/" + user.id, user);
      }
      deleteUser(id) {
        return this.http.delete("http://localhost:3000/users/" + id);
      }
      patchUser(id, user) {
        return this.http.patch("http://localhost:3000/users/" + id, user);
      }
      static ctorParameters = () => [
        { type: HttpClient }
      ];
    };
    DataserviceService = __decorate([
      Injectable({
        providedIn: "root"
      })
    ], DataserviceService);
  }
});

export {
  DataserviceService,
  init_dataservice_service
};
//# sourceMappingURL=chunk-JCRRTR37.js.map

module App {

    export class AppConfig {
        private stateProvider: angular.ui.IStateProvider;
        private routerProvider: angular.ui.IUrlRouterProvider;
        static $inject = ["$stateProvider", "$urlRouterProvider"];
        constructor($stateProvider: angular.ui.IStateProvider, $urlRouterProvider: angular.ui.IUrlRouterProvider) {
            this.stateProvider = $stateProvider;
            this.routerProvider = $urlRouterProvider;

            console.log('i am in appConfig');
            $stateProvider.state("root", {
                abstract: true,
                url: "",
                template: "<div ui-view class=\"container-fluid slide\"></div>",

            }).state("root.home", {
                url: "/",
                templateUrl: "partials/home/home.tpl.html",
                controller: "HomeController",
                controllerAs: "vm"
            }).state("root.student-entry", {
                url: "/student-entry",
                templateUrl: "partials/student/student-entry.tpl.html",
                controller: "StudentController",
                controllerAs: "vm"
            }).state("root.signin", {
                url: "/signin",
                templateUrl: "partials/account/signin.tpl.html",
                controller: "SigninController",
                controllerAs: "vm"
            }).state("root.registration", {
                url: "/registration",
                templateUrl: "partials/account/registration.tpl.html",
                controller: "RegistrationController",
                controllerAs: "vm"
            });
        }
    }

    angular.module("app", ["ui.router", "ngResource","LocalStorageModule"]);
    angular.module("app").config(AppConfig);

}
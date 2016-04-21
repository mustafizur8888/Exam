module App {
    export class HomeController {
        constructor() {

            console.log('home controller');
        }
    }
    angular.module("app").controller("HomeController", HomeController);
}
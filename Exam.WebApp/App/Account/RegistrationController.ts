module App {

    export class RegistrationRequest {
        Email: string;
        ConfirmPassword:string;
        Password: string;
        Address: string;

    }
    export class RegistrationController {
        User: RegistrationRequest;
        private stateService: angular.ui.IStateService;
        private httpService: angular.IHttpService;
        static $inject: string[] = ["$http", "$state"];
        constructor(private http: angular.IHttpService, state: angular.ui.IStateService) {
            this.httpService = http;

            this.stateService = state;

        }
        
        Registration(): void {
            var self = this;
            console.log(this.User);

            var success = function (result) {
                
                console.log(result.data);
                self.stateService.go('root.signin');
            }

            var error = function (error) {
                console.log(error);
            }

            self.User.ConfirmPassword = self.User.Password;

            self.httpService.post('api/Account/Register', self.User).then(success, error);

        }
    }
    angular.module("app").controller("RegistrationController", RegistrationController);

}
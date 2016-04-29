module App {

    export class AdminServiceQueryController {

        AdminService: AdminService[];
        private adminServiceService: AdminServiceService;
        static $inject = ["AdminServiceService"];
        constructor(adminServiceService: AdminServiceService) {

          
            this.adminServiceService = adminServiceService;
            this.AdminService = [];
            this.Get();
        }

        Get() {
            var self = this;
            console.log('get method');

            var successCallback = result => {
                self.AdminService = result.data as AdminService[];
                console.log(self.AdminService);
                
            };
            var errorCallback = error => {
                console.log(error);
            };
            self.adminServiceService.Get().then(successCallback, errorCallback);;


        }
    }

    angular.module('app').controller('AdminServiceQueryController', AdminServiceQueryController);


}
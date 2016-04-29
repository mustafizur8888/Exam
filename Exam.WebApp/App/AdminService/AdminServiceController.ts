module App {

    export class AdminServiceController {
        
        AdminService: AdminService;
        private adminServiceService: AdminServiceService;
         private stateParamService: angular.ui.IStateParamsService;
        static $inject = ["AdminServiceService"];
        constructor(adminServiceService: AdminServiceService) {

            console.log('service controller');
            this.AdminService = new AdminService();
            this.adminServiceService = adminServiceService;
           // this.stateParamService = stateParams;
        }
       
        Save() {
            console.log(this.AdminService);


            var successCallback = result => {
                console.log(result);
            };
            var errorCallback = error => {
                console.log(error);
            };

            this.adminServiceService.Save(this.AdminService)
                .then(successCallback, errorCallback);
        }
    }

    angular.module('app').controller('AdminServiceController', AdminServiceController);


}
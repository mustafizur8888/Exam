module App {

    export class  AdminServiceService {
        private httpService: angular.IHttpService;
        private qService: angular.IQService;
      

        static $inject: string[] = ["$http", "$q"];
        constructor(private $http: ng.IHttpService, private $q: ng.IQService) {
            this.httpService = $http;
            this.qService = $q;
           
        }
        Save(data: AdminService): angular.IPromise<any> {
            var deffered = this.qService.defer();
            var successCallback = result => {
                console.log(result);
                return deffered.resolve(result);
            };
            var errorCallback = error => {
                console.log(error);
                return deffered.reject(error);
            };
          
           this.httpService.post("/api/AdminService", data)
                .then(successCallback, errorCallback);
            return deffered.promise;
        }

        Get() {
            var self = this;
            var deffered = this.qService.defer();

            var successCallback = result => {
                console.log(result);
                return deffered.resolve(result);
            };
            var errorCallback = error => {
                console.log(error);
                return deffered.reject(error);
            };
            //var config: angular.IRequestShortcutConfig = { headers: { 'Authorization': "Bearer "+self.authService.AccountInfo.AccessToken } };
            self.httpService.get("/api/AdminServiceQuery")
                .then(successCallback, errorCallback);
            return deffered.promise;
        }
    }

    angular.module("app").service("AdminServiceService", AdminServiceService);
}
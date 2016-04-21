module App {



    export class StudentService {
        private httpService: angular.IHttpService;
        private qService: angular.IQService;

        static $inject: string[] = ["$http", "$q"];
        constructor(private $http: ng.IHttpService, private $q: ng.IQService) {
            this.httpService = $http;
            this.qService = $q;
        }
        Save(data: Student): angular.IPromise<any> {
            var deffered = this.qService.defer();
            var successCallback = result => {
                console.log(result);
                return deffered.resolve(result);
            };
            var errorCallback = error => {
                console.log(error);
                return deffered.reject(error);
            };

            this.httpService.post("/api/student", data)
                .then(successCallback, errorCallback);
            return deffered.promise;
        }
    }
    angular.module("app").service("StudentService", StudentService);
}
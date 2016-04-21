module App {

    export class StudentController {
        Student: Student;
        private studentService: StudentService;
        private stateParamService: angular.ui.IStateParamsService;
        static $inject = ["StudentService"];
        constructor(studentService: StudentService) {
            this.Student = new Student();
            this.studentService = studentService;
            //this.stateParamService = stateParams;
        }

        Save() {
            console.log(this.Student);


            var successCallback = result => {
                console.log(result);
            };
            var errorCallback = error => {
                console.log(error);
            };

            this.studentService.Save(this.Student)
                .then(successCallback, errorCallback);
        }
    }

    angular.module('app').controller('StudentController', StudentController);


}
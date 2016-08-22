var FormApp = angular.module('application', []);

FormApp.controller('degreeController', function ($scope, $http) {
    var url = '/api/ApplicationForm/GetDegree';
    $http.get(url).then(function degree(response) {
        $scope.degrees = response.data;
    });

});
FormApp.controller('yearController', function ($scope) {
    $scope.user = {
        year: {
            minlength: 4,
            maxlength: 4
        }
    }
});
FormApp.controller('languageController', function ($scope) {
    $scope.FullLangage = '';
    $scope.addLanguage = function addLanguage() {
      $scope.Current = $scope.FullLangage;
      $scope.FullLangage = $scope.Current + '\n' + ' ' + $scope.Langage + ' ' + $scope.DoP;
      

    };
});

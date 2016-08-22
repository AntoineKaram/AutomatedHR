var FormApp = angular.module('application', []);

FormApp.controller('educationController', function ($scope, $http) {
    var url = '/api/ApplicationForm/GetDegree';
    $http.get(url).then(function degree(response) {
        $scope.degrees = response.data;
    });
    $scope.educationExperiences = [{}];
    $scope.addEducationExperience = function addEducationExperience() {
        $scope.Current = [{
            "Degree": $scope.Application.Education.Degree,
            "Institute": $scope.Application.Education.Institute,
            "GPA": $scope.Application.Education.GPA,
            "BS": $scope.Application.Education.BS,
            "MS": $scope.Application.Education.MS
        }];
        $scope.educationExperiences = $scope.educationExperiences.concat($scope.Current);
        alert(JSON.stringify($scope.educationExperiences));
    };
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
    $scope.FullLangage = [{}];
    $scope.addLanguage = function addLanguage() {
        $scope.Current = {
            "Language": $scope.Application.Langage.Name,
            "DoP": $scope.Application.Langage.DoP
        };
        $scope.FullLangage = $scope.FullLangage.concat($scope.Current);
    }
});

FormApp.controller('workExperienceController', function ($scope) {
    $scope.workExperiences = [{}];
    $scope.addWorkExperience = function addWorkExperience() {
        $scope.Current = [{
            "Employer": $scope.Application.Work.Employer,
            "Current": $scope.Application.Work.Current,
            "StartDate": $scope.Application.Work.StartDate,
            "EndDate": $scope.Application.Work.EndDate,
            "Role": $scope.Application.Work.Role,
            "Location": $scope.Application.Work.Location
        }];
        $scope.workExperiences = $scope.workExperiences.concat($scope.Current);
        alert(JSON.stringify($scope.workExperiences));
    };
});

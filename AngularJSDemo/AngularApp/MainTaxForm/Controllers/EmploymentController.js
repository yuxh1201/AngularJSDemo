taxFormModule.controller('employmentController', function ($scope, $http, $location, mainTaxFormService) {
    $scope.subTotal = {};

    init();

    function init() {
        mainTaxFormService.getTaxFormData().then(function (response) {
            $scope.subTotal = response.data; 
            console.log($scope.subTotal);
        });
    };

    $scope.updateTaxFormData = function () {
        mainTaxFormService.updateTaxFormData($scope.subTotal).then(function (response) {
            $location.path('/');
        });
    };

    $scope.go = function (path) {

        $location.path(path);
    };
});
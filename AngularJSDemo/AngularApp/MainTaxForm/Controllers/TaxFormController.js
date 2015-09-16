taxFormModule.controller('taxFormController', function ($scope, $http, mainTaxFormService) {
    $scope.subTotal = {};
    //$scope.subTotal = { TotalBusinessIncome: '$100.00', TotalEmploymentIncome: '$200.00', GrandTotalDeductions: '$300.00', txtTotalOtherIncome: '$400.00' };

    init();

    function init() {
        mainTaxFormService.getTaxFormData().then(function (response) {
            $scope.subTotal = response.data; //JSON.parse(response.data);
            console.log($scope.subTotal);
        });

        //mainTaxFormService.setSubTotal($scope.subTotal);
    };

    $scope.updateTaxFormData = function () {
        mainTaxFormService.updateTaxFormData($scope.subTotal).then(function (response) {
            alert("Data Saved!");
        });
    };
});
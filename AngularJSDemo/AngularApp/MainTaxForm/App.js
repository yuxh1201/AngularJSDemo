var taxFormModule = angular.module('mainTaxFormApp', ['ngRoute']);

taxFormModule.directive('dvw', ['$templateCache', function ($templateCache) {
    return {
        restrict: 'A',
        compile: function (element) {
            $templateCache.put('default.html', element.html());
        }
    };
} ]);

taxFormModule.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider.when('/', {
        templateUrl: 'default.html',
        controller: 'taxFormController'
    });
    $routeProvider.when('/Employment', {
        templateUrl: '/angularjsdemo/angularapp/maintaxform/views/Employment.html',
        controller: 'employmentController'
    });

    $routeProvider.otherwise({ redirectTo: '/' });

    $locationProvider.html5Mode({
        enable: true,
        requireBase: true
    });
} ]);

taxFormModule.filter('num', function () {
    return function (input) {
        return parseFloat(input);
    };
});

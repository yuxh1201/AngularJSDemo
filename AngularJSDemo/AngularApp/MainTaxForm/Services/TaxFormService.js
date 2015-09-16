taxFormModule.service("mainTaxFormService", function ($http) {
    //    var subTotal = {};

    //    this.getSubTotal = function () {
    //        return subTotal;
    //    };

    //    this.setSubTotal = function (data) {
    //        subTotal = data;
    //    };

    this.getTaxFormData = function () {
        // 1. webmethod
        //        var req = {
        //            method: 'GET',
        //            url: 'Service.aspx/LoadMainTaxFormData',
        //            data: '',
        //            headers: {
        //                'Content-Type': 'application/json; charset=utf-8'
        //            }
        //        };

        //        return $http(req);


        // 2. wcf service with entity
        //        var request = $http.get('taxservice.svc/loadmaintaxformdata');
        //        return request;

        // 3. wcf service with session
        var request = $http.get('WCFService/TaxService.svc/LoadMainTaxFormSession');
        return request;

        // 4. wcf service with dataset
        //        var request = $http.get('TaxService.svc/LoadMainTaxFormDataSet');
        //        return request;
    };

    this.updateTaxFormData = function (subTotal) {
        var request = $http.post('WCFService/TaxService.svc/UpdateMainTaxFormData', subTotal);
        return request;
    }
});
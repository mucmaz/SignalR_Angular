(function (angular) {

    function MainController($scope) {
        var hubProxy = $.connection.producHub;
        hubProxy.client.getAllProcuts = function (productList) {
            //$scope.Products = productList;
        };
        $.connection.logging = true;
        $.connection.hub.start()
            .done(function () {
                console.log("hub.start.done");
            })
            .fail(function (error) {
                console.log(error);
            });
    };

    var app = angular.module('app', []);
    app.controller('MainController', ['$scope', MainController]);
})(angular);
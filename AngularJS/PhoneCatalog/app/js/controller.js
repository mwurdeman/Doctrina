'use strict';

var phonecatControllers = angular.module('phonecatControllers', []);

phonecatApp.controller('phoneListCtrl', ['$scope', '$http',
   function ($scope, $http) {
       $http.get('phones/phones.json').success(function (data) {
           $scope.phones = data;
       });

       $scope.orderProp = 'age';
   }
]);

phonecatApp.controller('phoneDetailCtrl', ['$scope', '$routeParams', '$http',
    function ($scope, $routeParams, $http) {
        $http.get('phones/' + $routeParams.phoneId + '.json').success(function(data) {
            $scope.phone = data;
            $scope.mainImageUrl = data.images[0];
        });

        $scope.setImage = function(imageUrl) {
            $scope.mainImageUrl = imageUrl;
        };
    }
]);
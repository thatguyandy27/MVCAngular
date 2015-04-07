angular.module('mvcApp').controller('dynamicCtrl', ['$scope', '$routeParams', 'dynamicService', function ($scope, $routeParams, dynamicService) {
    $scope.hello = "Hello World from dynamic.js";

    dynamicService.getDynamicList($routeParams.id).then(function (data) {
        $scope.dynamicList = data.data;
    });
}]);
'use strict';

angular
  .module('mvcApp', ['ngRoute']).config(['$routeProvider',  function ($routeProvider) {

      $routeProvider.when('/', {
          templateUrl: 'home',
          controller:'mainCtrl'
      })
      .when('/dynamic/:id', {
          templateUrl: function(params){
              return 'dynamic/index/' + params.id;
          },
          controller: 'dynamicCtrl'
      });
}]);

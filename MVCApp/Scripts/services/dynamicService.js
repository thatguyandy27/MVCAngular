angular.module('mvcApp').factory('dynamicService',['$http',  function ($http) {

    function getDynamicList(id) {

        return $http.get('api/dynamic/' + id);
    }

    return {
        getDynamicList: getDynamicList
    };

}]);
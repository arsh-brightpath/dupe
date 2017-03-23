(function () {
    appModule.controller('tenant.views.phonebook.index', [
        '$scope', '$uibModal','abp.services.app.person',
        function ($scope, $uibModal, personService) {
            var vm = this;

            personService.getPeople({}).then(function (result) {
                vm.persons = result.data.items;
            });

            vm.openCreatePersonModal = function () {
                var modalInstance = $uibModal.open({
                    templateUrl: '~/App/tenant/views/phonebook/Create.cshtml',
                    controller: 'tenant.views.phonebook.createPersonModal as vm',
                    backdrop: 'static'
                });

                modalInstance.result.then(function () {
                    getPeople();
                });
            };

            vm.deletePerson = function (person) {
                abp.message.confirm(
                    app.localize('AreYouSureToDeletePerson', person.name),
                    function (isConfirmed) {
                        if (isConfirmed) {
                            personService.deletePerson({
                                id: person.id
                            }).then(function () {
                                abp.notify.success(app.localize('SuccessfullyDeleted'));
                                getPeople();
                            });
                        }
                    }
                );
            };

            //start from here...
        }
    ]);
})();
(function() {
    var blue = {
        red: 50,
        green: 100,
        blue: 150,
    };

    var red = {
        red: 150,
        green: 100,
        blue: 50,
    };

    this.holdingClickEntity = function(entityId, mouseEvent) {
        Entities.editEntity(entityId, { color: red });
    };

    this.clickReleaseEntity = function(entityId, mouseEvent) {
        Entities.editEntity(entityId, { color: blue });
    };
})
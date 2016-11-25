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

    this.mousePressOnEntity = function(entityId, mouseEvent) {
        print("click");
        Entities.editEntity(entityId, { color: red });
    };

    this.mouseReleaseOnEntity = function(entityId, mouseEvent) {
        print("lolwat");
        Entities.editEntity(entityId, { color: blue });
    };
})
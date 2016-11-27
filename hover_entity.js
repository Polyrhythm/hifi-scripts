(function() {
    var ORIG_SCALE = {
        x: 0.4,
        y: 0.4,
        z: 0.4,
    };
    var MAX_DIMENSION = 0.6;
    var newScale = ORIG_SCALE;

    this.hoverOverEntity = function(id, evt) {
        print("hello");
        if (newScale.x >= MAX_DIMENSION) {
            return;
        }

        newScale = {
            x: newScale.x + 0.01,
            y: newScale.y + 0.01,
            z: newScale.z + 0.01,
        };

        Entities.editEntity(id, {
            dimensions: newScale,
        });
    };

    this.hoverLeaveEntity = function(id, evt) {
        print("goodbye");
        var loop; // interval declaration
        function lerp() {
            if (newScale.x <= ORIG_SCALE.x) {
                Script.clearInterval(loop);
                return;
            }

            newScale = {
                x: newScale.x - 0.01,
                y: newScale.y - 0.01,
                z: newScale.z - 0.01,
            };

            Entities.editEntity({
                dimensions: newScale,
            });
        }

        loop = Script.setInterval(lerp, 0.1);
    };
})
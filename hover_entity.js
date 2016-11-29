(function() {
    function TestEntity() {}
    var time = 0;
    var HOVER_SPEED = 0.001;

    TestEntity.prototype.update = function(deltaTime) {
        time += deltaTime;
        var pos = Entities.getEntityProperties(this.entityId, ['position']).position;
        Entities.editEntity(this.entityId, {
            position: {
                x: pos.x,
                y: pos.y + Math.sin(time) * HOVER_SPEED,
                z: pos.z,
            },
            color: {
                red: Math.abs(Math.sin(time)) * 255,
                green: 150,
                blue: 150,
            },
        });
    };

    TestEntity.prototype.preload = function(id) {
        this.entityId = id;

        Script.update.connect(this, this.update);
    };

    TestEntity.prototype.unload = function() {
        Script.update.disconnect(this, this.update);
    };

    return new TestEntity();
})

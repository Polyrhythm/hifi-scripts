var SCRIPT_URL = "file:///C:/Users/polyr/Development/games/hifi-scripts/hover_entity.js";

var center = Vec3.sum(Vec3.sum(MyAvatar.position, {
  x: 0,
  y: 0.5,
  z: 0
}), Vec3.multiply(0.5, Quat.getFront(Camera.getOrientation())));

var test = Entities.addEntity({
    type: "Box",
    name: "Test entity",
    position: center,
    dimensions: {
        x: 0.05,
        y: 0.05,
        z: 0.05,
    },
    gravity: {
        x: 0,
        y: 0,
        z: 0,
    },
    dynamic: false,
    shapeType: 'box',
    lifetime: 3600,
    script: SCRIPT_URL,
    userData: JSON.stringify({
        testProp: 5.0
    }),
});
Script.stop();
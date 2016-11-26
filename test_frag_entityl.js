(function() {
    var newData = JSON.stringify({
        ProceduralEntity: {
            shaderUrl: "https://raw.githubusercontent.com/Polyrhythm/hifi-scripts/master/fragl.fs",
            version: 2,
            uniforms: {},
        }
    });
    this.mousePressOnEntity = function(id, evt) {
       print("click");
       Entities.editEntity(id, { userData: newData }); 
    };
})

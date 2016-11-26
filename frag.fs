// Produce a lit procedural surface
float getProceduralColorsLit(inout vec3 diffuse, inout vec3 specular, inout float shininess) {
    vec3 noiseColor = getNoiseColor();
    diffuse = noiseColor;
    return 0.0;
}

// Produce an unlit procedural surface:  emulates old behavior
float getProceduralColorsUnlit(inout vec3 diffuse, inout vec3 specular, inout float shininess) {
    vec3 noiseColor = getNoiseColor();
    diffuse = vec3(1.0);
    specular = noiseColor;
    return 1.0;
}

float getProceduralColors(inout vec3 diffuse, inout vec3 specular, inout float shininess) {
    return getProceduralColorsLit(diffuse, specular, shininess);
}

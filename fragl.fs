float getProceduralColors(inout vec3 diffuse, inout vec3 specular, inout float shininess) {
    vec2 uv = _position.xz / iResolution.xy;
    vec2 p = -1.0 + 2.0 * uv;

    vec3 colour = vec3(1.0);

    float map = step(0.1, distance(p, vec2(0.0)));

    diffuse = vec3(1.0, 1.0, map);
    
    return 0.0;
}

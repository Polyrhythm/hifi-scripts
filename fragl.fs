float getProceduralColors(inout vec3 diffuse, inout vec3 specular, inout float shininess) {
    vec2 uv = _position.xz / iResolution.xy;
    vec2 p = uv;

    p.x += sin(p.y + iGlobalTime * 3.0) * 0.1;

    vec3 colour = vec3(1.0);

    float map = step(0.1, distance(p, vec2(0.0)));

    diffuse = vec3(step(0.0, p.x));
    
    return 0.0;
}

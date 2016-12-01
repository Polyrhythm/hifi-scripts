float getProceduralColors(inout vec3 diffuse, inout vec3 specular, inout float shininess) {
    vec2 uv = _position.xz / iResolution.xy;
    vec2 p = uv;

	vec3 colour = vec3(0.0);

	diffuse = vec3(pow(hifi_fbm(p + hifi_fbm(p + sin(iGlobalTime))), 2.0));

    return 0.0;
}

float getProceduralColors(inout vec3 diffuse, inout vec3 specular, inout float shininess) {
    vec2 uv = _position.xz / iResolution.xy;
    vec2 p = uv;

	vec3 colour = vec3(0.0);
	float d;

	d = length(p);

	colour = vec3(fract(d * abs(cos(iGlobalTime))),
	   			  1.0 - fract(d * 10.0) + abs(sin(iGlobalTime)),
				  fract(d * abs(sin(iGlobalTime)) + 0.5));

	diffuse = vec3(colour);

    return 0.0;
}
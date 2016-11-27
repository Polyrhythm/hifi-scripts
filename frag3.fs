#define TWO_PI 6.28318530718

vec3 hsb2rgb(in vec3 c) {
	vec3 rgb = clamp(abs(mod(c.x * 6.0 + vec3(0.0, 4.0, 2.0),
							 6.0) - 3.0) - 1.0,
					 0.0,
					 1.0);
	rgb = rgb * rgb * (3.0 - 2.0 * rgb);

	return c.z * mix(vec3(1.0), rgb, c.y);
}

float getProceduralColors(inout vec3 diffuse, inout vec3 specular, inout float shininess) {
    vec2 uv = _position.xz / iResolution.xy;
    vec2 p = uv;

	vec2 pos = vec2(0.0, sin(cos(iGlobalTime))) * 0.25;
	vec3 colour = vec3(0.0);
	float wheelSize = abs(sin(iGlobalTime)) * 0.04 + 0.3;

	vec2 toCenter = vec2(pos) - uv;
	float angle = atan(toCenter.y, toCenter.x);
	float radius = length(toCenter) * 2.0 * (1.0 / wheelSize);

	float shading;
	float hue = (angle / TWO_PI) + iGlobalTime * 0.1;
	if (uv.y > 0.0) {
		shading = 1.0 - length(toCenter) * 4.0 + length(toCenter);
	} else {
		shading = 1.0;
		radius = length(toCenter) - 1.0;
		hue = 0.0;
	}

	colour = hsb2rgb(vec3(hue,
						  radius,
						  shading));

	if (length(toCenter) >= wheelSize) {
		colour = mix(vec3(1.0) - vec3(step(0.0, uv.y)),
					 vec3(step(0.0, uv.y)),
					 smoothstep(0.0, 1.0, length(toCenter) * 2.5 - wheelSize));
	}

	if (uv.y < 0.0) {
		colour -= 1.75 * vec3(smoothstep(1.0, 0.0, abs(uv.y)));
	}

	diffuse = vec3(colour);

	return 0.0;
}


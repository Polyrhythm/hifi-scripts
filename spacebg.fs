const mat2 m2 = mat2(0.8,-0.6,0.6,0.8);
float fbm( in vec2 p ){
    float f = 0.0;
    f += 0.5000 * snoise( p ); p = m2*p*2.02;
    f += 0.2500 * snoise( p ); p = m2*p*2.03;
    f += 0.1250 * snoise( p ); p = m2*p*2.01;
    f += 0.0625 * snoise( p );

    return f / 0.9375;
}

float iPlanet(in vec3 p) {
    return 1.0 - smoothstep(0.995, 1.0, distance(p, vec3(1.0, 0.0, 0.0)));
}

float iAtmo(in vec3 p) {
    return 1.0 - smoothstep(0.945, 1.0, distance(p, vec3(0.9, 0.0, 0.0)));
}

vec3 getSkyboxColor() {
    vec3 p = normalize(_normal);
    float planet = iPlanet(p);
    float atmo = iAtmo(p);
    vec3 planetColour = vec3(1.0);
    vec3 atmoColour = vec3(0.2, 0.3, 0.8);
    vec3 cloudColour = 1.0 - vec3(1.0, 0.6, 0.8);
    vec3 clouds = cloudColour * fbm(p.xy + fbm(p.xy));

    vec3 colour = mix(vec3(0.0), planetColour - clouds, planet);
    colour += mix(vec3(0.0), atmoColour, fract(atmo));

    return colour;
}
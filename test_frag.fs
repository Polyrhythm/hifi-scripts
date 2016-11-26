precision highp float;

void main(void) {
    vec2 uv = gl_FragCoord.xy / iResolution.xy;
    vec2 p = -1.0 + 2.0 * uv;

    vec3 colour = vec3(1.0);

    float map = step(0.1, distance(p, vec2(0.0)));

    outColour = vec4(vec3(map, 1.0, 1.0), 1.0);
}

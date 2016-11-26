vec2 iResolution = iWorldScale.xz;

void main(out vec4 gl_FragColor, in vec2 gl_FragCoord) {
    vec2 uv = gl_FragCoord.xy / iResolution.xy;
    vec2 p = -1.0 + 2.0 * uv;

    vec3 colour = vec3(1.0);

    float map = step(0.1, distance(p, vec2(0.0)));

    gl_FragColor = vec4(vec3(map, 1.0, 1.0), 1.0);
}

vec4 getProceduralColor() {
    vec2 position = _position.xz;
    position += 0.5;
    position.y = 1.0 - position.y;
    
    vec4 result;
    mainImage(result, position * iWorldScale.xz);
    return result;
}

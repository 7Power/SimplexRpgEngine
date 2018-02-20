//
// Simple passthrough fragment shader
//
varying vec2 v_vTexcoord;
varying vec4 v_vColour;

void main()
{
    gl_FragColor = vec4(-1.0, -1.0, -1.0, 1.0) * v_vColour * texture2D( gm_BaseTexture, v_vTexcoord );
}

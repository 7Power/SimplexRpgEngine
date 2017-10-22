/// @description Insert description here
// You can write your code in this editor

v_lerp = make_color_rgb(255 - 255 * sin(degtorad(time)), 255 * sin(degtorad(time)), 255 - 255 * sin(degtorad(time)));
time++;

var vz = z + lengthdir_x(1, image_index / image_number * 360);
draw_shadow(x, y, 6 / (1 + vz / 20), qqa);
if (z <= 0) {image_speed = lerp(image_speed, 0, 0.1); if (image_speed < 0.1) {if (image_index < h) {image_index+=0.5;} if (image_index > h) {image_index-=0.5;} image_speed = 0; image_speed = 0;} qqa = lerp(qqa, 0, 0.1); if (image_angle < 30) {image_angle++;}} else {qqa = lerp(qqa, 1, 0.1);}

shader_set(shdLerp);
shader_set_uniform_f(shader_get_uniform(shdLerp, "v_vColour"), color_get_red(v_lerp), color_get_green(v_lerp), color_get_blue(v_lerp), v_lerpAlpha);
draw_sprite_ext(sprite_index, image_index, x, y - z, image_xscale, image_yscale, f*image_angle, image_blend, image_alpha);
shader_reset();

event_inherited();

if (!v_alive)
{
    if (image_xscale > 0)
       {
        image_xscale -= 0.1;
        image_yscale = image_xscale;
       }
       else {instance_destroy();}	
}
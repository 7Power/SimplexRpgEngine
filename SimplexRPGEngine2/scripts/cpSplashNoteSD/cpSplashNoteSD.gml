/// @function cpSplashNote()

var text,color,sprite,override,ani,xx,yy,mode,log,spd, font;
text     = "Nedefinovaný log"
color    = c_lime;
sprite   = -1;
override = 0;
ani      = 0.2;
xx       = oPlayer.x-32;
yy       = oPlayer.y-48;
font     = fntPixel;
mode     = "normal";
spd      = 0.02;

if (argument_count > 0) {text     = string(argument[0]);}
if (argument_count > 1) {color    = argument[1];}
if (argument_count > 2) {if (argument[2] != -1) {sprite   = argument[2];}}
if (argument_count > 3) {if (argument[3] != -1) {override = argument[3];}}
if (argument_count > 4) {if (argument[4] != -1) {ani      = argument[4];}}
if (argument_count > 5) {if (argument[5] != -1) {xx       = argument[5];}}
if (argument_count > 6) {if (argument[6] != -1) {yy       = argument[6];}}
if (argument_count > 7) {if (argument[7] != -1) {font     = argument[7];}}
if (argument_count > 8) {if (argument[8] != -1) {mode     = argument[8];}}
if (argument_count > 9) {if (argument[9] != -1) {spd      = argument[9];}}

//if (text   == "-1") {text   = "+ " + itm_info_head; if (itm_stackable && itm_number > 1) {text += " x" + string(itm_number);}}
//if (color  == -1)   {color  = itm_effect; if (color == c_black) {color = c_white;}}
//if (sprite == -1)   {sprite = tempSpr;}

show_message("");
log = instance_create_depth(xx, yy, -30000, oSplashNote);
log.sprite = sprite;
log.text   = text;
log.color  = color;
log.ani    = ani;
log.parsed = libUtilityParseTextColored(text);
log.font   = font;
log.mode   = mode;
log.spd    = spd;
using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Backgrounds : StoryboardObjectGenerator
    {
        public int delay = 65988;

        public override void Generate()
        {
		    Section1(0,3522, 26110, 31736);
		    Section2(26110, 31736, 78281, 82899);
		    Section3(78281, 82899, 113756, 118039);
		    Section4(113756, 118039, 159553, 168604);
		    Section5(159553, 168604, 228604, 238527);
		    Section6(228604, 238527, 267399, 270105);
		    Section6Extra(267399, 270105, 325143, 330265);
		    Section7(325193, 331193, 325143 + delay, 330265 + delay);
		    Section8(325143 + delay, 330265 + delay, 385122 + delay, 390839 + delay);
		    Section9(385122 + delay, 390839 + delay, 421696 + delay, 425124 + delay);
		    Section9Extra(421696 + delay, 425124 + delay, 462839 + delay, 464553 + delay);
		    Section9Extra2(462839 + delay, 464553 + delay, 473124 + delay, 476527 + delay);
		    Section10(473124 + delay, 476527 + delay, 512718 + delay, 517468 + delay);
		    Section11(512718 + delay, 517468 + delay, 537000 + delay, 538874 + delay);
		    Section11Extra(537000 + delay, 538874 + delay, 547468 + delay, 548874 + delay);
		    Section11Extra2(547468 + delay, 548874 + delay, 557468 + delay, 572258 + delay);
		    Section12(557468 + delay, 572258 + delay, 649797 + delay, 659879 + delay);
		    Section13(649797 + delay, 659879 + delay, 668278 + delay, 670078 + delay);
		    Section13Extra(668278 + delay, 670078 + delay, 678479 + delay, 679679 + delay);
		    Section13(678479 + delay, 679679 + delay, 687479 + delay, 689278 + delay);
		    Section13Extra2(687479 + delay, 689278 + delay, 698278 + delay, 704355 + delay);
		    Section14(698278 + delay, 704355 + delay, 747555 + delay, 748927 + delay);
		    Section14Extra(747555 + delay, 748927 + delay, 792127 + delay, 798302 + delay);
		    Section15(792127 + delay, 798302 + delay, 827773 + delay, 831471 + delay);
		    Section16(827773 + delay, 831471 + delay, 877380 + delay, 883429 + delay);
		    Section17(877380 + delay, 883429 + delay, 928429 + delay, 934054 + delay);

            // remove map background
            var bg = GetLayer("").CreateSprite("bg.jpg", OsbOrigin.Centre);
            bg.Fade(0, 0);

            // darken backgrounds
            var bitmap = GetMapsetBitmap("sb/pixel.png");
            var DO = GetLayer("Dark Overlay").CreateSprite("sb/pixel.png", OsbOrigin.Centre);
            DO.Fade(0, 1000043, 0.3f, 0.3f);
            DO.Color(0, Color4.Black);
            DO.ScaleVec(0, 854.0f / bitmap.Width, 480.0f / bitmap.Height);
        }
        
        public void Section1(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/1/bg.jpg");
            var scale = 480.0f / bitmap.Height;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/1/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, 240);
            sprite.MoveX(start, end, 280, 320);
            sprite.Scale(start, end, scale + 0.1f, scale);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);

            var armOverlay = GetLayer("Overlays").CreateSprite("sb/backgrounds/1/overlay.png", OsbOrigin.Centre);

            armOverlay.MoveY(start, 240);
            armOverlay.MoveX(start, end, 280, 320);
            armOverlay.Scale(start, end, scale + 0.1f, scale);
            armOverlay.Fade(3522, 3522 + 1000, 0, 1);
            armOverlay.Fade(endBookmark - 1000, endBookmark, 1, 0);
        }
        
        public void Section2(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/2/bg.jpg");
            var scale = 480.0f / bitmap.Height;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/2/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, end, 350, 300);
            sprite.MoveX(start, end, 400, 200);
            sprite.Scale(start, scale + 0.2);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section3(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/3/bg.jpg");
            var scale = 480.0f / bitmap.Height;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/3/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, end, 360, 200);
            sprite.MoveX(start, 320);
            sprite.Scale(start, scale + 0.16);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section4(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/4/bg.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/4/bg.jpg", OsbOrigin.BottomCentre);

            sprite.MoveY(start, end, 1000, 500);
            sprite.MoveX(start, 320);
            sprite.Scale(start, scale + 0.16);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section5(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/5/bg.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/5/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, 300);
            sprite.MoveX(start, end, 400, 320);
            sprite.Scale(start, scale + 0.16);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section6(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/6/bg.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/6/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, 300);
            sprite.MoveX(start, end, 320, 400);
            sprite.Scale(start, scale + 0.16);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section6Extra(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/6/bg.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/6/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, end, 300, 400);
            sprite.MoveX(start, end, 100, 20);
            sprite.Scale(start, scale + 0.5);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section7(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/7/bg.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/7/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, end, 350, 300);
            sprite.MoveX(start, end, 400, 200);
            sprite.Scale(start, scale + 0.2);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section8(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/8/bg.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/8/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, end, 380, 300);
            sprite.MoveX(start, end, 100, 200);
            sprite.Scale(start, scale + 0.2);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section9(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/9/bg.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/9/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, end, 300, 350);
            sprite.MoveX(start, end, 300, 350);
            sprite.Scale(start, scale + 0.2);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section9Extra(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/9/bg2.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/9/bg2.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, end, 300, 220);
            sprite.MoveX(start, end, 300, 400);
            sprite.Scale(start, scale + 0.2);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section9Extra2(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/9/bg3.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/9/bg3.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, end, 350, 250);
            sprite.MoveX(start, end, 300, 350);
            sprite.Scale(start, scale + 0.2);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section10(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/10/bg.jpg");
            var scale = 480.0f / bitmap.Height;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/10/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, 240);
            sprite.MoveX(start, 320);
            sprite.Scale(start, end, scale, scale + 0.1);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section11(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/11/bg.jpg");
            var scale = 480.0f / bitmap.Height;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/11/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, 240);
            sprite.MoveX(start, 320);
            sprite.Scale(start, end, scale, scale + 0.1);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section11Extra(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/11/bg2.jpg");
            var scale = 480.0f / bitmap.Height;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/11/bg2.jpg", OsbOrigin.Centre);

            sprite.MoveY(OsbEasing.InOutSine, start, end, 140, 240);
            sprite.MoveX(start, end, 80, 200);
            sprite.Scale(start, scale + 0.2);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section11Extra2(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/11/bg3.jpg");
            var scale = 480.0f / bitmap.Height;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/11/bg3.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, 240);
            sprite.MoveX(start, 320);
            sprite.Scale(start, end, scale, scale + 0.1);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section12(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/12/bg.jpg");
            var scale = 480.0f / bitmap.Height;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/12/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, 240);
            sprite.MoveX(start, 320);
            sprite.Scale(start, end, scale, scale + 0.2);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section13(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/13/bg.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/13/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, end, 240, 300);
            sprite.MoveX(start, 320);
            sprite.Scale(start, end, scale + 0.2, scale + 0.3);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section13Extra(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/13/bg2.jpg");
            var scale = 480.0f / bitmap.Height;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/13/bg2.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, end, 340, 400);
            sprite.MoveX(start, end, 280, 320);
            sprite.Scale(start, end, scale + 0.3, scale + 0.4);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section13Extra2(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/13/bg3.jpg");
            var scale = 480.0f / bitmap.Height;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/13/bg3.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, 240);
            sprite.MoveX(start, 320);
            sprite.Scale(start, end, scale + 0.2, scale + 0.4);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section14(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/14/bg.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/14/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, end, 240, 300);
            sprite.MoveX(start, end, 420, 320);
            sprite.Scale(start, scale + 0.3);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section14Extra(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/14/bg2.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/14/bg2.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, end, 300, 240);
            sprite.MoveX(start, end, 320, 420);
            sprite.Scale(start, scale + 0.2);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section15(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/15/bg.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/15/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, end, 300, 340);
            sprite.MoveX(start, 320);
            sprite.Scale(start, end, scale + 0.2, scale + 0.4);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section16(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/16/bg.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/16/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, 240);
            sprite.MoveX(start, 320);
            sprite.Scale(start, end, scale, scale + 0.05);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
        
        public void Section17(int start, int startBookmark, int endBookmark, int end)
        {
            var fade = 0.9f;
            var bitmap = GetMapsetBitmap("sb/backgrounds/17/bg.jpg");
            var scale = 854.0f / bitmap.Width;
            var sprite = GetLayer("").CreateSprite("sb/backgrounds/17/bg.jpg", OsbOrigin.Centre);

            sprite.MoveY(start, 240);
            sprite.MoveX(start, end, 400, 300);
            sprite.Scale(start, scale + 0.1);
            sprite.Fade(start, startBookmark, 0, fade);
            sprite.Fade(endBookmark, end, fade, 0);
        }
    }
}

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
    public class Overlays : StoryboardObjectGenerator
    {
        public int delay = 65988;
        public override void Generate()
        {
            // HUD();

		    GridPattern(0, 1000043);
		    Vignette(0, 1000043);

		    Gradient(0, 118039 + delay, "#D48A08");
		    Gradient(118039, 238527, "#E6BB7E");
		    Gradient(238527, 267399, "#42E2E0");
		    Gradient(267399, 390839 + delay, "#E24264");
		    Gradient(390839 + delay, 476527 + delay, "#42E2E0");
		    Gradient(476527 + delay, 704355 + delay, "#E24264");
		    Gradient(704355 + delay, 798302 + delay, "#E6BB7E");
		    Gradient(798302 + delay, 831471 + delay, "#42E2E0");
		    Gradient(831471 + delay, 928429 + delay, "#E24264");

		    Particles("Particles Front", 0, 991605);
		    Particles("Particles Back", 0, 991605);
            
            // SECTION 1
		    LensFlare("sb/lens flare/1.jpg", 3522, 26110, -40, 10, new Vector2(-307, -200), new Vector2(0, 0), OsbOrigin.TopLeft, false);
		    Highlight(3522, 26110, 0, "#FF3C7C");
            
            // SECTION 2
		    LensFlare("sb/lens flare/1.jpg", 31736, 78281, 20, -10, new Vector2(1200, -400), new Vector2(0, 0), OsbOrigin.TopRight, true);
		    Highlight(31736, 78281, 0, "#FF3C7C");
            
            // SECTION 3
		    LensFlare("sb/lens flare/1.jpg", 82899, 113756, 20, 0, new Vector2(1200, -400), new Vector2(0, 0), OsbOrigin.TopRight, true);
		    Highlight(82899, 113756, 0, "#FF3C7C");
            
            // SECTION 4
		    // LensFlare("sb/lens flare/1.jpg", 118039, 159553, -40, 10, new Vector2(-107, 0), new Vector2(0, 0), OsbOrigin.TopLeft, false);
		    Highlight(118039, 159553, 0.1f, "#FFFFFF");
            
            // // SECTION 5
		    LensFlare("sb/lens flare/2.jpg", 168604, 228604, 0, 3, new Vector2(-600, 280), new Vector2(-680, 280), OsbOrigin.CentreLeft, false, true);
		    Highlight(168604, 228604, 0, "#FF3C7C");
            
            // // SECTION 6
		    LensFlare("sb/lens flare/2.jpg", 238527, 267399, 0, 0, new Vector2(-600, 400), new Vector2(0, 0), OsbOrigin.CentreLeft, false);
		    LensFlare("sb/lens flare/2.jpg", 267399, 325143, 0, 3, new Vector2(-800, 400), new Vector2(-880, 500), OsbOrigin.CentreLeft, false, true);
		    Highlight(238527, 325143, 0, "#FF3C7C");
            
            // // // SECTION 7
		    LensFlare("sb/lens flare/1.jpg", 331193, 389318, -30, -10, new Vector2(-507, -200), new Vector2(-707, -200), OsbOrigin.TopLeft, false, true);
		    Highlight(331193, 389318, 0.05f, "#E6BB7E");
            
            // // SECTION 8
		    LensFlare("sb/lens flare/1.jpg", 330265 + delay, 385122 + delay, 10, -10, new Vector2(-553, -450), new Vector2(-500, -350), OsbOrigin.TopLeft, false, true);
		    Highlight(330265 + delay, 385122 + delay, 0.05f, "#42E2E0");
            
            // // SECTION 9
		    Highlight(390839 + delay, 423410 + delay, 0.1f, "#FFFFFF");
		    LensFlare("sb/lens flare/2.jpg", 423410 + delay, 464553 + delay, 0, 3, new Vector2(580, 450), new Vector2(680, 530), OsbOrigin.Centre, true, true);
		    Highlight(423410 + delay, 464553 + delay, 0, "#42E2E0");
		    LensFlare("sb/lens flare/1.jpg", 464553 + delay, 473124 + delay, -30, -40, new Vector2(450, -500), new Vector2(500, -600), OsbOrigin.TopRight, true, true);
		    Highlight(464553 + delay, 473124 + delay, 0, "#FFFFFF");
            
            // // SECTION 10
		    // LensFlare("sb/lens flare/1.jpg", 476527, 512718, -10, 0, new Vector2(-650, -300), new Vector2(0, 0), OsbOrigin.TopLeft, false);
		    Highlight(476527 + delay, 512718 + delay, 0.1f, "#FFFFFF");
            
            // // SECTION 11
		    // LensFlare("sb/lens flare/1.jpg", 0, 26110, -40, 10, new Vector2(-107, 0), new Vector2(0, 0), OsbOrigin.TopLeft, false);
		    Highlight(517468 + delay, 557468 + delay, 0.1f, "#FF3C7C");
            
            // // SECTION 12
		    LensFlare("sb/lens flare/1.jpg", 572258 + delay, 649797 + delay, 10, -10, new Vector2(1200, -400), new Vector2(0, 0), OsbOrigin.TopRight, true);
		    Highlight(572258 + delay, 649797 + delay, 0.1f, "#E6BB7E");
            
            // // SECTION 13
		    // LensFlare("sb/lens flare/1.jpg", 0, 26110, -40, 10, new Vector2(-107, 0), new Vector2(0, 0), OsbOrigin.TopLeft, false);
		    Highlight(659879 + delay, 698278 + delay, 0, "#FF3C7C");
            
            // // SECTION 14
		    LensFlare("sb/lens flare/1.jpg", 704355 + delay, 748927 + delay, -30, -40, new Vector2(550, -500), new Vector2(600, -600), OsbOrigin.TopRight, true, true);
		    LensFlare("sb/lens flare/1.jpg", 748927 + delay, 792127 + delay, -40, -30, new Vector2(550, -500), new Vector2(600, -600), OsbOrigin.TopRight, true, true);
		    Highlight(704355 + delay, 792127 + delay, 0, "#42E2E0");
            
            // // SECTION 15
		    // LensFlare("sb/lens flare/1.jpg", 0, 26110, -40, 10, new Vector2(-107, 0), new Vector2(0, 0), OsbOrigin.TopLeft, false);
		    Highlight(798302 + delay, 827773 + delay, 0, "#42E2E0");
            
            // // SECTION 16
		    LensFlare("sb/lens flare/1.jpg", 831471 + delay, 877380 + delay, -40, -30, new Vector2(600, -600), new Vector2(650, -620), OsbOrigin.TopRight, true, true);
		    Highlight(831471 + delay, 877380 + delay, 0, "#E6BB7E");
            
            // // SECTION 17
		    // LensFlare("sb/lens flare/1.jpg", 0, 26110, -40, 10, new Vector2(-107, 0), new Vector2(0, 0), OsbOrigin.TopLeft, false);
		    Highlight(883429 + delay, 928429 + delay, 0.1f, "#D48A08");
        }

        public int[] SectionStart()
        {
            int[] sectionStart = new int[]{ 3522, 31736, 82899, 118039, 168604, 238527, 325193, 330265 + delay, 390839 + delay, 476527 + delay, 517468 + delay, 572258 + delay, 659879 + delay, 704355 + delay, 798302 + delay, 831471 + delay, 883429 + delay };
            
            return sectionStart;
        }

        public int[] SectionEnd()
        {
            int[] sectionEnd = new int[]{ 26110, 78281, 113756, 159553, 228604, 325143, 396253, 385122 + delay, 473124 + delay, 512718 + delay, 557468 + delay, 649797 + delay, 698278 + delay, 792127 + delay, 827773 + delay, 877380 + delay, 928429 + delay };
            
            return sectionEnd;
        }

        public void HUD()
        {
            var opacity = 0.2f;
            var position = new Vector2(320, 380);
            var play = GetLayer("HUD").CreateSprite("sb/overlays/play.png", OsbOrigin.CentreLeft, new Vector2(position.X - 320, position.Y));
            var playTrigger = GetLayer("HUD").CreateSprite("sb/overlays/play.png", OsbOrigin.Centre);
            var pause = GetLayer("HUD").CreateSprite("sb/overlays/pause.png", OsbOrigin.CentreLeft, new Vector2(position.X - 298.5f, position.Y));
            var pauseTrigger = GetLayer("HUD").CreateSprite("sb/overlays/pause.png", OsbOrigin.Centre, new Vector2(position.X - 298.5f + 11, position.Y));
            var progress = GetLayer("HUD").CreateSprite("sb/pixel.png", OsbOrigin.CentreLeft, new Vector2(position.X - 273, position.Y));

            play.Scale(0, 0.1);
            play.Fade(0, 1000, 0, opacity);
            play.Fade(1000043 - 1000, 1000043, opacity, 0);
            play.Additive(0, 1000043);
            pause.Scale(0, 0.1);
            pause.Fade(0, 1000, 0, opacity);
            pause.Fade(1000043 - 1000, 1000043, opacity, 0);
            pause.Additive(0, 1000043);
            
            var color = "#FFFFFF";

            // play.Color(time, time + 2000, play.ColorAt(time), color);
            play.Color(0, color);
            // playTrigger.Color(time, time + 2000, playTrigger.ColorAt(time), color);
            playTrigger.Color(0, color);
            // pause.Color(time, time + 2000, pause.ColorAt(time), color);
            pause.Color(0, color);
            // pauseTrigger.Color(time, time + 2000, pauseTrigger.ColorAt(time), color);
            pauseTrigger.Color(0, color);
            // progress.Color(time, time + 2000, progress.ColorAt(time), color);
            progress.Color(0, color);

            for (int i = 0; i < SectionStart().Length; i++)
            {
                playTrigger.Scale(SectionStart()[i], SectionStart()[i] + 2000, 0.1, 0.2);
                playTrigger.Fade(SectionStart()[i], SectionStart()[i] + 2000, 1, 0);
                playTrigger.Move(SectionStart()[i], SectionStart()[i] + 2000, new Vector2(position.X - 320 + 11, position.Y), new Vector2(position.X - 320 + 12.5f, position.Y));
                playTrigger.Additive(SectionStart()[i], SectionStart()[i] + 2000);
            }

            for (int i = 0; i < SectionEnd().Length; i++)
            {
                pauseTrigger.Scale(SectionEnd()[i], SectionEnd()[i] + 2000, 0.1, 0.2);
                if (SectionStart()[i] < 17640)
                pauseTrigger.Fade(0, 0);
                else
                pauseTrigger.Fade(SectionEnd()[i], SectionEnd()[i] + 2000, 1, 0);
                pauseTrigger.Additive(SectionEnd()[i], SectionEnd()[i] + 2000);
            }

            int[] sectionEnd = new int[]{ 0 };
            var startScale = new Vector2(0, 10);
            var endScale = new Vector2(593, 10);
            
            for (int i = 0; i < SectionEnd().Length; i++)
            progress.ScaleVec(SectionStart()[i], SectionEnd()[i], startScale, endScale);
            for (int i = 0; i < SectionEnd().Length; i++)
            progress.ScaleVec(OsbEasing.OutBack, SectionEnd()[i], SectionEnd()[i] + 3000, endScale, startScale);
            progress.Fade(0, 1000, 0, opacity);
            progress.Fade(1000043 - 1000, 1000043, opacity, 0);
            progress.Additive(0, 1000043);
        }

        public void GridPattern(int start, int end)
        {
            var bitmap = GetMapsetBitmap("sb/overlays/grid.jpg");
            var sprite = GetLayer("Grid").CreateSprite("sb/overlays/grid.jpg", OsbOrigin.Centre);

            sprite.Additive(start, end);
            sprite.Fade(start, start + 2500, 0, 0.3f);
            sprite.Fade(end - 2500, end, 0.3f, 0);
            sprite.ScaleVec(start, 854.0f / bitmap.Width, 480.0f / bitmap.Height);
        }

        public void Vignette(int start, int end)
        {
            var bitmap = GetMapsetBitmap("sb/overlays/vignette.png");
            var sprite = GetLayer("Vignette").CreateSprite("sb/overlays/vignette.png", OsbOrigin.Centre);

            sprite.Fade(start, start + 2500, 0, 0.8f);
            sprite.Fade(end - 2500, end, 0.8f, 0);
            sprite.ScaleVec(start, 854.0f / bitmap.Width, 480.0f / bitmap.Height);
        }

        public void Gradient(int start, int end, string color)
        {
            var bitmap = GetMapsetBitmap("sb/overlays/gradient.png");
            var sprite = GetLayer("Gradient").CreateSprite("sb/overlays/gradient.png", OsbOrigin.Centre);

            sprite.Color(start, color);
            sprite.Additive(start, end);
            sprite.Fade(start, start + 2500, 0, 0.3f);
            sprite.Fade(end - 2500, end, 0.3f, 0);
            sprite.ScaleVec(start, 854.0f / bitmap.Width, 480.0f / bitmap.Height);
        }

        public void LensFlare(string path, int start, int end, int startR, int endR, Vector2 posStart, Vector2 posEnd, OsbOrigin origin, bool flipH, bool move = false)
        {
            var bitmap = GetMapsetBitmap(path);
            var sprite = GetLayer("LensFlare").CreateSprite(path, origin);

            var startRotation = MathHelper.DegreesToRadians(startR);
            var endRotation = MathHelper.DegreesToRadians(endR);

            sprite.Additive(start, end);
            sprite.Scale(start, 1000.0f / bitmap.Height);
            sprite.Fade(start, start + 2500, 0, 0.8f);
            sprite.Fade(end - 2500, end, 0.8f, 0);
            sprite.Rotate(start, end, startRotation, endRotation);

            if (!move)
            {
                sprite.Move(start, posStart);
            }
            else
            {
                sprite.Move(start, end, posStart, posEnd);
            }

            if (flipH)
            sprite.FlipH(start, end);
        }

        public void Highlight(int start, int end, float extraFade, string color)
        {
            int timeStep = 0;
            for (int i = start; i < end; i += timeStep)
            {
                timeStep = Random(100, 1000);
                var fade = Random(0.01 + extraFade, 0.1 + extraFade);
                var fadeTime = Random(1000, 2000);
                var sprite = GetLayer("Highlight").CreateSprite("sb/overlays/highlight.png", OsbOrigin.Centre);

                sprite.Color(i, color);
                sprite.Additive(i, i + fadeTime * 2);
                sprite.Move(i, new Vector2(Random(-107, 854), Random(0, 480)));
                sprite.Fade(i + fadeTime / 2, i + fadeTime, 0, fade);
                sprite.Fade(i + fadeTime, i + fadeTime * 2, fade, 0);
                sprite.Scale(i, i + fadeTime * 2, 2, 0.5f);
            }
        }

        public void Particles(string layer, int start, int end)
        {
            for (var i = 0; i < 100; i++)
            {
                var sprite = GetLayer(layer).CreateSprite("sb/p.png", OsbOrigin.Centre);

                var fade = Random(0.05, 0.5);
                var fadeTime = Random(200, 500);
                var duration = Random(1500, 5000);
                var startX = Random(50, 590);
                var middleX = startX + Random(-100, 100);
                var endX = middleX + Random(-50, 50);

                sprite.StartLoopGroup(3522, (end - start) / duration);

                sprite.Additive(0, duration);
                sprite.Fade(0, fadeTime, 0, fade);
                sprite.Fade(duration - fadeTime, duration, fade, 0);
                sprite.Scale(0, duration, Random(0.005, 0.02), Random(0.005, 0.02));

                sprite.MoveY(0, duration, Random(380, 480), Random(-100, 0));

                var shift = Random(50, 150);
                if (startX >= 320)
                {
                    sprite.MoveX(OsbEasing.InOutSine, 0, duration / 2, startX + shift, middleX + shift);
                    sprite.MoveX(OsbEasing.InOutSine, duration / 2, duration, middleX + shift, endX + shift);
                }
                else if (startX < 320)
                {
                    sprite.MoveX(OsbEasing.InOutSine, 0, duration / 2, startX - shift, middleX - shift);
                    sprite.MoveX(OsbEasing.InOutSine, duration / 2, duration, middleX - shift, endX - shift);
                }

                sprite.EndGroup();
            }
        }
    }
}

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
    public class Transitions : StoryboardObjectGenerator
    {
        public int delay = 65988;

        public override void Generate()
        {
		    Waves(0, 3522 + 4000, 0);
		    Waves(26110, 31736, 1000);
		    Waves(78281, 82899, 1000);
		    Waves(113756, 118039, 1000);
		    Waves(159553, 168604, 1000);
		    Waves(228604, 238527, 1000);
		    Waves(325193, 331193, 1000);
            
		    Waves(325143 + delay, 330265 + delay, 1000);
		    Waves(385122 + delay, 390839 + delay, 1000);
		    Waves(473124 + delay, 482242 + delay, 1000);
		    Waves(512718 + delay, 517468 + delay, 1000);
		    Waves(557468 + delay, 572258 + delay, 1000);
		    Waves(649797 + delay, 659879 + delay, 1000);
		    Waves(698278 + delay, 704355 + delay, 1000);
		    Waves(792127 + delay, 798302 + delay, 1000);
		    Waves(827773 + delay, 831471 + delay, 1000);
		    Waves(877380 + delay, 883429 + delay, 1000);
        }

        public void Waves(int start, int end, int delay)
        {
            // vignette
            var bitmap = GetMapsetBitmap("sb/overlays/vignette2.png");
            var sprite = GetLayer("Vignette").CreateSprite("sb/overlays/vignette2.png", OsbOrigin.Centre, new Vector2(320, 240));

            var duration = end - start;
            bool minDuration = duration >= 6000;

            if (!minDuration)
            {
                WaveStyle(false, new Vector2(1000, 420), 0.5f, start - delay, 50, duration + 2000 + delay, 20);
                WaveStyle(true, new Vector2(-360, 70), 0.5f, start - delay, 50, duration + 2000 + delay, 20);

                var endtime = start + duration + 2000;
                sprite.ScaleVec(start, 854.0f / bitmap.Width, 480.0f / bitmap.Height);
                sprite.Fade(start - (delay * 1.5f), start + 500, 0, 0.6f);
                sprite.Fade(endtime - 1500, endtime + 500, 0.6f, 0);
            }
            else if (minDuration)
            {
                WaveStyle(false, new Vector2(1000, 420), 0.5f, start - delay, 50, duration + delay, 20);
                WaveStyle(true, new Vector2(-360, 70), 0.5f, start - delay, 50, duration + delay, 20);

                var endtime = start + duration;
                sprite.ScaleVec(start, 854.0f / bitmap.Width, 480.0f / bitmap.Height);
                sprite.Fade(start - (delay * 1.5f), start + 500, 0, 0.6f);
                sprite.Fade(endtime - 1500, endtime + 500, 0.6f, 0);
            }
        }

        public void WaveStyle(bool flipV, Vector2 position, float opacity, int start, int interval, int duration, int amount)
        {
            var fadeDelay = 150;
            for (var i = 0; i < 15; i++)
            {
                var distance = 20;

                // not flipped
                if (!flipV)
                {
                    WaveSettings(flipV, opacity, new Vector2(position.X - (i * distance), position.Y - i * (distance / 5)),
                        new Vector2(position.X - (i * distance) - (i * 50), position.Y - i * (distance / 10)),
                    
                    10 + i * 5, 10 + i * 5,
                    0.01f - i * (-0.0005f), 0.01f - i * (0.0008f), 0.01f - i * (0.0005f),
                    start + i * fadeDelay, start, interval, duration, amount);
                }
                else
                {
                    // flipped
                    WaveSettings(flipV, opacity, new Vector2(position.X + (i * distance), position.Y + i * (distance / 5)),
                        new Vector2(position.X + (i * distance) + (i * 50), position.Y + i * (distance / 10)),
                    
                    10 + i * 5, 10 + i * 5,
                    0.01f - i * (-0.0005f), 0.01f - i * (0.0008f), 0.01f - i * (0.0005f),
                    start + i * fadeDelay, start, interval, duration, amount);
                }
            }
        }

        public void WaveSettings(bool flipV, float opacity, Vector2 posStart, Vector2 posEnd, int startWidth, int endWidth, float startScale, float endScale, float scaleRate, int fadeStart, int start, int interval, int duration, int amount)
        {
            var I = 0;
            for (var i = 0; i < amount; i += 1)
            {
                var sprite = GetLayer("").CreateSprite("sb/c.png", OsbOrigin.Centre);

                if (!flipV)
                {
                    var startPos = new Vector2(posStart.X - i * startWidth, posStart.Y);
                    var endPos = new Vector2(posEnd.X - i * endWidth, posEnd.Y);

                    sprite.MoveX(OsbEasing.None, start, start + duration, startPos.X, endPos.X);
                    sprite.MoveY(OsbEasing.InSine, start, start + duration, startPos.Y + I, endPos.Y + I);

                    I += 6;
                }
                else
                {
                    var startPos = new Vector2(posStart.X + i * startWidth, posStart.Y);
                    var endPos = new Vector2(posEnd.X + i * endWidth, posEnd.Y);

                    sprite.MoveX(OsbEasing.None, start, start + duration, startPos.X, endPos.X);
                    sprite.MoveY(OsbEasing.InSine, start, start + duration, startPos.Y + I, endPos.Y + I);

                    I -= 6;
                }
                
                var fadeDelay = 20;
                var colorDelay = 20;
                sprite.Fade(fadeStart + i * fadeDelay, fadeStart + i * fadeDelay + 500, 0, opacity);
                sprite.Fade(start + duration - 1000, start + duration, opacity, 0);
                sprite.Color(fadeStart + i * colorDelay, fadeStart + i * colorDelay + 500, "#F1BFAB", "#FFFFFF");

                sprite.Scale(start, start + duration, startScale + i * scaleRate, endScale + i * scaleRate);
            }
        }
    }
}

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
    public class Highlight : StoryboardObjectGenerator
    {
        [Configurable]
        public int fadeDuration = 3000;

        public override void Generate()
        {
            List<int> hits = new List<int>();
            hits.Add(26160);
            hits.Add(78331);
            hits.Add(113806);
            hits.Add(159603);
            hits.Add(228654);
            hits.Add(325193);
            hits.Add(389318);
            hits.Add(451110);
            hits.Add(539112);
            hits.Add(578706);
            hits.Add(623456);
            hits.Add(715785);
            hits.Add(764267);
            hits.Add(858115);
            hits.Add(893761);
            hits.Add(943368);
            hits.Add(994418);

            // emphasized downbeats
            hits.Add(168655);
            hits.Add(198654);
            hits.Add(238577);
            hits.Add(332847);
            hits.Add(396252);
            hits.Add(423681);
            hits.Add(460255);
            hits.Add(473970);
            hits.Add(528827);
            hits.Add(548230);
            hits.Add(563468);
            hits.Add(583456);
            hits.Add(603612);
            hits.Add(656708);
            hits.Add(725867);
            hits.Add(745067);
            hits.Add(814229);
            hits.Add(847143);
            hits.Add(864290);
            hits.Add(914277);
            hits.Add(949418);
            hits.Add(964418);

            // sort the list
            hits.Sort();

            foreach (var hitobject in Beatmap.HitObjects)
            {
                foreach (var hitTimes in hits)
                {
                    if ((hitTimes != 0 || hitTimes + 50 != 0) && 
                        (hitobject.StartTime < hitTimes - 5 || hitTimes + 50 + 5 <= hitobject.StartTime))
                        continue;
                    
                    var sprite = GetLayer("").CreateSprite("sb/s.png", OsbOrigin.Centre, hitobject.Position);
                    var circle = GetLayer("").CreateSprite("sb/c2.png", OsbOrigin.Centre, hitobject.Position);
                    var ring = GetLayer("Ring").CreateSprite("sb/r.png", OsbOrigin.Centre, hitobject.Position);

                    var rotation = MathHelper.DegreesToRadians(Random(-360, 360));
                    var scale = new Vector2((float)Random(1, 2), (float)Random(0.2, 0.5));

                    sprite.ScaleVec(OsbEasing.OutSine, hitobject.StartTime, hitobject.StartTime + fadeDuration, scale.X / 3, scale.Y, scale.X, 0);
                    sprite.Rotate(OsbEasing.OutSine, hitobject.StartTime, hitobject.StartTime + fadeDuration, rotation, rotation + MathHelper.DegreesToRadians(Random(-20, 20)));
                    sprite.Fade(hitobject.StartTime + 50, hitobject.StartTime + fadeDuration, 1, Random(0.7, 1));

                    circle.Scale(OsbEasing.InOutSine, hitobject.StartTime, hitobject.StartTime + fadeDuration, 0.4f, 0);
                    
                    ring.Color(hitobject.StartTime + fadeDuration - (fadeDuration / 3), hitobject.StartTime + fadeDuration, Color4.White, Color4.IndianRed);
                    ring.Scale(OsbEasing.OutSine, hitobject.StartTime, hitobject.StartTime + fadeDuration, 0.2f, 1.5f);
                    ring.Fade(hitobject.StartTime + 50, hitobject.StartTime + fadeDuration, 1, 0);
                }
            }
        }
    }
}

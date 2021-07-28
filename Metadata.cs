using System;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics;
using Microsoft.VisualBasic;
using StorybrewCommon.Scripting;
using StorybrewCommon.Subtitles;
using System.Collections.Generic;
using StorybrewCommon.Storyboarding;

namespace StorybrewScripts
{
    public class Metadata : StoryboardObjectGenerator
    {
        // public int delay = 65988;

        [Configurable]
        public float Scale = 1f;
        
        [Configurable]
        public int ShakeAmount = 100;
        
        [Configurable]
        public int Radius = 20;

        private int startTime;

        private int endTime;

        private FontGenerator font;
        
        private int fontSize;
        
        private FontStyle fontStyle;
        
        private string fontName;

        private float textScale;

        private double angle;

        private int radius;

        private OsbSprite box;

        private Vector2 topLeftStart;
        private Vector2 topLeftEnd;
        private Vector2 topRightStart;
        private Vector2 topRightEnd;
        private Vector2 bottomLeftStart;
        private Vector2 bottomLeftEnd;
        private Vector2 bottomRightStart;
        private Vector2 bottomRightEnd;
        private Vector2 centreLeftStart;
        private Vector2 centreLeftEnd;
        private Vector2 centreRightStart;
        private Vector2 centreRightEnd;

        // private List<DataForDots> dot;

        public override void Generate()
        {
            this.startTime = 0;
            this.endTime = 998168;
		    FloatingBox(0.6f, "box", startTime, endTime, -2, 2);
		    FloatingBox(0.2f, "boxOutlines", startTime, endTime, 2, -2);
        }
        
        public void FloatingBox(float fade, string sprite, int StartTime, int EndTime, int startRotation, int endRotation)
        {
            var box = GetLayer(sprite).CreateSprite("sb/" + sprite + ".png", OsbOrigin.Centre, new Vector2(210, 400));
                
            box.Fade(StartTime, StartTime + 1500, 0, fade);
            box.Fade(EndTime - 1500, EndTime, fade, 0);
            box.ScaleVec(StartTime, 0.5f * Scale, 0.5f * Scale);

            var angleStart = MathHelper.DegreesToRadians(startRotation);
            var angleEnd = MathHelper.DegreesToRadians(endRotation);

            var RotationVelocity = 15000;
            box.StartLoopGroup(StartTime, (EndTime - StartTime) / RotationVelocity);
            box.Rotate(OsbEasing.InOutSine, 0, RotationVelocity / 2, angleStart, angleEnd);
            box.Rotate(OsbEasing.InOutSine, RotationVelocity / 2, RotationVelocity, angleEnd, angleStart);
            box.EndGroup();

            // shaking
            var angleCurrent = 0d;
            var radiusCurrent = 0;
            for (int i = StartTime; i < EndTime - ShakeAmount; i += ShakeAmount)
            {
                var angle = Random(angleCurrent - Math.PI / 4, angleCurrent + Math.PI / 4); this.angle = angle;
                var radius = Math.Abs(Random(radiusCurrent - Radius / 4, radiusCurrent + Radius / 4)); this.radius = radius;

                while (radius > Radius)
                {
                    radius = Math.Abs(Random(radiusCurrent - Radius / 4, radiusCurrent + Radius / 4));
                }

                var start = box.PositionAt(i);
                var end = CirclePos(angle, radius);

                if (i + ShakeAmount >= EndTime)
                {
                    box.Move(OsbEasing.InOutSine, i, EndTime, start, end);
                    if (sprite == "box")
                    this.box = box;
                }
                else
                {
                    box.Move(OsbEasing.InOutSine, i, i + ShakeAmount, start, end);
                    if (sprite == "box")
                    this.box = box;
                }

                angleCurrent = angle;
                radiusCurrent = radius;
                this.box = box;
                
            }

            if (startRotation < 0)
            {
                SectionDots();
                SongData(219, 26160, new string[] { "-Tochi", "#1", "隣人", "LASTDANCE//NEXTRA", "170 BPM", "(00:32)" });
                SongData(28876, 78331, new string[] { "meiikyuu", "#2", "GHOST DATA", "Black Lotus", "165 BPM", "(00:58)" });
                SongData(81235, 113806, new string[] { "Gamu", "#3", "Negoto", "Synchromanica (droplamp Remix)", "140 BPM", "(00:41)" });
                SongData(116467, 159603, new string[] { "ScubDomino", "#4", "Feryquitous", "Lifill", "92.5 BPM", "(00:50)" });
                SongData(162197, 228654, new string[] { "toybot", "#5", "Mei Ayakura", "Deeper Than Your Eyes, Farther Than Platinum Moon", "128 BPM", "(01:13)" });
                SongData(231358, 325193, new string[] { "revurii", "#6", "Taishi", "There (Progressive Rework)", "133 BPM", "(01:42)" });
                SongData(327561, 389318, new string[] { "Heilia", "#7", "暗黒神話", "The Poetry of Fragments", "136 BPM", "(00:54)" });
                SongData(391744, 451110, new string[] { "Frostmourne", "#8", "S.C.X", "drop", "140 BPM", "(01:01)" });
                SongData(453574, 539112, new string[] { "Nozhomi", "#9", "Virtual Riot", "We're Not Alone (Fractal & Prismatic Remix)", "140 BPM", "(01:33)" });
                SongData(541563, 578706, new string[] { "RVMathew", "#10", "ITM", "Reverberation of Mind", "126 BPM", "(00:44)" });
                SongData(581269, 623456, new string[] { "fanzhen0019", "#11", "Annabel & lasah", "In crowds", "192 BPM", "(00:49)" });
                SongData(626034, 715785, new string[] { "-Tochi", "#12", "Aruna", "Reason To Believe (Aruna Chillout Mix)", "130 BPM", "(01:37)" });
                SongData(718323, 764267, new string[] { "Realazy", "#13", "GHOST DATA", "Simulated Sensations", "100 BPM", "(00:53)" });
                SongData(766817, 858115, new string[] { "Acylica", "#14", "深水チエ", "atom -yoshihisa nagao remix-", "175 BPM", "(01:38)" });
                SongData(860606, 893761, new string[] { "Moecho", "#15", "jEt", "Feel My Heart (Fortyeight Remix)", "130.3 BPM", "(00:39)" });
                SongData(895948, 943368, new string[] { "Kite", "#16", "Puru", "Flower declaration of your heart", "132 BPM", "(00:53)" });
                SongData(946136, 994418, new string[] { "Matha", "#17", "綾倉盟", "on the way home", "128 BPM", "(01:06)" });
            }
        }

        public void SongData(int StartTime, int EndTime, string[] Metadata)
        {
            this.fontName = "Helvetica";
            this.textScale = 0.8f * Scale;
            this.fontStyle = FontStyle.Regular;
                
            this.fontSize = 65; CreateText("Mapper", FontStyle.Bold, StartTime, EndTime, new Vector2(-17, 4), Metadata[0]);
            this.fontSize = 30; CreateText("Section", FontStyle.Bold, StartTime, EndTime, new Vector2(100, -80), Metadata[1]);
            this.fontSize = 30; CreateText("Artist", FontStyle.Bold, StartTime, EndTime, new Vector2(0, 0), Metadata[2]);
            this.fontSize = 15; CreateText("Title", FontStyle.Italic, StartTime, EndTime, new Vector2(1, -5), Metadata[3]);
            this.fontSize = 15; CreateText("BPM", FontStyle.Regular, StartTime, EndTime, new Vector2(100, -52), Metadata[4]);
            this.fontSize = 15; CreateText("Length", FontStyle.Italic, StartTime, EndTime, new Vector2(100, 17), Metadata[5]);
        }

        FontGenerator FontGenerator(string outputPath, string fontName)
        {
            var font = LoadFont(outputPath, new FontDescription()
            {
                FontPath = fontName,
                FontSize = this.fontSize,
                Color = Color4.White,
                Padding = Vector2.Zero,
                FontStyle = this.fontStyle,
                TrimTransparency = true,
                EffectsOnly = false,
                Debug = false,
            },
            new FontGlow()
            {
                Radius = false ? 0 : 30,
                Color = new Color4(150, 150, 150, 255),
            },
            new FontOutline()
            {
                Thickness = 0,
                Color = Color4.Black,
            },
            new FontShadow()
            {
                Thickness = 0,
                Color = Color4.Black,
            });

            return font;
        }

        public void boxCornerPos(Vector2 boxStartPos, Vector2 boxEndPos)
        {
            Bitmap bitmap = GetMapsetBitmap("sb/box.png");
            float boxHeight = 0.5f * bitmap.Height * Scale;
            float boxWidth = 0.5f * bitmap.Width * Scale;

            this.topLeftStart = new Vector2(boxStartPos.X - (boxWidth / 2), boxStartPos.Y - (boxHeight / 2));
            this.topRightStart = new Vector2(boxStartPos.X + (boxWidth / 2), boxStartPos.Y - (boxHeight / 2));
            this.bottomLeftStart = new Vector2(boxStartPos.X - (boxWidth / 2), boxStartPos.Y + (boxHeight / 2));
            this.bottomRightStart = new Vector2(boxStartPos.X + (boxWidth / 2), boxStartPos.Y + (boxHeight / 2));
            this.centreLeftStart = new Vector2(boxStartPos.X - (boxWidth / 2), boxStartPos.Y);
            this.centreRightStart = new Vector2(boxStartPos.X + (boxWidth / 2), boxStartPos.Y);

            this.topLeftEnd = new Vector2(boxEndPos.X - (boxWidth / 2), boxEndPos.Y - (boxHeight / 2));
            this.topRightEnd = new Vector2(boxEndPos.X + (boxWidth / 2), boxEndPos.Y - (boxHeight / 2));
            this.bottomLeftEnd = new Vector2(boxEndPos.X - (boxWidth / 2), boxEndPos.Y + (boxHeight / 2));
            this.bottomRightEnd = new Vector2(boxEndPos.X + (boxWidth / 2), boxEndPos.Y + (boxHeight / 2));
            this.centreLeftEnd = new Vector2(boxEndPos.X - (boxWidth / 2), boxEndPos.Y);
            this.centreRightEnd = new Vector2(boxEndPos.X + (boxWidth / 2), boxEndPos.Y);
        }

        private Vector2 transform(float angle, Vector2 position, Vector2 targetPos)
        {
            var offset = new Vector2(targetPos.X, targetPos.Y);
            angle = MathHelper.RadiansToDegrees(angle) * (float)Math.PI / 180f;

            position = new Vector2(position.X - offset.X, position.Y - offset.Y);
            return Vector2.Transform(position, Quaternion.FromEulerAngles((float)(angle), 0, 0)) + offset;
        }

        public void SectionDots()
        {
            var delay = 200;
            var StartTime = this.startTime;
            var EndTime = 994769;

            // for (var i = 0; i < 17; i++)
            // StartTime = StartTime + i * (delay / 2);

            Bitmap bitmap = GetMapsetBitmap("sb/box.png");
            float boxHeight = 0.9f * bitmap.Height * Scale;
            float boxWidth = 0.9f * bitmap.Width * Scale;

            Vector2 Offset = new Vector2(65 * Scale, -63 * Scale);

            var preDelay = -3500;
            List<OsbSprite> dot = new List<OsbSprite>();
            List<int> startTimes = new List<int>();
            startTimes.Add(219);
            startTimes.Add(31786 + preDelay);
            startTimes.Add(82949 + preDelay);
            startTimes.Add(118089 + preDelay);
            startTimes.Add(168654 + preDelay);
            startTimes.Add(238577 + preDelay);
            startTimes.Add(331193 + preDelay);
            startTimes.Add(396266 + preDelay);
            startTimes.Add(456827 + preDelay);
            startTimes.Add(542515 + preDelay);
            startTimes.Add(583456 + preDelay);
            startTimes.Add(638246 + preDelay);
            startTimes.Add(725867 + preDelay);
            startTimes.Add(770343 + preDelay);
            startTimes.Add(860606 + preDelay);
            startTimes.Add(897459 + preDelay);
            startTimes.Add(949418 + preDelay);

            List<int> endTimes = new List<int>();
            endTimes.Add(26160);
            endTimes.Add(78331);
            endTimes.Add(113806);
            endTimes.Add(159603);
            endTimes.Add(228654);
            endTimes.Add(325193);
            endTimes.Add(389318);
            endTimes.Add(451110);
            endTimes.Add(539112);
            endTimes.Add(578706);
            endTimes.Add(623456);
            endTimes.Add(715785);
            endTimes.Add(764267);
            endTimes.Add(858115);
            endTimes.Add(893761);
            endTimes.Add(943368);
            endTimes.Add(994418);
                
            for (var i = 0; i < 17; i++)
            {
                OsbSprite dots = GetLayer("SectionDots").CreateSprite("sb/c2.png", OsbOrigin.Centre);
                dot.Add(dots);
                
                // scale animations
                var scale = new Vector2(0.01f * Scale, 0.02f * Scale);

                if (startTimes[i] != startTimes[0])
                dot[i].Scale(OsbEasing.OutBack, startTimes[0] + i * (delay / 2), startTimes[0] + delay + i * (delay / 2), (scale.Y * 2), scale.X);
                else
                dot[i].Scale(OsbEasing.OutBack, startTimes[0] + i * (delay / 2), startTimes[0] + delay + i * (delay / 2), (scale.X * 2), scale.Y);

                if (startTimes[i] != startTimes[0])
                dot[i].Scale(OsbEasing.OutBack, startTimes[i] + i * (delay / 2), startTimes[i] + delay + i * (delay / 2), scale.X, scale.Y);

                // end
                dot[i].Scale(OsbEasing.InBack, (this.endTime - 4000) - delay + i * (delay / 2), (this.endTime - 4000) + i * (delay / 2), scale.Y, 0);


                // fade animations
                var fade = new Vector2(0.3f, 1f);

                if (startTimes[i] != startTimes[0])
                dot[i].Fade(startTimes[0] + i * (delay / 2), startTimes[0] + delay + i * (delay / 2), 0, fade.X);
                else
                dot[i].Fade(startTimes[0] + i * (delay / 2), startTimes[0] + delay + i * (delay / 2), 0, fade.Y);

                if (startTimes[i] != startTimes[0])
                dot[i].Fade(startTimes[i] + i * (delay / 2), startTimes[i] + delay + i * (delay / 2), fade.X, fade.Y);


                // color animations
                dot[i].Color(endTimes[i] - 6000, endTimes[i], Color4.White, Color4.IndianRed);
                if (endTimes[i] < 995824)
                dot[i].Color(endTimes[i], endTimes[i] + 6000, Color4.IndianRed, Color4.White);
            }
            
            for (int t = this.startTime; t < (this.endTime - 4000) - ShakeAmount; t += ShakeAmount)
            {
                var angle = box.RotationAt(t);
                var newAngle = box.RotationAt(EndTime + 3000);
                var newAngle2 = box.RotationAt(t + ShakeAmount);

                Vector2 CentreRightStart = new Vector2(0, 0);
                Vector2 CentreRightEnd = new Vector2(0, 0);

                if (t >= StartTime)
                {
                    if (t + ShakeAmount >= EndTime + 3000)
                    {
                        boxCornerPos(box.PositionAt(t), box.PositionAt(EndTime + 3000));

                        CentreRightStart = (Vector2)RelativePosition(angle, centreRightStart + Offset);
                        CentreRightEnd = (Vector2)RelativePosition(newAngle, centreRightEnd + Offset);

                        for (var i = 0; i < 8; i++)
                        {
                            var height = (boxHeight / 2) / 9;
                            var startPos = new Vector2(CentreRightStart.X, CentreRightStart.Y + i * height);
                            var endPos = new Vector2(CentreRightEnd.X, CentreRightEnd.Y + i * height);
                            var relativeStartPos = transform(angle, startPos, CentreRightStart);
                            var relativeEndPos = transform(newAngle, endPos, CentreRightEnd);

                            if (endTimes[i] < 995824)
                            dot[i].Move(OsbEasing.InOutSine, t, EndTime + 3000, relativeStartPos, relativeEndPos);
                        }
                        for (var i = 8; i < 17; i++)
                        {
                            var height = (boxHeight / 2) / 9;
                            var startPos = new Vector2(CentreRightStart.X + 10, (CentreRightStart.Y - 8 * height) + i * height);
                            var endPos = new Vector2(CentreRightEnd.X + 10, (CentreRightEnd.Y - 8 * height) + i * height);
                            var relativeStartPos = transform(angle, startPos, CentreRightStart);
                            var relativeEndPos = transform(newAngle, endPos, CentreRightEnd);
                            
                            if (endTimes[i] < 995824)
                            dot[i].Move(OsbEasing.InOutSine, t, EndTime + 3000, relativeStartPos, relativeEndPos);
                        }
                        
                        angle = newAngle;
                        CentreRightStart = CentreRightEnd;
                    }
                    else
                    {
                        boxCornerPos(box.PositionAt(t), box.PositionAt(t + ShakeAmount));

                        CentreRightStart = (Vector2)RelativePosition(angle, centreRightStart + Offset);
                        CentreRightEnd = (Vector2)RelativePosition(newAngle2, centreRightEnd + Offset);

                        for (var i = 0; i < 8; i++)
                        {
                            var height = (boxHeight / 2) / 9;
                            var pos = new Vector2(320, 240 + i * height);
                            var startPos = new Vector2(CentreRightStart.X, CentreRightStart.Y + i * height);
                            var endPos = new Vector2(CentreRightEnd.X, CentreRightEnd.Y + i * height);
                            var centreStartPos = new Vector2(startPos.X, startPos.Y - (height / 2));
                            var centreEndPos = new Vector2(endPos.X, endPos.Y - (height / 2));

                            var relativeStartPos = transform(angle, centreStartPos, CentreRightStart);
                            var relativeEndPos = transform(newAngle2, centreEndPos, CentreRightEnd);

                            if (endTimes[i] < 995824)
                            dot[i].Move(OsbEasing.InOutSine, t, t + ShakeAmount, relativeStartPos, relativeEndPos);
                        }
                        for (var i = 8; i < 17; i++)
                        {
                            var height = (boxHeight / 2) / 9;
                            var startPos = new Vector2(CentreRightStart.X + 10, (CentreRightStart.Y - 8 * height) + i * height);
                            var endPos = new Vector2(CentreRightEnd.X + 10, (CentreRightEnd.Y - 8 * height) + i * height);
                            var centreStartPos = new Vector2(startPos.X, startPos.Y - (height / 2));
                            var centreEndPos = new Vector2(endPos.X, endPos.Y - (height / 2));
                            
                            var relativeStartPos = transform(angle, centreStartPos, CentreRightStart);
                            var relativeEndPos = transform(newAngle2, centreEndPos, CentreRightEnd);
                            
                            if (endTimes[i] < 995824)
                            dot[i].Move(OsbEasing.InOutSine, t, t + ShakeAmount, relativeStartPos, relativeEndPos);
                        }
                        
                        angle = newAngle2;
                        CentreRightStart = CentreRightEnd;
                    }
                }
                else if (t >= EndTime + 3000)
                break;
            }
        }

        public void ProgressBar(int StartTime, int EndTime)
        {
            Vector2 Offset = new Vector2(20 * Scale, -20 * Scale);

            var progress = GetLayer("ProgressBar").CreateSprite("sb/pixel.png", OsbOrigin.BottomLeft);
            for (int t = StartTime; t < EndTime + 3000 - ShakeAmount; t += ShakeAmount)
            {
                var angle = box.RotationAt(t);
                var newAngle = box.RotationAt(EndTime + 3000);
                var newAngle2 = box.RotationAt(t + ShakeAmount);

                Vector2 BottomLeftStart = new Vector2(0, 0);
                Vector2 BottomLeftEnd = new Vector2(0, 0);

                if (t >= StartTime)
                {
                    if (t + ShakeAmount >= EndTime + 3000)
                    {
                        boxCornerPos(box.PositionAt(t), box.PositionAt(EndTime + 3000));

                        BottomLeftStart = (Vector2)RelativePosition(angle, bottomLeftStart + Offset);
                        BottomLeftEnd = (Vector2)RelativePosition(newAngle, bottomLeftEnd + Offset);

                        progress.Move(OsbEasing.InOutSine, t, EndTime + 3000, BottomLeftStart, BottomLeftEnd);
                        progress.Rotate(OsbEasing.InOutSine, t, EndTime + 3000, angle, newAngle);
                        
                        angle = newAngle;
                        BottomLeftStart = BottomLeftEnd;
                    }
                    else
                    {
                        boxCornerPos(box.PositionAt(t), box.PositionAt(t + ShakeAmount));

                        BottomLeftStart = (Vector2)RelativePosition(angle, bottomLeftStart + Offset);
                        BottomLeftEnd = (Vector2)RelativePosition(newAngle2, bottomLeftEnd + Offset);

                        progress.Move(OsbEasing.InOutSine, t, t + ShakeAmount, BottomLeftStart, BottomLeftEnd);
                        progress.Rotate(OsbEasing.InOutSine, t, t + ShakeAmount, angle, newAngle2);
                        
                        angle = newAngle2;
                        BottomLeftStart = BottomLeftEnd;
                    }
                }
                else if (t >= EndTime + 3000)
                break;
            }

            var width = new Vector2(0, 437 * Scale);
            var height = 25 * Scale;

            progress.ScaleVec(StartTime, EndTime - 1000, width.X, height, width.Y, height);
            progress.ScaleVec(OsbEasing.OutElastic, EndTime, EndTime + 3000, width.Y, height, width.X, height);
            progress.Color(EndTime - 6000, EndTime, Color4.White, Color4.IndianRed);
        }

        public void CreateText(string output, FontStyle style, int StartTime, int EndTime, Vector2 Offset, string text)
        {
            Offset = new Vector2(Offset.X * Scale, Offset.Y * Scale);
            ProgressBar(StartTime, EndTime);
            
            if (style == FontStyle.Bold)
            this.fontStyle = FontStyle.Bold;
            if (style == FontStyle.Regular)
            this.fontStyle = FontStyle.Regular;
            if (style == FontStyle.Italic)
            this.fontStyle = FontStyle.Italic;
            if (style == FontStyle.Underline)
            this.fontStyle = FontStyle.Underline;
            if (style == FontStyle.Strikeout)
            this.fontStyle = FontStyle.Strikeout;
            if (text == "隣人" || text == "暗黒神話")
            this.fontSize = 25;
            else
            this.fontName = "Helvetica";
            if (text == "隣人" || text == "暗黒神話")
            this.fontName = "Yu Gothic UI";
            else
            this.fontName = "Helvetica";

            if (text == "Negoto" || text == "Feryquitous" || text == "Mei Ayakura")
            Offset = new Vector2(Offset.X, Offset.Y + 4);
            if (text == "meiikyuu" || text == "toybot" || text == "Realazy" || text == "Acylica")
            Offset = new Vector2(Offset.X, Offset.Y + 14);
            if (text == "Synchromanica (droplamp Remix)" || text == "Deeper Than Your Eyes, Farther Than Platinum Moon" || text == "There (Progressive Rework)" || text == "The Poetry of Fragments" || text == "drop" || text == "atom -yoshihisa nagao remix-" || text == "Feel My Heart (Fortyeight Remix)" || text == "Flower declaration of your heart" || text == "on the way home")
            Offset = new Vector2(Offset.X, Offset.Y + 2);
            
            font = FontGenerator("sb/metadata/" + output + "/" + StartTime.ToString(), this.fontName);
            OsbOrigin origin = OsbOrigin.CentreLeft;

            if (output == "Mapper" || output == "Section" || output == "Artist")
            origin = OsbOrigin.BottomLeft;
            if (output == "Section" || output == "BPM")
            origin = OsbOrigin.TopRight;
            if (output == "Length")
            origin = OsbOrigin.BottomRight;

            var texture = font.GetTexture(text);

            Vector2 TopLeftStart = new Vector2(0, 0);
            Vector2 TopLeftEnd = new Vector2(0, 0);
            Vector2 TopRightStart = new Vector2(0, 0);
            Vector2 TopRightEnd = new Vector2(0, 0);
            Vector2 BottomLeftStart = new Vector2(0, 0);
            Vector2 BottomLeftEnd = new Vector2(0, 0);
            Vector2 BottomRightStart = new Vector2(0, 0);
            Vector2 BottomRightEnd = new Vector2(0, 0);
            Vector2 CentreLeftStart = new Vector2(0, 0);
            Vector2 CentreLeftEnd = new Vector2(0, 0);
            Vector2 CentreRightStart = new Vector2(0, 0);
            Vector2 CentreRightEnd = new Vector2(0, 0);
            
            var sprite = GetLayer("").CreateSprite(texture.Path, origin);

            // ShakeAmount = 200;
            for (int t = StartTime; t <  EndTime + 3000 - ShakeAmount; t += ShakeAmount)
            {
                var angle = box.RotationAt(t);
                var newAngle = box.RotationAt(EndTime + 3000);
                var newAngle2 = box.RotationAt(t + ShakeAmount);
                
                if (t >= StartTime)
                { 
                    if (t + ShakeAmount >= EndTime + 3000)
                    {
                        boxCornerPos(box.PositionAt(t), box.PositionAt(EndTime + 3000));

                        TopLeftStart = (Vector2)RelativePosition(angle, topLeftStart + Offset);
                        TopLeftEnd = (Vector2)RelativePosition(newAngle, topLeftEnd + Offset);

                        TopRightStart = (Vector2)RelativePosition(angle, topRightStart + Offset);
                        TopRightEnd = (Vector2)RelativePosition(newAngle, topRightEnd + Offset);

                        BottomRightStart = (Vector2)RelativePosition(angle, bottomRightStart + Offset);
                        BottomRightEnd = (Vector2)RelativePosition(newAngle, bottomRightEnd + Offset);

                        CentreLeftStart = (Vector2)RelativePosition(angle, centreLeftStart + Offset);
                        CentreLeftEnd = (Vector2)RelativePosition(newAngle, centreLeftEnd + Offset);

                        // CentreRightStart = (Vector2)RelativePosition(angle, centreRightStart + Offset);
                        // CentreRightEnd = (Vector2)RelativePosition(newAngle, centreRightEnd + Offset);
                        
                        if (output == "Mapper")
                        sprite.Move(OsbEasing.InOutSine, t, EndTime + 3000, TopLeftStart, TopLeftEnd);
                        if (output == "Section" || output == "BPM")
                        sprite.Move(OsbEasing.InOutSine, t, EndTime + 3000, TopRightStart, TopRightEnd);
                        if (output == "Length")
                        sprite.Move(OsbEasing.InOutSine, t, EndTime + 3000, BottomRightStart, BottomRightEnd);
                        if (output == "Artist" || output == "Title")
                        sprite.Move(OsbEasing.InOutSine, t, EndTime + 3000, CentreLeftStart, CentreLeftEnd);
                        // sprite.Move(OsbEasing.InOutSine, t, EndTime + 3000, CentreRightStart, CentreRightEnd);
                        sprite.Rotate(OsbEasing.InOutSine, t, EndTime + 3000, angle, newAngle);
                        
                        angle = newAngle;
                        TopLeftStart = TopLeftEnd;
                        TopRightStart = TopRightEnd;
                        BottomRightStart = BottomRightEnd;
                        CentreLeftStart = CentreLeftEnd;
                        // CentreRightStart = CentreRightEnd;
                    }
                    else
                    {
                        boxCornerPos(box.PositionAt(t), box.PositionAt(t + ShakeAmount));

                        TopLeftStart = (Vector2)RelativePosition(angle, topLeftStart + Offset);
                        TopLeftEnd = (Vector2)RelativePosition(newAngle2, topLeftEnd + Offset);

                        TopRightStart = (Vector2)RelativePosition(angle, topRightStart + Offset);
                        TopRightEnd = (Vector2)RelativePosition(newAngle2, topRightEnd + Offset);

                        BottomRightStart = (Vector2)RelativePosition(angle, bottomRightStart + Offset);
                        BottomRightEnd = (Vector2)RelativePosition(newAngle2, bottomRightEnd + Offset);

                        CentreLeftStart = (Vector2)RelativePosition(angle, centreLeftStart + Offset);
                        CentreLeftEnd = (Vector2)RelativePosition(newAngle2, centreLeftEnd + Offset);

                        // CentreRightStart = (Vector2)RelativePosition(angle, centreRightStart + Offset);
                        // CentreRightEnd = (Vector2)RelativePosition(newAngle2, centreRightEnd + Offset);

                        if (output == "Mapper")
                        sprite.Move(OsbEasing.InOutSine, t, t + ShakeAmount, TopLeftStart, TopLeftEnd);
                        if (output == "Section" || output == "BPM")
                        sprite.Move(OsbEasing.InOutSine, t, t + ShakeAmount, TopRightStart, TopRightEnd);
                        if (output == "Length")
                        sprite.Move(OsbEasing.InOutSine, t, t + ShakeAmount, BottomRightStart, BottomRightEnd);
                        if (output == "Artist" || output == "Title")
                        sprite.Move(OsbEasing.InOutSine, t, t + ShakeAmount, CentreLeftStart, CentreLeftEnd);
                        // sprite.Move(OsbEasing.InOutSine, t, t + ShakeAmount, CentreRightStart, CentreRightEnd);
                        sprite.Rotate(OsbEasing.InOutSine, t, t + ShakeAmount, angle, newAngle2);
                        
                        angle = newAngle2;
                        TopLeftStart = TopLeftEnd;
                        TopRightStart = TopRightEnd;
                        BottomRightStart = BottomRightEnd;
                        CentreLeftStart = CentreLeftEnd;
                        // CentreRightStart = CentreRightEnd;
                    }
                }
                else if (t >= EndTime + 3000)
                break;
            }

            sprite.Scale(StartTime, textScale);

            var randomCount = Random(3, 7);
            var randomFlickerSpeed = Random(80, 200);

            for (int s = StartTime; s < StartTime + (randomFlickerSpeed * randomCount); s += randomFlickerSpeed)
            {
                var sfx = GetLayer("").CreateSample("sb/sfx_" + Random(1, 4) + ".ogg", s, 10);
            }

            for (int s = EndTime + 1000; s < EndTime + 1000 + (randomFlickerSpeed * randomCount); s += randomFlickerSpeed)
            {
                var sfx = GetLayer("").CreateSample("sb/sfx_" + Random(1, 4) + ".ogg", s, 10);
            }

            sprite.StartLoopGroup(StartTime, randomCount);
            sprite.Fade(0, randomFlickerSpeed, 0, 1);
            sprite.EndGroup();

            sprite.StartLoopGroup(EndTime + 1000, randomCount);
            sprite.Fade(0, randomFlickerSpeed, 1, 0);
            sprite.EndGroup();
        }

        public Vector2d RelativePosition(double a, Vector2 pointPosition)
        {
            double angle = a * Math.PI / 180; // converting to radians
            double cos = Math.Cos(angle), sin = Math.Sin(angle);

            return new Vector2d((float)pointPosition.X * cos - (float)pointPosition.Y * sin, (float)pointPosition.X * sin + (float)pointPosition.Y * cos);
        }
        
        // public String ConvertToFullWidth(string text)
        // {
        //     string fullWidthCharacters = Strings.StrConv(text, VbStrConv.Wide, 1041);
        //     return fullWidthCharacters;
        // }
        
        // public String ConvertToHalfWidth(string text)
        // {
        //     string fullWidthCharacters = Strings.StrConv(text, VbStrConv.Narrow, 1041);
        //     return fullWidthCharacters;
        // }

        public Vector2 CirclePos(double angle, int radius)
        {
            double posX = 210 + (radius * Math.Cos(angle));
            double posY = 400 + ((radius * 5) * Math.Sin(angle));

            return new Vector2((float)posX, (float)posY);
        }
    }
}

using OpenTK;
using System;
using System.Linq;
using System.Drawing;
using OpenTK.Graphics;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Subtitles;
using System.Collections.Generic;

public class Playlist
{
    private StoryboardObjectGenerator generator;
    private int start;
    private int end;

    public Playlist(StoryboardObjectGenerator generator, int start, int end)
    {
        this.generator = generator;
        this.start = start;
        this.end = end;

        GeneratePlaylist(start, end);
    }

    public class songData
    {
        public List<string> artist;
        public List<string> title;
        public List<string> album;
        public List<string> length;

    }

    public void GeneratePlaylist(int start, int end)
    {
        // Playlist Songs

        // List<string> unknown = Artist();
        // foreach (item => { i.a = "hello!"; i.b = 99; })
        // {
        //     // ...
        // }
    }
}
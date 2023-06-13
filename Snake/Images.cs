﻿using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Snake
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("empty.png");
        public readonly static ImageSource Body = LoadImage("body.png");
        public readonly static ImageSource HeadBody = LoadImage("head.png");
        public readonly static ImageSource Food = LoadImage("Uva.png");
        public readonly static ImageSource DeadHead = LoadImage("deadhead.png");
        public readonly static ImageSource DeadBody = LoadImage("deadbody.png");
        public readonly static ImageSource Fruta = LoadImage("orange.png");


        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/{fileName}", UriKind.Relative));

        }
    }
}

﻿using System;

namespace Demo.Animations
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            using (var game = new Game1())
            {
                game.Run();
            }
        }
    }
}
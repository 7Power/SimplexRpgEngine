﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimplexResources.Rooms;

namespace SimplexIde
{
    public static class Config
    {
        public static Type[] GameRooms = { typeof(Room1), typeof(Room2) };
        public static string GameProjectName = "SimplexResources";
        public static string GameProjectObjectsFolder = "Objects";

        public static readonly string[] Extensions = {"TestExtension1"};
    }
}

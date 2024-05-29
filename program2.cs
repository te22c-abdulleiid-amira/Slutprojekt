using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows;
using System.Threading;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace InteraktivBerattelse
{
// klass som representerar en scen i berättelsen
public class Scene
    {
        public string Description { get; set; } // beskrivning av scenen
        public Dictionary<int, string> Choices { get; set; } // val spelaren kan göra
    }
}


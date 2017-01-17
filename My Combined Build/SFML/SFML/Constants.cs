using System;

namespace SFML
{
    public class Constants
    {
        #if LINUX
        public const string AudioDll = "libcsfml-audio.so.2";
        public const string GraphicsDLL = "libcsfml-graphics.so.2";
        public const string SystemDLL = "libcsfml-system.so.2";
        public const string WindowDLL = "libcsfml-window.so.2";
        
#else
        public const string AudioDll = "csfml-audio-2";
        public const string GraphicsDLL = "csfml-graphics-2";
        public const string SystemDLL = "csfml-system-2";
        public const string WindowDLL = "csfml-window-2";
        #endif
    }
}


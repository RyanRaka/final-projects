using System.Collections.Generic;

namespace GameBelajar.Helpers
{
    public static class SvgHelper
    {
        public static Dictionary<string, string> Images { get; } = new Dictionary<string, string>
           {
               { "bola", "<svg>...</svg>" },
               { "buku", "<svg>...</svg>" },
               { "apel", "<svg>...</svg>" },
               { "pensil", "<svg>...</svg>" }
           };

        public static string DefaultShape => "<svg>...</svg>";

        public static string WrapSvgInHtml(string svgContent)
        {
            return $"<html><body>{svgContent}</body></html>";
        }
    }
}

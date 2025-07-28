using System.Collections.Generic;

namespace GameBelajar.Helpers
{
    public static class SvgHelper
    {
        public static Dictionary<string, string> Images { get; } = new Dictionary<string, string>();

        public static string DefaultShape => @"<svg width='50' height='50'><circle cx='25' cy='25' r='20' fill='blue'/></svg>";

        static SvgHelper()
        {
            InitializeImages();
        }

        private static void InitializeImages()
        {
            // Add your SVG content here
            Images["bola"] = @"<svg width='50' height='50'><circle cx='25' cy='25' r='20' fill='red'/></svg>";
            Images["buku"] = @"<svg width='50' height='50'><rect x='5' y='5' width='40' height='40' fill='brown'/></svg>";
            Images["apel"] = @"<svg width='50' height='50'><circle cx='25' cy='25' r='20' fill='red'/><rect x='23' y='5' width='4' height='10' fill='brown'/></svg>";
            Images["pensil"] = @"<svg width='50' height='50'><polygon points='10,45 40,45 25,5' fill='yellow'/></svg>";

            // Add more words and their corresponding SVGs
            foreach (string word in new[] { "ceri", "dadu", "ekor", "foto", "gula", "hari", "ikan", "jari" })
            {
                Images[word] = DefaultShape; // Use default shape for words without custom SVGs
            }
        }

        public static string WrapSvgInHtml(string svgContent)
        {
            return $@"
                <html>
                <body style='margin: 0; overflow: hidden;'>
                    {svgContent}
                </body>
                </html>";
        }
    }
}
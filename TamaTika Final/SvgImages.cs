using System.Collections.Generic;

namespace GameBelajar
{
    public static class SvgImages
    {
        public static readonly Dictionary<string, string> Images = new Dictionary<string, string>
        {
            {"apel", @"<svg viewBox='0 0 100 100'><circle cx='50' cy='50' r='40' fill='#ff0000'/><path d='M50 20 L50 5 L60 15' fill='#2d5016'/><path d='M50 5 L40 15' fill='#2d5016'/></svg>"},
            
            {"buku", @"<svg viewBox='0 0 100 100'><rect x='20' y='20' width='60' height='70' fill='#4a90e2'/><rect x='25' y='25' width='50' height='60' fill='#ffffff'/><line x1='35' y1='35' x2='65' y2='35' stroke='#000' stroke-width='2'/><line x1='35' y1='45' x2='65' y2='45' stroke='#000' stroke-width='2'/></svg>"},
            
            {"bola", @"<svg viewBox='0 0 100 100'><circle cx='50' cy='50' r='40' fill='#ff5722'/><path d='M30 50 Q50 20 70 50' fill='none' stroke='#000' stroke-width='2'/></svg>"},
            
            {"pensil", @"<svg viewBox='0 0 100 100'><path d='M20 80 L70 30 L80 40 L30 90 Z' fill='#ffd700'/><path d='M70 30 L80 20 L90 30 L80 40 Z' fill='#ff9800'/><path d='M20 80 L30 90 L20 90 Z' fill='#ffecb3'/></svg>"},
            
            {"ceri", @"<svg viewBox='0 0 100 100'><circle cx='40' cy='60' r='20' fill='#d32f2f'/><circle cx='65' cy='65' r='20' fill='#b71c1c'/><path d='M50 20 C30 40 60 40 60 20' fill='none' stroke='#2e7d32' stroke-width='4'/></svg>"},
            
            {"dadu", @"<svg viewBox='0 0 100 100'><rect x='20' y='20' width='60' height='60' fill='#ffffff' stroke='#000' stroke-width='2'/><circle cx='35' cy='35' r='5' fill='#000'/><circle cx='65' cy='35' r='5' fill='#000'/><circle cx='50' cy='50' r='5' fill='#000'/><circle cx='35' cy='65' r='5' fill='#000'/><circle cx='65' cy='65' r='5' fill='#000'/></svg>"}
        };

        public static readonly string DefaultShape = @"<svg viewBox='0 0 100 100'><rect x='10' y='10' width='80' height='80' fill='#e0e0e0'/></svg>";
    }
}

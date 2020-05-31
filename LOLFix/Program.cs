using System;
using System.Diagnostics;

namespace LOLFix {
    class Program {
        static void Main(string[] args) {
            var processes = Process.GetProcessesByName("LeagueClientUxRender");
            var target = processes[0].WorkingSet64 < processes[1].WorkingSet64 ? processes[1] : processes[0];
            target.Kill();
        }
    }
}

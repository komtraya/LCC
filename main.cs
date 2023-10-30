using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LCC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string systemC = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)); // returns SYSTEM letter + :/

        private void openStudioCodeGarbage_Click(object sender, EventArgs e)
        {
            
            string pathTest = $@"{userPath}\AppData/Roaming/Code/logs";
            List<string> StudioCodeGarbage = new List<string>
{
                $@"{userPath}\AppData/Roaming/Code/logs",
                $@"{userPath}\AppData\Roaming\Code\Cache",
                $@"{userPath}\AppData\Roaming\Code\CachedData",
                $@"{userPath}\AppData\Roaming\Code\GPUCache",
                $@"{userPath}\AppData\Roaming\Code\User\History",

};
            foreach (string path in StudioCodeGarbage)
            {
                try
                {
                    Process.Start(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}: {path}", "Error");
                }
            }
        }

        private void openSpotifyGarbage_Click(object sender, EventArgs e)
        {
            List<string> SpotifyGarbage = new List<string>
            {
                $@"{userPath}\AppData\Local\Spotify\Browser\Cache",
                $@"{userPath}\AppData\Local\Spotify\Browser\DawnCache",
                $@"{userPath}\AppData\Local\Spotify\Browser\982ca3cd2eec00bdb1c252e5c3333fd9d1467f00\Cache",
                $@"{userPath}\AppData\Local\Spotify\Data",
                $@"{userPath}\AppData\Local\Spotify\Storage",
            };
            foreach(string path in SpotifyGarbage)
            {
                try
                {
                    Process.Start(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}: {path}", "Error");
                }
            }
        }

        private void openMicrosoftGarbage_Click(object sender, EventArgs e)
        {
            List<string> MicrosoftGarbage = new List<string>
            {
                $@"{userPath}\AppData\Local\Microsoft\CLR_v4.0",//\UsageLogs",
                $@"{userPath}\AppData\Local\Microsoft\Windows\WebCache",
                $@"{userPath}\AppData\Local\Microsoft\Windows\INetCache\IE",
                $@"{userPath}\AppData\Local\Microsoft\Edge\User Data\BrowserMetrics",
                $@"{userPath}\AppData\Local\Temp",
                $@"{systemC}Windows\Temp",
                $@"{ userPath}\AppData\Local\D3DSCache",
                $@"{ userPath}\AppData\Local\Package Cache",
                $@"{ userPath}\AppData\Local\CrashDumps"

            };
            foreach (string path in MicrosoftGarbage)
            {
                try
                {
                    Process.Start(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}: {path}", "Error");
                }
            }

        }

        private void openAdobeGarbage_Click(object sender, EventArgs e)
        {
            List<string> AdobeGarbage = new List<string>
            {
                    $@"{userPath}\AppData\Roaming\Adobe\LogTransport2CC\Logs",
                    $@"{userPath}\AppData\Roaming\Adobe\Logs",
                    $@"{userPath}\AppData\Roaming\Adobe\CRLogs",
                    $@"{userPath}\AppData\Roaming\Adobe\Adobe Photoshop 2023\Logs",
                    $@"{userPath}\AppData\Roaming\Adobe\Common\Media Cache",
                    $@"{userPath}\AppData\Roaming\Adobe\Common\Media Cache Files",
                    $@"{userPath}\AppData\Roaming\Adobe\Premiere Pro\Logs",
            };
            foreach(string path in AdobeGarbage)
            {
                try
                {
                    Process.Start(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}: {path}", "Error");
                }
            }
        }

        private void openTaskManager_Click(object sender, EventArgs e)
            {
            System.Diagnostics.Process.Start("taskmgr");
            }

        private void openDiskCleanup_Click(object sender, EventArgs e)
            {
            System.Diagnostics.Process.Start("cleanmgr.exe");
            }
        }
}

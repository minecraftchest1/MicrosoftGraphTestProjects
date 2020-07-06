using System;
using System.Diagnostics;

namespace MsGraphApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*var psi = new ProcessStartInfo
            {
                FileName = "https://login.microsoftonline.com/common/oauth2/v2.0/authorize?client_id=5a69c973-5751-4ddb-b66c-981f62cd3a76&response_type=code&redirect_uri=https://login.microsoftonline.com/common/oauth2/nativeclient&response_mode=query&scope=offline_access%20user.read&state=712931familyofjacksonscommsgraphapp3",
                UseShellExecute = true
            };*/
            //Process.Start(psi);
            //System.Diagnostics.Process.Start("https://login.microsoftonline.com/common/oauth2/v2.0/authorize?client_id=5a69c973-5751-4ddb-b66c-981f62cd3a76&response_type=code&redirect_uri=https://login.microsoftonline.com/common/oauth2/nativeclient&response_mode=query&scope=offline_access%20user.read&state=712931familyofjacksonscommsgraphapp3");

            try
            {
                Process.Start(@"C:\Users\Wyatt\ProgramFiles\Microsoft\Edge Beta\Application\msedge.exe", "https://login.microsoftonline.com/common/oauth2/v2.0/authorize?client_id=5a69c973-5751-4ddb-b66c-981f62cd3a76&response_type=code&redirect_uri=https://login.microsoftonline.com/common/oauth2/nativeclient&response_mode=query&scope=offline_access%20user.read&state=712931familyofjacksonscommsgraphapp3");
            }
            catch
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "https://login.microsoftonline.com/common/oauth2/v2.0/authorize?client_id=5a69c973-5751-4ddb-b66c-981f62cd3a76&response_type=code&redirect_uri=https://login.microsoftonline.com/common/oauth2/nativeclient&response_mode=query&scope=offline_access%20user.read&state=712931familyofjacksonscommsgraphapp3",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }


        }
    }
}

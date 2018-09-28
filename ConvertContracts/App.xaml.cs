using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ConvertContracts
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private static string ClientId = "864082b3-d007-48cd-ab41-8f58be088154--";

        public static PublicClientApplication PublicClientApp = new PublicClientApplication(ClientId);
    }
}

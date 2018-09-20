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
        private static string ClientId = "da4df5fc-eca4-472f-90b0-d595060bc4fb";

        public static PublicClientApplication PublicClientApp = new PublicClientApplication(ClientId);
    }
}

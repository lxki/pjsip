using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PJSip.Interop.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            PJSipLib.Init();

            // Create endpoint
            Endpoint ep = new Endpoint();
            ep.libCreate();
            // Initialize endpoint
            EpConfig epConfig = new EpConfig();
            ep.libInit(epConfig);
            // Create SIP transport. Error handling sample is shown
            TransportConfig sipTpConfig = new TransportConfig {port = 5060};
            ep.transportCreate(pjsip_transport_type_e.PJSIP_TRANSPORT_UDP, sipTpConfig);
            // Start the library
            ep.libStart();

            AccountConfig acfg = new AccountConfig();
            acfg.idUri = "sip:test@pjsip.org";
            acfg.regConfig.registrarUri = "sip:pjsip.org";
            AuthCredInfo cred = new AuthCredInfo("digest", "*", "test", 0, "secret");
            acfg.sipConfig.authCreds.Add(cred);
            // Create the account
            MyAccount acc = new MyAccount();
            acc.create(acfg);
            // Here we don't have anything else to do..
            Thread.Sleep(10000);
            /* Explicitly delete the account.
             * This is to avoid GC to delete the endpoint first before deleting
             * the account.
             */
            acc.Dispose();

            // Explicitly destroy and delete endpoint
            ep.libDestroy();
            ep.Dispose();
        }
    }

    internal class MyAccount : Account
    {
        public override void onRegState(OnRegStateParam prm)
        {
            base.onRegState(prm);
            Console.Out.WriteLine("*** On registration state: " + prm.code + prm.reason);
        }
    }
}

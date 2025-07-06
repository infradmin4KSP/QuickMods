using System.IO;
using System.Reflection;
using UnityEngine;



namespace QuickGoTo
{

    [KSPAddon(KSPAddon.Startup.MainMenu, true)]
    public class RegisterToolbar : MonoBehaviour
    {
        public static string VERSION;
        public static string MOD = "";
        public static string relativePath;
        public static string PATH = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).Replace(@"\", "/") + "/../";

        void Start()
        {
            // This is here to get the varsinitialized
            // This mod does not (yet) use the ToolbarController

            //ToolbarControl.RegisterMod(QStockToolbar.MODID, QStockToolbar.MODNAME);

            VERSION = Assembly.GetExecutingAssembly().GetName().Version.Major + "." + Assembly.GetExecutingAssembly().GetName().Version.Minor + Assembly.GetExecutingAssembly().GetName().Version.Build;
            MOD = Assembly.GetExecutingAssembly().GetName().Name;
            relativePath = MOD;
            PATH = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/../";

            QStockToolbar.TexturePath = relativePath + "/Textures/StockToolBar";
        }
    }
}
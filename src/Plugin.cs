using System;
using System.Security.Permissions;
using BepInEx;
using UnityEngine;

#pragma warning disable CS0618
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
#pragma warning restore CS0618

namespace YourModNamespace
{
    [BepInPlugin(MOD_ID, MOD_NAME, ModVersionInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public const string MOD_ID = "YourAuthor.YourMod";
        public const string MOD_NAME = "YourModName";
        private bool initialized;

        public void OnEnable()
        {
            On.RainWorld.OnModsInit += RainWorld_OnModsInit;
        }

        private void RainWorld_OnModsInit(On.RainWorld.orig_OnModsInit orig, RainWorld self)
        {
            orig(self);
            if (initialized)
                return;
            initialized = true;

            // 在这里写你的初始化逻辑(挂 Hook、加载贴图等)
        }
    }
}

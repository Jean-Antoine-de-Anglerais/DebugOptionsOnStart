using UnityEngine;

namespace DebugOptionsOnStart_NativeModloader
{
    public class WorldBoxMod : MonoBehaviour
    {
        static bool initialized = false;

        void Update()
        {
            if (!Config.gameLoaded) return;


            if (!initialized)
            {
                init();
            }

            initialized = true;
        }

        void init()
        {
            DebugConfig.instance.debugButton.SetActive(true);
            DebugConfig.setOption(DebugOption.PauseOnStart, true, true);
            DebugConfig.setOption(DebugOption.ShowHiddenStats, true, true);
            DebugConfig.setOption(DebugOption.SonicSpeed, true, true);
            DebugConfig.setOption(DebugOption.Greg, true, true);
            DebugConfig.setOption(DebugOption.RenderHoldingResources, true, true);
        }
    }
}
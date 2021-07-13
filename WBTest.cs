using UnityEngine;
using BepInEx;

namespace wbtest
{
    [BepInPlugin("xyz.mgurga.wbtest", "WorkbenchAPI Test Plugin", "1.0.0")]
    [BepInDependency("xyz.mgurga.workbenchapi")]
    public class WBTest : BaseUnityPlugin
    {
        void Awake()
        {
            Logger.LogInfo("WBTest loaded");

            var wb = new WorkbenchAPI.WorkbenchAPI();
            wb.CreateItem("Test Item", "just a test item");
            wb.CreateItem("Hello World", "foo bar");
            wb.PatchItems();

            Logger.LogInfo("Added Test Items!");
        }
    }
}
# wbtest
Very simple plugin that uses [Workbench API](https://github.com/mgurga/WorkbenchAPI) to add a couple test items.

```
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
```

## Screenshots
![unlock ui](https://github.com/mgurga/wbtest/raw/master/docs/unlockedui.png)
![crafting ui](https://github.com/mgurga/wbtest/raw/master/docs/craftingui.png)

<img src="https://github.com/mgurga/wbtest/raw/master/docs/testitemhover.png"> <img src="https://github.com/mgurga/wbtest/raw/master/docs/helloworldhover.png">

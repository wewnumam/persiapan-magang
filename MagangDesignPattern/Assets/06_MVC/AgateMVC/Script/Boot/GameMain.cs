using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using MVC.Module.SaveData;

namespace MVC.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return null;
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]{
                new SaveDataController()
            };
        }

        protected override IEnumerator StartInit()
        {
            yield return null;
        }
    }
}

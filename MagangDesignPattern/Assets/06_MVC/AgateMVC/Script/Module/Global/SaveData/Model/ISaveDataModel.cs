using Agate.MVC.Base;

namespace MVC.Module.SaveData
{
    public interface ISaveDataModel : IBaseModel
    {
        public int Coin { get; }
    }
}

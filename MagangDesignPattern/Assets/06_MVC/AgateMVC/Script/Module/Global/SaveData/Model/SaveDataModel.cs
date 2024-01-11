using Agate.MVC.Base;

namespace MVC.Module.SaveData
{
    public class SaveDataModel : BaseModel, ISaveDataModel
    {
        public int Coin { get; private set; }

        public void SetCoinData(int coin)
        {
            Coin = coin;
            SetDataAsDirty();
        }
    }
}

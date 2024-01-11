using Agate.MVC.Base;
using MVC.Message;
using MVC.Module.SaveData;
using MVC.Module.Soundfx;

namespace MVC.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private SaveDataController _saveData;
        private SoundfxController _soundfx;

        public void OnUpdateCoin(UpdateCoinMessage message)
        {
            _saveData.OnUpdateCoin(message.Coin);
            _soundfx.OnUpdateCoin();
        }

        protected override void Connect()
        {
            Subscribe<UpdateCoinMessage>(OnUpdateCoin);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateCoinMessage>(OnUpdateCoin);
        }
    }
}

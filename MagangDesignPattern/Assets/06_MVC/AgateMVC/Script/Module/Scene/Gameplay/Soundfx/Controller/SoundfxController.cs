using UnityEngine;
using Agate.MVC.Base;
using MVC.Message;

namespace MVC.Module.Soundfx
{
    public class SoundfxController : BaseController<SoundfxController>
    {
        public void OnUpdateCoin()
        {
            Debug.Log("Play Sound fx");
        }
    }
}

using Life;
using UnityEngine;

namespace MyTrucker
{
    public class Main : Plugin
    {
        public Main(IGameAPI api) : base(api)
        { 
        }

        public override void OnPluginInit()
        {
            base.OnPluginInit();

            Debug.Log($"Plugin \"MyTrucker\" initialisé avec succès.");
        }
    }
}
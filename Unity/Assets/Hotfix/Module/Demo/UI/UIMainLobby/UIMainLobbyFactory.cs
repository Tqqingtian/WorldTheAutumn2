using System;
using ETModel;
using UnityEngine;

namespace ETHotfix
{
    public static class UIMainLobbyFactory
    {
        public static UI Create()
        {
            try
            {
                string uiType = UIType.UIMainLobby;
                ResourcesComponent resourcesComponent = ETModel.Game.Scene.GetComponent<ResourcesComponent>();
                resourcesComponent.LoadBundle(uiType.StringToAB());

                GameObject bundleGameObject = (GameObject)resourcesComponent.GetAsset(uiType.StringToAB(), uiType);
                GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);

                UI ui = ComponentFactory.Create<UI, string, GameObject>(uiType, gameObject, false);

                ui.AddComponent<UIMainLobbyComponent>();
                return ui;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return null;
            }
        }
    }

    [Event(EventIdType.EnterMainLobbyFinish)]
    public class EnterMainFinish_CreateMainLobbyUI : AEvent
    {
        public override void Run()
        {
            UI ui = UIMainLobbyFactory.Create();
            Game.Scene.GetComponent<UIComponent>().Add(ui);
        }
    }

    //[Event(EventIdType)]
    //public class EnterMainFinish_CreateMainLobbyUI : AEvent
    //{
    //    public override void Run()
    //    {
    //        Game.Scene.GetComponent<UIComponent>().Remove(UIType.UILogin);
    //        ETModel.Game.Scene.GetComponent<ResourcesComponent>().UnloadBundle(UIType.UILogin.StringToAB());
    //    }
    //}
}
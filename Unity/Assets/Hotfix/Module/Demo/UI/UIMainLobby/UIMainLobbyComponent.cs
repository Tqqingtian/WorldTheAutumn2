using ETModel;
using UnityEngine;
using UnityEngine.UI;

namespace ETHotfix
{
    [ObjectSystem]
    public class UIMainLobbyComponentSystem : AwakeSystem<UIMainLobbyComponent>
    {
        public override void Awake(UIMainLobbyComponent self)
        {
            self.Awake();
        }
    }

    public class UIMainLobbyComponent : Component
    {
        private GameObject btn_HeadPortrait;
        private Text txt_NickName;

        public void Awake()
        {
            Log.TypeInfo("初始主大厅界面");
            ReferenceCollector rc = this.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            this.btn_HeadPortrait = rc.Get<GameObject>("Btn_HeadPortrait");
            this.btn_HeadPortrait.GetComponent<Button>().onClick.Add(this.ClickHeadPortrait);

            this.txt_NickName = rc.Get<GameObject>("Txt_NickName").GetComponent<Text>();

        }

        private void ClickHeadPortrait()
        {
            Log.Info("点击头像");
        }


    }
}

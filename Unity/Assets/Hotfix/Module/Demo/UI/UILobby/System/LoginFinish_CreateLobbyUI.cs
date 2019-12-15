using ETModel;

namespace ETHotfix
{
    /// <summary>
    /// 登录完成 创建大厅UI
    /// </summary>
	[Event(EventIdType.LoginFinish)]
	public class LoginFinish_CreateLobbyUI: AEvent
	{
		public override void Run()
		{
			UI ui = UILobbyFactory.Create();
			Game.Scene.GetComponent<UIComponent>().Add(ui);
		}
	}
}

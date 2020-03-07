namespace ETHotfix
{
    /// <summary>
    /// 事件类型
    /// </summary>
	public static class EventIdType
	{
        /// <summary>
        /// 初始化场景开始（初始化游戏）
        /// </summary>
		public const string InitSceneStart = "InitSceneStart";
        /// <summary>
        /// 登录完成（关闭登录界面）
        /// </summary>
		public const string LoginFinish = "LoginFinish";
        /// <summary>
        /// 进入地图完成（加载地图）
        /// </summary>
		public const string EnterMapFinish = "EnterMapFinish";
        /// <summary>
        /// 进入主大厅（显示大厅UI）
        /// </summary>
		public const string EnterMainLobbyFinish = "EnterMainLobbyFinish";
	}
}
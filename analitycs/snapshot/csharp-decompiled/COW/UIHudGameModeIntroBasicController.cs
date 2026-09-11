using System;
using GCommon;

namespace COW;

public class UIHudGameModeIntroBasicController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public UIHudGameModeIntroBasicController _003C_003E4__this;

		public Action callback;

		internal void _003CShowDetailInfo_003Eb__0()
		{
		}
	}

	private UIHudGameModeIntroBasicView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowDetailInfo(GameModeIntroBasicInfo info, Action callback = null)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

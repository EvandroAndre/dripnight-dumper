using GCommon;

namespace COW;

internal class UIHudLWFactionController : UIBaseController
{
	private UIHudLWFactionView m_View;

	private uint m_DelayCallIdAnimationStep;

	private uint m_DelayCallIdPlayShound;

	private bool mLocalPlayerJoined;

	private bool mLoadingMaskClosed;

	private bool m_NeedOpenMatchInfo;

	private float m_Time;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnPlayerJoin(object[] data)
	{
	}

	private void OnLocalPlayerJoin(object[] data)
	{
	}

	private void OnLoadingMaskClosed(object[] data)
	{
	}

	private void SetUIData()
	{
	}

	private void SetTeamView(UILabel teamName1, UISprite teamIcon, UISprite defaultTeamIcon1, int index)
	{
	}

	private void ShowSelfTeamInfo()
	{
	}

	private void GoClose()
	{
	}

	private void CheckStartDelayShow()
	{
	}

	private void ShowAndPlaySound()
	{
	}

	public void TryClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

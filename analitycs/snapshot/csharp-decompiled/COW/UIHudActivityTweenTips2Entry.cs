using GCommon;

namespace COW;

public class UIHudActivityTweenTips2Entry
{
	public readonly string Style;

	public readonly ResourceID ResourceID;

	private UIHudActivityPopup2Controller m_LoadedTipsCtrl;

	public string Title;

	public string Content;

	public UIHudActivityTweenTips2Entry(string style, ResourceID resourceID, string title, string content)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void TryHideLoadedTips()
	{
	}

	public void TryCloseLoadedTips()
	{
	}

	public bool GetLoadedTipsCtrl(out UIHudActivityPopup2Controller tipsCtrl)
	{
		tipsCtrl = null;
		return false;
	}

	public void SetLoadedTipsCtrl(UIHudActivityPopup2Controller tipsCtrl)
	{
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}

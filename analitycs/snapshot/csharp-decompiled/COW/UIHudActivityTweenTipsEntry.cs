using GCommon;

namespace COW;

public class UIHudActivityTweenTipsEntry
{
	public readonly string Style;

	public readonly ResourceID ResourceID;

	private UIHudActivityPopupController m_LoadedTipsCtrl;

	public UIHudActivityTweenTipsEntry(string style, ResourceID resourceID)
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

	public bool GetLoadedTipsCtrl(out UIHudActivityPopupController tipsCtrl)
	{
		tipsCtrl = null;
		return false;
	}

	public void SetLoadedTipsCtrl(UIHudActivityPopupController tipsCtrl)
	{
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}

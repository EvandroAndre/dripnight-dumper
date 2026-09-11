using GCommon;

namespace COW;

public class UILadderHeroicMarkPopupController : UIPopupWindowController
{
	private UILadderHeroicMarkPopupView m_View;

	private const string ANIM_END = "AnimEnd";

	private const string ANIM_FIRST = "FX_UI_LaddeHeroicMarkPopupFirst";

	private const string ANIM_LEVELUP = "FX_UI_LaddeHeroicMarkPopupLevelUp";

	private const string ANIM_MASTER_LEVELUP = "FX_UI_LaddeHeroicMarkPopup03";

	private const string ANIM_GRANDMASTER_LEVELUP = "FX_UI_LaddeHeroicMarkPopupGrandMaster";

	private bool EnableSkip;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnMaskClick()
	{
	}

	public void PlayFirstMasterAnim(EHeroicMarkType t, uint valAfter)
	{
	}

	public void PlayFirstGrandMasterAnim(EHeroicMarkType t, uint valAfter)
	{
	}

	public void PlayAnim(EHeroicMarkType t, uint valBefore, uint valAfter)
	{
	}

	private void OnAnimEvtOccur(object[] data)
	{
	}

	public override int GlassDelay()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return 0;
	}
}

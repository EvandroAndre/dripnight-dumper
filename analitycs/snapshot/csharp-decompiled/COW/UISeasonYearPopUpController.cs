using GCommon;

namespace COW;

public class UISeasonYearPopUpController : UIPopupWindowController
{
	public UISeasonYearPopUpView m_View;

	public uint m_PopAnimDelayCall;

	public ESeasonYearMainAnimType m_MainAnimType;

	protected bool ISChangeYearPop;

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

	public override bool ClosedByEsc()
	{
		return false;
	}

	public virtual void PlayAnim()
	{
	}

	public virtual float GetAnimLength()
	{
		return 0f;
	}

	public virtual void SetView(ESeasonYearMainAnimType mainAnimType)
	{
	}

	private void _003CPlayAnim_003Eb__8_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}

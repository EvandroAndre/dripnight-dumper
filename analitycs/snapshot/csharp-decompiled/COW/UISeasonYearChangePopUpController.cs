using GCommon;

namespace COW;

public class UISeasonYearChangePopUpController : UISeasonYearPopUpController
{
	public UISeasonYearChangePopUpView m_NewView;

	private uint m_ChangeAnimDelayCall;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override void PlayAnim()
	{
	}

	public override float GetAnimLength()
	{
		return 0f;
	}

	public override void SetView(ESeasonYearMainAnimType mainAnimType)
	{
	}

	private void _003CPlayAnim_003Eb__5_0()
	{
	}

	private void _003CPlayAnim_003Eb__5_1()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_PlayAnim()
	{
	}

	public float _003C_003EiFixBaseProxy_GetAnimLength()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_SetView(ESeasonYearMainAnimType P0)
	{
	}
}

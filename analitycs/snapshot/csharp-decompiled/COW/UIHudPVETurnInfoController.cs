using GCommon;

namespace COW;

internal class UIHudPVETurnInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHudPVETurnInfoView m_View;

	private uint m_delcayCall;

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

	private void PlayerMidAnimation(byte turn)
	{
	}

	private void OnNewRoundStart(object[] data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CPlayerMidAnimation_003Eb__5_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

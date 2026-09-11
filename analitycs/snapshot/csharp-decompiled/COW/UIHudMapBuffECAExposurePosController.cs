using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudMapBuffECAExposurePosController : UIBaseController
{
	private UIHudMapBuffECAExposurePosView m_View;

	private uint _003CDelayCallID_003Ek__BackingField;

	public uint DelayCallID
	{
		get
		{
			return _003CDelayCallID_003Ek__BackingField;
		}
		set
		{
			_003CDelayCallID_003Ek__BackingField = value;
		}
	}

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

	public void ResetUI(BHGGAEEHJCO playerID)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

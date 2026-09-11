using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityBindListContentController : UIActivityListContentController
{
	private UIModelOTP m_ModelOTP;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override IUIActivityTask SetNormalTaskType(Transform parentTransform)
	{
		return null;
	}

	protected override void RefreshOperateState()
	{
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public IUIActivityTask _003C_003EiFixBaseProxy_SetNormalTaskType(Transform P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_RefreshOperateState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIBM26_SYSTokenTipsWndController : UIBigEventTokenTipsBaseWndController
{
	private UIBM26SysTokenTipsWndView m_View;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UINinthSYSTokenTipsWndController : UIBigEventTokenTipsBaseWndController
{
	private UINinthSYSTokenTipsWndView m_View;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	protected override void OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}

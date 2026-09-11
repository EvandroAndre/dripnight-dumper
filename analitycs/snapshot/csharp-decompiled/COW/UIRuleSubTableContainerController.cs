using GCommon;
using UnityEngine;

namespace COW;

internal class UIRuleSubTableContainerController : UIRuleTableContainerController
{
	private UIRuleSubTableContainerView m_SubView;

	public CSubTableContainerData SubData;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(CSubTableContainerData data, float width, float height, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	protected override UIBaseController BuildChildComponent(Transform container, IModeEditComponentData data)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public UIBaseController _003C_003EiFixBaseProxy_BuildChildComponent(Transform P0, IModeEditComponentData P1)
	{
		return null;
	}
}

using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudInGamePersonalShopV2Controller : UIHudInGameShopV2Controller
{
	private static readonly Vector3 m_DefaultDetailTipsOffset;

	private bool m_PersonalShopHaveBought;

	private uint m_PersonalShopIdentifier;

	private UIDetailTipsInGameController m_DetailTipsCtrl;

	private uint PersonalShopIdentifier
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IsSuspendingEnabled()
	{
		return false;
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnShowPersonalShopHud(object[] data)
	{
	}

	private void OnPersonalShopTemporaryHide()
	{
	}

	private void OnPersonalShopBoughtStateChanged(bool bought)
	{
	}

	protected override void RegisterTypeSpecificContainerEvents()
	{
	}

	protected override void OnExitShopMaskClicked()
	{
	}

	private void OnTitleHelpBtnPress(GameObject go, bool pressed)
	{
	}

	protected override void AddTypeSpecificEventDelegates()
	{
	}

	private void UpdateBoughtStateInternal(bool bought)
	{
	}

	private void ResetAndUpdateBoughtState()
	{
	}

	protected override void OnInGameShopShow()
	{
	}

	protected override void OnInGameShopHide()
	{
	}

	protected override void SetupTypeSpecificStaticContent()
	{
	}

	internal override EDPFGIMHEPM BuildInGameShopBuyReqMessage()
	{
		return null;
	}

	protected virtual bool CheckCanShow()
	{
		return false;
	}

	public new bool _003C_003EiFixBaseProxy_IsSuspendingEnabled()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterTypeSpecificContainerEvents()
	{
	}

	public void _003C_003EiFixBaseProxy_OnExitShopMaskClicked()
	{
	}

	public void _003C_003EiFixBaseProxy_AddTypeSpecificEventDelegates()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInGameShopShow()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInGameShopHide()
	{
	}

	public void _003C_003EiFixBaseProxy_SetupTypeSpecificStaticContent()
	{
	}

	public EDPFGIMHEPM _003C_003EiFixBaseProxy_BuildInGameShopBuyReqMessage()
	{
		return null;
	}
}

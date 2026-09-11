using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudRoomOBPlayerMapIconController : UIBaseController
{
	private const float SELECTED_VFX_SHOW_TIME = 3f;

	private UIHudRoomOBPlayerMapIconView m_View;

	private BHGGAEEHJCO m_BoundPlayerId;

	private bool m_HasBoundPlayer;

	private uint m_HideSelectedVFXDelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnRecyle()
	{
	}

	public void BindPlayerData(PlayerData data)
	{
	}

	private void SetDepth(uint depth)
	{
	}

	private void RefreshObserverTrackingHighlight()
	{
	}

	public void SyncBigMapIcon(Player matchPlayer, UIMapUtil.MapOffsetContext ctx, Vector3 iconScale)
	{
	}

	private void OnGotoBtnClick()
	{
	}

	private void ShowSelectedVFX()
	{
	}

	private void HideSelectedVFX()
	{
	}

	private void CancelHideSelectedVFXDelayCall()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRecyle()
	{
	}
}

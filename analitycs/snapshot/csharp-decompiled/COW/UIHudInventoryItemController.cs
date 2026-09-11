using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudInventoryItemController : UIInventoryItemControllerBase
{
	protected UIHudInventoryItemView m_View;

	private uint m_AsyncLoadUIAtlasTicket;

	private uint m_AsyncLoadDragUIAtlasTicket;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void CancelAsyncLoadIconUIAtlasTicket()
	{
	}

	protected virtual void CreateHudView()
	{
	}

	public void ShowAmmoGuideEffect(bool isShow)
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void OnRecycle()
	{
	}

	public void OnReInit()
	{
	}

	public void SetItemNameColor(Color newColor)
	{
	}

	public virtual void SetUIData(UIItem item)
	{
	}

	private void RefreshCollectionTrialDragState(HENEHAGJCLI itemData)
	{
	}

	public virtual void RefeshCount(int count)
	{
	}

	public void SetItemBg(HENEHAGJCLI itemData)
	{
	}

	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	private void OnOpBtnGOClick()
	{
	}

	private void PlaySoundByUseItem(NAELPAAELNO item)
	{
	}

	protected override void OnItemToggleChanged()
	{
	}

	private bool HasWeaponCanReplace()
	{
		return false;
	}

	public void HideOpBtnGo()
	{
	}

	public UISprite GetItemIcon()
	{
		return null;
	}

	public override UIToggle GetToggle()
	{
		return null;
	}

	public override GameObject GetHighlightGO()
	{
		return null;
	}

	public override void SetHighlightGoActive(bool paramActive)
	{
	}

	public override GameObject GetDragGO()
	{
		return null;
	}

	public override GameObject GetNonDragGO()
	{
		return null;
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	public override GameObject GetDragRedGo()
	{
		return null;
	}

	protected override bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
	{
		return false;
	}

	protected virtual void ShowItemCount(int count)
	{
	}

	private bool IsShopToken()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemToggleChanged()
	{
	}

	public bool _003C_003EiFixBaseProxy_HandleReleaseEvent(UIInventoryItemDragDropContainer P0)
	{
		return false;
	}
}

using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudIceWallMakerItemController : UIHudInventoryItemController, UITable2.IUITable2Item
{
	private UIHudIceWallMakerItemView m_BigView;

	private IceWallMakerData m_CurLevelData;

	private int m_Count;

	private uint m_AsyncLoadUIAtlasTicket;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public new static bool KillCamDontDestroy()
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

	protected override void OnUIDestroy()
	{
	}

	protected override void CreateHudView()
	{
	}

	private void DoViewProxy(UIHudInventoryItemView view, UIHudIceWallMakerItemView bigView)
	{
	}

	private void SetItemName(uint level)
	{
	}

	public override void SetUIData(UIItem item)
	{
	}

	public override void RefeshCount(int count)
	{
	}

	protected override void ShowItemCount(int count)
	{
	}

	private void ShowArrowVfx()
	{
	}

	private void ChangeSprite(ResourceID resIcon)
	{
	}

	private void OnBuildingCountChange(object[] param)
	{
	}

	public void LevelChange()
	{
	}

	public void ProcessChange(int process)
	{
	}

	private void OnIceWallMakerLevelChange(object[] data)
	{
	}

	private void OnIceWallMakerProcessChange(object[] data)
	{
	}

	private void RefreshView(object data, int index)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public new bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_CreateHudView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetUIData(UIItem P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefeshCount(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowItemCount(int P0)
	{
	}
}

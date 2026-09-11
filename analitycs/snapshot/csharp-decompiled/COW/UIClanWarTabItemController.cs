using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarTabItemController : UIStandardTabItemRemakeController
{
	private Color OpenColor;

	private Color NotOpenColor;

	private Color NotEnableColor;

	private UIClanWarTabItemViewExt m_ViewExt;

	private UIModelClan m_ModelClan;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private ClanWarV2Stage m_Stage;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void SetUnFoldObjShow(bool show)
	{
	}

	public void RefreshTournamentTabName(string name)
	{
	}

	public void RefreshInfo()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}

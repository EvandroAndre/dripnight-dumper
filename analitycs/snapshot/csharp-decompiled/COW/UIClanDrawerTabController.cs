using GCommon;
using UnityEngine;

namespace COW;

public class UIClanDrawerTabController : UIStandardDrawerTabRemakeController
{
	private UIClanWarTabItemController m_ClanWarTab;

	public UIClanWarTabItemController ClanWarTab => null;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIStandardTabItemController CreateTabItem(Transform container, StandardTabItemViewData mainTabData)
	{
		return null;
	}

	public void RefreshInfo()
	{
	}

	public void SetUnFoldObjShow(bool show)
	{
	}

	public void RefreshTournamentTabName(string name)
	{
	}

	public new UIStandardTabItemController _003C_003EiFixBaseProxy_CreateTabItem(Transform P0, StandardTabItemViewData P1)
	{
		return null;
	}
}

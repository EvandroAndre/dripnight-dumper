using System;
using GCommon;
using proto;

namespace COW;

public class UIUGCMainSideRecItemCollaborationController : UIUGCMainSideRecItemController
{
	private WorkshopBannerPopup m_BannerPopupConfig;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetViewData(int index, WorkshopEditorChoiceDesc choiceDesc, Action<uint> callback)
	{
	}

	protected override void OnMainRecMoreBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(int P0, WorkshopEditorChoiceDesc P1, Action<uint> P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnMainRecMoreBtnClick()
	{
	}
}

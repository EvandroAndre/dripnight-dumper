using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHippoCrisisPreStartNoticePopController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIHippoCrisisPreStartNoticePopView m_View;

	private List<UIHippoCrisisPreStartNoticeItemController> m_NoticeItemCtrlList;

	private bool m_IsBlock;

	private List<uint> m_ConditionList;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(List<uint> conditionList)
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void ReturnToLobby()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

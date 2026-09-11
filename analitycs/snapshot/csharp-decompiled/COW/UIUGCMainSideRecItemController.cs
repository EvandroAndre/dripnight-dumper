using System;
using GCommon;
using proto;

namespace COW;

public class UIUGCMainSideRecItemController : UIBaseController
{
	protected UIUGCMainSideRecItemView m_View;

	private UIModelSceneEdit m_Model;

	private UIUGCHotIndicatorController m_HotCtrl;

	private UIUGCLikeIndicatorController m_LikeCtrl;

	private int m_Index;

	protected WorkshopEditorChoiceDesc m_ChoiceInfo;

	private Action<uint> m_GoposCallback;

	private WorkshopBasicInfo m_WorkshopInfo;

	private bool m_IsExposureRequested;

	private bool m_IsExposed;

	private const int LikeHotPadding = 20;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public virtual void SetViewData(int index, WorkshopEditorChoiceDesc choiceDesc, Action<uint> callback)
	{
	}

	public void OnExposure()
	{
	}

	private void TryRecordExposure()
	{
	}

	private void RepositionLikeAfterHot()
	{
	}

	protected virtual void OnMainRecMoreBtnClick()
	{
	}

	private void _003CSetViewData_003Eb__12_0()
	{
	}

	private void _003CSetViewData_003Eb__12_1(WorkshopBasicInfo data)
	{
	}

	private void _003COnMainRecMoreBtnClick_003Eb__17_0(SceneEditSlotInfo slotInfo)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIActivityV2FriendReunionInviterProgressController : UIBaseController, IUIModelDataChangeObserver
{
	private UIActivityV2FriendReunionInviterProgressView m_View;

	private List<UIActivityV2FriendReunionInviterProgressItemController> m_V2FriendReunionInviterProgressItemControllerList;

	private List<CallbackProcessDesc> m_CallbackProcessDescs;

	private UIModelFriendReunion m_ModelFriendReunion;

	private UIActivityV2FriendReunionInviterDetailAwardPopController m_GrowPathDetailAwardPopController;

	private int m_SelectedIndex;

	public static ResourceID GetResourceID()
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

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void InitData()
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshScoreNum()
	{
	}

	private void RefreshProgressVal()
	{
	}

	private void InitView()
	{
	}

	public void SetDetailAward(Transform transform, List<AwardDesc> awardDescs)
	{
	}

	public int GetSelectIndex()
	{
		return 0;
	}

	public void OnDetailAwardPopClose()
	{
	}

	private void OnBtnShareClicked()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}

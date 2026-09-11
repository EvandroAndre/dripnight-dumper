using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIQuickMessageRewardItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIQuickMessageRewardItemView m_View;

	private uint m_MsgId;

	private GameObject m_GlowVoice;

	private GameObject m_Icon;

	private Action m_PlayVoiceEndDelegate;

	private uint m_CurPlayingMsgId;

	private int m_CurPlayingTicked;

	private uint m_CurPlayingVoiceDelayCall;

	private bool m_NeedDownload;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnItemBtnClick()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void RefreshHighLightView(bool isShow)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshDownloadView()
	{
	}

	private void PlayVoiceEnd()
	{
	}

	private void PlayVoice()
	{
	}

	private void ShowVoicePlayingVfx(bool value)
	{
	}

	private void RefreshVoicePlayingIconView(bool isShow)
	{
	}

	private void RefreshVoiceIconView(bool isShow)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void StopVoicePlay()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}

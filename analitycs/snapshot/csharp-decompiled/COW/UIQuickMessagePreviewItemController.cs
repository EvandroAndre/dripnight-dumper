using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIQuickMessagePreviewItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIQuickMessagePreviewItemView m_View;

	private uint m_MsgId;

	private UIQuickMessagePreviewItemColorInfo m_ColorInfo;

	private GameObject m_GlowVoice;

	private GameObject m_Icon;

	private UIQuickMessagePreviewPlayIconHelper m_PlayIconHelper;

	private UIQuickMessagePreviewPlayVFXHelper m_PlayVFXHelper;

	private Action m_PlayVoiceEndDelegate;

	private uint m_CurPlayingMsgId;

	private int m_CurPlayingTicked;

	private uint m_CurPlayingVoiceDelayCall;

	private bool m_NeedDownload;

	private UINewDownloadInfoController m_DownloadCtrl;

	private MaterialPropertyBlock m_MaterialPropertyBlock;

	private readonly int ColorPropertyID;

	private readonly int ColorTexPropertyID;

	private const float GlowVoiceAlpha = 10f / 51f;

	private const float LiziAlpha = 10f / 51f;

	private const float Layer2Alpha = 20f / 51f;

	private const float FrameAlpha = 0.7058824f;

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

	private void DownloadSecondConfirmWnd()
	{
	}

	private void DownloadRes()
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

	private void UpdateVoicePlayingColor()
	{
	}

	private void UpdateVoicePlayingVFXColor()
	{
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

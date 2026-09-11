using System;
using GCommon;
using UnityEngine;

namespace COW;

public class ReplayKitVideoPreviewWindowController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<string, PlatformUtility.SendContentResult> _003C_003E9__41_0;

		public static Action<int, string> _003C_003E9__42_0;

		internal void _003COnOtherShareClick_003Eb__41_0(string video, PlatformUtility.SendContentResult shareResult)
		{
		}

		internal void _003COnTikTokShareClick_003Eb__42_0(int code, string _msg)
		{
		}
	}

	private ReplayKitVideoPreviewWindowView m_View;

	private int video_width;

	private int video_height;

	private ReplayKitVideoInfo videoInfo;

	private uint videoPlayRepeatedKey;

	private bool destroy;

	private FFVideoPlayer videoPlay;

	private float mfRecordStartDragPoint;

	private float mfRecordEndDragPoint;

	private float mfDragEndTimePoint;

	private int video_length;

	private bool mIsRecordReplayPreview;

	private bool mNeedReturnToLobby;

	private bool m_ClickSave;

	private bool m_IsHighlightShareView;

	private ulong m_HighlightMatchId;

	private ulong m_SavedHighlightMatchId;

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

	public override int MinGroupDepth()
	{
		return 0;
	}

	protected override void OnUIDestory()
	{
	}

	public void PlayVideo(ReplayKitVideoInfo info, bool isRecordReplayPreview = false)
	{
	}

	private void PlayVideoInternal(string videoPath)
	{
	}

	public void PlayVideo(string fileName)
	{
	}

	private void UpdateVideoTexture()
	{
	}

	public void OnCloseClick()
	{
	}

	private void OnClickPlayBtn()
	{
	}

	private void OnClickPauseBtn()
	{
	}

	public void PauseVideo(bool pause = true)
	{
	}

	private void OnClickSaveBtn()
	{
	}

	private void OnVideoProgressCallback()
	{
	}

	private void OnDragVideoProgressStartCallback()
	{
	}

	private void OnDragVideoProgressEndCallback()
	{
	}

	private void OnVideoPrepareCallback()
	{
	}

	private void OnSaveRecordCallback(bool result, string message)
	{
	}

	private void ShowSaveRecordTips(bool result)
	{
	}

	private void OnVideoSeekToCallback()
	{
	}

	private void ResetRecordDragPoint()
	{
	}

	private void OnVideoStartCallback()
	{
	}

	private void OnVideoEndCallback()
	{
	}

	private void OnOtherShareClick()
	{
	}

	private void OnTikTokShareClick()
	{
	}

	private void OnSingleHighlightClickExit()
	{
	}

	private void ShowTipTok()
	{
	}

	private string GetVideoPath(ReplayKitVideoInfo info)
	{
		return null;
	}

	public void SetHighlightShareView(ulong matchId = 0uL)
	{
	}

	public void SetSavedHighlightMatchId(ulong matchId)
	{
	}

	public Vector3 GetWorldPosByDefaultShow(float[] defaultShowPos)
	{
		return default(Vector3);
	}

	private Vector3 TransDefaultShowPosToWorldPos(Vector2 defaultPos)
	{
		return default(Vector3);
	}

	private void _003CPlayVideo_003Eb__22_0(bool result, string message)
	{
	}

	private void _003COnClickSaveBtn_003Eb__30_0(bool permission)
	{
	}

	private void _003COnVideoStartCallback_003Eb__39_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCameraEmotePanelController : UIBaseController
{
	public const uint VISIBILITY_STATE_CAMERAZOOMING = 1073741824u;

	public const uint VISIBILITY_STATE_VEDIO_REC = 536870912u;

	protected UIHudCameraEmotePanelView m_View;

	protected List<UIHudCameraEmoteItemController> m_EmoteItemControllerList;

	protected List<UIHudCameraEmoteItemController> m_EmoteItemControllerPlayList;

	protected int m_CurPlayingIndex;

	protected float m_CurPlayingIndexStartTime;

	private bool _003CCurIsPlaying_003Ek__BackingField;

	private bool m_IsAnimFinishComplete;

	private bool m_IsTransformerBeforeAnimFinishComplete;

	private bool m_IsStopEmoteInitiative;

	protected bool CurIsPlaying
	{
		get
		{
			return _003CCurIsPlaying_003Ek__BackingField;
		}
		set
		{
			_003CCurIsPlaying_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected virtual void RegisterEvents()
	{
	}

	public override void Hide()
	{
	}

	protected virtual bool HasBp()
	{
		return false;
	}

	protected virtual uint GetTransfromId()
	{
		return 0u;
	}

	protected void InitEmoteItems()
	{
	}

	public override void Show()
	{
	}

	protected virtual bool NeedRefreshEmoteItemsOnShow()
	{
		return false;
	}

	protected void RefreshEmoteItems()
	{
	}

	private void ClearEmoteItems()
	{
	}

	private int SortEmoteItemGrid(Transform trA, Transform trB)
	{
		return 0;
	}

	public virtual void AddToPlayList(UIHudCameraEmoteItemController item, bool isItemClick = false)
	{
	}

	public void RemoveFromPlayList(UIHudCameraEmoteItemController item, bool isItemClick = false)
	{
	}

	public void ClearPlayList(bool needRealStop = true)
	{
	}

	protected virtual void StopEmote(int index, bool needRealStop = true)
	{
	}

	protected virtual bool PlayEmote(int index, bool IsItemClick = false)
	{
		return false;
	}

	private void DelayPlayNextEmote(bool isSuccess)
	{
	}

	protected virtual void Update()
	{
	}

	public virtual void OnBtnCloseClick()
	{
	}

	private void OnBtnReplayClick()
	{
	}

	protected virtual void BeforeDoEmoteListReplay()
	{
	}

	protected virtual void DoEmoteListReplay()
	{
	}

	private void OnTransformerBeforeAnimFinish()
	{
	}

	private void OnAnimEmotionFinish()
	{
	}

	private void OnCameraModeZooming(bool isZooming)
	{
	}

	private void OnVedioRecordBeforeStart(int sec)
	{
	}

	private void OnVedioRecordBeforeStartEnd(bool isSuccessStart)
	{
	}

	private void OnCameraStateChanged(int state)
	{
	}

	private void OnVideoTemplateStartPlay(float duration)
	{
	}

	public List<int> GetCurPlaylistIDs()
	{
		return null;
	}

	private bool IsDuoEmote(int index)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}

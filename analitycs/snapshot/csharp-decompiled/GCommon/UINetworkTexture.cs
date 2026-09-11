using System;
using UnityEngine;

namespace GCommon;

public class UINetworkTexture : MonoBehaviour
{
	public UITexture m_TargetTexture;

	public Texture m_DefaultTexture;

	private bool m_ShowLoadingState;

	private bool m_WaitingTimeState;

	private float m_WaitingTime;

	private GameObject m_CommonLoadingGO;

	private bool m_IsMakePerfect;

	private bool m_needCache;

	private bool m_isReadable;

	private string m_CurrentDownloadURL;

	private string m_PendingURL;

	private bool m_IsUseOriginalURL;

	private bool m_IsAwaked;

	private bool m_IsPendingDownload;

	private bool m_LoadImmediately;

	private Action m_SuccessCallBack;

	public int DownloadFinishedTextureHeight;

	public int DownloadFinishedTextureWidth;

	private uint m_SetDifferentUrlTimes;

	private bool m_NeedRefCountClean;

	private bool m_ReleaseUnused;

	private bool m_IsGif;

	public bool IsGif => false;

	public static implicit operator UITexture(UINetworkTexture network_texture)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void ReleaseUnUseTexture()
	{
	}

	public void UnRegisterCallBack()
	{
	}

	public void SetAsyncImageFromUrl(string url, bool isMakePerfect = false, bool needCache = true, Action successCallBack = null, bool useOriginalUrl = false, bool isReadable = false, bool useDefaultTexture = true, bool showLoading = true, bool enableRefCountClean = false, uint endTime = uint.MaxValue, ETextureUsageType textureUsageType = ETextureUsageType.None, bool loadImmediately = false, bool releaseUnused = false)
	{
	}

	public void StopDownload(bool removeCache = true)
	{
	}

	public virtual void OnDowloadFinished(ResultTextureInfo textureInfo)
	{
	}

	public void OnDownloadFailed(CDNDownloadFailedInfo info)
	{
	}

	private void ShowCommonLoading(bool show = true)
	{
	}

	private void CommonLoadingActive(bool isActive)
	{
	}

	private void Update()
	{
	}
}

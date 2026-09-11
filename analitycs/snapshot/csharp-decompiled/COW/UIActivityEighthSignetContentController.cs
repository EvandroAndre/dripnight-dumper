using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityEighthSignetContentController : UIActivityContentController, IUIModelDataChangeObserver
{
	public class EighthSignetItemList
	{
		public uint index;

		public ulong startTime;

		public ulong endTime;

		public List<ClientActivityDesc> EighthSignetItemDatas;

		public List<ClientActivityDesc> EighthSignetSpecialItemDatas;
	}

	public enum SignetTapType
	{
		Left = 1,
		Big,
		Mid
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public uint subTypeId;

		internal bool _003CGetCdnUrl_003Eb__0(AdvertDesc e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public float targetBarValue;

		public UIActivityEighthSignetContentController _003C_003E4__this;

		public float tempBarDuration;

		internal void _003COnShowFirstProgressBar_003Eb__0()
		{
		}
	}

	private UIActivityEighthSignetContentView m_View;

	private UIModelActivity m_ModelActivity;

	private ActivityGroupDesc m_Descs;

	private List<UIActivityEighthSignetItemContentController> m_EighthSignetCtrlList;

	public const uint CDN_UNSHARE_BG = 20250001u;

	public const uint CDN_SHARE_BG = 20250002u;

	public const uint CDN_PROGRESS_BG = 20250003u;

	public const uint CDN_PROGRESS_FG = 20250004u;

	public const uint CDN_PROGRESS_Dot = 20250005u;

	public const uint CDN_PROGRESS_THUMB = 20250006u;

	public const uint CDN_SHARE_ICON = 20250015u;

	public const uint CDN_SHARE_TITLE = 20250020u;

	private List<float> m_TargetProgressBarValues;

	private int m_LoadCdnCount;

	private uint m_DailyStartShowKey;

	private int m_SignetShowBar;

	private UIStandardTabArrowRemakeController m_TabCtrl;

	private UIStandardArrowTopTabController m_TopCtrl;

	private bool m_IsShareClickBtn;

	private uint m_SignetNormalNum;

	private uint m_SignetNormalActiveNum;

	private uint m_SignetEggActiveNum;

	protected UIMaleAvatar m_Avatar;

	protected Vector3 m_AvatarPosition;

	protected Vector3 m_AvatarPreparePosition;

	protected Vector3 m_AvatarRotation;

	protected Vector3 m_AvatarScale;

	private GameObject m_GoMixCamera;

	private uint m_RoleShareShowKey;

	private UICommonGuideController m_CommonGuideCtrl;

	private UITutorialIndicatorHandController m_IndicatorHandCtrl;

	private uint m_SignetGuideDelayID;

	private UIActivityEighthSignetItemController m_SignetItemCtrl;

	private uint m_HideGuideDelayID;

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

	public override void SetData(object data)
	{
	}

	public override void Reload()
	{
	}

	private void UpdateTapData()
	{
	}

	private void UpdateIntroData()
	{
	}

	private void RefreshCountDownState()
	{
	}

	protected void InitCDN()
	{
	}

	protected string GetCdnUrl(uint subTypeId)
	{
		return null;
	}

	private bool LoadImageFromUrl(UINetworkTexture uINetworkTexture, string strUrl)
	{
		return false;
	}

	private void OnShareCdnSuccessCallback()
	{
	}

	private void RefershShareBtn()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void UpdateProgressLabel()
	{
	}

	private void OnShowFirstProgressBar()
	{
	}

	private GameObject GetProgressDotUIFX()
	{
		return null;
	}

	private void UpdateMissNum()
	{
	}

	private void RefreshShareInfo()
	{
	}

	private void RefreshShareEggInfo()
	{
	}

	private void OnClickShareBtn()
	{
	}

	protected void OnShowShareView()
	{
	}

	private void OnShareClose()
	{
	}

	public override void OnShare(bool success, int platform)
	{
	}

	private void SendEventShareLog(bool success, uint platform)
	{
	}

	private void SendLimitedEventShareLog(uint id, uint platform, uint pageId, uint type, bool success)
	{
	}

	public override void OnCopyShareLink(bool success)
	{
	}

	public override void OnSaveSharePhoto(bool success)
	{
	}

	private void SetShareView(bool visible)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void InitShareView()
	{
	}

	private void CreateAvatar()
	{
	}

	protected void PlayRoleAnim()
	{
	}

	private void InitAvatarAndCamera()
	{
	}

	protected void SetCameraFovAccordingToResolution(Camera camera)
	{
	}

	public void ShowRoleAvater(bool visible)
	{
	}

	public bool GetSightItemFingerItem(ref UIActivityEighthSignetItemController signetItemCtrl)
	{
		return false;
	}

	private void CheckShowGuide()
	{
	}

	public void OnShowGuide()
	{
	}

	public void HideGuide()
	{
	}

	public void UpdateDepth(UIBaseController ctrl, int depth)
	{
	}

	private void _003CPlayRoleAnim_003Eb__65_0()
	{
	}

	private void _003CCheckShowGuide_003Eb__75_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShare(bool P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCopyShareLink(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSaveSharePhoto(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}

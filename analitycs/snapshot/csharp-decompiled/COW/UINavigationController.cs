using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINavigationController : UIBaseNavigationController
{
	public class BGInfo
	{
		public ResourceID bgResID;

		public string bgURL;

		public bool isFliphHorizontally;

		public bool needResetLocalScale;
	}

	protected UINavigationTopbarViewData m_TopbarViewData;

	protected bool m_TopbarViewDataShowBeforeScreenShot;

	public static List<Type> m_DontRecordTimeList;

	public ulong m_StartShowTime;

	public int m_ShowTime;

	public ulong m_StartPauseTime;

	public int m_PauseTime;

	protected bool isDataInited;

	protected BGInfo m_bgInfo;

	private GameObject m_NewVaultBGVFX;

	private GameObject m_SubBgObject;

	private GameObject m_bgEffectGo;

	private ResourceID m_bgEffectResId;

	protected virtual void AvatarCameraStateChange(UINavigationData navigationData)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected void SetChatBtn(bool status)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected virtual void OnWaitDataReady()
	{
	}

	protected virtual void PlayFrontEndBGM()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected virtual void OnSendShowTimeEvent(ref string eventLogKey, ref EventLogger.EventPageDetentionTime eventLog)
	{
	}

	private void OnApplicationPauseEvent(object[] data)
	{
	}

	protected void OnDataReady()
	{
	}

	protected virtual void OnOnDataReady()
	{
	}

	public UITexture GetBG()
	{
		return null;
	}

	public void SetBG(BGInfo bgInfo)
	{
	}

	public void SetMallMiddleBG(int width = 0, int height = 0, bool isFliphHorizontally = false, bool needResetLocalScale = true)
	{
	}

	public virtual void SetBG(ResourceID bgRes, int width = 0, int height = 0, bool isFliphHorizontally = false, bool needResetLocalScale = true)
	{
	}

	public virtual void SetBG(string url, int width = 0, int height = 0, bool isFliphHorizontally = false, bool needResetLocalScale = true, uint endTime = uint.MaxValue)
	{
	}

	public void SetBG(AdType adType, uint subType = 0u, int width = 0, int height = 0, bool isFliphHorizontally = false, bool needResetLocalScale = true)
	{
	}

	public void SetBGActive(bool active)
	{
	}

	public void ClearBGUrl()
	{
	}

	public void ShowBgEffect(ResourceID resID, Vector3 offset, Vector3 scale, string targetLayer = null)
	{
	}

	public void ShowBgEffect()
	{
	}

	public void HideBgEffect()
	{
	}

	public void DestroyBgEffect()
	{
	}

	public void SetNewVaultBGVFXActive(bool active)
	{
	}

	public void DestroyNewVaultBGVFX()
	{
	}

	public Transform GetNewVaultBGVFXTransform()
	{
		return null;
	}

	public void SetNewVaultBGVFX(ResourceID resID, Vector2 offset, Vector2 scale)
	{
	}

	public void SetSubBGActive(bool active)
	{
	}

	public UINetworkTexture GetSubGameNetWorkTextureInfo(Vector2 offset, Vector2 scale, int left = 0, int right = 0, int top = 0, int bottom = 0)
	{
		return null;
	}

	public void DestroySubBg()
	{
	}

	protected virtual bool NeedRecoverSubBgActivOnNavigationShowed()
	{
		return false;
	}

	public void SetSubBG(string url, Vector2 offset, Vector2 scale, int left = 0, int right = 0, int top = 0, int bottom = 0, uint endTime = uint.MaxValue)
	{
	}

	public void SetSubBGWithCamera(string url, Vector3 UIRootItemPos, Vector2 scale)
	{
	}

	protected virtual bool NeedWaitDataReady()
	{
		return false;
	}

	public virtual EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public virtual List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	public virtual bool OverwriteBackButtonLogic()
	{
		return false;
	}

	public void OnBackButtonClick(object[] param)
	{
	}

	public virtual bool IgnoreEsc()
	{
		return false;
	}

	public override void BeforeScreenshot()
	{
	}

	protected void HideAllNavigation()
	{
	}

	protected void ShowAllNavigation()
	{
	}

	public override void AfterScreenshot()
	{
	}

	protected virtual void OnHelpButtonClick(object[] param)
	{
	}

	public void NaviPageReposition()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}

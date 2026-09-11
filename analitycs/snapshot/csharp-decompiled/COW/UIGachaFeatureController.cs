using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaFeatureController : UIPreviewPopUpWindowController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public UIGachaFeatureController _003C_003E4__this;

		public List<ResourceID> needDownloadResList;

		public CSSharedItemData itemData;

		internal void _003CRefreshDownloader_003Eb__0()
		{
		}
	}

	private sealed class _003CIEChangeBtnLayer_003Ed__131 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaFeatureController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIEChangeBtnLayer_003Ed__131(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public static bool IsOpen;

	private UIGachaFeatureView m_View;

	private Transform m_FeatureSubTrans;

	private GameObject m_GroundShadow;

	private CSSharedItemData m_Data;

	private GachaLuckyData m_GachaLuckyData;

	private UIGachaFeatureLuckyController m_GachaFeatureLuckyController;

	private bool m_WeaponCGCanRotate;

	private UI2dCommonController m_2dPreviewitem;

	private UIQuickMessagePreviewController m_QuickMessagePreviewCtrl;

	private Texture2D m_BgTerxture;

	private ItemUtil.ItemShareType m_ShareType;

	private UINewDownloadInfoController m_Downloader;

	private bool m_IsABReady;

	private const float SHRINK_ICON_SIZE_RATIO = 0.8f;

	private UIModelVirtualBrand m_ModelVirtualBrand;

	private bool m_ShowFeatureHasDone;

	private bool m_AnimPaused;

	private GameObject m_BGUIFX;

	private bool m_IsGacha;

	private uint m_GachaID;

	private bool m_IsSuperEmote;

	private uint m_LaunchTagID;

	private uint m_LaunchTagSerialNumber;

	private bool m_IsCommonLaunchTag;

	private UILaunchTagShowController m_LaunchTagShowCtrl;

	private uint m_AsyncLoadPetTicket;

	private bool m_IsGrenade;

	private bool m_IsFinalShot;

	private bool m_HasInitFinalShotUI;

	private GameObject m_FinalShotBooyahUI;

	private UIMaleAvatar m_PausedPreviewAvatar;

	private GameObject m_PausedPreviewModelRoot;

	private readonly List<AvatarTimelineSync> m_PausedPreviewAvatarTimelineSyncs;

	private const uint DAPP_ITEM_ID = 907105157u;

	private const uint DAPP_ITEM_ID_2 = 907105222u;

	private GameObject m_LuckyVFX;

	private bool m_HasSendLuckyLog;

	private static readonly Vector3 LuckyContainerContentOffset;

	private static readonly string Anim_Purple_Enter;

	private static readonly string Anim_Purple_Skip;

	private static readonly string Anim_Purple_Loop;

	private static readonly string Anim_Orange_Enter;

	private static readonly string Anim_Orange_Skip;

	private static readonly string Anim_Orange_Loop;

	private static readonly string Anim_Red_Enter;

	private static readonly string Anim_Red_Skip;

	private static readonly string Anim_Red_Loop;

	private static readonly string Anim_Purple_Enter_LaunchTag;

	private static readonly string Anim_Purple_Loop_LaunchTag;

	private static readonly string Anim_Orange_Enter_LaunchTag;

	private static readonly string Anim_Orange_Loop_LaunchTag;

	private static readonly string Anim_Red_Enter_LaunchTag;

	private static readonly string Anim_Red_Loop_LaunchTag;

	private static readonly string Anim_LaunchTagSp;

	private static readonly string Anim_LaunchTagCommon;

	public Action m_CloseAction;

	private bool m_UsingPreviewComponent;

	private bool ShowLaunchTag => false;

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	private static bool IsEmoteWithAnimationCamera(CSSharedItemData data)
	{
		return false;
	}

	public override UIFrontEndPreviewController GetFrontEndPreviewUIController()
	{
		return null;
	}

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

	private void InitButtonBg()
	{
	}

	public void ShowELSButtonBg()
	{
	}

	public void ShowLaunchTagFeatureView(uint itemID, ItemUtil.ItemShareType shareType, GachaLuckyData gachaLuckyData = null, uint launchTagSeriesNumber = uint.MaxValue, bool isGacha = false, uint chestID = 0u)
	{
	}

	private void TryShowScreenShotCDNBg()
	{
	}

	private void TryHideScreenShotCDNBg()
	{
	}

	private void SetPreviewCameraVisible(bool visible)
	{
	}

	public void ShowFeatureView(uint itemID, ItemUtil.ItemShareType shareType, GachaLuckyData gachaLuckyData = null, bool isGacha = false, uint chestID = 0u)
	{
	}

	private void LoadCongratulation()
	{
	}

	private void RefreshBg()
	{
	}

	private void TryPreDownloadScreenShotBg()
	{
	}

	private bool CanUsePreviewComponent()
	{
		return false;
	}

	private void CreateFeatureByPreviewComponent()
	{
	}

	private void TryCreateFinalShotBooyahUI()
	{
	}

	private void EnsureFinalShotBooyahUIActive()
	{
	}

	private void ShowPreviewByPreviewComponent()
	{
	}

	private void CreateFeature()
	{
	}

	private void OnShowFeature()
	{
	}

	private void ShowGachaLuckyView()
	{
	}

	private void SetGotNewContentLuckyOffset(bool hasLucky)
	{
	}

	private void SetGotNewContentVisible(bool visible)
	{
	}

	private void ShowGachaLuckyEnterVFX()
	{
	}

	private void TryShowLuckyWheelShareInfo()
	{
	}

	private void TryShowAvatarInfo()
	{
	}

	private void TryGetFrontEndPreviewFeatureTargets(out UIMaleAvatar avatar, out GameObject modelRoot)
	{
		avatar = null;
		modelRoot = null;
	}

	private bool Is2DCollectionItem()
	{
		return false;
	}

	private void SetupNonPreviewFeatureItemUI()
	{
	}

	private void RefreshDownloader()
	{
	}

	private bool CheckItemABReady(uint itemID)
	{
		return false;
	}

	private void OnFeatureModelCreated()
	{
	}

	private bool IsNeedDisablePauseReplayItem(uint itemid)
	{
		return false;
	}

	private void EnablePauseReplay()
	{
	}

	private bool EnablePauseReplay(uint itemid)
	{
		return false;
	}

	private void OnOKBtnClick()
	{
	}

	public void OnShareBtnClick()
	{
	}

	private void OnScreenShotClose()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void SetShareUIVisiable(bool isScreenShot)
	{
	}

	public override void OnNavigationBack()
	{
	}

	protected override void OnRecoverPreview()
	{
	}

	private void AdjustBGScale()
	{
	}

	private void ShowTagTable()
	{
	}

	private void SetLeftLabels()
	{
	}

	private void UpdateViewInfo()
	{
	}

	public void OnMaskClick()
	{
	}

	private void OnPauseResumeBtnClick()
	{
	}

	private void OnPauseResumeBtnClickByPreviewComponent()
	{
	}

	private void PauseResumePreviewComponentTargets(bool pause)
	{
	}

	private void PauseResumeAvatarEffectVFX(UIMaleAvatar avatar, bool pause)
	{
	}

	private void ResumePausedFeatureResources()
	{
	}

	private void OnReplayBtnClick()
	{
	}

	private void OnReplayBtnClickByPreviewComponent()
	{
	}

	public void ShowIPTag()
	{
	}

	private void ShowVirtualBrandTag()
	{
	}

	private void ChangeLayer(Transform trans, string targetLayer)
	{
	}

	private void ChangeNewCollectionTipsBoxLayer(string layer)
	{
	}

	private void Destroy3DModel()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void CreateShadow(uint itemID)
	{
	}

	private IEnumerator IEChangeBtnLayer()
	{
		return null;
	}

	private void OnOptionalDownloadPopWindowClose(object[] data)
	{
	}

	private bool NeedHideShareBtn()
	{
		return false;
	}

	private void RefreshTakePhotoBtn()
	{
	}

	private void OnGotoPhotoBtnClick()
	{
	}

	private bool IsVoicePackageItem(uint itemId)
	{
		return false;
	}

	private void CreateQuickMessagePreview()
	{
	}

	private Vector3 GetVoicePackagePreviewScale()
	{
		return default(Vector3);
	}

	private Color[] VoicePackageParseColorSet(string colorStr)
	{
		return null;
	}

	private Color VoicePackageParseColor(string colorStr)
	{
		return default(Color);
	}

	private string VoicePackageGetCDNLink(int itemIdsCount, string item_cdn_link, string bundle_cdn_link)
	{
		return null;
	}

	private string VoicePackageGetDefaultCDNLink(bool isSingleItem)
	{
		return null;
	}

	private void _003CRefreshBg_003Eb__74_0()
	{
	}

	private void _003CRefreshBg_003Eb__74_1()
	{
	}

	public UIFrontEndPreviewController _003C_003EiFixBaseProxy_GetFrontEndPreviewUIController()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationBack()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRecoverPreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}

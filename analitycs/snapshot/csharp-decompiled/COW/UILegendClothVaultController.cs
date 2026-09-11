using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILegendClothVaultController : UINavigationController, IUIModelDataChangeObserver
{
	public enum ShowingSubPage
	{
		Main,
		ColorPanelPage,
		Feature
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__75_0;

		internal void _003COnBtnConfirmClick_003Eb__75_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public List<ResourceID> listResNeedDownload;

		public UILegendClothVaultController _003C_003E4__this;

		public string title;

		internal void _003CRefreshDownloadState_003Eb__0()
		{
		}
	}

	private sealed class _003CMoveAvatar_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILegendClothVaultController _003C_003E4__this;

		public float x;

		public float uix;

		public float bgx;

		public bool isShowLoopVFXAfterMove;

		private Vector3 _003Cpos_003E5__2;

		private Vector3 _003CpanelPos_003E5__3;

		private float _003CcdnPosX_003E5__4;

		private float _003CminDeltaX_003E5__5;

		private int _003CminDeltaUIX_003E5__6;

		private float _003CmovePerFrame_003E5__7;

		private int _003CpanelMovePerFrame_003E5__8;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMoveAvatar_003Ed__83(int _003C_003E1__state)
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

	private UILegendClothVaultView m_View;

	private UIModelInventory m_ModelInventory;

	private UIModelAvatar m_ModelAvatar;

	private LegendClothVaultPageType m_PageType;

	private LegendClothVaultIntroductionSubType m_SubType;

	private uint m_LegendId;

	private bool m_IsMatchGender;

	private bool m_IsBothGender;

	private LegendClothVaultSexChangeType m_SexChangeType;

	private const float MoveLeftPixel = -0.35f;

	private const float MiddlePixel = 0.15f;

	private const float MoveLeftPixelUI = -200f;

	private const float MiddlePixelUI = 94f;

	private const float MoveLeftPixelBG = -294f;

	private const float MiddlePixelBG = 0f;

	private const int DefaultShowLegendType = 1;

	private const uint InvalidClothId = 0u;

	private const uint DefaultAvatarIdFemale = 101000018u;

	private const uint DefaultAvatarIdMale = 102000007u;

	private const string HasSeenEnterVFXKey = "HasSeenEnterVFX_{0}_{1}";

	private uint m_ChoosingColorLevel;

	private GameObject m_GoMixCamera;

	private UIMaleAvatar m_Avatar;

	private Vector2 m_BgCdnSceneSize;

	private Vector3 m_AvatarLeftPos;

	private Vector3 m_AvatarMidPos;

	private UIModelAvatarBase.EWardrobeType m_ChoosingWardrobeType;

	private Dictionary<int, UILegendClothVaultSlotItemController> m_SlotItems;

	private Dictionary<int, UISprite> m_DictSlotSpriteCurrentColor;

	private UITexture m_BgCdnTexture;

	private Coroutine m_MovingAvatarCoroutine;

	private ShowingSubPage m_CurrentSubPage;

	private static List<string> UI3DOBJECT_NAMES;

	private UINewDownloadInfoController m_DownloadCtrl;

	private HashSet<ResVersionInfo.FileInfo> m_NeedDownloadFileInfoList;

	private UIStandardItemMiniController m_StandardItemCtrl;

	private List<LegendClothPrivilege> m_LegendClothPrivilegeList;

	private uint m_GoPos;

	private string m_SubGopos;

	private bool m_NeedLegendClothOptionDownLoad;

	private bool m_IsHideAvatar;

	private UILoadingCardController m_LoadingCardCtrl;

	private UILaunchTagFrameController m_LaunchTagCtrl;

	private LegendClothVaultFeature m_CurFeatureType;

	private LegendClothPrivilege m_CurFeatureData;

	private LegendClothData m_BaseClothData;

	private bool m_IsUsingGachaCustomizedBackground;

	private uint m_CurCustomizedBackgroundType;

	private UIGachaContentCustomizedBackgroundBaseController m_GachaCustomizedBackgroundCtrl;

	private GameObject m_SwitchVFX;

	private uint m_EndPreviewPrivilegeDelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void SetCdnPosX(float x)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetData(LegendClothVaultPageType pageType, uint legendId = 1u, LegendClothVaultIntroductionSubType subType = LegendClothVaultIntroductionSubType.Default)
	{
	}

	private void RefreshView()
	{
	}

	private void InitAvatarAndCamera()
	{
	}

	private void InitAvatar()
	{
	}

	private uint GetPreviewAvatarID()
	{
		return 0u;
	}

	private void PrepareSlotItems()
	{
	}

	private void PrepareSlotItem(UIModelAvatarBase.EWardrobeType wardrobeType)
	{
	}

	private bool IfMatchGender()
	{
		return false;
	}

	private bool IfBothGender()
	{
		return false;
	}

	private void RefreshColorPanelColors(List<LegendClothData> data)
	{
	}

	private void RefreshColorPanelUnlockRank(uint level)
	{
	}

	private void OnBtnColorPanelClick()
	{
	}

	private void OnBtnHideColorPanelClick()
	{
	}

	private void OnBtnPurchaseClick()
	{
	}

	private void OnBtnObtainClick()
	{
	}

	private void OnBtnConfirmClick()
	{
	}

	private bool CheckHaveHadAllSlotClothes()
	{
		return false;
	}

	private void OnFeatureShow(object[] data)
	{
	}

	private void SetFeatureDescData(LegendClothVaultFeature featureType, LegendClothPrivilege featureData)
	{
	}

	private void SetBottomRightState(LegendClothPrivilege featureData)
	{
	}

	private void MoveAvatarLeft()
	{
	}

	private void MoveAvatarMiddle(bool isShowLoopVFXAfterMove = false)
	{
	}

	private void SetAvatarPos(float x, float uix, float bgx, bool instant = false, bool isShowLoopVFXAfterMove = false)
	{
	}

	private IEnumerator MoveAvatar(float x, float uix, float bgx, bool isShowLoopVFXAfterMove = false)
	{
		return null;
	}

	private void SwitchPage(ShowingSubPage showType)
	{
	}

	private void SetAvatarPos(bool inputEnable, bool resetRotation)
	{
	}

	private void RefreshPropertyContainer()
	{
	}

	private void OnBtnSlotChooseClick(object[] data)
	{
	}

	private void TakeOnAll(int level = 0)
	{
	}

	private void RefreshColorPanelSlotAllCurrentColor()
	{
	}

	private void CheckWearingAndTakeOnByLevel(UIModelAvatarBase.EWardrobeType slot, int level)
	{
	}

	private void TakeOnByLevel(UIModelAvatarBase.EWardrobeType slot, int level)
	{
	}

	private void TakeOnById(UIModelAvatarBase.EWardrobeType slot, uint itemId, int level)
	{
	}

	private void RefreshShowingPreviewAvatarCloth()
	{
	}

	private void RefreshSlotPanel()
	{
	}

	private void OnBtnSlotCancelClick(object[] data)
	{
	}

	private void OnAnimExit(object[] data)
	{
	}

	private void TakeOff(UIModelAvatarBase.EWardrobeType slot)
	{
	}

	private bool CheckHaveWearing()
	{
		return false;
	}

	private void RefreshConfirmBtn()
	{
	}

	private void OnSwitchColor(object[] data)
	{
	}

	private void OnBtnColorPanelComponentHairClick()
	{
	}

	private void OnBtnColorPanelComponentFaceClick()
	{
	}

	private void OnBtnColorPanelComponentHeadAdditiveClick()
	{
	}

	private void OnBtnColorPanelComponentChestClick()
	{
	}

	private void OnBtnColorPanelComponentLegsClick()
	{
	}

	private void OnBtnColorPanelComponentFeetClick()
	{
	}

	private void OnBtnColorPanelComponentAllClick()
	{
	}

	public void OnGotoCharaBtnClick()
	{
	}

	private void OnGotoVaultBtnClick()
	{
	}

	private void OnShowMvpAnimBtnClick()
	{
	}

	private void OnSexChangeBtnClick()
	{
	}

	private void CloseAction()
	{
	}

	private void PickChoosingWardrobeType(UIModelAvatarBase.EWardrobeType choosingType)
	{
	}

	private void RefreshColorPanelComponentStates()
	{
	}

	private void RefreshColorPanelColorStates()
	{
	}

	private bool SlotHaveItem(UIModelAvatarBase.EWardrobeType slotType)
	{
		return false;
	}

	private void RefreshRankDescState()
	{
	}

	private bool IsWearingWardrobeAtSlot(UIModelAvatarBase.EWardrobeType slotType)
	{
		return false;
	}

	public void ShowMotionWithAnimAvatar(uint id, bool needShowAnimAvatar = true, bool isCheckLowestDisplay = true, bool playIdleAlternate = true)
	{
	}

	private void OnAvatarInitReady(bool isLocal)
	{
	}

	public void HideAvatar()
	{
	}

	public void RecoverAvatar()
	{
	}

	public void ShowLoadingCardAndHideAvatar(uint cardId)
	{
	}

	public void ReCoverAvatarAndHideLoadingCard()
	{
	}

	public void RefreshlaunchTag(uint legendId)
	{
	}

	private void RefreshBgVFX()
	{
	}

	private void RefreshTitle()
	{
	}

	private void RefreshDownloadState(string title)
	{
	}

	private void RefreshGachaCustomizedBackground(uint type)
	{
	}

	private UIGachaContentCustomizedBackgroundBaseController SetEclipseCustomizedBackground()
	{
		return null;
	}

	private void HideUIContent()
	{
	}

	private void ShowUIContent()
	{
	}

	private void TryShowSkipPanel()
	{
	}

	private void ShowLoopVFX()
	{
	}

	private void ShowSwitchVFX()
	{
	}

	private void EndPreviewPrivilege(bool isDelay = false)
	{
	}

	private void OnGachaCustomizedBackgroundMaskBtnClick()
	{
	}

	private bool _003COnNavigationShowed_003Eb__56_0(AdvertDesc x)
	{
		return false;
	}

	private bool _003CSetData_003Eb__60_0(AdvertDesc x)
	{
		return false;
	}

	private void _003CRefreshTitle_003Eb__128_0()
	{
	}

	private void _003CEndPreviewPrivilege_003Eb__137_0()
	{
	}

	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}

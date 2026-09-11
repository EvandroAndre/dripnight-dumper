using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UMA;
using UnityEngine;
using UnityEngine.Events;
using proto;

namespace COW;

public class UIIPCollabController : UIPreviewNavigationController, IEasyList, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BundleShowData, uint> _003C_003E9__114_0;

		internal uint _003COnGotoBtnClick_003Eb__114_0(BundleShowData item)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public IPCollabTabData tabData;

		public UIIPCollabController _003C_003E4__this;

		internal void _003CInitLeftTab_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_1
	{
		public CollabDesc subTab;

		public _003C_003Ec__DisplayClass59_0 CS_0024_003C_003E8__locals1;

		internal void _003CInitLeftTab_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public UIIPCollabController _003C_003E4__this;

		public uint IPCollabID;

		public int index;

		public bool isLastAvatar;

		public UMAData umaData;

		public UnityAction<UMAData> characterUpdatedCallback;

		internal void _003CChangeAvatarMaterial_003Eb__0(UMAData data)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass98_0
	{
		public uint itemID;

		internal bool _003CRefreshWeaponAndAnimationPreview_003Eb__0(uint item)
		{
			return false;
		}
	}

	private sealed class _003CFullScreenMoveCoroutine_003Ed__111 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIIPCollabController _003C_003E4__this;

		public bool isFullScreen;

		private Vector3 _003CcurrentCameraPos_003E5__2;

		private Vector3 _003CcurrentlogoPos_003E5__3;

		private Vector3 _003CtargetCameraPos_003E5__4;

		private Vector3 _003CtargetlogoPos_003E5__5;

		private float _003CminDeltaCamera_003E5__6;

		private int _003CminDeltaLogo_003E5__7;

		private float _003CcameraMovePerFrame_003E5__8;

		private int _003ClogoMovePerFrame_003E5__9;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFullScreenMoveCoroutine_003Ed__111(int _003C_003E1__state)
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

	private UIIPCollabView m_View;

	private UIModelIPCollab m_ModelIPCollab;

	private UIModelWishList m_ModelWishList;

	private UIModelAvatar m_ModelAvatar;

	private UIModelInventory m_ModelInventory;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIStanardDrawTabIPCollalbController m_TabCtrl;

	private UINewDownloadInfoController m_DownloadController;

	private UIIPCollabBottomTabItemController[] m_BottomTabList;

	private uint m_CurrentShowIPID;

	private uint m_CurrentShowIPDetailedType;

	private uint m_CurrentShowItemID;

	private EIPCollabItemType m_CurrentShowItemType;

	private EIPCollabOtherType m_CurrentShowOtherType;

	private CollabDesc m_CurrentCollabDesc;

	private IPLikeState m_CurrentLikeState;

	public UIMaleAvatar m_MaleAvatar;

	private ItemChannelInfo m_TargetItemChannelInfo;

	protected SortedDictionary<uint, UIMaleAvatar> m_IPCollabAvatarDict;

	private List<GameObject> m_SweepVFXList;

	private GameObject m_GoMixCamera;

	private bool m_HasShowPoster;

	private float m_SweepTime;

	private bool m_IsSweepTimeInit;

	private uint m_SweepVFXDelayCallID;

	private uint m_CurrentChangeAvatarIndex;

	private GameObject m_AllCollectionVFX;

	private List<GameObject> m_ClickZoneGameObjectList;

	private List<UIButton> m_ClickZoneButtonList;

	private List<UIWidget> m_ClickZoneWidgetList;

	private List<float> m_SweepUIPositions;

	private List<ResourceID> m_NeedDownloadResList;

	private HashSet<uint> m_HasDownloadIPCollabIDList;

	private UIIPCollabDetailTipsController m_DetailTipsCtrl;

	private bool m_IsClosePoster;

	private uint m_LastShowIPAvatarNumber;

	private uint m_LastShowIPCollabID;

	private HashSet<uint> m_HasShowPosterIDList;

	private UILobbyProfileController m_LobbyProfileCtrl;

	private Vector3 m_LogoDefaultPos;

	private Vector3 m_CameraDefaultPos;

	private Vector3 m_CameraFullScreenPos;

	private Coroutine m_FullScreenMoveCoroutine;

	private uint m_LastShowIPID;

	private EIPCollabItemType m_LastShowIPType;

	private uint m_LastShowItemID;

	private bool m_IsLogoPostionInit;

	private bool m_IsFromNavigation;

	private bool m_IsAvatarRefreshing;

	private List<UIIPCollabPosterBgChangeItemController> m_PosterChangeItemList;

	private int m_CurrentPosterIndex;

	private int m_LastPosterIndex;

	private UIFFLogoController m_MainLogoController;

	private UIFFLogoController m_PosterLogoController;

	private EIPCollabItemType m_NavigationShowItemType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void InitState()
	{
	}

	private void InitLeftTab()
	{
	}

	private void InitBottomTab()
	{
	}

	private void InitClickZone()
	{
	}

	private void InitMixCamera()
	{
	}

	private void RefreshAvatar(bool isOptionalDownload = false)
	{
	}

	private void RefreshAllCollectVFX()
	{
	}

	private void OverridePreviewAvatarByGender(List<uint> preview3DList, uint genderShowOn, uint bundleItemId)
	{
	}

	private List<ResourceID> GetNeedDownLoadList(List<uint> itemIds)
	{
		return null;
	}

	private bool CheckIsHaveAllBundle(List<CollabItemDesc> avatarDescList)
	{
		return false;
	}

	private bool CheckIsNotHaveAnyBundle(List<CollabItemDesc> avatarDescList)
	{
		return false;
	}

	private void ClearSweepVFX()
	{
	}

	private void HideAllAvatar()
	{
	}

	private void ShowAvatarAfterSweep(uint IPCollabID)
	{
	}

	private void ChangeAvatarMaterial(UIMaleAvatar MaleAvatar, uint IPCollabID, bool isLastAvatar = false, int index = 0)
	{
	}

	private void ApplyFresnelMaterial(UMAData umaData, uint IPCollabID)
	{
	}

	private void RefreshClickZone(List<Vector3> sweepPosList)
	{
	}

	private void GotoTab(int IPCollabID)
	{
	}

	public void OnGotoBottomTab(EIPCollabItemType type, uint itemID = 0u)
	{
	}

	public void RefreshCurrentItemPreview(uint itemID)
	{
	}

	private void RefreshCurrentItemState(uint itemID)
	{
	}

	private void OnTabSelected(uint IPCollabID)
	{
	}

	private void CheckShowPoster()
	{
	}

	private void RefreshNewIPRedPoint()
	{
	}

	private EIPCollabItemType RefreshBottomTabById(uint IPCollabID)
	{
		return EIPCollabItemType.None;
	}

	private void RefreshAll(uint itemID = 0u)
	{
	}

	private void RefreshPosterContainer()
	{
	}

	private void RefreshPosterPhoto()
	{
	}

	private void RefreshPosterChangeItems(int photoCount)
	{
	}

	private void HidePosterChangeItems()
	{
	}

	public void OnPosterChangeItemClick(int index)
	{
	}

	private bool CheckNeedShowPosterChangeTips()
	{
		return false;
	}

	private void MarkPosterChangeTipsSeen()
	{
	}

	public bool CheckNeedShowDetailChangeSetTips()
	{
		return false;
	}

	public void MarkDetailChangeSetTipsSeen()
	{
	}

	private void RefreshLogo()
	{
	}

	private void RefreshBottomTabSelect()
	{
	}

	private void RefreshBG()
	{
	}

	private void RefreshRightBtnState()
	{
	}

	private void RefreshShowItem(uint itemID = 0u)
	{
	}

	private void RefreshWeaponAndAnimationPreview(uint itemID = 0u)
	{
	}

	private void RefreshOtherItemList()
	{
	}

	private void TempHidePreview()
	{
	}

	private void CloseAvatarPreview()
	{
	}

	private void RefreshLikeBtnState()
	{
	}

	private void OnLikeBtnClick()
	{
	}

	private void OnAvatarZoneClick(int index)
	{
	}

	private void OnBundleSetChanged(object[] data)
	{
	}

	private void RefreshSingleAvatarBundle(int avatarIndex)
	{
	}

	private void PlayBundleSwitchEffect(int avatarIndex, CollabItemDesc defaultDesc)
	{
	}

	private void OnFullScreenBtnClick()
	{
	}

	private void OnRecoverZoneBtnClick()
	{
	}

	private void SetFullScreenState(bool isFullScreen)
	{
	}

	private IEnumerator FullScreenMoveCoroutine(bool isFullScreen)
	{
		return null;
	}

	private void OnPosterBtnClick()
	{
	}

	private void OnPosterCloseBtnClick()
	{
	}

	private void OnGotoBtnClick()
	{
	}

	private void OnBuyBtnClick()
	{
	}

	private void OnOtherSwitchBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void OnPopupWindowListChange()
	{
	}

	private void _003CRefreshAvatar_003Eb__63_0()
	{
	}

	private void _003CRefreshAvatar_003Eb__63_1()
	{
	}

	private void _003CRefreshPosterPhoto_003Eb__85_0()
	{
	}

	private void _003CRefreshLogo_003Eb__93_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}

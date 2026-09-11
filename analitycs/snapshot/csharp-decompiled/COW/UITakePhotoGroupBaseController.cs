using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public abstract class UITakePhotoGroupBaseController : UINavigationController
{
	private sealed class _003C_003Ec__DisplayClass116_0
	{
		public UITakePhotoGroupBaseController _003C_003E4__this;

		public UIFrontEndScene scene;

		internal void _003CApplyBigEventBackGroundTexture_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public UITakePhotoGroupBaseController _003C_003E4__this;

		public int i;

		public Predicate<TakePhotoGroupFriendInfo> _003C_003E9__0;

		internal bool _003COnSelectTemplate_003Eb__0(TakePhotoGroupFriendInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass90_0
	{
		public ulong account_id;

		internal bool _003COnSelectFriend_003Eb__0(TakePhotoGroupFriendInfo x)
		{
			return false;
		}
	}

	protected Camera m_CurTempalteCamera;

	protected Camera GhostCamera;

	protected UITakePhotoFilterController m_FilterCtrl;

	protected UIButton FilterBtn;

	protected UILabel FilterBtnLabel;

	protected GameObject FilterBtnIsOpen;

	protected Transform FilterListContainer;

	protected UIWidget FilterGuideWidget;

	protected UIWidget FilterBtnWidget;

	protected bool IsShow2DObject;

	protected bool BgTextureInitialActive;

	protected uint TemplateType;

	protected ResourceID BgDefaultTextureResId;

	protected UIButton CloseFriendListBtn;

	private bool IsFirstEnter;

	private bool m_SocialAreaBgForcedActive;

	protected SortedDictionary<uint, GroupPhotoAvatar> PosToAvatarDic;

	protected SortedDictionary<uint, string> PosToLayerMask;

	protected Dictionary<uint, List<GameObject>> PosToModelList;

	private SortedDictionary<uint, GroupPhotoAvatar> m_BackupAvatarData;

	private Dictionary<uint, GameObject> TemplatCameraDic;

	private GameObject m_CurrentCamerObj;

	protected GroupPhotoTemplateData m_CurSelectTemplate;

	private Dictionary<uint, UITakePhotoGroupNameController> m_NameCtrlsDic;

	protected bool m_IsShowName;

	protected int m_SelectedPosId;

	protected Transform[] NamePosArray;

	protected UIModelTakePhoto m_ModelPhoto;

	protected UIModelAvatarProfile m_ModelAvatarProfile;

	protected UIModelFriends m_ModelFriend;

	protected UIModelCollectionCustom m_ModelCollectionCustom;

	protected UILabel SelectNumLabel;

	protected List<TakePhotoGroupFriendInfo> m_Friends;

	protected List<GroupPhotoTemplateData> m_TemplateDataList;

	protected bool IsVertical;

	protected UIEasyList FriendEasyList;

	protected GameObject FriendContainer;

	protected UIButton ExpandBtn;

	protected UISprite IsExpandIcon;

	protected UISprite UnExpandIcon;

	protected UILabel IntimacyLabel;

	protected GameObject Line;

	protected bool IsExpand;

	private List<TakePhotoGroupFriendInfo> SpecialFriends;

	protected List<UITakePhotoGroupFriendItemController> m_FriendItemCtrls;

	protected Animation FriendsListAnim;

	protected bool IsSeasonReplay;

	protected bool IsSeasonReplayBR;

	protected bool IsSquadTreasure;

	protected uint SeasonReplayTab;

	protected uint SelectedTemplateId;

	protected List<ulong> SelectedFriendIds;

	protected Dictionary<ulong, List<SeasonReplayFriendData>> m_AccountId2SocialReplayDataDic;

	protected List<UIEditableIconBaseController> m_EditableBackGroundList;

	protected List<GameObject> m_TemplateModelList;

	protected TakePhotoGroupExtraData m_ExtraData;

	protected uint m_PreviewBackGroundId;

	protected Vector3 m_PreviewBackGroundOffectPosition;

	protected Vector2 m_PreviewBackGroundSize;

	protected UINetworkTexture m_SceneBgNetWorkTexture;

	protected Dictionary<uint, UITakePhotoGroupNameController> NameCtrlsDic => null;

	protected override void OnUIInit()
	{
	}

	protected virtual void OnTakePhotoBtnClick(object[] objects)
	{
	}

	public virtual void OnExpandBtn()
	{
	}

	public void ExpandFriendList(bool isIn, bool isSkip = false)
	{
	}

	protected abstract string GetExpandFriendAnim(bool isIn);

	public void RefreshExpandIcon()
	{
	}

	protected void AddFriendItemCtrl(UITakePhotoGroupFriendItemController ctrl)
	{
	}

	protected void RefreshFriendIsSelectNext()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public bool IsFromLobbyEmotePanel()
	{
		return false;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void ShowHideAvatarCamera(bool show)
	{
	}

	public void Refresh()
	{
	}

	protected void RefreshExpand(bool isShow)
	{
	}

	protected virtual void ShowFriendList()
	{
	}

	protected virtual void HideFriendList()
	{
	}

	protected abstract void InitView();

	public void RefreshFriends(bool show)
	{
	}

	protected void RefreshNameCtrlPos()
	{
	}

	public void SaveSelectedFriendData(ulong accountId, List<SeasonReplayFriendData> dataList)
	{
	}

	public List<SeasonReplayFriendData> GetSelectedFriendData(ulong accountId)
	{
		return null;
	}

	private void RefreshNameCtrlsSelect()
	{
	}

	private UITakePhotoGroupNameController GetNameCtrl(uint pos_id)
	{
		return null;
	}

	public void RefreshCloths()
	{
	}

	public virtual void OnSelectBackGround(PhotoEditBackgroundData backGroundData)
	{
	}

	public virtual void OnSelectTemplate(GroupPhotoTemplateData templateData)
	{
	}

	public void RecycleAvatar(uint pos_id)
	{
	}

	public bool CheckIsSelelct(ulong account_id, ref uint pos_id)
	{
		return false;
	}

	public void RefreshCamera()
	{
	}

	public void RefreshAllAvatar(bool isFromAvatarProfileGot = false)
	{
	}

	public void RefreshAvatar(uint pos_id, bool isFromAvatarProfileGot = false)
	{
	}

	private void TryApplyLocalAvatarTransformer(GroupPhotoAvatar target, uint pos_id)
	{
	}

	public virtual void OnSelectFriend(ulong account_id)
	{
	}

	private int GetNextSelectPosId(int curPosId)
	{
		return 0;
	}

	protected void RefreshSelectNum()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected void RecycleAll()
	{
	}

	public void RecycleAllAvatars()
	{
	}

	public void OnHideNameCtrlsBtn(bool show)
	{
	}

	public void OnExChangeBtn(uint pos_id)
	{
	}

	public uint GetSelfPosId()
	{
		return 0u;
	}

	public void OnPlusBtn(uint pos_id)
	{
	}

	public void OnSwitchBtn(uint pos_id)
	{
	}

	private void UpdateSelectedPosId(int pos_id)
	{
	}

	public void OnDeleteBtn(uint pos_id)
	{
	}

	public override void AfterScreenshot()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public string GetGoposFromStr()
	{
		return null;
	}

	public List<uint> GetSocialRelationList()
	{
		return null;
	}

	public uint GetCurrentTemplateId()
	{
		return 0u;
	}

	public List<ulong> GetGroupPhotoAccountIds()
	{
		return null;
	}

	public void HideAllNamePos()
	{
	}

	public virtual void OnSelectBigEventBackGround(PhotoBackGroundData backGroundData)
	{
	}

	public virtual uint GetCurrentBigEventBackGroundId()
	{
		return 0u;
	}

	public void ApplyBigEventBackGroundTexture(PhotoBackGroundData backgroundData)
	{
	}

	public void CreateDefaultFemaleAvatarsForNotOwnedTemplate(uint start, uint end)
	{
	}

	private void BackupCurrentAvatarData()
	{
	}

	private void RestoreBackupAvatarData()
	{
	}

	private void OnPhotoGroupTabClick(uint tabType)
	{
	}

	private void DestroyTemplateModel()
	{
	}

	protected void RefreshTemplateModel()
	{
	}

	private void DestroyPosModel(uint posId)
	{
	}

	protected void RefreshPosModelWhenAvatarChange()
	{
	}

	private void DestroyAllModel()
	{
	}

	private void ShowAllModel(bool show)
	{
	}

	public override void OnShare(bool success, int platform)
	{
	}

	protected virtual void OnFilterBtnClickGroup()
	{
	}

	protected virtual void ShowFilterWnd()
	{
	}

	public void HideFilterBtn()
	{
	}

	public void TryInitCameraForFilter(Camera camera)
	{
	}

	public virtual void HideFilterIsOpen()
	{
	}

	private void ShowFilterGuide()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShare(bool P0, int P1)
	{
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using Spine.Collections;
using UnityEngine;
using proto;

namespace COW;

public class UISeasonReplaySocialController : UIBaseController, IUISeasonReplayItem, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__82_0;

		internal void _003CRefreshPoseDownloading_003Eb__82_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass73_0
	{
		public SeasonReplayFriendData data;

		internal bool _003CRefreshLike_003Eb__0(ulong id)
		{
			return false;
		}
	}

	private sealed class _003CPlayInAnim_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISeasonReplaySocialController _003C_003E4__this;

		public bool isFirstEnter;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayInAnim_003Ed__75(int _003C_003E1__state)
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

	private UISeasonReplaySocialView m_View;

	private UIModelSeasonReplay m_ModelSeasonReplay;

	private UIModelProfile m_ModelProfile;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private List<UISeasonReplaySocialItemController> m_FriendList;

	private List<SeasonReplayFriendData> m_FriendListData;

	private List<UISeasonReplaySocialSocialTabController> m_SocialTabCtrlList;

	private List<UISeasonReplaySocialSocialTagController> m_SocialTagCtrlList;

	private UINewDownloadInfoController m_DownloadInfoController;

	private OrderedDictionary<uint, List<List<SeasonReplayFriendData>>> m_RelationToFriendShowDataDic;

	private Dictionary<ulong, SeasonReplaySocialGroupPhotoAvatar> m_AccountIDToAvatarDic;

	private List<UIMaleAvatar> m_CreatedAvatar;

	private ESeasonReplaySocialRelationTag m_SeasonReplaySocialRelationTag;

	private GroupPhotoTemplateData m_PhotoTemplateData;

	private static List<string> LayerMaskList;

	public const uint MaxShowCount = 3u;

	public const uint SocialDuoPhotoTemplateId = 928005102u;

	public const uint SocialDuoNegativePhotoTemplateId = 928005106u;

	public const uint SocialTriplePhotoTemplateId = 928005103u;

	public const uint SocialSquadPhotoTemplateId = 928005105u;

	public const uint SocialSquadWorshipPhotoTemplateId = 928005108u;

	public bool m_IsV2;

	private bool m_PoseReady;

	private bool m_AvatarProfileReady;

	private GameObject m_PoseCamera;

	private bool m_IsBR;

	private bool m_IsLoneWolf;

	private bool m_BrrimOn;

	private Color CenterBGSelectedColor;

	private Color CenterBGUnSelectedColor;

	private const string OutAnimStr = "UIFX_UISeasonReplaySocial_NormalContainer_Out";

	private const string V2OutAnimStr = "UIFX_UISeasonReplaySocial_NormalV2Container_Out";

	private const string InAnimStr = "UIFX_UISeasonReplaySocial_NormalContainer_In";

	private const string V2InAnimStr = "UIFX_UISeasonReplaySocial_NormalV2Container_In";

	private const string ClickAnimStr = "UIFX_UISeasonReplaySocial_NormalContainer_Click";

	private const string LonelyOutAnimStr = "UIFX_UISeasonReplaySocial_LoneWolfContainer_Out";

	private const string LoneLyInAnimStr = "UIFX_UISeasonReplaySocial_LoneWolfContainer_In";

	private const string SeasonReplayTakePhotoBubbleKey = "SeasonReplayTakePhotoBubbleKey";

	public const string SeasonReplayTakePhotoHudBubbleKey = "SeasonReplayTakePhotoHudBubbleKey";

	private uint m_Ticket_SEASONREPLAYSOCIALNORMAL_UIFX;

	private uint m_Ticket_SEASONREPLAYSOCIALLONEWOLF_UIFX;

	private int m_CurrentSelectIdx;

	private int m_PreSelectIdx;

	private UICSRankIconController m_CSRankIconController;

	private UIBRRankIconController m_BRRankIconController;

	private Color PositiveLabelTopCol;

	private Color PositiveLabelBottomCol;

	private Color PositiveLabelLineCol;

	private Color NegativeLabelTopCol;

	private Color NegativeLabelBottomCol;

	private Color NegativeLabelLineCol;

	private Color PositiveLine12Col;

	private Color PositiveLine34Col;

	private Color PositiveBgCol;

	private Color NegativeLine12Col;

	private Color NegativeLine34Col;

	private Color NegativeBgCol;

	private List<UISprite> m_ViewBgList;

	private Vector2 DragStartPos;

	private UISprite[] m_CenterBGArray;

	private UISeasonReplayController Parent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void EnableBRRIMON()
	{
	}

	public void ResetBRRIMON()
	{
	}

	private void SocialGuidelShow(object[] data)
	{
	}

	private void OnScorllBtnDragStart(GameObject go)
	{
	}

	private void OnScorllBtnButtonEnd(GameObject go)
	{
	}

	private void OnScorllBtnClick(GameObject go)
	{
	}

	private void OnAsyncLoadResFinished(uint ticket, bool success, UnityEngine.Object obj)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void RefreshLike(SeasonReplayFriendData data)
	{
	}

	public void Selected(bool isFirstEnter)
	{
	}

	private IEnumerator PlayInAnim(bool isFirstEnter)
	{
		return null;
	}

	public void ShowPose()
	{
	}

	public void HidePose()
	{
	}

	public void UnSelected()
	{
	}

	public void OnSocialTabClick(ESeasonReplaySocialRelationTag tag)
	{
	}

	private void RefreshSocialTags()
	{
	}

	private void RefreshCamera()
	{
	}

	private void RefreshPoseDownloading()
	{
	}

	private void RefreshAllAvatar()
	{
	}

	private void RefreshAvatarClothes(ulong accountId)
	{
	}

	public void HideView()
	{
	}

	public void HidePreview()
	{
	}

	public void RecoverPreview()
	{
	}

	public void RefreshDataView()
	{
	}

	private bool IsPositive(EFriend.SeasonReplayFriendTag tag)
	{
		return false;
	}

	private void RefreshPositiveNegativeView(EFriend.SeasonReplayFriendTag tag)
	{
	}

	public void OnLikeBtnClick()
	{
	}

	private void OnSummaryBtnClick()
	{
	}

	private void OnTakePhotoBtnClick()
	{
	}

	private void ProcessFriendListData(ESeasonReplaySocialRelationTag tag)
	{
	}

	public void Init(bool isBR)
	{
	}

	private void ShowGuide()
	{
	}

	public CombineScreenshotData BeforeCombineShare()
	{
		return default(CombineScreenshotData);
	}

	public void AfterCombineShare()
	{
	}

	public void PrepareControllerBeforeScreenshot()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

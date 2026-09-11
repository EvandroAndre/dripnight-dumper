using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISeasonReplaySocialSocialTagController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public List<SeasonReplayFriendData> newSortList;

		public int i;

		public Predicate<SeasonReplayFriendData> _003C_003E9__0;

		internal bool _003COnChangeBtnClick_003Eb__0(SeasonReplayFriendData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_1
	{
		public SeasonReplayFriendData data;

		internal bool _003COnChangeBtnClick_003Eb__1(SeasonReplayFriendData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public SeasonReplayFriendData data;

		internal bool _003CSetTakePhotoGroupViewData_003Eb__0(SeasonReplayFriendData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public UISeasonReplaySocialSocialTagController _003C_003E4__this;

		public List<ResourceID> resList;

		internal void _003CRefreshDownload_003Eb__0()
		{
		}
	}

	private sealed class _003CDelayRelationsRepos_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISeasonReplaySocialSocialTagController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRelationsRepos_003Ed__36(int _003C_003E1__state)
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

	private sealed class _003CIE_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UITable table;

		public UIScrollView scrollview;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIE_003Ed__28(int _003C_003E1__state)
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

	private UISeasonReplaySocialSocialTagView m_View;

	private List<UISeasonReplaySocialSocialTagItemController> m_TagItemCtrlList;

	private List<UISeasonReplaySocialSocialTagPopUpItemController> m_PopItemCtrlList;

	private UINewDownloadInfoController m_DownloadInfoController;

	private bool m_IsBR;

	private bool m_IsLeft;

	private bool m_IsSelf;

	private bool m_IsTakePhoto;

	private bool m_IsSave;

	private uint m_MaxTakephotoShowCount;

	private SeasonReplaySocialGroupPhotoAvatar m_ReplayGroupPhotoAvatar;

	private GroupPhotoAvatar m_GroupPhotoAvatar;

	private GroupPhotoTemplatePoseData m_GroupPhotoTemplatePoseData;

	private List<SeasonReplayFriendData> m_TempSelectDataList;

	private List<SeasonReplayFriendData> m_CurrentFriendDataList;

	private ulong m_AccountId;

	private List<ResourceID> m_DownloadList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public List<uint> GetCurrentShowRelationList()
	{
		return null;
	}

	public void BeforeReplayScreenshot()
	{
	}

	public void AfterReplayScreenshot()
	{
	}

	private void OnSocialTagCollapse()
	{
	}

	private void OnLiked(object[] param)
	{
	}

	private void OnLikeBtnClick()
	{
	}

	private void OnEditorSaveBtnClick()
	{
	}

	private void OnSpecialLikeBtnClick()
	{
	}

	public void OnChangeBtnClick()
	{
	}

	private IEnumerator IE(UITable table, UIScrollView scrollview)
	{
		return null;
	}

	public bool OnSelectBtnClick(SeasonReplayFriendData data, bool select)
	{
		return false;
	}

	private void ResetAllPopUpItems()
	{
	}

	public void SetViewData(SeasonReplaySocialGroupPhotoAvatar photoAvatar, GroupPhotoTemplatePoseData poseData, bool isBR, bool isSelf, bool isSpecialLike, bool isPoseReady)
	{
	}

	public void SetTakePhotoGroupViewData(GroupPhotoAvatar photoAvatar, GroupPhotoTemplatePoseData poseData, ulong accountID, bool isBR, uint seasonReplayTab, int poseCount, List<SeasonReplayFriendData> selectedDataList = null)
	{
	}

	private void SaveSelectedFriendData()
	{
	}

	private void RefreshDownload(List<ResourceID> resList)
	{
	}

	private void RefreshUI(bool isSelf, bool isSpecialLike)
	{
	}

	private IEnumerator DelayRelationsRepos()
	{
		return null;
	}

	private void RefreshPose(bool isPoseReady)
	{
	}

	public void SetPoseReady()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private bool _003COnLiked_003Eb__23_0(ulong id)
	{
		return false;
	}

	private bool _003COnLikeBtnClick_003Eb__24_0(ulong id)
	{
		return false;
	}

	private bool _003COnSpecialLikeBtnClick_003Eb__26_0(ulong id)
	{
		return false;
	}

	private bool _003CRefreshUI_003Eb__35_0(ulong id)
	{
		return false;
	}

	private void _003CRefreshPose_003Eb__37_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

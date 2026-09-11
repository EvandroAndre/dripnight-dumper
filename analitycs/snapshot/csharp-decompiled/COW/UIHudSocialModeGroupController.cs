using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class UIHudSocialModeGroupController : UIBaseController, IUIModelDataChangeObserver
{
	public enum SocialModeGroupItemState
	{
		InSameGame = 1,
		InSocial,
		InTrain,
		InLobby,
		InSocialLobby
	}

	public class SocialModeGroupItemData
	{
		public bool isLeader;

		public GroupMemberInfo info;

		public SocialModeGroupItemState state;
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public GroupInfo groupInfo;

		internal bool _003CRefreshView_003Eb__0(SocialModeGroupItemData x)
		{
			return false;
		}
	}

	private sealed class _003CShowItem_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudSocialModeGroupController _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowItem_003Ed__25(int _003C_003E1__state)
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

	private const uint VISIBILITY_STATE_CAMERAMODE = 1073741824u;

	private UIHudSocialModeGroupView m_View;

	private UIModelGroup m_ModelGroup;

	private List<UIHudSocialModeGroupItemController> m_MemberControllerList;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private UIHudSwitchLobbyContainerController m_UIHudSwitchLobbyContainerController;

	private bool m_IsShowLobbyContainer;

	private List<SocialModeGroupItemData> m_DataList;

	private float SwitchLobbyContainerPosY;

	private uint MaxScrollVisableCnt;

	private HashSet<ulong> m_CacheGroupMemberSet;

	private bool m_IsMoving;

	private bool m_IsFold;

	private uint m_VisibleItemCnt;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnCameraModeChanged(bool isOpen)
	{
	}

	private void SwitchLobbyContainer()
	{
	}

	private void OnSyncOptionalMapResNtf(object[] data)
	{
	}

	private void ShowTeamInfo()
	{
	}

	private void Update()
	{
	}

	public int SortMembers(SocialModeGroupItemData a, SocialModeGroupItemData b)
	{
		return 0;
	}

	private void OnFoldBtnClick()
	{
	}

	private IEnumerator ShowItem()
	{
		return null;
	}

	public void FoldFromExternal()
	{
	}

	private void SetState(bool state)
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshSwitchLobbyContainerPos(uint count)
	{
	}

	private void RefreshTeamInfo()
	{
	}

	private void UpdateCacheMembers()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}

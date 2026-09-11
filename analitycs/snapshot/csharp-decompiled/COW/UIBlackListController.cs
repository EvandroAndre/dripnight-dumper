using GCommon;
using UnityEngine;

namespace COW;

public class UIBlackListController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	private UIBlackListView m_View;

	private EBlackListTabType m_CurBlackListTabType;

	private UIModelChat m_ChatModel;

	private UIModelFriends m_FriendModel;

	private UIModelMatch m_MatchModel;

	public EBlackListTabType CurBlackListTabType
	{
		get
		{
			return EBlackListTabType.None;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override string Rule()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	private void OnSelectMatchMaking()
	{
	}

	private void OnSelectApplication()
	{
	}

	private void OnSelectChat()
	{
	}

	private void ShowSelectView()
	{
	}

	private void RefreshEasyListView()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

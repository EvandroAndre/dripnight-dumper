using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2LeaderBoardController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	public enum ELeaderBoardType
	{
		BR,
		CS
	}

	private UILobbyV2LeaderBoardView m_View;

	private UIModelLeaderBoard m_ModelBRMatch;

	private UIModelCSLadderMatch m_ModelCSMatch;

	private UIModelMapOpeningInfo m_ModelMapInfo;

	private UILobbyV2LeaderBoardItemController m_SelfItem;

	private ELeaderBoardType _003CLeaderBoardType_003Ek__BackingField;

	public ELeaderBoardType LeaderBoardType
	{
		get
		{
			return _003CLeaderBoardType_003Ek__BackingField;
		}
		private set
		{
			_003CLeaderBoardType_003Ek__BackingField = value;
		}
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

	private void HideAndShowInviteBox()
	{
	}

	private void InitLeaderBoard()
	{
	}

	private void RefreshBRLeaderBoard()
	{
	}

	private void RefreshCSleaderBoard()
	{
	}

	private void RefreshSelfRank(bool showClosedUI = false)
	{
	}

	private void RefreshSelfCSRank(bool showClosedUI = false)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public Vector3 GetBriefBoxPos()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}

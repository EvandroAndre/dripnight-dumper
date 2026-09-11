using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIBaseHudInfoListController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	protected const uint SINGLE_PLAYER_CELL_HEIGHT = 80u;

	protected const uint DUO_PLAYER_CELL_HEIGHT = 150u;

	protected const uint TRIPLE_PLAYER_CELL_HEIGHT = 210u;

	protected const uint QUAD_PLAYER_CELL_HEIGHT = 270u;

	protected const uint PENTA_PLAYER_CELL_HEIGHT = 330u;

	protected const uint SIX_PLAYER_CELL_HEIGHT = 405u;

	protected const uint EIGHT_PLAYER_CELL_HEIGHT = 570u;

	protected const uint TWELVE_PLAYER_CELL_HEIGHT = 810u;

	protected const int SINGLE_PLAYER_ITEM_HEIGHT = 78;

	protected const int MULTI_PLAYER_ITEM_HEIGHT = 58;

	protected UIBaseHudInfoListView m_BaseView;

	protected UIModelSpectator m_Model;

	protected CMDBIPLGLGA m_CurrentGroupMode;

	protected Vector3 m_PlayerGridTransform;

	protected float CELL_WIDTH;

	protected float m_CellHeight;

	protected float m_PlayerPanelHeight;

	protected Vector3 m_MoveRelative;

	protected UIScrollView m_PlayerScrollView;

	private bool m_ShowInfoList;

	protected override void OnUIInit()
	{
	}

	protected void OnHotkeyInfoTabChanged(object[] data)
	{
	}

	protected void AutoscrollToSelectedPlayer(object[] data)
	{
	}

	protected void RefreshAirdropSelected(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected void OnCloseClick()
	{
	}

	protected void OnPlayerTabClick()
	{
	}

	protected void OnAirdropTabClick()
	{
	}

	protected void SetPlayerGridParam()
	{
	}

	protected void RefreshPlayerList()
	{
	}

	protected void RefreshAirdropList()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	protected void ShowHudInfoList(bool value)
	{
	}

	private void OnShowFinished()
	{
	}

	private void OnGlobalEventOpen(bool data)
	{
	}

	private void OnPollEntryOpen(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2LeaderBoardItemController : UIEasyListItemController
{
	private UILobbyV2LeaderBoardItemView m_View;

	private LeaderBoardInfo m_Info;

	private UIBaseProfileInfoController m_BaseProfile;

	private const int m_TopRankThreshold = 3;

	private GameObject[] m_TopCupArray;

	private GameObject[] m_TopBgArray;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetSelfUI(bool showClosedUI = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}

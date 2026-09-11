using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHUDUGC_CheckPointMgrController : UIBaseController, IUIHUDBaseController
{
	private UIHUDUGC_CheckPointMgrView m_View;

	private UGCCheckPointMgrHudRepItem m_ViewData;

	private UIInGameScene m_GameScene;

	private Dictionary<int, UIHUDUGC_CheckPointMarkShowController> m_CheckPointDict;

	private List<UIHUDUGC_CheckPointMarkShowController> m_EndPointList;

	private const int CONST_FirstCheckPointID = 1;

	private string m_EntityID;

	private bool m_IsInit;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected void OnPlayerLastCheckPointIDChange(object[] data)
	{
	}

	protected void OnPlayerNextCheckPointIDChange(object[] data)
	{
	}

	protected void ProcessPlayerCurCheckPointIDChange(int oldID, int newID)
	{
	}

	protected void ProcessPlayerNextCheckPointIDChange(int oldID, int newID)
	{
	}

	private void ShowEndPoints()
	{
	}

	private void HideEndPoints()
	{
	}

	private void AddCheckPointHud(int index)
	{
	}

	private void RemoveCheckPointHud(int index)
	{
	}

	private UGCLevelCheckPoint GetCheckPoint(int id)
	{
		return null;
	}

	private int GetCheckPointCount()
	{
		return 0;
	}

	private Dictionary<uint, BaseLevelObject> GetAllEndPoints()
	{
		return null;
	}

	public void SetEntityID(string entityID)
	{
	}

	public void DestroyEntity()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnShowArriveEndPointTipsChanged(bool old, bool cur)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIMapContenBigItemIconController : UIBaseController
{
	private UIMapContenBigItemIconView m_View;

	private float m_FillAmount;

	private float MAXPROCESS;

	private uint m_UniqueID;

	private InteractiveState m_CurrentState;

	private JFNIEEBCBLD m_BigItemType;

	private MHAHMMCPHOA m_BigItemState;

	private Vector3 m_CacheWorldPos;

	private int m_Time;

	private MutableString m_TextBuilder;

	private uint m_DelayID;

	private float m_DisplayTime;

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

	private void ResetData()
	{
	}

	public void SetViewData(uint uniqueID, JFNIEEBCBLD bigItemType, MHAHMMCPHOA bigItemState, Vector3 worldPos, float displayTime = 5f)
	{
	}

	private void OnEnterInteract(GEvent param)
	{
	}

	public void SetState(InteractiveState state)
	{
	}

	private void ShowIcon(string spriteName)
	{
	}

	public void SetTime(int time)
	{
	}

	public void SetBigItemState(MHAHMMCPHOA bigItemState)
	{
	}

	private void SetGameObjectVisibleByState()
	{
	}

	private void SwitchIcon(bool showDefault = true)
	{
	}

	public void ShowFlashVfx(bool show)
	{
	}

	private void ShowView()
	{
	}

	public bool InLevelObjectState()
	{
		return false;
	}

	public Vector3 GetWorldPos()
	{
		return default(Vector3);
	}

	public void HideArrow()
	{
	}

	public void UpdateDir(Vector3 lookdir)
	{
	}

	public void ShowCountDown(int seconds)
	{
	}

	public uint GetBigItemUniqueID()
	{
		return 0u;
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}

	public void SyncPosition(Vector3 vector3)
	{
	}

	private void HideGameObject()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}

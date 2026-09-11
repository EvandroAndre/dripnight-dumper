using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPlayerMarkController : UIBaseController
{
	private UIHudPlayerMarkView m_View;

	private Vector3 m_pos;

	private BHGGAEEHJCO m_playerId;

	private uint m_posType;

	private int m_playerTeamIndex;

	private int m_PreDistance;

	private float m_showTime;

	private UIHudPlayerMarkWinterlandController m_WinterlandMarkCtrl;

	private uint m_ParachuteLeaderMarkEffect;

	private float m_DefaultInteractingIconX;

	private float m_DefaultInteractingIconY;

	private const string MAP_LOCATION_FOR_REVIVAL_ICON_NAME = "UI_icon_Skyexits";

	private const string MAP_LOCATION_ICON_NAME = "UI_icon_minimap_coordinate";

	private bool m_IsMapLocationForRevival;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnDisableBigMap(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetInfo(BHGGAEEHJCO playerId, int playerTeamIndex, uint posType, Vector3 realPos, EBigMapType bigMapType = EBigMapType.MapTypeNormal)
	{
	}

	private void SetInteractingIconPos(uint posType)
	{
	}

	private void DelayPlayIconAnimation()
	{
	}

	public bool IsLineEffectPosType()
	{
		return false;
	}

	public void UpdatearachuteLeaderMarkEffect(bool b)
	{
	}

	public void SetScale(float scale)
	{
	}

	public void UpdateDis()
	{
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}

	private void ForceHide(object[] data)
	{
	}

	private void ForceHide()
	{
	}

	private void OnMarkObjectStateChanged(object[] data)
	{
	}

	private void ResetPointUI()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class UIHudControlPointPosMarkController : UIHudNameBaseController
{
	public enum MarkType
	{
		EMarkType_Default,
		EMarkType_GuildWar_Generator,
		EMarkType_GuildWar_Warehouse
	}

	private UIHudControlPointPosMarkView m_View;

	private Vector3 m_ControlPointPos;

	private uint m_CurrentPointID;

	private UIModelMatch m_ModelMatch;

	private const int NO_OCCUPY_COLOR = 2130706517;

	private const int LOCAL_OCCUPY_COLOR = 2131790519;

	private const int OPP_OCCUPY_COLOR = 2145343516;

	private UITimeLabelHelper m_TimeHelper;

	public bool m_NeedKeepInscreen;

	public MeshRenderer m_TimeRender;

	private ParticleSystem m_TimeUpParticle;

	private bool m_TimeUpEffectPlayed;

	private const float TIME_EMPTY = -0.5f;

	private const float TIME_SPAN = 0.7f;

	private uint m_WarehosueHitDelayCallID;

	private MarkType m_MarkType;

	public void UpdateMarkType(MarkType markType)
	{
	}

	private void SetSimpleUI()
	{
	}

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

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	private void OnMyWareHouseHit(object[] data)
	{
	}

	private void OnMyWareHouseHPChanged(object[] data)
	{
	}

	private void OnOccupateTeamChange(object[] data)
	{
	}

	public void InitControlPointPos(Vector3 pos)
	{
	}

	public void SetNormalStateIcon(string iconName)
	{
	}

	private void Update()
	{
	}

	private void OnControlPointChange(object[] data)
	{
	}

	private void ClearHudShow()
	{
	}

	private void _003COnMyWareHouseHit_003Eb__26_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		return default(Vector2);
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}
}

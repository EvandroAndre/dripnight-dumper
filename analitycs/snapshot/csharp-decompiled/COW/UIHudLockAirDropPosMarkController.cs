using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudLockAirDropPosMarkController : UIHudNameBaseController
{
	public enum ESpecialType
	{
		None,
		Airdrop,
		TechAirDrop,
		AirDropVariant,
		NormalAirDropVariant
	}

	private UIHudLockAirDropPosMarkView m_View;

	private LockAirDropIcon m_Icon;

	private uint m_PointId;

	private int m_PointMarkShowDis;

	private bool m_NeedUpdatePosition;

	private uint m_MaxProcess;

	private string m_SpriteName;

	private CIJPLNEAIIH m_LastPhase;

	private uint m_DelayCallID;

	private uint m_CloseDelayCallID;

	private UIHudCSTeamGoalBtnController m_CSTeamGoalBtnCtrl;

	private Vector3 m_PointPos;

	private Vector3 m_DistancePos;

	private DFMAGBNLCHD m_Type;

	private uint m_ExtraId;

	private uint m_SubType;

	private BaseLevelObject m_BindLvlObject;

	private string m_BaseProcessSprite;

	private Color m_BaseProcessColor;

	public Vector3 PointPos => default(Vector3);

	public DFMAGBNLCHD PointType => DFMAGBNLCHD.AirDropInteractLock;

	public uint ExtraCombineId => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnPinMark()
	{
	}

	private void OnNewPhaseStarted(object[] param)
	{
	}

	private void SetDefaultDistanceShow()
	{
	}

	private void CancelDelay()
	{
	}

	public void SetDistanceShow(int dis)
	{
	}

	protected override void OnUIDestory()
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

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	public void BindLvlObject(BaseLevelObject obj)
	{
	}

	private void Update()
	{
	}

	public void BindTarget(uint id, Vector3 target, uint param, DFMAGBNLCHD type, bool showPos, string spriteName = "", uint extraId = 0u, uint subType = 0u, bool isVariant = false)
	{
	}

	public void SwitchToSpecialStateBg(ESpecialType specialType)
	{
	}

	public void DelayClose(float time)
	{
	}

	private void RemoveFromScene()
	{
	}

	public void Reset()
	{
	}

	public void SetState(InteractiveState state)
	{
	}

	protected override void OnDistanceChanged(float distance)
	{
	}

	private void OnEnterInteract(GEvent param)
	{
	}

	public void SetTime(int time)
	{
	}

	public void SetStep(int step)
	{
	}

	protected override bool NeedOptDistanceUpdate()
	{
		return false;
	}

	protected override void OnDistanceLabelChanged()
	{
	}

	private void CloseTeamGoalBtnCtrl()
	{
	}

	private void ResetTeamGoalBtnCtrl()
	{
	}

	private void BindTeamGoalTarget(uint id, string hintTxt, DFMAGBNLCHD type, uint subType)
	{
	}

	public void TryRefreshTeamGoalSelectItemView(uint id, int playerIndex, bool show, bool showSelectUIFX = false)
	{
	}

	public float GetPositionXAxis()
	{
		return 0f;
	}

	private void ResetStyle()
	{
	}

	public void ChangeStyle(string processSpr, Color processCol)
	{
	}

	private void ChangeSprite(string spriteName, UISprite sprite, UIAtlas atlas)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
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

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDistanceChanged(float P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedOptDistanceUpdate()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDistanceLabelChanged()
	{
	}
}

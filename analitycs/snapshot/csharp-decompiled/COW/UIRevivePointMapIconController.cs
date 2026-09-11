using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIRevivePointMapIconController : MonoBehaviour
{
	private uint m_RevivePointId;

	private LevelRevivePoint m_RevivePoint;

	private Vector3 m_RevivePointPos;

	private CMHCKKJBOFL m_CurrentState;

	private bool m_Advanced;

	private bool m_InTriggerAllIsEnemy;

	private bool m_RevivePointIconChangeEventRegistered;

	private UIModelMatch m_ModelMatch;

	private int m_RevivePointMarkShowDis;

	private bool m_NeedUpdatePosition;

	public UISprite ProgressBg;

	public UISprite StateIcon;

	public UISprite StateBg;

	public GameObject AdvancedStateBg;

	public UILabel PointStatusLabel;

	public UISprite PermanentIcon;

	public VFXCreateHelper AdvanceRevivePointVFX;

	public Transform ActivityNode;

	public GameObject NormalStatus;

	public bool IsSoloRevivePoint;

	private bool m_ShowActivityNode;

	private UIHudActivityRevivePointIconController m_ActivityNode;

	private VisualInstanceHolder m_ActivityHolder;

	private StringBuilder m_DistanceStr;

	private int m_PrevDistance;

	public static Color ReviveIconNormal;

	public static Color ReviveBgNormal;

	public static Color ReviveSoloBgNormal;

	public static Color ReviveIconCD;

	public static Color ReviveBgCD;

	private VisualInstanceHolder m_InTriggerAllIsEnemyVfx;

	private bool m_IsInit;

	private bool m_IsDestroyed;

	private uint m_AdvancedVFXHideDelayCall;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void TryInit()
	{
	}

	public void TryDestroy()
	{
	}

	private void RegisterRevivePointIconChangeEvent()
	{
	}

	private void UnRegisterRevivePointIconChangeEvent()
	{
	}

	public bool IsAdvanced()
	{
		return false;
	}

	public void SetState(CMHCKKJBOFL state)
	{
	}

	public void SetTime(int time)
	{
	}

	public void SetAdvanced(bool advanced)
	{
	}

	private void RefreshState()
	{
	}

	public void RefreshActivityNode(CMHCKKJBOFL state)
	{
	}

	private bool IsCapturing()
	{
		return false;
	}

	public void SetData(uint id, Vector3 pos)
	{
	}

	public void ApplyPOIMissionCompletedIconForHudItemMark(uint revivePointId, LevelRevivePoint revivePoint)
	{
	}

	private void ChangeIconRes(uint revivePointId)
	{
	}

	private void TryApplyPOIMissionCompletedIcon()
	{
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}

	private void OnPermanentEvent(object[] data)
	{
	}

	private void InTriggerAllIsEnemyChanged(uint id, uint boolValue)
	{
	}

	private void ShowAllIsEnemyVfx(bool show)
	{
	}

	public void Flash()
	{
	}

	private void _003CChangeIconRes_003Eb__48_0(GameObject instance)
	{
	}

	private void _003CFlash_003Eb__55_0()
	{
	}
}

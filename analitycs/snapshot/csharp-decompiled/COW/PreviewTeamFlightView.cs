using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using UnityEngine.Animations;

namespace COW;

public class PreviewTeamFlightView : MonoBehaviour
{
	public enum TeamFlightMoveAnimState
	{
		None,
		Opening,
		Level,
		StartSkyDrivingFromLevel,
		StartSkyDrivingFromSkyDiving,
		StartFlightSkyDivingFromLevel,
		StartFlightSkyDivingFromSkySurfing,
		StartFlightParachutingFromLevel,
		StartFlightParachutingFromSkyDiving
	}

	private const string MULTI_FLIGHT_MOVE_PREVIEW_DEFAULT_PARENT_BONE_NAME = "Root";

	public Transform[] AvatarPosArray;

	public Transform[] FemaleAvatarPosArray;

	private HashSet<BHGGAEEHJCO> m_PlayerSet;

	private Dictionary<BHGGAEEHJCO, int> m_PlayerSeatIndexMap;

	public Transform CachedTransForm;

	public bool IsFrame;

	public float UpOffset;

	public float BackOffset;

	public float FOV;

	public float AirUpOffset;

	public float AirBackOffset;

	public float AirFOV;

	public List<Renderer> RendererList;

	public Animator RigTrans;

	public Animator EffectRigTrans;

	public List<Animator> m_AppendEffectAnimatorList;

	public bool IsVisible;

	public float RigScale;

	private ResourceID resID;

	private bool m_NeedReleaseFlightRes;

	private string m_lastTrigger;

	private float m_animStartServerTime;

	private int m_animStartFrame;

	private TeamFlightMoveAnimState m_animSyncState;

	public Transform[] EffectBindPosArray;

	public Transform OpenCameraBindPos;

	public string MultiFlightMovePreviewParentBoneName;

	public void SetParaByOther(PreviewTeamFlightView view)
	{
	}

	public void InitTeamFlight(ResourceID id)
	{
	}

	public Transform GetPosTrans(bool isFemale, int index)
	{
		return null;
	}

	public string GetMultiFlightMovePreviewParentBoneName()
	{
		return null;
	}

	private Transform GetEffectBindTrans(int index)
	{
		return null;
	}

	internal void BindSeatParentConstraints(int seatIndex, Player player)
	{
	}

	internal void BindSeatParentConstraints(int seatIndex, UIMaleAvatar avatar)
	{
	}

	internal void BindMultiFlightMovePreviewDriver(UIMaleAvatar driverAvatar)
	{
	}

	internal void UnbindMultiFlightMovePreviewDriver()
	{
	}

	private void BindParentConstraintToTarget(ParentConstraint constraint, Transform targetBone)
	{
	}

	private void ClearParentConstraintSource(ParentConstraint constraint)
	{
	}

	private Transform ResolveTargetBone(ParentConstraint constraint, Player player)
	{
		return null;
	}

	private Transform ResolveTargetBone(ParentConstraint constraint, UIMaleAvatar avatar)
	{
		return null;
	}

	public void UnbindSeatParentConstraints(int seatIndex)
	{
	}

	private void InitEffectBindPosVisible()
	{
	}

	private void SetAllEffectBindPosVisible(bool visible)
	{
	}

	private void SetEffectBindPosVisible(int seatIndex, bool visible)
	{
	}

	public void AddPlayer(BHGGAEEHJCO pId, int seatIndex = -1)
	{
	}

	private void RecordNeedReleaseFlightRes(BHGGAEEHJCO pId)
	{
	}

	public bool RemovePlayer(BHGGAEEHJCO pId)
	{
		return false;
	}

	private void DetachRuntimeChildrenBeforeDestroy()
	{
	}

	public bool ContainPlayer(BHGGAEEHJCO pId)
	{
		return false;
	}

	public void SetParent(Transform newParent)
	{
	}

	public void SetVisible(bool value)
	{
	}

	private void SetAppendEffectAnimatorEnabled(bool value)
	{
	}

	private void SetSeatConstraintsActive(bool active)
	{
	}

	public void PlayFlightLevel()
	{
	}

	public bool IsFlightLevelAnimatorReady()
	{
		return false;
	}

	private bool IsAnimatorInState(Animator anim, string stateName)
	{
		return false;
	}

	public void PlayStartSkyDriving(bool fromSkyDiving, bool needPlayCrossFacade = false)
	{
	}

	public void PlayStartFlightSkyDiving(bool fromSkySurfing)
	{
	}

	public void PlayStartFlightParachuting(bool fromSkyDiving)
	{
	}

	public void PlayOpeningAnim()
	{
	}

	public void PlayLandAnimEffect()
	{
	}

	private void ResetLastTrigger()
	{
	}

	public void AppendAnimSetTrigger(string name, bool needReset = false, string fallbackName = null)
	{
	}

	private string GetSkyDrivingTriggerName(Animator anim, bool needPlayCrossFacade)
	{
		return null;
	}

	private string GetExistingTriggerName(Animator anim, string triggerName, string fallbackName = null)
	{
		return null;
	}

	private bool HasTrigger(Animator anim, string triggerName)
	{
		return false;
	}

	private void MarkMoveAnimSyncState(TeamFlightMoveAnimState state)
	{
	}

	public bool TryGetMoveAnimSyncInfo(out TeamFlightMoveAnimState syncState, out float elapsedServerTime, out float normalizedTime)
	{
		syncState = default(TeamFlightMoveAnimState);
		elapsedServerTime = default(float);
		normalizedTime = default(float);
		return false;
	}

	public void SyncMoveAnimToPlayers()
	{
	}

	public void SyncMoveAnimToPlayers(BHGGAEEHJCO ignorePlayerId)
	{
	}

	public float GetAnimStartServerTime()
	{
		return 0f;
	}
}

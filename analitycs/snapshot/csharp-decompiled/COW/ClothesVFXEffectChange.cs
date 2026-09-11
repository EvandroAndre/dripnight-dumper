using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class ClothesVFXEffectChange : MonoBehaviour
{
	public GameObject residentEffect;

	public GameObject triggerEffect;

	private VFXCreateHelper m_Helper;

	public Animator vfxEffectAnimator;

	private UIMaleAvatar m_Avatar;

	private uint clothId;

	private List<GameObject> m_TriggerEffect;

	private List<GameObject> m_ResidentEffect;

	public Animator skeletonEffectAnimator;

	private bool m_InEditorMode;

	private float m_LobbySkeletonStateInterval;

	private const string TRIGGER_PLAY_TRIGGER_EFFECT = "PlayTriggerEffect";

	private const string TRIGGER_PLAY_IDLE_EFFECT = "PlayIdleEffect";

	private const string STATE_SPECIAL = "Special";

	private const string STATE_IDLE = "Idle";

	private const string STATE_SPECIAL_1 = "Special_1";

	private const string STATE_IDLE_1 = "Idle_1";

	private const string TRIGGER_PLAY_SPECIAL = "PlaySpecial";

	private const string TRIGGER_PLAY_IDLE = "PlayIdle";

	private const string TRIGGER_PLAY_SPECIAL_1 = "PlaySpecial1";

	private const string TRIGGER_PLAY_IDLE_1 = "PlayIdle1";

	private const string TRIGGER_DEFAULT = "Default";

	private const string PARAM_FRONT_GAME = "FrontGame";

	private static readonly string[] s_MultiStateTriggerNames;

	private uint[] m_LobbySkeletonSpecialTriggerIDs;

	private uint[] m_LobbySkeletonSpecial1TriggerIDs;

	private Dictionary<uint, List<GameObject>> m_LobbySkeletonTriggerEffectMap;

	private bool m_LobbyAvatar;

	private Dictionary<uint, List<GameObject>> m_PrivilegeSkeletonTriggerEffectObjects;

	private uint[] m_PrivilegeSkeletonSpecialStateIDs;

	private uint[] m_PrivilegeSkeletonSpecial1StateIDs;

	private bool m_IsPrivilegeSkeletonPreview;

	private bool m_PrivilegeSkeletonKeepResidentVisible;

	private bool m_PrivilegeSkeletonUseSecondaryState;

	private static readonly string[] s_LobbySkeletonStateNames;

	private uint m_LobbySkeletonStateDelayCallID;

	private int m_LobbySkeletonStateIndex;

	private bool m_LobbySkeletonStateLoopRunning;

	private const string PRIVILEGE_SKELETON_DEFAULT_STATE = "Default";

	private const int PRIVILEGE_SKELETON_DEFAULT_LAYER = 0;

	private string m_PrivilegeSkeletonCurrentStateName;

	private void OnEnable()
	{
	}

	private void ResetMultiStateRuntimeStateOnEnable()
	{
	}

	private bool ShouldResetMultiStateRuntimeStateOnEnable()
	{
		return false;
	}

	public void RefreshMultiStateRuntimeStateOnVisible()
	{
	}

	public void ResetMultiStateRuntimeStateBeforeInvisible()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void TryStartLobbySkeletonStateLoop()
	{
	}

	private void StopLobbySkeletonStateLoop()
	{
	}

	public bool GetInEditorMode()
	{
		return false;
	}

	private void RefreshFrontGameAnimatorParam(bool frontGame)
	{
	}

	private bool SetAnimatorBoolIfExists(string paramName, bool value)
	{
		return false;
	}

	public void PlayTriggerEffectInEditor()
	{
	}

	public void PlayTriggerEffect(bool changeEffectOnly = false, bool forcePlay = false, bool useSecondaryState = false)
	{
	}

	public void PlayResidentEffect(bool changeEffectOnly = false, bool useSecondaryState = false, bool isMultiStateSkeletonCloth = false)
	{
	}

	private bool ShouldPlayIngameMultiStateResidentDirectly()
	{
		return false;
	}

	public void SetClothId(uint id)
	{
	}

	public void SetEffectForPrivilegePreview(List<GameObject> triggerObjs)
	{
	}

	public void SetEffectForPrivilegePreview(Dictionary<uint, List<GameObject>> privilegeTriggerEffectObjects, uint[] specialStateIDs, uint[] special1StateIDs, bool useSecondaryState)
	{
	}

	private void SetResidentEffectActive(bool show)
	{
	}

	private void SetTriggerEffectActive(bool show)
	{
	}

	public bool IsLobbySkeletonStateLoopRunning()
	{
		return false;
	}

	private bool ShouldUseLobbySkeletonStateLoop()
	{
		return false;
	}

	private void ScheduleNextLobbySkeletonState()
	{
	}

	private void OnLobbySkeletonStateTimeUp()
	{
	}

	private void PlayLobbySkeletonState()
	{
	}

	private bool TrySetMultiStateTrigger(string stateName)
	{
		return false;
	}

	private bool HasAnimatorTrigger(string triggerName)
	{
		return false;
	}

	private string GetMultiStateTriggerName(string stateName)
	{
		return null;
	}

	private void ResetMultiStateTriggers()
	{
	}

	private void ResetAnimatorTriggerIfExists(string triggerName)
	{
	}

	private bool ShouldUseMultiStateTriggerSwitch()
	{
		return false;
	}

	public void OnMultiStateSkeletonStateEnter(string stateName)
	{
	}

	private void ApplySkeletonEffectByState(string stateName)
	{
	}

	private void ApplyTriggerSkeletonEffectByState(string stateName)
	{
	}

	private void ApplyResidentSkeletonEffectByState(string stateName)
	{
	}

	private void ApplyLobbySkeletonTriggerEffectByState(string stateName)
	{
	}

	private void BuildLobbySkeletonTriggerEffectMap(uint id, List<EffectObject> effectObjects)
	{
	}

	private void AddTriggerIDsToMap(uint[] triggerIDs)
	{
	}

	private void AddEffectObjectToList(List<GameObject> list, EffectObject effectObject)
	{
	}

	private void SetLobbySkeletonTriggerEffectsActive(uint[] activeTriggerIDs)
	{
	}

	private bool ContainsTriggerID(uint[] triggerIDs, uint triggerID)
	{
		return false;
	}

	private void ResetPrivilegeSkeletonPreviewData()
	{
	}

	private List<GameObject> BuildPrivilegeSkeletonTriggerEffectList(Dictionary<uint, List<GameObject>> privilegeTriggerEffectObjects)
	{
		return null;
	}

	private uint[] GetActivePrivilegeSkeletonStateIDs()
	{
		return null;
	}

	private void SetPrivilegeSkeletonTriggerEffectsActive(uint[] activeStateIDs)
	{
	}

	private string GetPrivilegeSkeletonTriggerStateName()
	{
		return null;
	}

	private string GetPrivilegeSkeletonIdleStateName()
	{
		return null;
	}

	private uint[] GetPrivilegeSkeletonStateIDsByStateName(string stateName)
	{
		return null;
	}

	public void SetPrivilegeSkeletonKeepResidentVisible(bool keepVisible)
	{
	}

	public void PlayPrivilegeSkeletonDefaultState()
	{
	}

	private bool IsMultiStatePrivilegeSkeletonPreview()
	{
		return false;
	}

	private void SetPrivilegeSkeletonCurrentStateName(string stateName)
	{
	}

	private bool ShouldSkipResidentCrossFadeFromDefault()
	{
		return false;
	}
}

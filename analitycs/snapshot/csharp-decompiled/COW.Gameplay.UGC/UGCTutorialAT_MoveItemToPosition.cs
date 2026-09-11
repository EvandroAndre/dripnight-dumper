using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCTutorialAT_MoveItemToPosition : UGCTutorialAtomicTaskBase
{
	private const float POSITION_TOLERANCE = 0.5f;

	public const string REGISTRY_KEY_START_POS = "MoveItem_StartPos";

	public const string REGISTRY_KEY_TARGET_POS = "MoveItem_TargetPos";

	public const string REGISTRY_KEY_SOURCE_OBJ = "MoveItem_SourceObj";

	private UGCTutorialAtomicTaskParam_MoveItemToPosition m_Param;

	private UGCTutorialContextContent_SceneItem m_SceneItemCtx;

	private SceneEditObjectBase m_TargetObj;

	private Vector3 m_TargetPos;

	private EventDispatcher.VEventHandler m_ModifyChangedHandler;

	private bool m_ModifyEventRegistered;

	protected override void OnStart()
	{
	}

	protected override void OnDispose()
	{
	}

	public override bool CheckCompletion()
	{
		return false;
	}

	protected override void AutoComplete()
	{
	}

	private void OnModifyChanged()
	{
	}

	private static bool IsAgentModifying()
	{
		return false;
	}

	private void RegisterGuideData()
	{
	}

	private void UnregisterGuideData()
	{
	}

	private Vector3 ParseTargetPosition()
	{
		return default(Vector3);
	}

	private SceneEditObjectBase FindObjectByIndex(int instanceIndex)
	{
		return null;
	}

	private static bool IsPositionReached(Vector3 current, Vector3 target)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_AutoComplete()
	{
	}
}

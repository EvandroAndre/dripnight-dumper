using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace COW.Gameplay.UGC;

public class UGCAnimPlayableUnityWrap : PlayableBehaviour
{
	public UGCAnimPlayable_Simple ImplPlayer;

	public Playable SelfPlayable;

	private bool m_isDestroyed;

	private bool m_isOwnerGraph;

	public AnimatorControllerPlayable OriginAnimatorController;

	public AnimationPlayableOutput OriginAnimatorControllerOutput;

	public AnimationPlayableOutput SelfOutput;

	public bool hasOriginPlayableGraph;

	public PlayableGraph Graph => default(PlayableGraph);

	public bool IsDestroyed => false;

	public bool IsOwnerGraph => false;

	public static bool IsEnalbeUGCBlendFF => false;

	public override void OnPlayableCreate(Playable playable)
	{
	}

	public override void OnGraphStart(Playable playable)
	{
	}

	public override void OnGraphStop(Playable playable)
	{
	}

	public override void PrepareFrame(Playable owner, FrameData data)
	{
	}

	public void RebuildGraphTree()
	{
	}

	public void FetchFromExistGraph(PlayableGraph graph)
	{
	}

	public static UGCAnimPlayableUnityWrap Create(Animator anim)
	{
		return null;
	}

	public void Destroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlayableCreate(Playable P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnGraphStart(Playable P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnGraphStop(Playable P0)
	{
	}

	public void _003C_003EiFixBaseProxy_PrepareFrame(Playable P0, FrameData P1)
	{
	}
}

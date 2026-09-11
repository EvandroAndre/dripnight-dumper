using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class AdditiveEffectPlayableAsset : PlayableAsset
{
	public Material OverideMaterial;

	public bool IsTransparent;

	public GameObject EditorRigObject;

	public string EditorRigObjectName;

	private List<SkinnedMeshRenderer> m_CachedRenderers;

	public bool EnableTweenMaterialProperty;

	public List<TweenMaterialPropertyConfig> TweenConfigs;

	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}
}

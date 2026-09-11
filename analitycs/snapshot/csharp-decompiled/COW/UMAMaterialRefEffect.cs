using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UMAMaterialRefEffect : MonoBehaviour
{
	public delegate void Callback(bool isStart, bool forward, int type);

	public enum SupportedMono
	{
		TweenPropertyMono,
		UVSeqPlayerMono
	}

	public class MonoBehaviourWithWardrobeType
	{
		public MonoBehaviour m_Behaviours;

		public int m_Type;

		public SupportedMono m_MonoType;
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public TweenProperty tween;

		public UMAMaterialRefEffect _003C_003E4__this;

		internal void _003CShowAnim_003Eb__0()
		{
		}

		internal void _003CShowAnim_003Eb__1()
		{
		}
	}

	private Callback m_Callback;

	protected HashSet<int> m_HoldOnType;

	public Dictionary<int, MaterialRef> m_MaterialRefs;

	protected List<MonoBehaviourWithWardrobeType> m_Behaviours;

	protected Renderer m_Renderer;

	private Dictionary<int, int> m_TriggerEventId2Type;

	public void AddTargets(int type, MaterialRef matRef)
	{
	}

	public void CleanAllAnim()
	{
	}

	public void CleanAnim(int type)
	{
	}

	public void ShowAnim(int type, bool addCall = false)
	{
	}

	private void FindUMARenderer()
	{
	}

	private void AddTargetComponent(int type, MaterialRef materialRef, Material[] mats)
	{
	}

	public void ShowAllAnim()
	{
	}

	private bool FindMatchedMaterial(Material[] mats, string shaderName, string mainTextureName, out Material mat, out int materialIndex)
	{
		mat = null;
		materialIndex = default(int);
		return false;
	}

	public void UpdateEffectVisiblityMaterial(int type, bool vis, bool reverse)
	{
	}

	public void UpdateEffectVisibility(int type, bool vis = true, bool simpleAct = true, bool reverse = false)
	{
	}

	public void UpdateEffectVisibility(bool vis = true)
	{
	}

	public bool CheckTargetsExist(int type)
	{
		return false;
	}

	public void RemoveTargets(int type, bool resetToForward)
	{
	}

	public void Clear(int type)
	{
	}

	public void AddHoldOnType(int type)
	{
	}

	public void RemoveHoldOnType(int type)
	{
	}

	public void AddEventDelegate(Callback call)
	{
	}

	private void OnStartPlay(TweenProperty tween)
	{
	}

	private void OnFinishPlay(TweenProperty tween)
	{
	}

	private void PlayEffect(bool isStart, bool forward, int type)
	{
	}
}

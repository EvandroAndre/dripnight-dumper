using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class SparkPetEffect : MonoBehaviour
{
	public enum EEffectGroup
	{
		Default,
		Persistent,
		Temporary
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public SparkPetEffect _003C_003E4__this;

		public string effectName;

		public EEffectGroup group;

		internal void _003CLoadEffectAsync_003Eb__0(uint tid, bool succeeded, Object res)
		{
		}
	}

	private Dictionary<int, List<GameObject>> m_Effects;

	private Dictionary<int, List<string>> m_EffectNames;

	private List<uint> m_AsyncLoadingTickets;

	private Transform m_CachedTransform;

	public bool enableAsyncLoad;

	public bool enableDebugLog;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetCacheTransform(Transform transform)
	{
	}

	public void PlayEffect(AnimationEvent evt)
	{
	}

	public void PlayEffectByName(string resourceName)
	{
	}

	public void PlayEffectByName(string resourceName, EEffectGroup group = EEffectGroup.Default)
	{
	}

	public void PlayEffectWithPrefab(GameObject prefab, EEffectGroup group = EEffectGroup.Default, string customName = null)
	{
	}

	private void LoadEffectSync(ResourceID resId, EEffectGroup group, string effectName)
	{
	}

	private void LoadEffectAsync(ResourceID resId, EEffectGroup group, string effectName)
	{
	}

	private void PlayEffectInternal(GameObject prefab, EEffectGroup group, string customName = null)
	{
	}

	private Transform FindMountPoint(GameObject prefab)
	{
		return null;
	}

	private Transform FindTransformRecursive(Transform parent, string name)
	{
		return null;
	}

	private void AddEffectToGroup(GameObject effectGO, EEffectGroup group, string effectName)
	{
	}

	public bool HasEffect(string effectName, EEffectGroup group = EEffectGroup.Default)
	{
		return false;
	}

	public void ClearEffects(EEffectGroup group)
	{
	}

	public void ClearAllEffects()
	{
	}

	public void ClearEffectByName(string effectName)
	{
	}

	private void CancelAllAsyncLoading()
	{
	}

	public int GetEffectCount(EEffectGroup group)
	{
		return 0;
	}

	public int GetTotalEffectCount()
	{
		return 0;
	}

	private void Log(string format, object[] args)
	{
	}

	private void LogWarning(string format, object[] args)
	{
	}
}

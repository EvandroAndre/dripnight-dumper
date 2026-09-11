using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Graphics;
using GCommon;
using UMA;
using UnityEngine;

namespace COW;

internal class IngameAvatarClothEffectComponent : MonoBehaviour
{
	public class EffectDataBase
	{
		public ResourceID ResId;

		public bool IsLoaded;

		public uint LoadingTicket;

		public List<GameObject> GameObjects;

		public bool IsLoading => false;

		public virtual void Reset()
		{
		}
	}

	public class ClothEffectObject : EffectDataBase
	{
		public UIModelAvatarBase.EWardrobeType Type;

		public BitArrayBoolean IsVisible;

		public GameObject EffectGo;

		public SkinnedMeshRenderer[] effectHeadRenderers;

		public bool extraEffect;

		public bool isSkeletonEffect;

		public bool isMultiStateSkeletonEffect;

		public bool effectForceShow;

		public ClothEffectObject(UIModelAvatarBase.EWardrobeType type)
		{
		}

		public override void Reset()
		{
		}

		public void _003C_003EiFixBaseProxy_Reset()
		{
		}
	}

	private class DynamicEffectData : EffectDataBase
	{
		public int Id;

		public bool IsVisible;
	}

	private IUmaAvatar m_Avatar;

	public bool AsyncLoading;

	private bool PoolDynamicEffects;

	private const bool AllowsAnimationInDynamicEffects = false;

	public bool CastShadow;

	private GameObject m_TempBackpack;

	public List<GameObject> m_FootPrints;

	private LazyDictionary<ResourceID, GameObject> m_OwnershipPool;

	private AvatarManager m_AvatarManager;

	private bool m_FootPrintsPausedByStealth;

	private bool m_FootPrintsPausedByMoveEmote;

	private bool m_FootPrintsPausedByPlayerStatus;

	private Dictionary<int, ClothEffectObject> m_ClothEffects;

	private Dictionary<int, ClothEffectObject> m_ClothSkeletonEffects;

	private List<DynamicEffectData> m_DynamicEffects;

	private static List<DynamicEffectData> s_DynamicEffectsPool;

	private Action<uint, bool, UnityEngine.Object> m_CachedOnAsyncLoadDynamicEffectFromPool;

	private Action<uint, bool, UnityEngine.Object> m_CachedOnAsyncLoadDynamicEffect;

	private static List<ParticleSystem> s_SharedTmpParticlesList;

	private static List<Renderer> s_SharedTmpRenderList;

	private static List<Animator> s_SharedTmpAnimatorList;

	private static List<TweenProperty> s_SharedTmpTweenList;

	private static List<MeshRenderer> s_SharedTmpMeshRenderers;

	private static List<UMATweenProperty> s_SharedTmpUMATweenList;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private bool ShouldEnableHighResFallbackForEffect()
	{
		return false;
	}

	public void PlayIngameAnimEffect(GameObject prefab, UIModelAvatarBase.EWardrobeType wType, bool isPrefab = true, List<GameObject> gos = null, bool transformEffect = false, bool needRecover = false, bool isEffectHead = false, bool effectForceShow = false, ClothEffectObject effectData = null)
	{
	}

	private void ProcessBoneNameRefsIngame(GameObject go, UIModelAvatarBase.EWardrobeType wType, List<GameObject> gos = null, bool transformEffect = false, bool needRecover = false)
	{
	}

	public void ProcessBoneNameRefsIngameWithGos(GameObject go, UIModelAvatarBase.EWardrobeType wType, List<GameObject> gos = null, bool transformEffect = false, bool needRecover = false)
	{
	}

	public void RecoverBoneNameRefsIngame(List<GameObject> gos)
	{
	}

	public void SetShowBackpack(GameObject obj)
	{
	}

	public void UneuqippedBackPack()
	{
	}

	public void ShowFootPrints()
	{
	}

	public void HideFootPrints()
	{
	}

	public void PauseFootPrintsByPlayerStatus()
	{
	}

	public void ResumeFootPrintsByPlayerStatus()
	{
	}

	public void PauseFootPrintsByStealth()
	{
	}

	public void ResumeFootPrintsByStealth()
	{
	}

	public void PauseFootPrintsByMoveEmote()
	{
	}

	public void ResumeFootPrintsByMoveEmote()
	{
	}

	private void UpdateFootPrintsVisibility()
	{
	}

	private static bool ScaleInLocalSpace(GameObject o)
	{
		return false;
	}

	public void ChangeMeshLayer(int layer)
	{
	}

	private void CancelEffectLoading(EffectDataBase data, bool pool)
	{
	}

	private void ChangeMeshLayer(EffectDataBase data, int layer)
	{
	}

	public Dictionary<int, ClothEffectObject> GetClothEffects()
	{
		return null;
	}

	public Dictionary<int, ClothEffectObject> GetClothSkeletonEffects()
	{
		return null;
	}

	public ClothEffectObject GetClothesEffectData(UIModelAvatarBase.EWardrobeType wardrobeType)
	{
		return null;
	}

	public ClothEffectObject GetClothesSkeletonEffectData(UIModelAvatarBase.EWardrobeType wardrobeType)
	{
		return null;
	}

	private ClothEffectObject GetClothesEffectDataByTicket(uint ticket)
	{
		return null;
	}

	private void CancelClothesEffectLoadings()
	{
	}

	private void CancelClothesSkeletonEffectLoadings()
	{
	}

	public ClothEffectObject PlayEffect(UIModelAvatarBase.EWardrobeType type, ResourceID res, bool forceSyncLoading = false, bool isSkeletonEffect = false, bool extraEffect = false, bool effectForceShow = false, bool isMultiStateSkeletonEffect = false)
	{
		return null;
	}

	private void OnEffectDataLoaded(uint ticket, bool ok, UnityEngine.Object obj)
	{
	}

	private void OnEffectDataLoaded(ClothEffectObject effectData, UnityEngine.Object obj, bool async)
	{
	}

	public void UpdateEffectVisibility(ClothEffectObject effectData)
	{
	}

	public void SetEffectsVisibility(uint flag, bool v)
	{
	}

	public void SetEffectVisibility(UIModelAvatarBase.EWardrobeType wardrobeType, uint flag, bool v)
	{
	}

	public void RemoveAnimEffect(UIModelAvatarBase.EWardrobeType wardrobeType)
	{
	}

	public bool StartDynamicEffect(int id, ResourceID res, bool isVisible)
	{
		return false;
	}

	public void StopDynamicEffect(int id, ResourceID res)
	{
	}

	public void SetDynamicEffectVisibility(int id, bool visible)
	{
	}

	private void StartEffects(List<GameObject> list, bool start)
	{
	}

	private bool StopEffects(GameObject go)
	{
		return false;
	}

	private void StartEffects(GameObject go, bool start)
	{
	}

	private void StartAnims(List<GameObject> list, bool start)
	{
	}

	private void EnableRenderers(List<GameObject> list, bool enable)
	{
	}

	private void EnableRenderers(GameObject go, bool enable)
	{
	}

	private void EnableAnimators(List<GameObject> list, bool enable)
	{
	}

	private DynamicEffectData GetDynamicEffectData(int id, bool remove = false)
	{
		return null;
	}

	private DynamicEffectData GetDynamicEffectDataByTicket(uint ticket)
	{
		return null;
	}

	private void CancelDynamicEffectLoadings()
	{
	}

	private void LoadAndPlayDynamicEffect(DynamicEffectData data)
	{
	}

	private void OnAsyncLoadDynamicEffectFromPool(uint ticket, bool ok, UnityEngine.Object obj)
	{
	}

	private void OnAsyncLoadDynamicEffect(uint ticket, bool ok, UnityEngine.Object obj)
	{
	}

	private void PlayDynamicEffectOnAsyncLoad(uint ticket, bool ok, UnityEngine.Object obj, bool isPrefab)
	{
	}

	private void PlayDynamicEffect(DynamicEffectData data, UnityEngine.Object obj, bool isPrefab)
	{
	}

	private void StopDynamicEffect(DynamicEffectData data)
	{
	}

	private void RecyleResToOwner(ResourceID resID, GameObject obj)
	{
	}

	private GameObject TryGetOwnerPoolEffect(ResourceID resId)
	{
		return null;
	}

	private void SetDynamicEffectVisibility(DynamicEffectData data, bool isVisible, bool force)
	{
	}

	public bool ReversePlayDymanicEffect(int id, bool vis, ref List<ParticleSystem> particleSystems)
	{
		return false;
	}

	public void ResetDymanicEffectBeforeRecyle(int id, List<ParticleSystem> particleSystems)
	{
	}
}

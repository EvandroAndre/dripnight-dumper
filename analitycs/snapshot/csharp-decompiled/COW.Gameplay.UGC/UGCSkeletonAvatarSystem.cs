using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using UMA;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

internal class UGCSkeletonAvatarSystem
{
	private class PartRuntimeData
	{
		public GameObject partMesh;

		public SkinnedMeshRenderer skinnedMeshRenderer;

		public Renderer m_renderer;

		public UGCResOneAvatar.AvatarPart partRes;

		public bool isCombined;

		public UGCSkeletonAvatarSystem ownerAvatar;

		public bool IsShow => false;

		public bool NeedCombine => false;

		public void OnResGameObjectChanged(UGCResource res)
		{
		}

		public void AddChangedCallback()
		{
		}

		public void RemoveChangedCallback()
		{
		}
	}

	private class PartBitRuntimeData
	{
		public List<PartRuntimeData> m_partList;

		public bool m_isEnable;
	}

	public delegate void OnAvatarLoaded();

	private class CombineSubMeshInfo
	{
		public int[] triangles;

		public Material sharedMaterial;
	}

	private sealed class _003C_003Ec__DisplayClass122_0
	{
		public UGCSkeletonAvatarSystem _003C_003E4__this;

		public bool isLoop;

		public bool isClearAvatarEffectOnEmoteEnd;

		public bool overrideGamePlayControl;

		internal void _003CPlayEmoteOrClipForFFPlayer_003Eb__1(uint tid, bool ret, UnityEngine.Object res)
		{
		}

		internal void _003CPlayEmoteOrClipForFFPlayer_003Eb__0(bool succ, UGCResAnimationClip resObj)
		{
		}
	}

	private sealed class _003CCor_DelaySyncFFAvatar_003Ed__107 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UGCSkeletonAvatarSystem _003C_003E4__this;

		private int _003CwaitCount_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCor_DelaySyncFFAvatar_003Ed__107(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003Ccor_applyRenderStatus_003Ed__128 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject obj;

		public UGCSkeletonAvatarSystem _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003Ccor_applyRenderStatus_003Ed__128(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CdelayLoadPlayerCloth_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UGCSkeletonAvatarSystem _003C_003E4__this;

		public AvatarManager.JEGKOJDIKEL pAvatarData;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CdelayLoadPlayerCloth_003Ed__95(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CrepeatPlayCustomAnimInEditor_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimationClip clip;

		public UGCSkeletonAvatarSystem _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CrepeatPlayCustomAnimInEditor_003Ed__94(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public static string FFEmotePrefix;

	private UGCAnimationController m_animController;

	private GameObject m_avatarParent;

	private GameObject m_boneOwnerObject;

	private GameObject m_skeletonObject;

	private UGCResOneAvatar m_resAvatar;

	private Dictionary<string, Transform> m_boneNameMap;

	public Action<GameObject, bool> OnSkeletonBuilt;

	public Action<string, string, Renderer> OnPartCreated;

	internal Func<SkinnedMeshRenderer, int, Material> MaterialOverrideLookup;

	private bool m_combineDirty;

	private PartBitRuntimeData[] m_allPartByRepBit;

	private int m_partCountByRepBit;

	public BaseLevelObject m_ownerLevelObject;

	private bool m_isEditMode;

	private MonoBehaviour m_editorMonoObj;

	private bool m_isAnimationControllerInited;

	private bool m_isCacheAvatarPartVisableMask1;

	private bool m_isCacheAvatarPartVisableMask2;

	private bool m_isCacheAvatarPartVisableMask3;

	private bool m_isCacheAvatarPartVisableMask4;

	private int m_cacheAvatarPartVisableMask1;

	private int m_cacheAvatarPartVisableMask2;

	private int m_cacheAvatarPartVisableMask3;

	private int m_cacheAvatarPartVisableMask4;

	private OnAvatarLoaded m_onLoadCallback;

	private Dictionary<string, Transform> m_forceNeedBones;

	private bool m_enableExtraRenderLayer;

	private int m_extraRenderLayer;

	private BaseLevelObjectRendererCollection m_extraRenderCollection;

	private Player m_ownerPlayer;

	private int m_curffAvatarGender;

	private bool m_isAvatarManagerLoaded;

	private AvatarManager m_AvatarManager;

	private AvatarManager m_AvatarManagerForPlayerCallTransform;

	private UGCSimulateAvatarEntity m_ffSimulateAvatar;

	private EmotionManager m_ffEmotionManager;

	private uint m_ffWeaponItemID;

	private uint m_ffBagItemID;

	private uint m_ffPetID;

	private uint m_ffAvatarID;

	private bool m_ffAvatarIsFemale;

	private uint m_ffPetSkinID;

	private GameObject m_ffPetObj;

	private PetAnimComponent m_ffPetAnim;

	private Transform m_ffUMARenderer;

	private string m_ffUMARendererName;

	private IEnumerator m_corRepeatPlayCustomAnimInEditor;

	private AvatarManager.JEGKOJDIKEL m_tempFFAvatarData;

	private Dictionary<int, int> m_userSetClothType2ClothIDMap;

	private int m_userSetWeaponSkinID;

	private int m_userSetBagSkinID;

	private IEnumerator m_corDelaySyncFFAvatar;

	private AvatarManager.JEGKOJDIKEL m_curFFAvatarData;

	private Dictionary<int, bool> m_showingPartListForFFAvatar;

	private List<int> m_tempDisablePartBitList;

	public IKFIHMAEFEA m_FFUGCPlayerAnimPort;

	private UGCSkeletonBoneOwner m_skeletonBoneOwner;

	private bool m_isLoadingFFAvatar;

	private List<SkinnedMeshRenderer> m_needCombineMeshRenderer;

	private GameObject m_combinedMeshObj;

	private Dictionary<int, int> m_usedBonesDictionary;

	public Transform SkeletonRoot => null;

	public GameObject AnimatorObject => null;

	private bool IsValid => false;

	public bool IsFFAvatar => false;

	public bool IsFFPet => false;

	public UGCSkeletonAvatarSystem(GameObject objParent, GameObject boneOwnerGameObject = null)
	{
	}

	public void EnableEditMode(bool isEditMode, MonoBehaviour editorMonoObj)
	{
	}

	public void SetAnimationController(UGCAnimationController value)
	{
	}

	private void clearAnimationControllerState()
	{
	}

	private void InitAnimationController()
	{
	}

	public void PreSetPartVisableBeforeLoad(int mask, int baseIndex)
	{
	}

	public void SetAvatarLoadedCallback(OnAvatarLoaded callback)
	{
	}

	private void applyExtraRenderLayer(GameObject obj)
	{
	}

	public void SetExtraRenderLayer(int layer, BaseLevelObjectRendererCollection renderCollecter)
	{
	}

	public void SetPlayer(Player player)
	{
	}

	public void LoadAvatar(string avatarResUUID, OnAvatarLoaded onLoaded = null, Dictionary<string, Transform> forceNeedBones = null)
	{
	}

	public void LoadAvatar(UGCResOneAvatar resAvatar, Dictionary<string, Transform> forceNeedBones = null)
	{
	}

	public static void GetAllViewablePart(MNJPGANHNOK data, int partViewMask1, int partViewMask2, int partViewMask3, int partViewMask4, List<MJAIEIAKNHJ> OutPartList)
	{
	}

	public bool RefreshAllPartViewable(int partViewMask, int baseIndex = 0, bool tryCombine = false)
	{
		return false;
	}

	public bool EnableAvatarPartByRepBit(int repBit, bool isEnable)
	{
		return false;
	}

	private bool EnableAvatarPart(PartRuntimeData runtimePart)
	{
		return false;
	}

	public bool TryGetPartRenderer(string group, string part, out SkinnedMeshRenderer renderer)
	{
		renderer = null;
		return false;
	}

	internal bool TryGetPartRendererAny(string group, string part, out Renderer renderer)
	{
		renderer = null;
		return false;
	}

	internal bool TryGetPartCombineState(string group, string part, out bool isCombined)
	{
		isCombined = default(bool);
		return false;
	}

	internal bool TryFindPartByRenderer(SkinnedMeshRenderer renderer, out string group, out string part)
	{
		group = null;
		part = null;
		return false;
	}

	internal void MarkRecombineDirty()
	{
	}

	internal void TickRecombineIfDirty()
	{
	}

	private bool DisableAvatarPart(PartRuntimeData runtimePart)
	{
		return false;
	}

	public GameObject CreateAvatarPart(UGCResOneAvatar.AvatarPart avatarPart, out SkinnedMeshRenderer skinnedMeshRenderer, out Renderer renderer)
	{
		skinnedMeshRenderer = null;
		renderer = null;
		return null;
	}

	private void cleanAvatarManager()
	{
	}

	private void RemoveUGCAvatarCharacterControllerForPlayer()
	{
	}

	private void cleanFFPet()
	{
	}

	public void Cleanup(bool isCleanSkeletonObject = true)
	{
	}

	public void DestroyAvatar()
	{
	}

	private void rebuildBoneMapFromTransform(Transform t)
	{
	}

	private void refreshFFPetAvatar(bool playDefaultAnim = false)
	{
	}

	private void calcVisablePartList(List<MJAIEIAKNHJ> OutPartList)
	{
	}

	private List<MJAIEIAKNHJ> calcFFClothList(AvatarManager.JEGKOJDIKEL retFFAvatarData, out uint bagItemID, out uint weaponItemID)
	{
		bagItemID = default(uint);
		weaponItemID = default(uint);
		return null;
	}

	private IEnumerator repeatPlayCustomAnimInEditor(AnimationClip clip)
	{
		return null;
	}

	private IEnumerator delayLoadPlayerCloth(AvatarManager.JEGKOJDIKEL pAvatarData)
	{
		return null;
	}

	public void SetUserSetClothType2ClothIDMap(Dictionary<int, int> map)
	{
	}

	public void SetUserSetWeaponSkinID(int userSetWeaponSkinID)
	{
	}

	public void SetUserSetBagSkinID(int userSetBagSkinID)
	{
	}

	public void PostFFClothUserChanged(bool refreshLinkPart = false)
	{
	}

	private void syncFFAvatar()
	{
	}

	private void startSyncFFAvatar()
	{
	}

	private IEnumerator Cor_DelaySyncFFAvatar()
	{
		return null;
	}

	private void refreshFFAvatarBag(uint bagItemID, bool force = false)
	{
	}

	private void refreshFFAvatarWeapon(uint weaponItemID)
	{
	}

	private void refreshFFAvatar(bool playDefaultAnim = false)
	{
	}

	private void validatePartListByBit()
	{
	}

	private void linkAllPartForFFPart(List<MJAIEIAKNHJ> curVisablePrtList)
	{
	}

	private void PlayFFPetDefaultAnim()
	{
	}

	private IKFIHMAEFEA validatePlayerAnimPort(NewPlayerAnimationSystemComponent myAvatarAnimComponent)
	{
		return null;
	}

	private bool playEmoteOrClipForFFPlayer(AnimationClip clip, NewPlayerAnimationSystemComponent myAvatarAnimComponent, bool isLoop, bool overrideGamePlayControl)
	{
		return false;
	}

	public void StopFFPlayerEmote()
	{
	}

	private void clearAvatarEmoteEffect()
	{
	}

	public void PlayEmoteOrClipForFFPlayer(string emoteOrClipUUID, bool isLoop, bool overrideGamePlayControl = false, bool isClearAvatarEffectOnEmoteEnd = false)
	{
	}

	private void PlayDefaultAnim()
	{
	}

	private void applyBonesScale()
	{
	}

	private bool loadFFClothAvatar(UGCResOneAvatar resAvatar)
	{
		return false;
	}

	private IEnumerator cor_applyRenderStatus(GameObject obj)
	{
		return null;
	}

	private void OnFFAvatarLoaded(UMAData data)
	{
	}

	private void LoadAvatar(UGCResOneAvatar resAvatar)
	{
	}

	private void OnSkeletonTransformChanged(UGCResource res)
	{
	}

	private void OnAvatarChanged(UGCResource res)
	{
	}

	private void onSkeletonAndMeshLoaded()
	{
	}

	private void TryCombineAvatarPart()
	{
	}

	private void CombineAsOneMesh(List<SkinnedMeshRenderer> srcMeshRendererList, GameObject combineGameObject)
	{
	}

	private void TryOverrideHitBox()
	{
	}

	private void _003CLoadAvatar_003Eb__54_0(bool succ, UGCResOneAvatar resObj)
	{
	}
}

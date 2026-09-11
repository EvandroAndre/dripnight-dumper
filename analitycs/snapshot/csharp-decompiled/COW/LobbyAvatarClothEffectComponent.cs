using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UMA;
using UnityEngine;

namespace COW;

public class LobbyAvatarClothEffectComponent : MonoBehaviour
{
	private sealed class _003CAutoShowMultiEventEffect_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LobbyAvatarClothEffectComponent _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoShowMultiEventEffect_003Ed__49(int _003C_003E1__state)
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

	private sealed class _003CAutoShowNormalEventEffect_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LobbyAvatarClothEffectComponent _003C_003E4__this;

		private bool _003CshowState_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoShowNormalEventEffect_003Ed__50(int _003C_003E1__state)
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

	private sealed class _003CAutoShowSoloEventEffect_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LobbyAvatarClothEffectComponent _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoShowSoloEventEffect_003Ed__48(int _003C_003E1__state)
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

	private sealed class _003CAutoShowTailorEventEffect_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LobbyAvatarClothEffectComponent _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoShowTailorEventEffect_003Ed__51(int _003C_003E1__state)
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

	private const uint AVATAREFFECTSHOWTIME = 6u;

	private const uint AVATAREFFECTHIDETIME = 2u;

	private const uint EFFECTINTERVAL = 4u;

	private const uint SOLOAVATAREFFECTSHOWTIME = 4u;

	private IUmaAvatar m_IAvatar;

	private List<GameObject> m_AnimEffects;

	private List<GameObject> m_AnimEffectsWithMandatoryDisplay;

	private List<GameObject> m_WeaponAnimEffects;

	private List<EffectObject> m_EventEffects;

	private Dictionary<uint, EffectObject> m_ResidentEffects;

	private List<EffectObject> m_MultiStateSkeletonEffects;

	private List<EffectObject> m_ExtraForceShowEffects;

	private List<EffectObject> m_NomralEventEffects;

	private Dictionary<uint, TailorEffectObject> m_TailorEventEffects;

	private Coroutine m_CoAutoShowTailorEventEffects;

	private Coroutine m_CoAutoShowNormalEventEffects;

	private Coroutine m_CoAutoShowSoloEventEffects;

	private Coroutine m_CoAutoShowMultiEventEffects;

	private UIModelTailor m_ModelTailor;

	private bool m_NotShowClothEffect;

	private bool m_CloseEffectFace;

	private Dictionary<uint, SoloEffectObject> m_DicIdToSoloEffects;

	private Dictionary<uint, MultiEffectObject> m_DicIdToMultiEffects;

	private bool m_IsPlayingSpecialEmoteWithSpecialShader;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void SetEffectsVisibilityForSpecialShader(bool v)
	{
	}

	public EffectObject GetResidentEffectObjectByClothId(uint id)
	{
		return null;
	}

	public GameObject PlayLobbyWeaponEffect(ResourceID effectID)
	{
		return null;
	}

	public void PlayLobbyAnimEffect(GameObject prefab, EffectObject eObject, EEffectType eEffectType)
	{
	}

	private void ProcessWeaponBoneNameRefs(GameObject go)
	{
	}

	private void ProcessBoneNameRefs(GameObject go, EffectObject eObject)
	{
	}

	private void ProcessBoneNameRefsOnly(GameObject go, EffectObject eObject, bool needRecover, bool addToEffectLists)
	{
	}

	private Transform ResolveBoneNameRefTransform(string boneName, bool allowAvatarNodeFallback)
	{
		return null;
	}

	public void ReProcessMultiStateBoneNameRefsWhenVisibleChange(bool visible)
	{
	}

	public void ResetMultiStateSkeletonRuntimeStateBeforeInvisible()
	{
	}

	public void SetMultiStateSkeletonEffectsVisibilityForSpecialAnim(bool visible)
	{
	}

	private void SetMultiStateSkeletonEffectObjectVisible(EffectObject effect, bool visible)
	{
	}

	private void RefreshMultiStateSkeletonRuntimeState(EffectObject effect)
	{
	}

	private void ResetMultiStateSkeletonRuntimeState(EffectObject effect)
	{
	}

	private void RecoverMultiStateBoneNameRefs(List<GameObject> gos)
	{
	}

	public void SetEventEffectsVisibility(bool isVisible, bool allEventEffects = true, bool takeEffectToTriggerEffects = true)
	{
	}

	private static bool ScaleInLocalSpace(GameObject o)
	{
		return false;
	}

	public void StopAnimEfects()
	{
	}

	public void StopAnimEffectsWithoutMandatoryDisplay()
	{
	}

	public void StopWeaponAnimEffects()
	{
	}

	public bool HasLoadedEventEffect()
	{
		return false;
	}

	private void StopAutoShowCoroutine()
	{
	}

	private IEnumerator AutoShowSoloEventEffect()
	{
		return null;
	}

	private IEnumerator AutoShowMultiEventEffect()
	{
		return null;
	}

	private IEnumerator AutoShowNormalEventEffect()
	{
		return null;
	}

	private IEnumerator AutoShowTailorEventEffect()
	{
		return null;
	}

	public List<EffectObject> GetExtraForceShowEffects()
	{
		return null;
	}

	public void SetNotShowClothEffect(bool notShow, bool closeEffectFace)
	{
	}
}

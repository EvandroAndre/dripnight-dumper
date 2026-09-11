using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UMA;
using UnityEngine;

namespace COW;

public class UIAvatarBase : Entity
{
	private sealed class _003CWaitUntilNotDirtyEnum_003Ed__69<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAvatarBase _003C_003E4__this;

		public Action<T> callback;

		public T t;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitUntilNotDirtyEnum_003Ed__69(int _003C_003E1__state)
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

	public SharedColorTable SkinColor;

	protected IUmaAvatar m_Avatar;

	protected GameObject m_AvatarGo;

	protected BoxCollider m_AvatarBoxCollider;

	public LobbyAvatarClothEffectComponent m_ClothEffectComponent;

	public MaterialAnimComponent m_MaterialAnimComponent;

	protected AvatarEffect m_AvatarEffect;

	private bool _003CUseIngameGroupAnimVfxInLobbySocialArea_003Ek__BackingField;

	protected bool m_IsLocalAvatar;

	public bool IsTeammateAvatar;

	protected ulong m_AccountId;

	protected FrontEndPreviewComponent m_FrontEndPreviewComponent;

	protected bool m_AvatarReady;

	protected bool m_AvatarCreated;

	private bool _003CIsClothReady_003Ek__BackingField;

	private bool _003CIsProcessCustomData_003Ek__BackingField;

	protected bool m_IsBuildingForJerseyNumber;

	protected bool m_PendingChangesForBuild;

	protected bool m_HidingSkinRender;

	protected bool m_IsPreviewAvatar;

	protected bool m_HasUpdateCallback;

	protected bool m_PlayEmoteBGMLoop;

	protected AudioResource m_AudioRes;

	public bool SkipInitBuild;

	protected int m_backpackSlot;

	protected UIModelTailor m_UIModelTailor;

	protected UIModelCollectionCustom m_UIModelCollectionCustom;

	public bool isUseSpecialAnimCtrl;

	public ResourceID SpecialAnimResID;

	public bool isNeedResetOnEnable;

	private UMAData m_CacheUMAData;

	public IUmaAvatar IAvatar => null;

	protected BoxCollider AvatarBoxCollider => null;

	public bool UseIngameGroupAnimVfxInLobbySocialArea
	{
		get
		{
			return _003CUseIngameGroupAnimVfxInLobbySocialArea_003Ek__BackingField;
		}
		set
		{
			_003CUseIngameGroupAnimVfxInLobbySocialArea_003Ek__BackingField = value;
		}
	}

	public FrontEndPreviewComponent FrontEndPreviewComponent => null;

	public bool IsLocalAvatar => false;

	public bool AvatarReady => false;

	public bool AvatarCreated => false;

	public bool IsClothReady
	{
		get
		{
			return _003CIsClothReady_003Ek__BackingField;
		}
		protected set
		{
			_003CIsClothReady_003Ek__BackingField = value;
		}
	}

	public bool IsProcessCustomData
	{
		get
		{
			return _003CIsProcessCustomData_003Ek__BackingField;
		}
		protected set
		{
			_003CIsProcessCustomData_003Ek__BackingField = value;
		}
	}

	public bool IsPreviewAvatar => false;

	public UMAData CacheUMAData => null;

	private void InitRecipeDic()
	{
	}

	public virtual void InitAvatar(bool isLocal, bool isPreview = false, int textureScale = 1, FrontEndPreviewComponent frontEndPreviewComponent = null, bool isTeammate = false)
	{
	}

	public void UpdateFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	public void HideRender(bool visble = false)
	{
	}

	public void SetOverrideDecalTexture(Texture tex, uint clothId, int recipeHash)
	{
	}

	public virtual void RegisterPausableManager()
	{
	}

	private void OnEnable()
	{
	}

	protected virtual void OnInitAvatarBeforeBuild(bool isLocal)
	{
	}

	protected virtual void CharacterCreatedCallback(UMAData umaData)
	{
	}

	private void OnCharacterReady(UMAData umaData)
	{
	}

	protected virtual void OnInitAvatarAfterBuild(bool isLocal)
	{
	}

	protected virtual void CharacterUpdateCallBack(UMAData umaData)
	{
	}

	protected IEnumerator WaitUntilNotDirty<T>(Action<T> callback, T t)
	{
		return null;
	}

	private IEnumerator WaitUntilNotDirtyEnum<T>(Action<T> callback, T t)
	{
		return null;
	}

	private bool IsUmaContextDestroyed()
	{
		return false;
	}

	internal virtual void SetSlot(int recipe, bool checkload = true)
	{
	}

	internal virtual void ClearSlot(string slot)
	{
	}

	protected void ClearSlotRaw(UIModelAvatarBase.EWardrobeType t)
	{
	}

	protected virtual void ChangeRace(string race)
	{
	}

	protected void SetColor(Color c, bool updateTexture)
	{
	}

	protected virtual void BuildAndUpdateAvatar()
	{
	}

	public void BuildIfChanged()
	{
	}

	public void WaitBuildSync(bool removeNonDirty = true)
	{
	}

	public bool IsAvatarDirty()
	{
		return false;
	}

	public void HidekinMeshRenderer(bool b)
	{
	}

	public void SetCharacterAway(bool isaway, bool idNeedMoveBoxCollider = false)
	{
	}
}

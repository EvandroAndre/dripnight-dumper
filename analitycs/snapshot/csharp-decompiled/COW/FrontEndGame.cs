using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

internal class FrontEndGame : COWGameBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__20_4;

		public static Action _003C_003E9__20_1;

		internal void _003COnUpdate_003Eb__20_1()
		{
		}

		internal void _003COnUpdate_003Eb__20_4()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public FrontEndGame _003C_003E4__this;

		public string titleKey;

		public string contentKey;

		internal void _003CDelayShowStartFailedDrawPopup_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public FrontEndGame _003C_003E4__this;

		public UIPopupMessageBoxController messageBox;

		public EAccount.Proto reason;

		internal void _003COnUpdate_003Eb__0()
		{
		}

		internal void _003COnUpdate_003Eb__2()
		{
		}

		internal void _003COnUpdate_003Eb__3()
		{
		}
	}

	private sealed class _003COnPreprocessFinished_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnPreprocessFinished_003Ed__19(int _003C_003E1__state)
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

	private sealed class _003CReloadCSVDataFromMemoryWithGC_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FrontEndGame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CReloadCSVDataFromMemoryWithGC_003Ed__31(int _003C_003E1__state)
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

	private static ResourceID[] SCENE_RESOURCE_LIST;

	public PostEffectManager postEffect;

	private bool m_SceneLoaded;

	private ShadowResolution originalShadowResolution;

	private uint mStartFailedDrawPopupDelayCall;

	private static List<Type> CacheTypesNeedsUnload;

	public new bool SceneLoaded => false;

	public override ResourceID[] GetResourceID()
	{
		return null;
	}

	public override Type GetUISceneType()
	{
		return null;
	}

	protected override void OnSceneLoaded()
	{
	}

	public override bool NeedPreloadBeforeLoadScene()
	{
		return false;
	}

	private void OnReturnToLobbyFromInGame()
	{
	}

	private void DelayShowStartFailedDrawPopup(string contentKey, string titleKey)
	{
	}

	public void CheckReconnectIfReachMaxResendCount()
	{
	}

	private void OnLastGameNeedReconnectConfirm()
	{
	}

	private void OnLastGameNeedReconnectCancel()
	{
	}

	public override ResourceID[] GetPreloadResourceIDSeq()
	{
		return null;
	}

	public override ResourceID[] GetPreloadResourceID()
	{
		return null;
	}

	public override int GetGameType()
	{
		return 0;
	}

	public override IEnumerator OnPreprocessFinished()
	{
		return null;
	}

	protected override void OnUpdate()
	{
	}

	private void OnCloseCallback(EAccount.Proto reason)
	{
	}

	public override void OnStartLoadScene()
	{
	}

	public void SetPostEffectProfile(bool isHD)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void ClearUIEvent()
	{
	}

	private bool NeedUnloadCSVFromMemory()
	{
		return false;
	}

	private void UnloadCSVDataFromMemory()
	{
	}

	private void ReloadCSVData()
	{
	}

	private void ReloadCSVDataFromMemory()
	{
	}

	private IEnumerator ReloadCSVDataFromMemoryWithGC()
	{
		return null;
	}

	public void ReloadTranslation(bool needOverride = false)
	{
	}

	private int GetResourcePoolInitCount(ResourceID resID)
	{
		return 0;
	}

	private void PrePoolInstantRes()
	{
	}

	protected override void OnPreloadLoaded()
	{
	}

	private void _003COnLastGameNeedReconnectConfirm_003Eb__14_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedPreloadBeforeLoadScene()
	{
		return false;
	}

	public ResourceID[] _003C_003EiFixBaseProxy_GetPreloadResourceIDSeq()
	{
		return null;
	}

	public ResourceID[] _003C_003EiFixBaseProxy_GetPreloadResourceID()
	{
		return null;
	}

	public int _003C_003EiFixBaseProxy_GetGameType()
	{
		return 0;
	}

	public IEnumerator _003C_003EiFixBaseProxy_OnPreprocessFinished()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUpdate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStartLoadScene()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPreloadLoaded()
	{
	}
}

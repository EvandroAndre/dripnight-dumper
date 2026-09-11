using System;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIGlobalCOWImpl : UIGlobalFacadeInterface
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public ResourceID delay_sound_resID;

		public int realBusType;

		internal void _003CPlayButtonClickSound_003Eb__0()
		{
		}
	}

	private const string LOADING_SPRITENAME = "";

	public void CancelGameDelayCall(uint id)
	{
	}

	public bool CheckIsInSpectatorSoundRange(Vector3 pos, uint resouceId)
	{
		return false;
	}

	public uint GameDelayCall(float delayTime, Action action, bool isRepeated = false)
	{
		return 0u;
	}

	public float GetInternalAudioVolume(float volume)
	{
		return 0f;
	}

	public void PlayButtonClickSound(string soundID, string delaySoundId, float delayTime, bool isCustom, EUIAudioSubBusType busType)
	{
	}

	public void RegisterKeyAction(string name, UIButton btn)
	{
	}

	public void SetNetworkTextureLoadingSprite(UISprite loadingSprite)
	{
	}

	public Renderer FindRenderInUMA(GameObject go)
	{
		return null;
	}

	public bool GetEnableUICameraSkipCulling()
	{
		return false;
	}

	public bool GetEnableCollectOnWillRenderObject()
	{
		return false;
	}

	public int GetCustomUIAtlasReleaserPendingCount()
	{
		return 0;
	}

	public int GetCustomUIAtlasReleaserContinuousFrameNum()
	{
		return 0;
	}

	public int GetCustomUIAtlasReleaserAtlasNum()
	{
		return 0;
	}

	public bool GetEnableNGUIRaycastNonAlloc()
	{
		return false;
	}

	public void ReportUIException(string msg, bool rethrow, bool showWindow)
	{
	}

	public bool GetEnableNGUIWidgetUpdateOpt()
	{
		return false;
	}

	public bool GetEnableNGUIActiveByScale()
	{
		return false;
	}

	public bool GetEnableUIMeshValidation()
	{
		return false;
	}

	public bool GetUITable2UseFrameCreate()
	{
		return false;
	}

	public bool GetEnableUIGeometryPool()
	{
		return false;
	}

	public bool GetUIAnimatedAlphaOpt()
	{
		return false;
	}

	public void OnPlayerPrefsUtilSave()
	{
	}

	public void DebuggerLog(string log)
	{
	}

	public bool NGUICallCreatePanelOptimization()
	{
		return false;
	}

	public bool NGUIGridListOptimization()
	{
		return false;
	}

	public bool GetEnableLegacyOnWillRenderObjectRegister()
	{
		return false;
	}

	public bool GetEnableUISpriteOptimizationOnLowMemory()
	{
		return false;
	}

	public bool GetEnableScreenResizeListOpt()
	{
		return false;
	}

	public bool GetEnableUIInputEnsureGeometry()
	{
		return false;
	}

	public bool GetInspectMobileInput()
	{
		return false;
	}

	public bool GetFixUIInput_iPad26NumPad()
	{
		return false;
	}
}

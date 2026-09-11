using System;
using GCommon;

namespace COW;

public class UIHudTrainingQuickSetController : UIBaseController
{
	private class UITraingSliderSettingItemController : UIInGameSliderSettingItemController
	{
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		public override void SetViewData(CommonSettingItemDataBase baseData, int type)
		{
		}

		protected override void UpdateWidgetBounds()
		{
		}

		public new void _003C_003EiFixBaseProxy_SetViewData(CommonSettingItemDataBase P0, int P1)
		{
		}

		public new void _003C_003EiFixBaseProxy_UpdateWidgetBounds()
		{
		}
	}

	private class UITrainingToggleSettingItemController : UIInGameSettingItemController
	{
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		protected override void UpdateWidgetBounds()
		{
		}

		public new void _003C_003EiFixBaseProxy_UpdateWidgetBounds()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<float> _003C_003E9__11_0;

		public static Action<float> _003C_003E9__12_0;

		public static Action<float> _003C_003E9__13_0;

		public static Action<float> _003C_003E9__14_0;

		public static Action<float> _003C_003E9__15_0;

		public static Action<float> _003C_003E9__16_0;

		public static Action<float> _003C_003E9__17_0;

		internal void _003CCreateSensitivityData_003Eb__11_0(float value)
		{
		}

		internal void _003CCreateSensitivity1PData_003Eb__12_0(float value)
		{
		}

		internal void _003CCreatex1ScopeData_003Eb__13_0(float value)
		{
		}

		internal void _003CCreatex2ScopeData_003Eb__14_0(float value)
		{
		}

		internal void _003CCreatex4ScopeData_003Eb__15_0(float value)
		{
		}

		internal void _003CCreatex8ScopeData_003Eb__16_0(float value)
		{
		}

		internal void _003CCreateAuxAimSensitivityData_003Eb__17_0(float value)
		{
		}
	}

	private UIHudTrainingQuickSetView m_View;

	private CommonSettingContentData m_Data;

	private UICommonSettingContentShortController m_Ctrl;

	private bool m_IsUGCModel1P;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void AddSetData(CommonSettingItemDataBase data)
	{
	}

	private InGameSettingItemDataToggleBtns CreatexSkillCdToggleData()
	{
		return null;
	}

	private void SendSetTrainingCDInfo()
	{
	}

	private InGameSettingItemDataSlider CreateSensitivityData()
	{
		return null;
	}

	private InGameSettingItemDataSlider CreateSensitivity1PData()
	{
		return null;
	}

	private InGameSettingItemDataSlider Createx1ScopeData()
	{
		return null;
	}

	private InGameSettingItemDataSlider Createx2ScopeData()
	{
		return null;
	}

	private InGameSettingItemDataSlider Createx4ScopeData()
	{
		return null;
	}

	private InGameSettingItemDataSlider Createx8ScopeData()
	{
		return null;
	}

	private InGameSettingItemDataSlider CreateAuxAimSensitivityData()
	{
		return null;
	}

	private float GetMinusValue()
	{
		return 0f;
	}

	private float GetPlusValue()
	{
		return 0f;
	}

	private void OnMiniGameStart(object[] data)
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnCloseQuickSet()
	{
	}

	private void OnLocalPlayerZoneChanged(object[] data)
	{
	}

	private void OnOpenQuickSet()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003CCreatexSkillCdToggleData_003Eb__9_0()
	{
	}

	private void _003CCreatexSkillCdToggleData_003Eb__9_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

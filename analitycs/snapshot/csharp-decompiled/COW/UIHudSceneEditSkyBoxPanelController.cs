using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudSceneEditSkyBoxPanelController : UIBaseController
{
	private enum AttributeType
	{
		LightColor,
		LightIntensity,
		Darkness,
		ShadowStrength,
		TerrainWetness,
		LensFlare,
		AmbientColor,
		FogEnable,
		FogColor,
		FogStartDistance,
		FogEndDistance
	}

	private class BasicConfig
	{
		public string DisplayName;

		public string FieldName;

		public bool RequiresAdvanceMode;

		public Transform RootTransform;

		public Func<JPLEGIBAHEN, bool> GetEnable;
	}

	private class SliderConfig : BasicConfig
	{
		public float DefaultMin;

		public float DefaultMax;

		public Action<JPLEGIBAHEN, float> SetValue;

		public Func<JPLEGIBAHEN, float> GetValue;

		public FloatRange Range;
	}

	private class ColorConfig : BasicConfig
	{
		public Action<JPLEGIBAHEN, int> SetValue;

		public Func<JPLEGIBAHEN, int> GetValue;

		public float DefaultAlpha;
	}

	private class ToggleConfig : BasicConfig
	{
		public Action<JPLEGIBAHEN, bool> SetValue;

		public Func<JPLEGIBAHEN, bool> GetValue;
	}

	private class NumbericConfig : BasicConfig
	{
		public float DefaultMin;

		public float DefaultMax;

		public Action<JPLEGIBAHEN, float> SetValue;

		public Func<JPLEGIBAHEN, float> GetValue;

		public FloatRange Range;
	}

	private struct FloatRange
	{
		public float Min;

		public float Max;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<JPLEGIBAHEN, int> _003C_003E9__25_0;

		public static Func<JPLEGIBAHEN, int> _003C_003E9__25_1;

		public static Action<JPLEGIBAHEN, float> _003C_003E9__25_2;

		public static Func<JPLEGIBAHEN, float> _003C_003E9__25_3;

		public static Action<JPLEGIBAHEN, float> _003C_003E9__25_4;

		public static Func<JPLEGIBAHEN, float> _003C_003E9__25_5;

		public static Action<JPLEGIBAHEN, float> _003C_003E9__25_6;

		public static Func<JPLEGIBAHEN, float> _003C_003E9__25_7;

		public static Action<JPLEGIBAHEN, float> _003C_003E9__25_8;

		public static Func<JPLEGIBAHEN, float> _003C_003E9__25_9;

		public static Action<JPLEGIBAHEN, float> _003C_003E9__25_10;

		public static Func<JPLEGIBAHEN, float> _003C_003E9__25_11;

		public static Action<JPLEGIBAHEN, int> _003C_003E9__25_12;

		public static Func<JPLEGIBAHEN, int> _003C_003E9__25_13;

		public static Func<JPLEGIBAHEN, bool> _003C_003E9__25_15;

		public static Action<JPLEGIBAHEN, int> _003C_003E9__25_16;

		public static Func<JPLEGIBAHEN, int> _003C_003E9__25_17;

		public static Func<JPLEGIBAHEN, bool> _003C_003E9__25_18;

		public static Action<JPLEGIBAHEN, float> _003C_003E9__25_19;

		public static Func<JPLEGIBAHEN, float> _003C_003E9__25_20;

		public static Func<JPLEGIBAHEN, bool> _003C_003E9__25_21;

		public static Action<JPLEGIBAHEN, float> _003C_003E9__25_22;

		public static Func<JPLEGIBAHEN, float> _003C_003E9__25_23;

		public static Func<JPLEGIBAHEN, bool> _003C_003E9__25_24;

		public static Action<GameObject> _003C_003E9__38_0;

		public static Action<UIHudSceneEditSkyBoxItem> _003C_003E9__38_1;

		public static Action<GameObject> _003C_003E9__38_2;

		internal void _003CInitializeAttributeConfigs_003Eb__25_0(JPLEGIBAHEN data, int value)
		{
		}

		internal int _003CInitializeAttributeConfigs_003Eb__25_1(JPLEGIBAHEN data)
		{
			return 0;
		}

		internal void _003CInitializeAttributeConfigs_003Eb__25_2(JPLEGIBAHEN data, float value)
		{
		}

		internal float _003CInitializeAttributeConfigs_003Eb__25_3(JPLEGIBAHEN data)
		{
			return 0f;
		}

		internal void _003CInitializeAttributeConfigs_003Eb__25_4(JPLEGIBAHEN data, float value)
		{
		}

		internal float _003CInitializeAttributeConfigs_003Eb__25_5(JPLEGIBAHEN data)
		{
			return 0f;
		}

		internal void _003CInitializeAttributeConfigs_003Eb__25_6(JPLEGIBAHEN data, float value)
		{
		}

		internal float _003CInitializeAttributeConfigs_003Eb__25_7(JPLEGIBAHEN data)
		{
			return 0f;
		}

		internal void _003CInitializeAttributeConfigs_003Eb__25_8(JPLEGIBAHEN data, float value)
		{
		}

		internal float _003CInitializeAttributeConfigs_003Eb__25_9(JPLEGIBAHEN data)
		{
			return 0f;
		}

		internal void _003CInitializeAttributeConfigs_003Eb__25_10(JPLEGIBAHEN data, float value)
		{
		}

		internal float _003CInitializeAttributeConfigs_003Eb__25_11(JPLEGIBAHEN data)
		{
			return 0f;
		}

		internal void _003CInitializeAttributeConfigs_003Eb__25_12(JPLEGIBAHEN data, int value)
		{
		}

		internal int _003CInitializeAttributeConfigs_003Eb__25_13(JPLEGIBAHEN data)
		{
			return 0;
		}

		internal bool _003CInitializeAttributeConfigs_003Eb__25_15(JPLEGIBAHEN data)
		{
			return false;
		}

		internal void _003CInitializeAttributeConfigs_003Eb__25_16(JPLEGIBAHEN data, int value)
		{
		}

		internal int _003CInitializeAttributeConfigs_003Eb__25_17(JPLEGIBAHEN data)
		{
			return 0;
		}

		internal bool _003CInitializeAttributeConfigs_003Eb__25_18(JPLEGIBAHEN data)
		{
			return false;
		}

		internal void _003CInitializeAttributeConfigs_003Eb__25_19(JPLEGIBAHEN data, float value)
		{
		}

		internal float _003CInitializeAttributeConfigs_003Eb__25_20(JPLEGIBAHEN data)
		{
			return 0f;
		}

		internal bool _003CInitializeAttributeConfigs_003Eb__25_21(JPLEGIBAHEN data)
		{
			return false;
		}

		internal void _003CInitializeAttributeConfigs_003Eb__25_22(JPLEGIBAHEN data, float value)
		{
		}

		internal float _003CInitializeAttributeConfigs_003Eb__25_23(JPLEGIBAHEN data)
		{
			return 0f;
		}

		internal bool _003CInitializeAttributeConfigs_003Eb__25_24(JPLEGIBAHEN data)
		{
			return false;
		}

		internal void _003CResetContainerState_003Eb__38_0(GameObject data)
		{
		}

		internal void _003CResetContainerState_003Eb__38_1(UIHudSceneEditSkyBoxItem data)
		{
		}

		internal void _003CResetContainerState_003Eb__38_2(GameObject data)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public GameObject centerGo;

		internal bool _003CGetCenterItem_003Eb__0(GameObject data)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public WorkShopCollaborationResources res;

		internal bool _003CRefreshSkyEnvList_003Eb__0(object e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public UIHudSceneEditSkyBoxPanelController _003C_003E4__this;

		public int attributeType;

		internal void _003CCreateOrUpdateAttribute_003Eb__0(string value)
		{
		}

		internal void _003CCreateOrUpdateAttribute_003Eb__1(string value)
		{
		}

		internal void _003CCreateOrUpdateAttribute_003Eb__2(string value)
		{
		}

		internal void _003CCreateOrUpdateAttribute_003Eb__3(string value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public string currentSkyEnv;

		internal bool _003CRefreshCurrentSkyEnv_003Eb__0(object data)
		{
			return false;
		}
	}

	private sealed class _003CJump2TargetCtrl_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject targetObj;

		public UIWidget targetWidget;

		public UIHudSceneEditSkyBoxPanelController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CJump2TargetCtrl_003Ed__28(int _003C_003E1__state)
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

	private UIHudSceneEditSkyBoxPanelView m_View;

	private HNDHJGJILHC m_Game;

	private List<object> m_SkyEnvResList;

	private int m_Index;

	private List<GameObject> m_GridContainers;

	private List<UIHudSceneEditSkyBoxItem> m_Items;

	private List<GameObject> m_CachedDotList;

	private bool m_SkyBoxCollapsed;

	private bool m_FogCollapsed;

	private Dictionary<int, UIHudSceneEditSkyBoxAttributeSliderController> m_Sliders;

	private Dictionary<int, UIHudSceneEditSkyBoxAttributeColorController> m_Colors;

	private Dictionary<int, UIHudSceneEditSkyBoxAttributeToggleController> m_Toggles;

	private Dictionary<int, UIHudSceneEditSkyBoxAttributeNumbericController> m_Numberics;

	private Dictionary<int, BasicConfig> m_AttributeConfigs;

	private const int GridCount = 6;

	private const uint CustomId = 999u;

	private bool m_IsCustomSkyEnvInited;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void InitializeAttributeConfigs()
	{
	}

	private void OnEditValueModify(object[] data)
	{
	}

	private void OnModeSettingVarCtrlJump(object[] data)
	{
	}

	private IEnumerator Jump2TargetCtrl(GameObject targetObj, UIWidget targetWidget)
	{
		return null;
	}

	private void SetSkyBoxCollapsed(bool collapsed)
	{
	}

	private void SetFogCollapsed(bool collapsed)
	{
	}

	private void ShowPanel()
	{
	}

	private void OnClickToHide(List<GameObject> hits)
	{
	}

	private void HidePanel()
	{
	}

	private void GetCenterItem(GameObject centerGo)
	{
	}

	private void ShowDotSelected(int index)
	{
	}

	private void RefreshSkyEnvList()
	{
	}

	private void GenerateContainer()
	{
	}

	private void ResetContainerState()
	{
	}

	private void HandleCustomSkyEnv(FFEAJEKGIIF sceneBuilder)
	{
	}

	private void GenerateSkyBoxItems(FFEAJEKGIIF sceneBuilder)
	{
	}

	private GameObject GetOrCreateGridContainer(int itemIndex)
	{
		return null;
	}

	private GameObject GetOrCreateSkyBoxItem(int index)
	{
		return null;
	}

	private void SetupSkyBoxItem(GameObject item, UIGrid grid, int index, FFEAJEKGIIF sceneBuilder)
	{
	}

	private void ConfigureScrollView()
	{
	}

	private void GenerateNavigationDots()
	{
	}

	private GameObject GetOrCreateNavigationDot(int index)
	{
		return null;
	}

	private void GenerateAttributes()
	{
	}

	private void RefreshTableHeight()
	{
	}

	private void CreateOrUpdateAttribute(int attributeType, JPLEGIBAHEN data)
	{
	}

	private void OnAttributeValueChange(int attributeType, string value)
	{
	}

	private void OnClickItem(int index, FDNOHKEMCKE data)
	{
	}

	private void RefreshCurrentSkyEnv()
	{
	}

	private static FloatRange GetFieldRange(Type hostType, string fieldName, float defaultMin, float defaultMax)
	{
		return default(FloatRange);
	}

	private void _003COnUIInit_003Eb__23_0(object[] args)
	{
	}

	private void _003COnUIInit_003Eb__23_1()
	{
	}

	private void _003COnUIInit_003Eb__23_2()
	{
	}

	private void _003CInitializeAttributeConfigs_003Eb__25_14(JPLEGIBAHEN data, bool value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

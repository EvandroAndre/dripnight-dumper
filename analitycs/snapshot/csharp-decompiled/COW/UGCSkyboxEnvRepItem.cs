using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCSkyboxEnvRepItem
{
	public const int PROP_ID_BASESKYENVRES = -122000;

	public const int PROP_ID_LIGHTCOLOR = -122001;

	public const int PROP_ID_LIGHTINTENSITY = -122002;

	public const int PROP_ID_DARKNESS = -122003;

	public const int PROP_ID_SHADOWSTRENGTH = -122004;

	public const int PROP_ID_TERRAINWETNESS = -122005;

	public const int PROP_ID_LENSFLARE = -122006;

	public const int PROP_ID_FOGCOLOR = -122007;

	public const int PROP_ID_AMBIENTCOLOR = -122008;

	public const int PROP_ID_NIGHTMODE = -122009;

	public const int PROP_ID_OWNERSUBLEVELGUID = -122010;

	public const int PROP_ID_FOG = -122011;

	public const int PROP_ID_FOGMODE = -122012;

	public const int PROP_ID_FOGDENSITY = -122013;

	public const int PROP_ID_FOGSTARTDISTANCE = -122014;

	public const int PROP_ID_FOGENDDISTANCE = -122015;

	public const int PROP_ID_ENABLEUGCFOGFEATURE = -122016;

	public const int PROP_ID_LIGHTROTATE = -122017;

	public const int PROP_ID_ENABLEUGCLIGHTROTATEFEATURE = -122018;

	public const int PROP_ID_CUSTOMMATERIAL = -122019;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnBaseSkyEnvResChangeEvent;

	public Action<int> OnLightColorChangeEvent;

	public Action<float> OnLightIntensityChangeEvent;

	public Action<float> OnDarknessChangeEvent;

	public Action<float> OnShadowStrengthChangeEvent;

	public Action<float> OnTerrainWetnessChangeEvent;

	public Action<float> OnLensFlareChangeEvent;

	public Action<int> OnFogColorChangeEvent;

	public Action<int> OnAmbientColorChangeEvent;

	public Action<bool> OnNightModeChangeEvent;

	public Action<string> OnOwnerSubLevelGUIDChangeEvent;

	public Action<bool> OnFogChangeEvent;

	public Action<int> OnFogModeChangeEvent;

	public Action<float> OnFogDensityChangeEvent;

	public Action<float> OnFogStartDistanceChangeEvent;

	public Action<float> OnFogEndDistanceChangeEvent;

	public Action<bool> OnEnableUGCFogFeatureChangeEvent;

	public Action<Quaternion> OnLightRotateChangeEvent;

	public Action<bool> OnEnableUGCLightRotateFeatureChangeEvent;

	public Action<string> OnCustomMaterialChangeEvent;

	private string _003CBaseSkyEnvRes_003Ek__BackingField;

	private int _003CLightColor_003Ek__BackingField;

	private float _003CLightIntensity_003Ek__BackingField;

	private float _003CDarkness_003Ek__BackingField;

	private float _003CShadowStrength_003Ek__BackingField;

	private float _003CTerrainWetness_003Ek__BackingField;

	private float _003CLensFlare_003Ek__BackingField;

	private int _003CFogColor_003Ek__BackingField;

	private int _003CAmbientColor_003Ek__BackingField;

	private bool _003CNightMode_003Ek__BackingField;

	private string _003COwnerSubLevelGUID_003Ek__BackingField;

	private bool _003CFog_003Ek__BackingField;

	private int _003CFogMode_003Ek__BackingField;

	private float _003CFogDensity_003Ek__BackingField;

	private float _003CFogStartDistance_003Ek__BackingField;

	private float _003CFogEndDistance_003Ek__BackingField;

	private bool _003CEnableUGCFogFeature_003Ek__BackingField;

	private Quaternion _003CLightRotate_003Ek__BackingField;

	private bool _003CEnableUGCLightRotateFeature_003Ek__BackingField;

	private string _003CCustomMaterial_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string BaseSkyEnvRes
	{
		get
		{
			return _003CBaseSkyEnvRes_003Ek__BackingField;
		}
		private set
		{
			_003CBaseSkyEnvRes_003Ek__BackingField = value;
		}
	}

	public int LightColor
	{
		get
		{
			return _003CLightColor_003Ek__BackingField;
		}
		private set
		{
			_003CLightColor_003Ek__BackingField = value;
		}
	}

	public float LightIntensity
	{
		get
		{
			return _003CLightIntensity_003Ek__BackingField;
		}
		private set
		{
			_003CLightIntensity_003Ek__BackingField = value;
		}
	}

	public float Darkness
	{
		get
		{
			return _003CDarkness_003Ek__BackingField;
		}
		private set
		{
			_003CDarkness_003Ek__BackingField = value;
		}
	}

	public float ShadowStrength
	{
		get
		{
			return _003CShadowStrength_003Ek__BackingField;
		}
		private set
		{
			_003CShadowStrength_003Ek__BackingField = value;
		}
	}

	public float TerrainWetness
	{
		get
		{
			return _003CTerrainWetness_003Ek__BackingField;
		}
		private set
		{
			_003CTerrainWetness_003Ek__BackingField = value;
		}
	}

	public float LensFlare
	{
		get
		{
			return _003CLensFlare_003Ek__BackingField;
		}
		private set
		{
			_003CLensFlare_003Ek__BackingField = value;
		}
	}

	public int FogColor
	{
		get
		{
			return _003CFogColor_003Ek__BackingField;
		}
		private set
		{
			_003CFogColor_003Ek__BackingField = value;
		}
	}

	public int AmbientColor
	{
		get
		{
			return _003CAmbientColor_003Ek__BackingField;
		}
		private set
		{
			_003CAmbientColor_003Ek__BackingField = value;
		}
	}

	public bool NightMode
	{
		get
		{
			return _003CNightMode_003Ek__BackingField;
		}
		private set
		{
			_003CNightMode_003Ek__BackingField = value;
		}
	}

	public string OwnerSubLevelGUID
	{
		get
		{
			return _003COwnerSubLevelGUID_003Ek__BackingField;
		}
		private set
		{
			_003COwnerSubLevelGUID_003Ek__BackingField = value;
		}
	}

	public bool Fog
	{
		get
		{
			return _003CFog_003Ek__BackingField;
		}
		private set
		{
			_003CFog_003Ek__BackingField = value;
		}
	}

	public int FogMode
	{
		get
		{
			return _003CFogMode_003Ek__BackingField;
		}
		private set
		{
			_003CFogMode_003Ek__BackingField = value;
		}
	}

	public float FogDensity
	{
		get
		{
			return _003CFogDensity_003Ek__BackingField;
		}
		private set
		{
			_003CFogDensity_003Ek__BackingField = value;
		}
	}

	public float FogStartDistance
	{
		get
		{
			return _003CFogStartDistance_003Ek__BackingField;
		}
		private set
		{
			_003CFogStartDistance_003Ek__BackingField = value;
		}
	}

	public float FogEndDistance
	{
		get
		{
			return _003CFogEndDistance_003Ek__BackingField;
		}
		private set
		{
			_003CFogEndDistance_003Ek__BackingField = value;
		}
	}

	public bool EnableUGCFogFeature
	{
		get
		{
			return _003CEnableUGCFogFeature_003Ek__BackingField;
		}
		private set
		{
			_003CEnableUGCFogFeature_003Ek__BackingField = value;
		}
	}

	public Quaternion LightRotate
	{
		get
		{
			return _003CLightRotate_003Ek__BackingField;
		}
		private set
		{
			_003CLightRotate_003Ek__BackingField = value;
		}
	}

	public bool EnableUGCLightRotateFeature
	{
		get
		{
			return _003CEnableUGCLightRotateFeature_003Ek__BackingField;
		}
		private set
		{
			_003CEnableUGCLightRotateFeature_003Ek__BackingField = value;
		}
	}

	public string CustomMaterial
	{
		get
		{
			return _003CCustomMaterial_003Ek__BackingField;
		}
		private set
		{
			_003CCustomMaterial_003Ek__BackingField = value;
		}
	}

	public string UGCEntityID
	{
		get
		{
			return _003CUGCEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CUGCEntityID_003Ek__BackingField = value;
		}
	}

	public UGCSkyboxEnvRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

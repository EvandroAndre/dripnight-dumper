using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class WeaponSetData : CSVBaseData, IGetId
{
	private int _003CweaponSetID_003Ek__BackingField;

	private int _003CevoWeaponType_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	private int _003CprevWeaponSetID_003Ek__BackingField;

	private int[] _003CCounter_003Ek__BackingField;

	private Color32 _003CCounterFontActiveColor_003Ek__BackingField;

	private Color32 _003CCounterFontDeactiveColor_003Ek__BackingField;

	private Color32 _003CCounterFontShadowColor_003Ek__BackingField;

	private uint[] _003CCounterFontShadowPos_003Ek__BackingField;

	private string _003CCounterStyleLobby_003Ek__BackingField;

	private string _003CCounterStyleIngame_003Ek__BackingField;

	private ResourceID _003CCounterVFXLobby_003Ek__BackingField;

	private ResourceID _003CCounterVFXIngame_003Ek__BackingField;

	private ResourceID _003CBgVFXStyle_003Ek__BackingField;

	private ResourceID _003CRenameHighLightVFX_003Ek__BackingField;

	private ResourceID _003CKillCountHighLightVFX_003Ek__BackingField;

	private string _003CTabStyle_003Ek__BackingField;

	private string _003CTabStyle2_003Ek__BackingField;

	private ResourceID _003CInfoStyle_003Ek__BackingField;

	private ResourceID _003CInfoStyle2_003Ek__BackingField;

	private Color32 _003CInfoStyle3_003Ek__BackingField;

	private Color32 _003CInfoStyle4_003Ek__BackingField;

	private ResourceID _003CLevelStyle1_003Ek__BackingField;

	private ResourceID _003CLevelStyle2_003Ek__BackingField;

	private ResourceID _003CLevelStyle3_003Ek__BackingField;

	private ResourceID _003CLevelStyle6_003Ek__BackingField;

	private ResourceID _003CLevelStyle7_003Ek__BackingField;

	private string _003CBG_003Ek__BackingField;

	private ResourceID _003CShareStyle_003Ek__BackingField;

	private Vector3 m_NaviPosition;

	private Vector3 m_NaviRotation;

	private Vector3 m_NaviScale;

	private Vector3 m_DetailPosition;

	private Vector3 m_DetailRotation;

	private Vector3 m_DetailScale;

	private Vector3 m_DefaultAvatarPosition;

	private Vector3 m_DefaultAvatarRotation;

	private Vector3 m_DefaultAvatarScale;

	private Vector3 m_GunTracePosition;

	private Vector3 m_GunTraceRotation;

	private Vector3 m_GunTraceScale;

	private Color32 _003CIngameKillCounterBackLightBottom_003Ek__BackingField;

	private Color32 _003CIngameKillCounterBackLightTop_003Ek__BackingField;

	private Color32 _003CCustomCustomizePopupButtonColor_003Ek__BackingField;

	private Color32 _003CWeaponNameVer2ColorTop_003Ek__BackingField;

	private Color32 _003CWeaponNameVer2ColorBottom_003Ek__BackingField;

	private Color32 _003CWeaponNameVer2ShadowColor_003Ek__BackingField;

	private Color32 _003CWeaponNameVer2EffectShadowColor_003Ek__BackingField;

	private Vector2 _003CWeaponNameVer2EffectShadowPos_003Ek__BackingField;

	private ResourceID _003CWeaponNameVer2VFX_003Ek__BackingField;

	private ResourceID _003CCustomCustomizePopupVFX_003Ek__BackingField;

	private string _003CBGExchange_003Ek__BackingField;

	private Vector3 _003CBgVFXStyleArmoryPosition_003Ek__BackingField;

	private Vector3 _003CBgVFXStyleArmoryScale_003Ek__BackingField;

	private Dictionary<int, float> BannerInfo;

	public int weaponSetID
	{
		get
		{
			return _003CweaponSetID_003Ek__BackingField;
		}
		private set
		{
			_003CweaponSetID_003Ek__BackingField = value;
		}
	}

	public int evoWeaponType
	{
		get
		{
			return _003CevoWeaponType_003Ek__BackingField;
		}
		private set
		{
			_003CevoWeaponType_003Ek__BackingField = value;
		}
	}

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		private set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public int prevWeaponSetID
	{
		get
		{
			return _003CprevWeaponSetID_003Ek__BackingField;
		}
		set
		{
			_003CprevWeaponSetID_003Ek__BackingField = value;
		}
	}

	public int[] Counter
	{
		get
		{
			return _003CCounter_003Ek__BackingField;
		}
		private set
		{
			_003CCounter_003Ek__BackingField = value;
		}
	}

	public Color32 CounterFontActiveColor
	{
		get
		{
			return _003CCounterFontActiveColor_003Ek__BackingField;
		}
		private set
		{
			_003CCounterFontActiveColor_003Ek__BackingField = value;
		}
	}

	public Color32 CounterFontDeactiveColor
	{
		get
		{
			return _003CCounterFontDeactiveColor_003Ek__BackingField;
		}
		private set
		{
			_003CCounterFontDeactiveColor_003Ek__BackingField = value;
		}
	}

	public Color32 CounterFontShadowColor
	{
		get
		{
			return _003CCounterFontShadowColor_003Ek__BackingField;
		}
		private set
		{
			_003CCounterFontShadowColor_003Ek__BackingField = value;
		}
	}

	public uint[] CounterFontShadowPos
	{
		get
		{
			return _003CCounterFontShadowPos_003Ek__BackingField;
		}
		private set
		{
			_003CCounterFontShadowPos_003Ek__BackingField = value;
		}
	}

	public string CounterStyleLobby
	{
		get
		{
			return _003CCounterStyleLobby_003Ek__BackingField;
		}
		private set
		{
			_003CCounterStyleLobby_003Ek__BackingField = value;
		}
	}

	public string CounterStyleIngame
	{
		get
		{
			return _003CCounterStyleIngame_003Ek__BackingField;
		}
		private set
		{
			_003CCounterStyleIngame_003Ek__BackingField = value;
		}
	}

	public ResourceID CounterVFXLobby
	{
		get
		{
			return _003CCounterVFXLobby_003Ek__BackingField;
		}
		private set
		{
			_003CCounterVFXLobby_003Ek__BackingField = value;
		}
	}

	public ResourceID CounterVFXIngame
	{
		get
		{
			return _003CCounterVFXIngame_003Ek__BackingField;
		}
		private set
		{
			_003CCounterVFXIngame_003Ek__BackingField = value;
		}
	}

	public ResourceID BgVFXStyle
	{
		get
		{
			return _003CBgVFXStyle_003Ek__BackingField;
		}
		private set
		{
			_003CBgVFXStyle_003Ek__BackingField = value;
		}
	}

	public ResourceID RenameHighLightVFX
	{
		get
		{
			return _003CRenameHighLightVFX_003Ek__BackingField;
		}
		private set
		{
			_003CRenameHighLightVFX_003Ek__BackingField = value;
		}
	}

	public ResourceID KillCountHighLightVFX
	{
		get
		{
			return _003CKillCountHighLightVFX_003Ek__BackingField;
		}
		private set
		{
			_003CKillCountHighLightVFX_003Ek__BackingField = value;
		}
	}

	public string TabStyle
	{
		get
		{
			return _003CTabStyle_003Ek__BackingField;
		}
		private set
		{
			_003CTabStyle_003Ek__BackingField = value;
		}
	}

	public string TabStyle2
	{
		get
		{
			return _003CTabStyle2_003Ek__BackingField;
		}
		private set
		{
			_003CTabStyle2_003Ek__BackingField = value;
		}
	}

	public ResourceID InfoStyle
	{
		get
		{
			return _003CInfoStyle_003Ek__BackingField;
		}
		private set
		{
			_003CInfoStyle_003Ek__BackingField = value;
		}
	}

	public ResourceID InfoStyle2
	{
		get
		{
			return _003CInfoStyle2_003Ek__BackingField;
		}
		private set
		{
			_003CInfoStyle2_003Ek__BackingField = value;
		}
	}

	public Color32 InfoStyle3
	{
		get
		{
			return _003CInfoStyle3_003Ek__BackingField;
		}
		private set
		{
			_003CInfoStyle3_003Ek__BackingField = value;
		}
	}

	public Color32 InfoStyle4
	{
		get
		{
			return _003CInfoStyle4_003Ek__BackingField;
		}
		private set
		{
			_003CInfoStyle4_003Ek__BackingField = value;
		}
	}

	public ResourceID LevelStyle1
	{
		get
		{
			return _003CLevelStyle1_003Ek__BackingField;
		}
		private set
		{
			_003CLevelStyle1_003Ek__BackingField = value;
		}
	}

	public ResourceID LevelStyle2
	{
		get
		{
			return _003CLevelStyle2_003Ek__BackingField;
		}
		private set
		{
			_003CLevelStyle2_003Ek__BackingField = value;
		}
	}

	public ResourceID LevelStyle3
	{
		get
		{
			return _003CLevelStyle3_003Ek__BackingField;
		}
		private set
		{
			_003CLevelStyle3_003Ek__BackingField = value;
		}
	}

	public ResourceID LevelStyle6
	{
		get
		{
			return _003CLevelStyle6_003Ek__BackingField;
		}
		private set
		{
			_003CLevelStyle6_003Ek__BackingField = value;
		}
	}

	public ResourceID LevelStyle7
	{
		get
		{
			return _003CLevelStyle7_003Ek__BackingField;
		}
		private set
		{
			_003CLevelStyle7_003Ek__BackingField = value;
		}
	}

	public string BG
	{
		get
		{
			return _003CBG_003Ek__BackingField;
		}
		private set
		{
			_003CBG_003Ek__BackingField = value;
		}
	}

	public ResourceID ShareStyle
	{
		get
		{
			return _003CShareStyle_003Ek__BackingField;
		}
		private set
		{
			_003CShareStyle_003Ek__BackingField = value;
		}
	}

	public Vector3 NaviPosition => default(Vector3);

	public Vector3 NaviRotation => default(Vector3);

	public Vector3 NaviScale => default(Vector3);

	public Vector3 DetailPosition => default(Vector3);

	public Vector3 DetailRotation => default(Vector3);

	public Vector3 DetailScale => default(Vector3);

	public Vector3 DefaultAvatarPosition => default(Vector3);

	public Vector3 DefaultAvatarRotation => default(Vector3);

	public Vector3 DefaultAvatarScale => default(Vector3);

	public Vector3 GunTracePosition => default(Vector3);

	public Vector3 GunTraceRotation => default(Vector3);

	public Vector3 GunTraceScale => default(Vector3);

	public Color32 IngameKillCounterBackLightBottom
	{
		get
		{
			return _003CIngameKillCounterBackLightBottom_003Ek__BackingField;
		}
		private set
		{
			_003CIngameKillCounterBackLightBottom_003Ek__BackingField = value;
		}
	}

	public Color32 IngameKillCounterBackLightTop
	{
		get
		{
			return _003CIngameKillCounterBackLightTop_003Ek__BackingField;
		}
		private set
		{
			_003CIngameKillCounterBackLightTop_003Ek__BackingField = value;
		}
	}

	public Color32 CustomCustomizePopupButtonColor
	{
		get
		{
			return _003CCustomCustomizePopupButtonColor_003Ek__BackingField;
		}
		private set
		{
			_003CCustomCustomizePopupButtonColor_003Ek__BackingField = value;
		}
	}

	public Color32 WeaponNameVer2ColorTop
	{
		get
		{
			return _003CWeaponNameVer2ColorTop_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponNameVer2ColorTop_003Ek__BackingField = value;
		}
	}

	public Color32 WeaponNameVer2ColorBottom
	{
		get
		{
			return _003CWeaponNameVer2ColorBottom_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponNameVer2ColorBottom_003Ek__BackingField = value;
		}
	}

	public Color32 WeaponNameVer2ShadowColor
	{
		get
		{
			return _003CWeaponNameVer2ShadowColor_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponNameVer2ShadowColor_003Ek__BackingField = value;
		}
	}

	public Color32 WeaponNameVer2EffectShadowColor
	{
		get
		{
			return _003CWeaponNameVer2EffectShadowColor_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponNameVer2EffectShadowColor_003Ek__BackingField = value;
		}
	}

	public Vector2 WeaponNameVer2EffectShadowPos
	{
		get
		{
			return _003CWeaponNameVer2EffectShadowPos_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponNameVer2EffectShadowPos_003Ek__BackingField = value;
		}
	}

	public ResourceID WeaponNameVer2VFX
	{
		get
		{
			return _003CWeaponNameVer2VFX_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponNameVer2VFX_003Ek__BackingField = value;
		}
	}

	public ResourceID CustomCustomizePopupVFX
	{
		get
		{
			return _003CCustomCustomizePopupVFX_003Ek__BackingField;
		}
		private set
		{
			_003CCustomCustomizePopupVFX_003Ek__BackingField = value;
		}
	}

	public string BGExchange
	{
		get
		{
			return _003CBGExchange_003Ek__BackingField;
		}
		private set
		{
			_003CBGExchange_003Ek__BackingField = value;
		}
	}

	public Vector3 BgVFXStyleArmoryPosition
	{
		get
		{
			return _003CBgVFXStyleArmoryPosition_003Ek__BackingField;
		}
		private set
		{
			_003CBgVFXStyleArmoryPosition_003Ek__BackingField = value;
		}
	}

	public Vector3 BgVFXStyleArmoryScale
	{
		get
		{
			return _003CBgVFXStyleArmoryScale_003Ek__BackingField;
		}
		private set
		{
			_003CBgVFXStyleArmoryScale_003Ek__BackingField = value;
		}
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public Dictionary<int, float> ConvertBannerInfoToDict(string input)
	{
		return null;
	}

	public float GetBannerInfoDataTimeByRewardID(int rewardID)
	{
		return 0f;
	}

	public Vector3 TransStringToVector3(string head, string[] headers, string[] values, Vector3? defaultValue = null)
	{
		return default(Vector3);
	}

	public Vector2 TransStringToVector2(string head, string[] headers, string[] values)
	{
		return default(Vector2);
	}

	public bool IsEvoGunVer2()
	{
		return false;
	}

	public bool IsEvoGunVer1()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}

using GCommon;
using UnityEngine;

namespace COW;

public class LeaderBoardTitleConfigData : CSVBaseData, IGetId
{
	private uint _003CTitleID_003Ek__BackingField;

	private ResourceID _003CIconSprite_003Ek__BackingField;

	private ResourceID _003CSingleBg_003Ek__BackingField;

	private ResourceID _003CCommonBg_003Ek__BackingField;

	private ResourceID _003CIconVFX_003Ek__BackingField;

	private uint _003CTitileType_003Ek__BackingField;

	private uint _003CTitlePriority_003Ek__BackingField;

	private Color _003CIconLabelColor_003Ek__BackingField;

	private Color _003CIconShadowColor_003Ek__BackingField;

	public static Color DEFAULT_ICON_LABEL_COLOR;

	public static Color DEFAULT_ICON_SHADOW_LABEL_COLOR;

	public uint TitleID
	{
		get
		{
			return _003CTitleID_003Ek__BackingField;
		}
		private set
		{
			_003CTitleID_003Ek__BackingField = value;
		}
	}

	public ResourceID IconSprite
	{
		get
		{
			return _003CIconSprite_003Ek__BackingField;
		}
		private set
		{
			_003CIconSprite_003Ek__BackingField = value;
		}
	}

	public ResourceID SingleBg
	{
		get
		{
			return _003CSingleBg_003Ek__BackingField;
		}
		private set
		{
			_003CSingleBg_003Ek__BackingField = value;
		}
	}

	public ResourceID CommonBg
	{
		get
		{
			return _003CCommonBg_003Ek__BackingField;
		}
		private set
		{
			_003CCommonBg_003Ek__BackingField = value;
		}
	}

	public ResourceID IconVFX
	{
		get
		{
			return _003CIconVFX_003Ek__BackingField;
		}
		private set
		{
			_003CIconVFX_003Ek__BackingField = value;
		}
	}

	public uint TitileType
	{
		get
		{
			return _003CTitileType_003Ek__BackingField;
		}
		private set
		{
			_003CTitileType_003Ek__BackingField = value;
		}
	}

	public uint TitlePriority
	{
		get
		{
			return _003CTitlePriority_003Ek__BackingField;
		}
		private set
		{
			_003CTitlePriority_003Ek__BackingField = value;
		}
	}

	public Color IconLabelColor
	{
		get
		{
			return _003CIconLabelColor_003Ek__BackingField;
		}
		private set
		{
			_003CIconLabelColor_003Ek__BackingField = value;
		}
	}

	public Color IconShadowColor
	{
		get
		{
			return _003CIconShadowColor_003Ek__BackingField;
		}
		private set
		{
			_003CIconShadowColor_003Ek__BackingField = value;
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

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}

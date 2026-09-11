using System;
using GCommon;
using UnityEngine;

namespace COW;

public class MiniMapBottomInfoEvent : GEvent
{
	private ResourceID _003CIconRes_003Ek__BackingField;

	public bool IconResMakePixelPerfect;

	private ResourceID _003CVfxRes_003Ek__BackingField;

	private string _003CInfo_003Ek__BackingField;

	private bool _003CShowProgressBar_003Ek__BackingField;

	private Color _003CColor1_003Ek__BackingField;

	private Color _003CColor2_003Ek__BackingField;

	private UIBasicSprite.ApplyGradient _003CGradient_003Ek__BackingField;

	private float _003CTotalTime_003Ek__BackingField;

	private float _003CStartTime_003Ek__BackingField;

	private bool _003CShouldTurnRed_003Ek__BackingField;

	private float _003CRedTime_003Ek__BackingField;

	private Func<float> _003CGetProgressValue_003Ek__BackingField;

	public ResourceID IconRes
	{
		get
		{
			return _003CIconRes_003Ek__BackingField;
		}
		set
		{
			_003CIconRes_003Ek__BackingField = value;
		}
	}

	public ResourceID VfxRes
	{
		get
		{
			return _003CVfxRes_003Ek__BackingField;
		}
		set
		{
			_003CVfxRes_003Ek__BackingField = value;
		}
	}

	public string Info
	{
		get
		{
			return _003CInfo_003Ek__BackingField;
		}
		set
		{
			_003CInfo_003Ek__BackingField = value;
		}
	}

	public bool ShowProgressBar
	{
		get
		{
			return _003CShowProgressBar_003Ek__BackingField;
		}
		set
		{
			_003CShowProgressBar_003Ek__BackingField = value;
		}
	}

	public Color Color1
	{
		get
		{
			return _003CColor1_003Ek__BackingField;
		}
		set
		{
			_003CColor1_003Ek__BackingField = value;
		}
	}

	public Color Color2
	{
		get
		{
			return _003CColor2_003Ek__BackingField;
		}
		set
		{
			_003CColor2_003Ek__BackingField = value;
		}
	}

	public UIBasicSprite.ApplyGradient Gradient
	{
		get
		{
			return _003CGradient_003Ek__BackingField;
		}
		set
		{
			_003CGradient_003Ek__BackingField = value;
		}
	}

	public float TotalTime
	{
		get
		{
			return _003CTotalTime_003Ek__BackingField;
		}
		set
		{
			_003CTotalTime_003Ek__BackingField = value;
		}
	}

	public float StartTime
	{
		get
		{
			return _003CStartTime_003Ek__BackingField;
		}
		set
		{
			_003CStartTime_003Ek__BackingField = value;
		}
	}

	public bool ShouldTurnRed
	{
		get
		{
			return _003CShouldTurnRed_003Ek__BackingField;
		}
		set
		{
			_003CShouldTurnRed_003Ek__BackingField = value;
		}
	}

	public float RedTime
	{
		get
		{
			return _003CRedTime_003Ek__BackingField;
		}
		set
		{
			_003CRedTime_003Ek__BackingField = value;
		}
	}

	public Func<float> GetProgressValue
	{
		get
		{
			return _003CGetProgressValue_003Ek__BackingField;
		}
		set
		{
			_003CGetProgressValue_003Ek__BackingField = value;
		}
	}
}

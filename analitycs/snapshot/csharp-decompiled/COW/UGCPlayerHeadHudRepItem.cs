using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCPlayerHeadHudRepItem
{
	public const int PROP_ID_MAINCOLOR = -374000;

	public const int PROP_ID_LOSEHPCOLOR = -374001;

	public const int PROP_ID_GAINHPCOLOR = -374002;

	public const int PROP_ID_BACKGRCOLOR = -374003;

	public const int PROP_ID_ALPHA = -374004;

	public const int PROP_ID_SCALE = -374005;

	public const int PROP_ID_PLAYERNAME = -374006;

	public const int PROP_ID_LEVEL = -374007;

	public const int PROP_ID_WIDTH = -374008;

	public const int PROP_ID_FOLLOWTARGET = -374009;

	public const int PROP_ID_OFFSET = -374010;

	public const int PROP_ID_LINESPACING = -374011;

	public const int PROP_ID_TOTALHP = -374012;

	public const int PROP_ID_CURRENTHP = -374013;

	public const int PROP_ID_ISOPENTWEEN = -374014;

	public const int PROP_ID_ISLOCALPOS = -374015;

	public const int PROP_ID_VISIBLEPLAYERS = -374016;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnMainColorChangeEvent;

	public Action<int> OnLoseHpColorChangeEvent;

	public Action<int> OnGainHpColorChangeEvent;

	public Action<int> OnBackGrColorChangeEvent;

	public Action<float> OnAlphaChangeEvent;

	public Action<Vector3> OnScaleChangeEvent;

	public Action<string> OnPlayerNameChangeEvent;

	public Action<int> OnLevelChangeEvent;

	public Action<int> OnWidthChangeEvent;

	public Action<string> OnFollowTargetChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	public Action<int> OnLineSpacingChangeEvent;

	public Action<int> OnTotalHpChangeEvent;

	public Action<int> OnCurrentHpChangeEvent;

	public Action<bool> OnIsOpenTweenChangeEvent;

	public Action<bool> OnIsLocalPosChangeEvent;

	public Action<List<object>> OnVisiblePlayersChangeEvent;

	private int _003CMainColor_003Ek__BackingField;

	private int _003CLoseHpColor_003Ek__BackingField;

	private int _003CGainHpColor_003Ek__BackingField;

	private int _003CBackGrColor_003Ek__BackingField;

	private float _003CAlpha_003Ek__BackingField;

	private Vector3 _003CScale_003Ek__BackingField;

	private string _003CPlayerName_003Ek__BackingField;

	private int _003CLevel_003Ek__BackingField;

	private int _003CWidth_003Ek__BackingField;

	private string _003CFollowTarget_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

	private int _003CLineSpacing_003Ek__BackingField;

	private int _003CTotalHp_003Ek__BackingField;

	private int _003CCurrentHp_003Ek__BackingField;

	private bool _003CIsOpenTween_003Ek__BackingField;

	private bool _003CIsLocalPos_003Ek__BackingField;

	private List<object> _003CVisiblePlayers_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int MainColor
	{
		get
		{
			return _003CMainColor_003Ek__BackingField;
		}
		private set
		{
			_003CMainColor_003Ek__BackingField = value;
		}
	}

	public int LoseHpColor
	{
		get
		{
			return _003CLoseHpColor_003Ek__BackingField;
		}
		private set
		{
			_003CLoseHpColor_003Ek__BackingField = value;
		}
	}

	public int GainHpColor
	{
		get
		{
			return _003CGainHpColor_003Ek__BackingField;
		}
		private set
		{
			_003CGainHpColor_003Ek__BackingField = value;
		}
	}

	public int BackGrColor
	{
		get
		{
			return _003CBackGrColor_003Ek__BackingField;
		}
		private set
		{
			_003CBackGrColor_003Ek__BackingField = value;
		}
	}

	public float Alpha
	{
		get
		{
			return _003CAlpha_003Ek__BackingField;
		}
		private set
		{
			_003CAlpha_003Ek__BackingField = value;
		}
	}

	public Vector3 Scale
	{
		get
		{
			return _003CScale_003Ek__BackingField;
		}
		private set
		{
			_003CScale_003Ek__BackingField = value;
		}
	}

	public string PlayerName
	{
		get
		{
			return _003CPlayerName_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerName_003Ek__BackingField = value;
		}
	}

	public int Level
	{
		get
		{
			return _003CLevel_003Ek__BackingField;
		}
		private set
		{
			_003CLevel_003Ek__BackingField = value;
		}
	}

	public int Width
	{
		get
		{
			return _003CWidth_003Ek__BackingField;
		}
		private set
		{
			_003CWidth_003Ek__BackingField = value;
		}
	}

	public string FollowTarget
	{
		get
		{
			return _003CFollowTarget_003Ek__BackingField;
		}
		private set
		{
			_003CFollowTarget_003Ek__BackingField = value;
		}
	}

	public Vector3 Offset
	{
		get
		{
			return _003COffset_003Ek__BackingField;
		}
		private set
		{
			_003COffset_003Ek__BackingField = value;
		}
	}

	public int LineSpacing
	{
		get
		{
			return _003CLineSpacing_003Ek__BackingField;
		}
		private set
		{
			_003CLineSpacing_003Ek__BackingField = value;
		}
	}

	public int TotalHp
	{
		get
		{
			return _003CTotalHp_003Ek__BackingField;
		}
		private set
		{
			_003CTotalHp_003Ek__BackingField = value;
		}
	}

	public int CurrentHp
	{
		get
		{
			return _003CCurrentHp_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentHp_003Ek__BackingField = value;
		}
	}

	public bool IsOpenTween
	{
		get
		{
			return _003CIsOpenTween_003Ek__BackingField;
		}
		private set
		{
			_003CIsOpenTween_003Ek__BackingField = value;
		}
	}

	public bool IsLocalPos
	{
		get
		{
			return _003CIsLocalPos_003Ek__BackingField;
		}
		private set
		{
			_003CIsLocalPos_003Ek__BackingField = value;
		}
	}

	public List<object> VisiblePlayers
	{
		get
		{
			return _003CVisiblePlayers_003Ek__BackingField;
		}
		private set
		{
			_003CVisiblePlayers_003Ek__BackingField = value;
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

	public UGCPlayerHeadHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

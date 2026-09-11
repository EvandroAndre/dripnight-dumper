using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCDrawingFilterStyleRepItem
{
	public const int PROP_ID_PENCILSIZE = -482000;

	public const int PROP_ID_PENCILCORRECTION = -482001;

	public const int PROP_ID_PENCILCOLOR = -482002;

	public const int PROP_ID_PAPERCOLOR = -482003;

	public const int PROP_ID_CORNERLOSE = -482004;

	public const int PROP_ID_PAPERTEX = -482005;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnPencilSizeChangeEvent;

	public Action<float> OnPencilCorrectionChangeEvent;

	public Action<int> OnPencilColorChangeEvent;

	public Action<int> OnPaperColorChangeEvent;

	public Action<float> OnCornerLoseChangeEvent;

	public Action<string> OnPaperTexChangeEvent;

	private float _003CPencilSize_003Ek__BackingField;

	private float _003CPencilCorrection_003Ek__BackingField;

	private int _003CPencilColor_003Ek__BackingField;

	private int _003CPaperColor_003Ek__BackingField;

	private float _003CCornerLose_003Ek__BackingField;

	private string _003CPaperTex_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float PencilSize
	{
		get
		{
			return _003CPencilSize_003Ek__BackingField;
		}
		private set
		{
			_003CPencilSize_003Ek__BackingField = value;
		}
	}

	public float PencilCorrection
	{
		get
		{
			return _003CPencilCorrection_003Ek__BackingField;
		}
		private set
		{
			_003CPencilCorrection_003Ek__BackingField = value;
		}
	}

	public int PencilColor
	{
		get
		{
			return _003CPencilColor_003Ek__BackingField;
		}
		private set
		{
			_003CPencilColor_003Ek__BackingField = value;
		}
	}

	public int PaperColor
	{
		get
		{
			return _003CPaperColor_003Ek__BackingField;
		}
		private set
		{
			_003CPaperColor_003Ek__BackingField = value;
		}
	}

	public float CornerLose
	{
		get
		{
			return _003CCornerLose_003Ek__BackingField;
		}
		private set
		{
			_003CCornerLose_003Ek__BackingField = value;
		}
	}

	public string PaperTex
	{
		get
		{
			return _003CPaperTex_003Ek__BackingField;
		}
		private set
		{
			_003CPaperTex_003Ek__BackingField = value;
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

	public UGCDrawingFilterStyleRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}

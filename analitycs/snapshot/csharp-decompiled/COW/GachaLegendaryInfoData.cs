using proto;

namespace COW;

public class GachaLegendaryInfoData : GachaPackageInfoData
{
	private const string MULTY_BUY_LEVEL_KEY = "GACHA_{0}_MULTY_BUY_LEVEL_{1}";

	private uint _003CTokenNum_003Ek__BackingField;

	private uint _003CTokenItemID_003Ek__BackingField;

	private uint _003CTokenID_003Ek__BackingField;

	private bool _003CHasSpecialToken_003Ek__BackingField;

	private bool _003CFinishAllTokens_003Ek__BackingField;

	private uint _003CGuaranteedDrop_003Ek__BackingField;

	private int _003CMultiDrawLevel_003Ek__BackingField;

	public uint TokenNum
	{
		get
		{
			return _003CTokenNum_003Ek__BackingField;
		}
		private set
		{
			_003CTokenNum_003Ek__BackingField = value;
		}
	}

	public uint TokenItemID
	{
		get
		{
			return _003CTokenItemID_003Ek__BackingField;
		}
		private set
		{
			_003CTokenItemID_003Ek__BackingField = value;
		}
	}

	public uint TokenID
	{
		get
		{
			return _003CTokenID_003Ek__BackingField;
		}
		private set
		{
			_003CTokenID_003Ek__BackingField = value;
		}
	}

	public bool HasSpecialToken
	{
		get
		{
			return _003CHasSpecialToken_003Ek__BackingField;
		}
		private set
		{
			_003CHasSpecialToken_003Ek__BackingField = value;
		}
	}

	public bool FinishAllTokens
	{
		get
		{
			return _003CFinishAllTokens_003Ek__BackingField;
		}
		private set
		{
			_003CFinishAllTokens_003Ek__BackingField = value;
		}
	}

	public uint GuaranteedDrop
	{
		get
		{
			return _003CGuaranteedDrop_003Ek__BackingField;
		}
		private set
		{
			_003CGuaranteedDrop_003Ek__BackingField = value;
		}
	}

	public int MultiDrawLevel
	{
		get
		{
			return _003CMultiDrawLevel_003Ek__BackingField;
		}
		private set
		{
			_003CMultiDrawLevel_003Ek__BackingField = value;
		}
	}

	public override void UpdateByGachaResult(CSLotteryRes gachaResult, UIModelGacha.GachaDrawType drawType = UIModelGacha.GachaDrawType.TYPE_NONE)
	{
	}

	protected override void OnProcessDescData(GachaDesc gachaRes)
	{
	}

	protected override void ProcessSuperGrandPrize()
	{
	}

	protected override void OnUpdateInfoData()
	{
	}

	public void ResetState()
	{
	}

	private void UpdateTokenNumByDrawResult(CSLotteryRes gachaResult)
	{
	}

	public void AddMultiDrawLevel()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateByGachaResult(CSLotteryRes P0, UIModelGacha.GachaDrawType P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnProcessDescData(GachaDesc P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ProcessSuperGrandPrize()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdateInfoData()
	{
	}
}

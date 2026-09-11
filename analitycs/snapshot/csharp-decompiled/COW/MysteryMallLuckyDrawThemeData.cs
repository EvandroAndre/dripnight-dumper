using System.Collections.Generic;
using GCommon;

namespace COW;

public class MysteryMallLuckyDrawThemeData : CSVBaseData
{
	public enum ECustomLabelType
	{
		LabelCongratulation,
		LabelSuperLuckTip,
		LabelBtnGoMystery,
		LabelLuckNum,
		Upper
	}

	public int ThemeType;

	private List<Dictionary<string, string>> m_LabelStyleList;

	public bool IsUseDiscountShow;

	public string SpriteGetLuckTip;

	public string SpriteLuckNum;

	public string SpriteGoMystery;

	public ResourceID DrawingMaskEffectID;

	public ResourceID StopDrawEffectID;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	private Dictionary<string, string> ReadLabelParams(string str)
	{
		return null;
	}

	public object GetLabelStyle(ECustomLabelType luckyDrawLabel, EMysteryMallLabelStyle drawLabelStyle, out bool isSucceed)
	{
		isSucceed = default(bool);
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}

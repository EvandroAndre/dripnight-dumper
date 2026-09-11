using System.Collections.Generic;
using GCommon;

namespace COW;

public class WorkshopVocaWhiteListData : CSVBaseData
{
	public static Dictionary<string, HashSet<string>> LanguageWhiteListPairs;

	public string ZHTW;

	public string EN;

	public string TH;

	public string VN;

	public string IND;

	public string RU;

	public string PTBR;

	public string TR;

	public string AR;

	public string ES;

	public string FR;

	public string BN;

	public string HI;

	public override void PostDeserializeData()
	{
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}

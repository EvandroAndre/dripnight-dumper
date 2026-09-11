using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using LitJson;
using UnityEngine;

namespace COW.GamePlay;

public class EJAOBJCGLKD : SingletonModule<EJAOBJCGLKD>
{
	public enum IJJIEFMOFBM
	{
		X,
		Y,
		Z
	}

	public class JNHDMBBECJP
	{
		public string INAAFFNAPLP;

		public List<ItemEditAttributeUIData_V2> FILJECAKHFP;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<SceneEditCommonGeneratorConfigData> _003C_003E9__17_0;

		public static Comparison<InspectorCraftlandConfig_Default> _003C_003E9__45_0;

		internal int MNNMCHAJAFG(SceneEditCommonGeneratorConfigData MDFHMBHHGGF, SceneEditCommonGeneratorConfigData OGECPGHMIHA)
		{
			return 0;
		}

		internal int HJCFMDPEHBI(InspectorCraftlandConfig_Default MDFHMBHHGGF, InspectorCraftlandConfig_Default OGECPGHMIHA)
		{
			return 0;
		}
	}

	private Dictionary<string, Dictionary<long, ItemEditAttributeCacheValue_V2>> KCBJPHBGEIK;

	private Dictionary<string, BOBCIBPAIEP> CIOFIAGJLBE;

	private Dictionary<string, Dictionary<int, ItemEditAttributeUIDataSliderBar>> OJPEJPCMBKM;

	private Dictionary<uint, Vector3> KHMJHKCNAIO;

	public Dictionary<uint, List<SceneEditCommonGeneratorConfigData>> OAFDINLONEP;

	private Dictionary<string, Dictionary<long, ItemEditAttributeUIData_V2>> JAOIHJNMLIM;

	private Dictionary<string, List<ItemEditAttributeUIData_V2>> LEAGINBPHLG;

	private Dictionary<string, List<long>> MGDMHBLANCH;

	private UGCTimelineEditorKeyFrameAttributeMgr JODJPDBDLBA;

	public Dictionary<string, List<JNHDMBBECJP>> CJBGFGJDGNJ;

	private EditorEntityData HANNEIDLGKA;

	public Dictionary<string, Dictionary<long, List<Action<string, string>>>> OLDIKGIFBJG;

	private Dictionary<int, InspectorCraftlandConfig_Default> MODCGHPEADJ;

	private Dictionary<int, InspectorCraftlandConfig_Default> GOOEOBAGFPN;

	private Dictionary<int, InspectorCraftlandConfig_Default> OFLGEPPEOPA;

	private List<InspectorCraftlandConfig_Default> CLMCIFJGNEK;

	private Dictionary<int, UGCComponentTypeData> JGCMNDDADAG;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void IDDOOGCADCA()
	{
	}

	public void PBPOEDFFMHB()
	{
	}

	public ItemEditAttributeCacheValue_V2 AFGHLCCBENP(string FEDNOFCNGPO, long FAICJLONPIK)
	{
		return null;
	}

	public void MDNOMLNOIFN(string FEDNOFCNGPO, int FAICJLONPIK, MutableValue GPFPIAMCEMI)
	{
	}

	public BOBCIBPAIEP PDIMIPFMJIM(string FEDNOFCNGPO)
	{
		return null;
	}

	public void HKBGPIHKPNB(string FEDNOFCNGPO, string MACKNNGKKCD, ref List<ItemEditAttributeUIData_V2> DFEJAEPKIFE, ref List<JNHDMBBECJP> MFKJHJIFLMA, bool GEPGHLNIEFK = true)
	{
	}

	public void NILCLPFFIMB(SceneEditObjectBase JBCDHLNHGIH)
	{
	}

	public Dictionary<int, ItemEditAttributeUIDataSliderBar> OFDILDOCJCG(string FEDNOFCNGPO)
	{
		return null;
	}

	public Vector3 NKPPDLHBNHI(uint GEHJJDLAGJJ)
	{
		return default(Vector3);
	}

	public bool GILCIOMGINM(string FEDNOFCNGPO, out List<ItemEditAttributeUIData_V2> LFJJJHIDDOD)
	{
		LFJJJHIDDOD = null;
		return false;
	}

	public bool EJEBHFMJIEJ(string FEDNOFCNGPO, out Dictionary<long, ItemEditAttributeUIData_V2> IJPOLFDPEGJ)
	{
		IJPOLFDPEGJ = null;
		return false;
	}

	public List<long> IDAFHNHBHLM(string FEDNOFCNGPO)
	{
		return null;
	}

	private void FKHLDAGOLKF(JsonData PHCKKIDADOA)
	{
	}

	private void KOFABAKBAKL(string FEDNOFCNGPO, JsonData PHCKKIDADOA, ref Dictionary<long, ItemEditAttributeCacheValue_V2> DFDJALLFLMD, ref Dictionary<long, List<ItemEditAttributeUIData_V2>> MMALLNOMDEI)
	{
	}

	public void FFGKAKDIFIL(string FEDNOFCNGPO, JsonData PNLGDGFFGGE, ref Dictionary<long, ItemEditAttributeUIData_V2> CDJLMFHAEII, ref List<ItemEditAttributeUIData_V2> IOJPNMAAIIA, ref List<ItemEditAttributeUIData_V2> PNBDAOGJOGO, ref Dictionary<long, ItemEditAttributeCacheValue_V2> DFDJALLFLMD, ref Dictionary<long, List<ItemEditAttributeUIData_V2>> MMALLNOMDEI, ref List<long> FAMOAMHHPKO)
	{
	}

	public bool NHMHAHFPPFH(string FEDNOFCNGPO, JsonData PNLGDGFFGGE)
	{
		return false;
	}

	private void CCOEEEFJKCG(string FEDNOFCNGPO, JsonData FNGANPMAGGG)
	{
	}

	public void AECEBACPCPB(string MACKNNGKKCD, int PEONNDKIEDG, Action<string, string> BBMKBKGDJKN)
	{
	}

	public void PNGAMKAKBIK(string MACKNNGKKCD, int PEONNDKIEDG, Action<string, string> BBMKBKGDJKN)
	{
	}

	public void CENIGKBOFIK(string MACKNNGKKCD, long PEONNDKIEDG, string OJEPOBEENEK, string FAAFBFAJFCL)
	{
	}

	public bool CMNNAGNAPMA(string FEDNOFCNGPO, out EJNANMFIPFN DKLKGHGFNCC)
	{
		DKLKGHGFNCC = null;
		return false;
	}

	public bool BPBNACNPGAE(string FEDNOFCNGPO, out NPDBPIJFAHH DKLKGHGFNCC)
	{
		DKLKGHGFNCC = null;
		return false;
	}

	public bool FKIFEIDJGGP(string PHDAKCKIAFE, out Dictionary<long, ItemEditAttributeUIData_V2> ABJHFFGHCNO)
	{
		ABJHFFGHCNO = null;
		return false;
	}

	public void OGCCOILFAAE(string FEDNOFCNGPO, string MACKNNGKKCD, ref List<ItemEditAttributeUIData_V2> DFEJAEPKIFE, ref List<JNHDMBBECJP> MFKJHJIFLMA, bool GEPGHLNIEFK = true)
	{
	}

	private void FOPNABJNCNH()
	{
	}

	private void FMHCIOBFOBP()
	{
	}

	public bool NHPKBHJEHHG(int BAKILCMJCJG)
	{
		return false;
	}

	public bool NFKLHBPANML(int IBNLMKGIJNI)
	{
		return false;
	}

	public InspectorCraftlandConfig_Default LHIIGIIBBJB(int BAKILCMJCJG)
	{
		return null;
	}

	public InspectorCraftlandConfig_Default CNMLFODMCHA(int BAKILCMJCJG)
	{
		return null;
	}

	public Dictionary<int, InspectorCraftlandConfig_Default> JMFPMCCDOCO()
	{
		return null;
	}

	public List<InspectorCraftlandConfig_Default> PGIIEAJCBFE()
	{
		return null;
	}

	public Dictionary<int, UGCComponentTypeData> POGEJLPMNAH()
	{
		return null;
	}
}

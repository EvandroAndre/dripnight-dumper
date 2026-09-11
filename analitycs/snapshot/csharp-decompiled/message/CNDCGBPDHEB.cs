using System.Collections.Generic;
using GCommon;

namespace message;

public class CNDCGBPDHEB
{
	public class AAJDBLADNEM : CSVBaseData, IGetId
	{
		public IJGKGIFOLGH IJGKGIFOLGH;

		public HLKDGIHIJPI ACPJJFFGPDI;

		public uint KOANKNNBAGP;

		public string IAJDNGKJKCB;

		public string NAKPFBAEIAI;

		public uint GetId()
		{
			return 0u;
		}

		public override uint GetUIntKey()
		{
			return 0u;
		}

		public override int GetIntKey()
		{
			return 0;
		}

		public override string GetPrimaryKey()
		{
			return null;
		}

		public override void ParseData(long NIBBKONKPHP, int AOHKLOEKIDA, string[] KNLLNGJMIDB, string[] NMGMFIGPBGL)
		{
		}
	}

	public class JMOOIKALNBL
	{
		public IJGKGIFOLGH IJGKGIFOLGH;

		public string FPHKEIMBEBG;

		public string EDBNBDIIJJA;

		public string GENFOGFPIHI;

		public uint BNDNJNMJPOL;

		public string IHCDEAGJJBP;

		public List<string> PDNJFJEMEOL;
	}

	public enum IJGKGIFOLGH
	{
		ErrorCode_Unknown = 0,
		ErrorCode_Reserved_MaxValue = 100000000,
		ErrorCode_Map_InsufficientSpawnPoints = 100000001,
		ErrorCode_Map_InsufficientTargetPoints = 100000002,
		ErrorCode_Map_InsufficientMustModeItems = 100000003,
		ErrorCode_Map_CostExceedLimit = 100000004,
		ErrorCode_Map_ObjectExceedLimit = 100000005,
		ErrorCode_Map_InsufficientAllTeamSpawnPointsNum = 100000006,
		ErrorCode_Map_InsufficientSingleTeamSpawnPoints = 100000007,
		ErrorCode_Map_InsufficientSingleTeamSpawnPointsNum = 100000008,
		ErrorCode_Map_RuntimeDataTooLager = 100000009,
		ErrorCode_Graph_MissingReference = 100200001,
		ErrorCode_Graph_TypeMismatch = 100200002,
		ErrorCode_Graph_VariableOutOfScope = 100200003,
		ErrorCode_Graph_ExceedLimit = 100200004,
		ErrorCode_Graph_ReturnOutOfScope = 100200005,
		ErrorCode_Graph_ReturnWithoutValueOutOfScope = 100200006,
		ErrorCode_Graph_ReturnWithValueOutOfScope = 100200007,
		ErrorCode_Graph_InvalidEvent = 100200008,
		ErrorCode_Graph_ForbbidenEmptySlot = 100200009,
		ErrorCode_Graph_EntityPropertyObsolete = 100200010,
		ErrorCode_Graph_EntityTypeObsolete = 100200011,
		ErrorCode_Graph_EventObsolete = 100200012,
		ErrorCode_Graph_FuncObsolete = 100200013,
		ErrorCode_Graph_EnumObsolete = 100200014,
		ErrorCode_Graph_CLAPIInGSGraph = 100200015,
		ErrorCode_Graph_GSAPIInCLGraph = 100200016,
		ErrorCode_Graph_IncorrectAttachEntity = 100200017,
		ErrorCode_Graph_InlegalProperty = 100200018,
		ErrorCode_Hud_InterfaceExceedLimit = 100300001,
		ErrorCode_Hud_ControlExceedLimit = 100300002
	}

	public enum HLKDGIHIJPI
	{
		ErrorSeverity_None,
		ErrorSeverity_Panic,
		ErrorSeverity_Error,
		ErrorSeverity_Warning
	}
}

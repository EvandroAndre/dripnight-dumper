using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class WorkshopCommentDataManager : SingletonModule<WorkshopCommentDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopCommentConfigData> _003C_003E9__2_0;

		public static Comparison<WorkshopCommentConfigData> _003C_003E9__2_1;

		internal int _003COnInit_003Eb__2_0(WorkshopCommentConfigData a, WorkshopCommentConfigData b)
		{
			return 0;
		}

		internal int _003COnInit_003Eb__2_1(WorkshopCommentConfigData a, WorkshopCommentConfigData b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public uint id;

		internal bool _003CGetWorkshopCommentDataById_003Eb__0(WorkshopCommentConfigData e)
		{
			return false;
		}

		internal bool _003CGetWorkshopCommentDataById_003Eb__1(WorkshopCommentConfigData e)
		{
			return false;
		}
	}

	private List<WorkshopCommentConfigData> m_PositiveList;

	private List<WorkshopCommentConfigData> m_NegativeList;

	protected override void OnInit()
	{
	}

	public List<WorkshopCommentConfigData> GetPositiveCommentDataList()
	{
		return null;
	}

	public List<WorkshopCommentConfigData> GetNegativeCommentDataList()
	{
		return null;
	}

	public WorkshopCommentConfigData GetWorkshopCommentDataById(uint id)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}
}

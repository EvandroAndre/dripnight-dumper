using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class CameraModeTemplateDataManager : SingletonModule<CameraModeTemplateDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<CameraTemplateData> _003C_003E9__4_0;

		internal bool _003CGetVerticalDefaultCameraTemplateData_003Eb__4_0(CameraTemplateData data)
		{
			return false;
		}
	}

	public List<CameraTemplateData> m_CameraTemplateDataList;

	public List<VideoTemplateData> m_VideoTemplateDataList;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public CameraTemplateData GetVerticalDefaultCameraTemplateData()
	{
		return null;
	}

	public List<CameraTemplateData> GetAllCameraTemplateData()
	{
		return null;
	}

	public List<VideoTemplateData> GetAllVideoTemplateData()
	{
		return null;
	}
}

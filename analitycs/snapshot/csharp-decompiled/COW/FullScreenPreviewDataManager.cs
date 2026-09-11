using System.Collections.Generic;
using GCommon;

namespace COW;

public class FullScreenPreviewDataManager : SingletonModule<FullScreenPreviewDataManager>
{
	private List<FullScreenPreviewData> m_DataList;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}
}

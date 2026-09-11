using System.Collections.Generic;
using GCommon;

namespace COW;

public class PreviewParticleDataManager : SingletonModule<PreviewParticleDataManager>
{
	private Dictionary<int, PreviewParticleData> m_dictIdToCSItemPreviewParticleData;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public PreviewParticleData FindPreviewParticleDataById(int InId)
	{
		return null;
	}
}

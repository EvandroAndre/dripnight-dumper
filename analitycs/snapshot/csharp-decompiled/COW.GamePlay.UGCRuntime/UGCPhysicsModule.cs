using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCPhysicsModule : IUGCModule
{
	private KOBHLHBJNAI m_cctConfigForPlayer;

	private int _003CPlayerPhysicalLayerIndex_003Ek__BackingField;

	private float m_DefaultSleepThreshold;

	private bool m_DefaultSmoothHighFrame;

	public int PlayerPhysicalLayerIndex
	{
		get
		{
			return _003CPlayerPhysicalLayerIndex_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerPhysicalLayerIndex_003Ek__BackingField = value;
		}
	}

	public KOBHLHBJNAI GetPlayerCCTConfig()
	{
		return default(KOBHLHBJNAI);
	}

	void IUGCModule.Init(object[] args)
	{
	}

	void IUGCModule.LoadParameters(Dictionary<object, object> parameters)
	{
	}

	void IUGCModule.Destroy()
	{
	}
}

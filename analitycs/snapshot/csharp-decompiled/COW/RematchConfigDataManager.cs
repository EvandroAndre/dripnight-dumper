using System;
using GCommon;

namespace COW;

public class RematchConfigDataManager : SingletonModule<RematchConfigDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<RematchConfig, uint> _003C_003E9__2_0;

		internal uint _003COnInit_003Eb__2_0(RematchConfig value)
		{
			return 0u;
		}
	}

	private CSVAsyncDataMap<uint, RematchConfig> m_Dict;

	private float m_EmergencyEffect;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public float GetEmergencyEffect()
	{
		return 0f;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}

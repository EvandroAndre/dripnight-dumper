using UnityEngine;

namespace GCommon;

public class PingCounter : MonoBehaviour
{
	public static PingCounterInterface instance;

	private PingCounter()
	{
	}

	public static ushort CurrentPingValueUInt16()
	{
		return 0;
	}
}

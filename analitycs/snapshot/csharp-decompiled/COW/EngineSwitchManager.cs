namespace COW;

public static class EngineSwitchManager
{
	private static uint m_CurrentShaderKeyword;

	public static void ApplyEngineSwitch()
	{
	}

	public static void CloseEngineSwitch(uint flag)
	{
	}

	public static void ApplyEngineAction(EngineActionFlag action_flag, uint external_value = 0u)
	{
	}

	public static void ApplyEngineAction2(EngineActionFlag2 action_flag)
	{
	}

	public static void EnableShaderKeyword(uint[] flags)
	{
	}

	public static void DisableShaderKeyword(uint[] flags)
	{
	}

	public static void EnableParticleMemOpt(bool enable)
	{
	}

	public static int MakeIl2CppSwitch(bool open, bool forceOpen32Bit, int divisor, int memoryThreshold)
	{
		return 0;
	}
}

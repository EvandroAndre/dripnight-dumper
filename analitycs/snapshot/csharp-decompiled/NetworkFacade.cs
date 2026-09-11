public static class NetworkFacade
{
	private static INetworkInterface m_Impl;

	public static bool EnableVibrateFeature => false;

	public static void SetImpl(INetworkInterface impl)
	{
	}
}

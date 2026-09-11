public static class VibrateFacade
{
	private static IVibrateInterface m_Impl;

	public static bool EnableVibrateFeature => false;

	public static void SetImpl(IVibrateInterface impl)
	{
	}
}

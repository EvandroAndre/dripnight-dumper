using GCommon;

namespace COW;

internal class DamageFontSizeManager : SingletonModule<DamageFontSizeManager>
{
	private int[] m_Thresholds;

	private int[] m_FontSizes;

	private int m_FallbackSize;

	private int[] m_NonHeadMinDamageThresholds;

	private int[] m_NonHeadFontSizes;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void SetConfig(string config)
	{
	}

	public void SetNonHeadConfig(string config)
	{
	}

	public int GetFontSize(int damage)
	{
		return 0;
	}

	public int GetFontSize(int damage, int defaultFontSize)
	{
		return 0;
	}

	public int GetNonHeadFontSize(int damage, int defaultFontSize)
	{
		return 0;
	}

	private void Parse(string config)
	{
	}

	private int GetMinDamageFontSize(int damage, int[] thresholds, int[] fontSizes)
	{
		return 0;
	}

	private void ParseMinDamageConfig(string config, out int[] thresholds, out int[] fontSizes)
	{
		thresholds = null;
		fontSizes = null;
	}
}

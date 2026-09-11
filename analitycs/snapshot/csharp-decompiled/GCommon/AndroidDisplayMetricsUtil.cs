namespace GCommon;

public class AndroidDisplayMetricsUtil
{
	private static int _003CDensityDPI_003Ek__BackingField;

	private static float _003CXDPI_003Ek__BackingField;

	private static float _003CYDPI_003Ek__BackingField;

	public static int DensityDPI
	{
		get
		{
			return _003CDensityDPI_003Ek__BackingField;
		}
		protected set
		{
			_003CDensityDPI_003Ek__BackingField = value;
		}
	}

	public static float XDPI
	{
		get
		{
			return _003CXDPI_003Ek__BackingField;
		}
		protected set
		{
			_003CXDPI_003Ek__BackingField = value;
		}
	}

	public static float YDPI
	{
		get
		{
			return _003CYDPI_003Ek__BackingField;
		}
		protected set
		{
			_003CYDPI_003Ek__BackingField = value;
		}
	}

	static AndroidDisplayMetricsUtil()
	{
	}
}

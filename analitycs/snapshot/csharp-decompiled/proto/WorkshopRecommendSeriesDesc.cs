using System.Collections.Generic;

namespace proto;

public class WorkshopRecommendSeriesDesc
{
	public enum SeriesType
	{
		SeriesTypeModularRecomm = 0,
		SeriesTypePersonalRecomm = 1,
		SeriesTypeHistory = 2,
		SeriesTypeMostPopular = 3,
		SeriesTypeSubscribe = 4,
		SeriesTypeDiscover = 6
	}

	public uint series_id;

	public string language;

	public string series_name;

	public string series_icon;

	public uint series_type;

	public long shelf_timestamp;

	public long under_timestamp;

	public uint source_map_cat_id;

	public ulong feature_id;

	public uint parameters_ugc_group_id;

	public bool is_mocha_abt;

	public uint external_display_count;

	public List<string> include_map_codes;

	public uint source_map_pool_type;

	public string default_series_name;

	public uint display_num;
}

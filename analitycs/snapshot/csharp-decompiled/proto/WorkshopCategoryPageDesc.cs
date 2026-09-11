namespace proto;

public class WorkshopCategoryPageDesc
{
	public enum CateType
	{
		CateTypeTags,
		CateTypeMostPopular,
		CateTypeSubscribe,
		CateTypeOfficialCreator
	}

	public uint page_id;

	public string page_key;

	public uint[] tags;

	public uint maps_count;

	public uint cate_type;

	public uint secondary_sorted_order;

	public ulong feature_id;

	public uint parameters_ugc_group_id;

	public uint secondary_maps_count;
}

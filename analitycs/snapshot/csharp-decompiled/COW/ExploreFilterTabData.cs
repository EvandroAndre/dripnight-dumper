namespace COW;

public class ExploreFilterTabData
{
	public enum ETabType
	{
		Waterfall,
		Category
	}

	public ETabType TabType;

	public string TabName;

	public uint SeriesID;

	public UGCCategoryType CategoryType;

	public bool IsSelected;
}

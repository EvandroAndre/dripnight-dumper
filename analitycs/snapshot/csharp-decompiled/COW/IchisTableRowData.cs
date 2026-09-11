using System.Collections.Generic;
using proto;

namespace COW;

public class IchisTableRowData
{
	public List<IchisSortableGoodsData> items;

	public ESharedGacha.RareType primaryTier;

	public bool isSingleSSpecial;

	public IchisTable2ItemType rowType;

	public uint chestId;

	public uint chestSubId;

	public string cdnUrl;

	public bool hideQualityBadge;

	public bool isTransitionFakePool;

	public bool maskPoolCounts;

	public bool disableCodeDrivenEffects;

	public bool disablePreviewClick;

	public int childPanelDepth;

	public bool hasPlayedMainAni;

	public bool suppressEntryUIFX;

	public List<IchisSortableGoodsData> aTierItems;
}

namespace COW;

internal interface IPickupListTagRepeatedSetProxy
{
	void SetItemTagDic(uint itemID, int index);

	bool CheckShowItemTag(uint itemID, int index, out bool isInCache);
}

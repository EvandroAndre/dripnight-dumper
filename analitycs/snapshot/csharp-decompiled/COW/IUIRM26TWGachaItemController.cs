using System;
using UnityEngine;
using proto;

namespace COW;

public interface IUIRM26TWGachaItemController
{
	int Index { get; }

	BaseItemInfo Info { get; }

	Transform transform { get; }

	uint LayoutType { get; }

	void Close();

	void Hide();

	void Show();

	void InitOnClickFunc(Action<int> onClick = null);

	void SetCDNReady(bool cndReady);

	void SetLayoutType(uint layoutType);

	void SetViewInfo(uint gachaID, int idx, GachaShowItem info, bool isShowDropUp = false);

	void ShowView(UIRM26TWGachaItemViewStage stage, float alpha = 1f);

	void SetFixedIconSpriteName(string spriteName);
}

using System.Collections.Generic;
using UnityEngine;
using proto;

namespace COW;

public interface IUIActivityTask
{
	GameObject RootObject { get; }

	bool ShowModel { get; set; }

	uint ItemType { get; }

	uint GetRewardActivityId();

	void ResetUI();

	void Close();

	void SetData(List<ClientActivityDesc> list, int index);

	void PlayShowAnimation(int index);

	void Reload();

	void Show();

	void Hide();

	void SetScrollView(UIScrollView scrollView);

	EActivity.State GetState();
}

namespace COW;

public interface IScheduledNotification
{
	void Play(object viewData);

	void Finish(bool interrupted);
}

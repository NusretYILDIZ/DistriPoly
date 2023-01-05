namespace DP.Systems;

public interface IEventWizard
{
    void AddEvent(IFilter filter);
    void GenerateEvent();
    void RemoveEvent(IFilter filter);
}
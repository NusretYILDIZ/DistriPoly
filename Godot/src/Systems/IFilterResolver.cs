namespace DP.Systems;

public interface IFilterResolver
{
    ICommandValue ApplyFilters(ICommandValue value);
}
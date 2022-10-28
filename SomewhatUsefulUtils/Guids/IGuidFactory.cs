namespace SomewhatUsefulUtils.Guids;

public interface IGuidFactory
{
    Guid GetGuid();

    string GetGuidAsString();

    string ConvertGuidToString(Guid g);
}
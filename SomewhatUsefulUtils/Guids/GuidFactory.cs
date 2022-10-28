namespace SomewhatUsefulUtils.Guids;

public class GuidFactory : IGuidFactory
{
    public Guid GetGuid()
    {
        return Guid.NewGuid();
    }

    public string GetGuidAsString()
    {
        return Guid.NewGuid().ToString();
    }

    public string ConvertGuidToString(Guid g)
    {
        return g.ToString();
    }
}
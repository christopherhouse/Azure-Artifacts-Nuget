namespace SomewhatUsefulUtils.Guids;

public class GuidFactory : IGuidFactory
{
    public Guid GetGuid() => Guid.NewGuid();

    public string GetGuidAsString() => Guid.NewGuid().ToString();

    public string ConvertGuidToString(Guid g) => g.ToString();

    public byte[] GetGuidAsByteArray() => Guid.NewGuid().ToByteArray();
}
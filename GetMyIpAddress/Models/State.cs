namespace GetMyIpAddress.Shared;

public class UiState
{
    public void SetIPAddress(IPAddressItem publicIPAddress)
    {
        ipaddress = publicIPAddress;
    }

    public IPAddressItem ipaddress { get; set; } = new();
}
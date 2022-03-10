namespace todoui.Shared;

public class  TodoUiState
{
    public void SetIPAddress(IPAddressItem publicIPAddress) 
    {
        ipaddress = publicIPAddress;
    }

    public IPAddressItem ipaddress { get; set; }  = new ();
}
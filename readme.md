Connection-Type 1.0
Written by jgeau in c# requires .net 3.0 or higher

Connection-Type.exe is just a simple command line tool that list the type of active network connections and the total count. 
If the adapter is installed but there is not connection (cable unplugged or WiFi not cvonnected to an AP) then it will not show up in the list or be added top the total counts.
It supports Ppp, Ethernet, GigabitEthernet, Ethernet3Megabit, FastEthernetFx, Fddi, TokenRing, Wireless80211, Wman (WiMax), Wwanpp (GSM boradband), Wwanpp2 (CDMA broadband), and unknown

Ppp is reported as a VPN adapter
Wimax and Broadband are counted as Wireless adapters
If an unknown adapter is found a warning will be displayed.

Usage
Connection-Type.exe

sample output

Wired Network connection Found.
1 Wired Network connections found.
0 Wireless Network connections found.
0 VPN Network connections found.


Example: in powershell 

#The line below will put the outpuy into an array in powershell
$Connections = .\Connection-Type.exe
#Then you can search the array for specific connection types or counts you are looking for.



Basic Design: 
this uses NetworkInterface.NetworkInterfaceType Property described below
https://msdn.microsoft.com/en-us/library/system.net.networkinformation.networkinterface.networkinterfacetype(v=vs.110).aspx





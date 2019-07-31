@ECHO OFF
netsh interface ip set address name="Ethernet" static 192.168.0.11 255.255.255.0 192.168.0.10
netsh interface ip set address name="Local Area Connection" static 192.168.0.11 255.255.255.0 192.168.0.10
netsh interface ip set address name="Wireless Network Connection" static 192.168.0.11 255.255.255.0 192.168.0.10
netsh interface ip set dns "Ethernet0" static 192.168.0.10
netsh interface ip set dns "Ethernet" static 192.168.0.10
netsh interface ip set dns "Local Area Connection" static 192.168.0.10
netsh interface ip set dns "Wireless Network Connection" static 192.168.0.10
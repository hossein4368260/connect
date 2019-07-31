netsh interface ip set address name="Ethernet" source=dhcp
netsh interface ip set address name="Local Area Connection" source=dhcp
netsh interface ip set address name="Wireless Network Connection" source=dhcp
netsh interface ip set dns "Ethernet0" source=dhcp
netsh interface ip set dns "Ethernet" source=dhcp
netsh interface ip set dns "Local Area Connection" source=dhcp
netsh interface ip set dns "Wireless Network Connection" source=dhcp
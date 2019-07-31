@ECHO OFF
netsh interface ip set address name="Ethernet" static 10.20.30.76 255.0.0.0 
netsh interface ip set address name="Local Area Connection" static 10.20.30.76 255.0.0.0 
netsh interface ip set address name="Wireless Network Connection" static 10.20.30.76 255.0.0.0 
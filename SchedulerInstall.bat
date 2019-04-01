schtasks /create /TN "AutoCaptive_Start" /xml "%TEMP%\AutoCaptive_Start.xml" /RU "%USERNAME%"
schtasks /create /TN "AutoCaptive_Stop" /xml "%TEMP%\AutoCaptive_Stop.xml" /RU "%USERNAME%"
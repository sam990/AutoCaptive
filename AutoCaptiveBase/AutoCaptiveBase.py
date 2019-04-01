import mechanicalsoup as ms
import os
import re
from win10toast import ToastNotifier
from time import sleep
from sys import exit


browser = ms.StatefulBrowser()

captive_portal_url = 'http://172.16.40.5:8090/httpclient.html'

try:
    browser.open(captive_portal_url)
except:
    exit(0)

#openfile 
try:
    accounts = open(os.getenv('APPDATA') + "/AutoCaptive/accounts.txt")
except:
    toastn = ToastNotifier()
    toastn.show_toast("AutoCaptive" , "Cannot find account",icon_path = "AutoCaptive.ico")
    exit(1)
lines = accounts.readlines();
user_acc = [tuple(i.strip().split()) for i in lines]
success_message = 'You have successfully logged in'

for i in user_acc:
    browser.open(captive_portal_url)
    browser.select_form()
    browser['username'] = i[0]
    browser['password'] = i[1]
    res = browser.submit_selected()
    if re.findall(success_message, str(res.text)):
        toastn = ToastNotifier()
        toastn.show_toast("AutoCaptive" , "Successfully logged in with " + i[0] , icon_path = "AutoCaptive.ico")
        while 1:
            browser.refresh()
            sleep(240)

toastn = ToastNotifier()
toastn.show_toast("AutoCaptive" , "All accounts are being used", icon_path = "AutoCaptive.ico")
exit(2)

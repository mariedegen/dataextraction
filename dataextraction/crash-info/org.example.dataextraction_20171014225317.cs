S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 3437
Date: 2017-10-14 22:53:17+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3437, uid 5000)

Register Information
r0   = 0x00000010, r1   = 0xfb9695d4
r2   = 0x4156c04b, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x417c77fc
r6   = 0x00000010, r7   = 0xbee59f10
r8   = 0x00000041, r9   = 0x40452824
r10  = 0xfb9695d4, fp   = 0x00000000
ip   = 0x0000016c, sp   = 0xbee59e30
lr   = 0x4156c04b, pc   = 0x404e62d0
cpsr = 0x20000010

Memory Information
MemTotal:   491948 KB
MemFree:     98100 KB
Buffers:     26328 KB
Cached:     151592 KB
VmPeak:      97752 KB
VmSize:      96644 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18792 KB
VmRSS:       18792 KB
VmData:      40412 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25100 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3437 TID = 3437
3437 3590 3591 3592 3593 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40046000 r-xp /usr/lib/libappcore-efl.so.1.1
40053000 4005f000 r-xp /usr/lib/libaul.so.0.1.0
40069000 4006b000 r-xp /lib/libdl-2.13.so
40074000 40077000 r-xp /usr/lib/libbundle.so.0.1.22
4007f000 40081000 r-xp /usr/lib/libdlog.so.0.0.0
40089000 4009d000 r-xp /lib/libpthread-2.13.so
400a8000 401e2000 r-xp /usr/lib/libelementary.so.1.7.99
401f9000 402c7000 r-xp /usr/lib/libevas.so.1.7.99
402ed000 40304000 r-xp /usr/lib/libecore.so.1.7.99
4031b000 40379000 r-xp /usr/lib/libedje.so.1.7.99
40382000 40452000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40453000 40459000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40461000 40465000 r-xp /usr/lib/libsmack.so.1.0.0
4046e000 40476000 r-xp /lib/libgcc_s-4.6.so.1
40477000 40592000 r-xp /lib/libc-2.13.so
405a0000 405dc000 r-xp /usr/lib/libsystemd.so.0.4.0
405e5000 405f0000 r-xp /lib/libunwind.so.8.0.1
4061d000 40634000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4063c000 40666000 r-xp /usr/lib/libdbus-1.so.3.8.12
4066f000 40674000 r-xp /usr/lib/libxdgmime.so.1.1.0
4067c000 4069e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
406a6000 406aa000 r-xp /usr/lib/libproc-stat.so.0.2.86
406b3000 406b9000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406c2000 4072b000 r-xp /lib/libm-2.13.so
40734000 4074d000 r-xp /usr/lib/libeet.so.1.7.99
4075e000 4079f000 r-xp /usr/lib/libeina.so.1.7.99
407a8000 407ca000 r-xp /usr/lib/libecore_evas.so.1.7.99
407d3000 407d8000 r-xp /usr/lib/libecore_file.so.1.7.99
407e0000 407f1000 r-xp /usr/lib/libecore_input.so.1.7.99
407f9000 40802000 r-xp /usr/lib/libvconf.so.0.2.45
4080a000 4085a000 r-xp /usr/lib/libecore_x.so.1.7.99
4085c000 40865000 r-xp /usr/lib/libedbus.so.1.7.99
4086d000 40887000 r-xp /usr/lib/libecore_con.so.1.7.99
40890000 408a3000 r-xp /usr/lib/libfribidi.so.0.3.1
408ab000 408e8000 r-xp /usr/lib/libharfbuzz.so.0.940.0
408f1000 40919000 r-xp /usr/lib/libfontconfig.so.1.8.0
4091a000 40970000 r-xp /usr/lib/libfreetype.so.6.11.3
4097c000 409d2000 r-xp /usr/lib/libpixman-1.so.0.28.2
409df000 409e5000 r-xp /lib/librt-2.13.so
409ee000 409f5000 r-xp /usr/lib/libembryo.so.1.7.99
409fd000 40a14000 r-xp /usr/lib/liblua-5.1.so
40a1d000 40a23000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a2b000 40a2c000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a34000 40a62000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a6b000 40a6e000 r-xp /lib/libcap.so.2.21
40a76000 40a8e000 r-xp /usr/lib/liblzma.so.5.0.3
40a96000 40b12000 r-xp /usr/lib/libgcrypt.so.20.0.3
40b1e000 40b2e000 r-xp /lib/libresolv-2.13.so
40b32000 40c05000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40c10000 40c44000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40c4d000 40c63000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40c6c000 40ce1000 r-xp /usr/lib/libsqlite3.so.0.8.6
40ceb000 40d01000 r-xp /lib/libz.so.1.2.5
40d09000 40d2c000 r-xp /usr/lib/libjpeg.so.8.0.2
40d44000 40e25000 r-xp /usr/lib/libX11.so.6.3.0
40e30000 40e35000 r-xp /usr/lib/libecore_fb.so.1.7.99
40e3e000 40e42000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40e4b000 40e4e000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40e56000 40e5d000 r-xp /usr/lib/libXcursor.so.1.0.2
40e65000 40e67000 r-xp /usr/lib/libXdamage.so.1.1.0
40e6f000 40e71000 r-xp /usr/lib/libXcomposite.so.1.0.0
40e79000 40e7b000 r-xp /usr/lib/libXgesture.so.7.0.0
40e83000 40e86000 r-xp /usr/lib/libXfixes.so.3.1.0
40e8e000 40e97000 r-xp /usr/lib/libXi.so.6.1.0
40e9f000 40ea0000 r-xp /usr/lib/libXinerama.so.1.0.0
40ea9000 40eaf000 r-xp /usr/lib/libXrandr.so.2.2.0
40eb7000 40ebd000 r-xp /usr/lib/libXrender.so.1.3.0
40ec5000 40ec9000 r-xp /usr/lib/libXtst.so.6.1.0
40ed1000 40edb000 r-xp /usr/lib/libXext.so.6.4.0
40ee4000 40f28000 r-xp /usr/lib/libcurl.so.4.3.0
40f31000 40f47000 r-xp /lib/libexpat.so.1.5.2
40f51000 40f69000 r-xp /usr/lib/libpng12.so.0.50.0
40f71000 40f8e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f97000 4102b000 r-xp /usr/lib/libstdc++.so.6.0.16
4103f000 41042000 r-xp /lib/libattr.so.1.1.0
4104a000 41055000 r-xp /usr/lib/libgpg-error.so.0.15.0
4105d000 4105e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
41066000 4106b000 r-xp /usr/lib/libffi.so.5.0.10
41073000 41075000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
4107e000 4114a000 r-xp /usr/lib/libxml2.so.2.7.8
41157000 41159000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
41162000 41164000 r-xp /usr/lib/journal/libjournal.so.0.1.0
4116c000 4117f000 r-xp /usr/lib/libxcb.so.1.1.0
41189000 41192000 r-xp /usr/lib/libcares.so.2.1.0
4119b000 411c9000 r-xp /usr/lib/libidn.so.11.5.44
411d1000 41218000 r-xp /usr/lib/libssl.so.1.0.0
41224000 413cd000 r-xp /usr/lib/libcrypto.so.1.0.0
413ee000 413f0000 r-xp /usr/lib/libiri.so
413f9000 41400000 r-xp /lib/libcrypt-2.13.so
41430000 41432000 r-xp /usr/lib/libXau.so.6.0.0
4153f000 41543000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
41552000 41557000 r-xp /usr/lib/libappcore-common.so.1.1
4155f000 41561000 r-xp /usr/lib/libiniparser.so.0
4156a000 4156d000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
4157d000 41581000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4158a000 4158c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41595000 4159b000 r-xp /usr/lib/libappsvc.so.0.1.0
415a3000 415c7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415d0000 4169f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416b5000 416bf000 r-xp /lib/libnss_files-2.13.so
41743000 4174e000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41756000 4175a000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41763000 4176b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
4176c000 4178d000 r-xp /usr/lib/libefl-extension.so.0.1.0
41796000 417c0000 r-xp /usr/lib/libsensor.so.1.9.6
417c9000 417db000 r-xp /usr/lib/libefl-assist.so.0.1.0
417e3000 4189b000 r-xp /usr/lib/libcairo.so.2.11200.14
418a6000 418b0000 r-xp /usr/lib/libsensord-shared.so
418b9000 418cb000 r-xp /usr/lib/libtts.so
418d3000 418f5000 r-xp /usr/lib/libui-extension.so.0.1.0
418fe000 41905000 r-xp /usr/lib/libtbm.so.1.0.0
4190d000 4191b000 r-xp /usr/lib/libGLESv2.so.2.0
41924000 41925000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4192e000 41934000 r-xp /usr/lib/libxcb-render.so.0.0.0
4193c000 4193f000 r-xp /usr/lib/libEGL.so.1.4
41947000 4194c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41954000 41957000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4195f000 41960000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41969000 41aa6000 r-xp /usr/lib/libicui18n.so.51.1
41ab6000 41b9a000 r-xp /usr/lib/libicuuc.so.51.1
41baf000 41bb7000 r-xp /usr/lib/libdrm.so.2.4.0
41bbf000 41bc1000 r-xp /usr/lib/libdri2.so.0.0.0
41bc9000 41bcf000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41bd7000 41bdc000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41be4000 41bfd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4318e000 431af000 r-xp /usr/lib/libexif.so.12.3.3
431c2000 431c4000 r-xp /usr/lib/libttrace.so.1.1
431cc000 431d1000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
431d9000 431df000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
431e8000 431f0000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
431f8000 43214000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4321d000 43224000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4322d000 4322f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43237000 4323e000 r-xp /usr/lib/libminizip.so.1.0.0
43246000 43253000 r-xp /usr/lib/libail.so.0.1.0
4335c000 43426000 r-xp /usr/lib/libCOREGL.so.4.0
43638000 43643000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4364c000 43651000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
436f7000 436f8000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43701000 43f00000 rw-p [stack:3590]
43f01000 44700000 rw-p [stack:3591]
44701000 44f00000 rw-p [stack:3592]
44f01000 45700000 rw-p [stack:3593]
45b14000 45b15000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45b30000 45b37000 r-xp /usr/lib/libfeedback.so.0.1.4
45b40000 45b41000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45b49000 45b4b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45b53000 45b5d000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45b65000 45b6c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45b74000 45b8a000 r-xp /usr/lib/libmmfsound.so.0.1.0
45b9c000 45ba1000 r-xp /usr/lib/libmmfsession.so.0.0.0
45ba9000 45bb3000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45bbf000 45bc3000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45bcc000 45be1000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45be9000 45c4a000 r-xp /usr/lib/libasound.so.2.0.0
45c54000 45c57000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45c5f000 45c97000 r-xp /usr/lib/libpulse.so.0.16.2
45c98000 45c9b000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45ca3000 45cd4000 r-xp /usr/lib/libmdm.so.1.1.86
45cdc000 45ce1000 r-xp /usr/lib/libjson.so.0.0.1
45ce9000 45d31000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45d32000 45d79000 r-xp /usr/lib/libsndfile.so.1.0.26
45d85000 45d8d000 r-xp /usr/lib/libmdm-common.so.1.0.89
45d8e000 45db0000 r-xp /usr/lib/libvorbis.so.0.4.3
45db8000 45dbc000 r-xp /usr/lib/libogg.so.0.7.1
bee3a000 bee5b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3437)
Call Stack Count: 1
 0: realloc + 0x50 (0x404e62d0) [/lib/libc.so.6] + 0x6f2d0
End of Call Stack

Package Information
Package Name: org.example.dataextraction
Package ID : org.example.dataextraction
Version: 1.0.0
Package Type: rpm
App Name: Health Reacording
App ID: org.example.dataextraction
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
48] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
10-14 22:53:06.815+0200 W/STARTER (  695): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
10-14 22:53:06.815+0200 W/STARTER (  695): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
10-14 22:53:06.855+0200 I/UXT     ( 3354): Uxt_ObjectManager.cpp: OnTerminating(752) > Terminating.
10-14 22:53:06.975+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-14 22:53:06.975+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-14 22:53:06.975+0200 E/EFL     (  767): ecore_x<767> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=452327
10-14 22:53:06.975+0200 W/STARTER (  695): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
10-14 22:53:06.975+0200 W/STARTER (  695): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
10-14 22:53:06.990+0200 W/STARTER (  695): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
10-14 22:53:06.990+0200 W/STARTER (  695): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
10-14 22:53:06.990+0200 E/STARTER (  695): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
10-14 22:53:06.990+0200 W/AUL     (  695): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-14 22:53:06.990+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 22:53:06.990+0200 W/AUL_AMD (  535): amd_launch.c: _start_app(1710) > caller pid : 695
10-14 22:53:06.995+0200 W/AUL_AMD (  535): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 767
10-14 22:53:07.000+0200 I/APP_CORE(  767): appcore-efl.c: __do_app(429) > [APP 767] Event: RESET State: RUNNING
10-14 22:53:07.000+0200 I/CAPI_APPFW_APPLICATION(  767): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-14 22:53:07.000+0200 W/W_HOME  (  767): main.c: _app_control(1704) > Service value : powerkey
10-14 22:53:07.000+0200 I/wnotib  (  767): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
10-14 22:53:07.000+0200 I/wnotib  (  767): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
10-14 22:53:07.000+0200 W/W_HOME  (  767): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
10-14 22:53:07.000+0200 E/W_HOME  (  767): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
10-14 22:53:07.000+0200 W/W_HOME  (  767): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
10-14 22:53:07.000+0200 W/W_HOME  (  767): move.c: move_move_to_apps(220) > move to apps
10-14 22:53:07.000+0200 W/AUL_AMD (  535): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(13), pid(767), cmd(0)
10-14 22:53:07.000+0200 W/AUL     (  695): launch.c: app_request_to_launchpad(282) > request cmd(0) result(767)
10-14 22:53:07.000+0200 E/AUL     (  695): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 22:53:07.000+0200 E/AUL     (  535): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 22:53:07.005+0200 W/W_HOME  (  767): move.c: _create_fake_apps(823) > fake image position : 432
10-14 22:53:07.010+0200 W/W_HOME  (  767): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
10-14 22:53:07.010+0200 W/W_HOME  (  767): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
10-14 22:53:07.010+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:53:07.010+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:53:07.010+0200 I/APP_CORE(  767): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-14 22:53:07.010+0200 W/W_HOME  (  767): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
10-14 22:53:07.010+0200 W/W_HOME  (  767): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-14 22:53:07.010+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:53:07.010+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:53:07.010+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:53:07.010+0200 W/W_HOME  (  767): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
10-14 22:53:07.010+0200 W/W_HOME  (  767): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
10-14 22:53:07.015+0200 I/wnotib  (  767): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
10-14 22:53:07.015+0200 I/wnotib  (  767): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
10-14 22:53:07.060+0200 I/efl-extension( 3354): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-14 22:53:07.165+0200 W/AUL_PAD ( 1190): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 3354 pgid = 3354
10-14 22:53:07.195+0200 W/AUL_PAD ( 1190): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 22:53:07.195+0200 I/AUL_AMD (  535): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3354
10-14 22:53:07.315+0200 W/W_HOME  (  767): move.c: _transit_del_cb(115) > transit end
10-14 22:53:07.320+0200 W/W_HOME  (  767): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
10-14 22:53:07.320+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:53:07.335+0200 W/W_HOME  (  767): move.c: _scroller_up_done(515) > up signal done
10-14 22:53:07.340+0200 W/W_HOME  (  767): event_manager.c: _apptray_visibility_cb(583) > apps,show
10-14 22:53:07.340+0200 W/W_HOME  (  767): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
10-14 22:53:07.340+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 22:53:07.340+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 22:53:07.340+0200 W/W_HOME  (  767): main.c: home_pause(766) > clock/widget paused
10-14 22:53:07.345+0200 W/W_HOME  (  767): clock_indicator.c: clock_indicator_pause(554) > 
10-14 22:53:07.345+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 22:53:07.345+0200 W/W_HOME  (  767): noti_broker.c: _apptray_visibility_cb(789) > apps,show
10-14 22:53:07.345+0200 W/W_HOME  (  767): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
10-14 22:53:07.345+0200 I/wnotib  (  767): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
10-14 22:53:07.345+0200 I/wnotib  (  767): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
10-14 22:53:07.345+0200 E/APPS    (  767): apps_main.c: apps_main_resume(636) >  resumed already
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:53:07.350+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:07.350+0200 E/CAPI_APPFW_APP_CONTROL( 1653): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 22:53:07.350+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1653]   [com.samsung.w-home]register msg port [true][0m
10-14 22:53:07.355+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 22:53:07.360+0200 W/AUL_AMD (  535): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 767
10-14 22:53:07.360+0200 W/WATCH_CORE(  813): appcore-watch.c: __widget_pause(1028) > widget_pause
10-14 22:53:07.370+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1653]   [MUSIC_PLAYER_EVENT][0m
10-14 22:53:07.370+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1653): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 22:53:07.375+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1653): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 22:53:07.375+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1653): preference.c: preference_get_int(1132) > preference_get_int(1653) : key(music-control-service_native/playing_diration) error
10-14 22:53:07.375+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1653]   preference_get_int() .. [0xfef00030][0m
10-14 22:53:07.375+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1653]   bundle_add_str() .. [0xffffffea][0m
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:07.375+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:53:07.375+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:07.380+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 22:53:07.380+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:07.380+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:07.380+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:07.380+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:53:07.380+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:53:07.380+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:07.380+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 22:53:07.380+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:53:07.380+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:53:07.380+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:07.380+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1653]   [MUSIC_PLAYER_EVENT][0m
10-14 22:53:07.385+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1653): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 22:53:07.385+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1653): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 22:53:07.385+0200 W/W_HOME  (  767): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 22:53:07.385+0200 E/W_HOME  (  767): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 22:53:07.385+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1653): preference.c: preference_get_int(1132) > preference_get_int(1653) : key(music-control-service_native/playing_diration) error
10-14 22:53:07.385+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1653]   preference_get_int() .. [0xfef00030][0m
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:53:07.385+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:07.390+0200 W/W_HOME  (  767): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 22:53:07.390+0200 E/W_HOME  (  767): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 22:53:07.390+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 22:53:07.395+0200 I/TIZEN_N_SOUND_MANAGER( 1653): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 22:53:07.395+0200 E/TIZEN_N_SOUND_MANAGER( 1653): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 22:53:07.395+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1653]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 22:53:07.395+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:07.395+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:07.395+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:07.395+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 22:53:07.395+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 22:53:07.395+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:07.395+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 22:53:07.395+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:07.400+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:07.400+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:07.400+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:07.400+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:53:07.400+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:53:07.400+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:07.400+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 22:53:07.400+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:53:07.400+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:53:07.400+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:07.405+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 22:53:07.405+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:07.405+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:07.405+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:07.405+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:53:07.405+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:53:07.405+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:07.405+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 22:53:07.405+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:53:07.405+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:53:07.405+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:07.405+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 22:53:07.405+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 22:53:07.420+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 22:53:07.420+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:07.420+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:07.420+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:07.420+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:53:07.420+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:53:07.420+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:07.420+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 22:53:07.420+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:53:07.420+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:53:07.420+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:07.420+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 22:53:07.425+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 22:53:07.430+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:07.430+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:07.430+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:07.430+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:53:07.430+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:53:07.430+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:07.430+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 22:53:07.430+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:53:07.430+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:53:07.430+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:07.430+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 22:53:07.435+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 22:53:07.435+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 22:53:07.440+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 22:53:07.440+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:07.440+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:07.440+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:07.440+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:53:07.440+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:53:07.440+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:07.440+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 22:53:07.440+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:53:07.440+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:53:07.440+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:07.440+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 22:53:07.440+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 22:53:07.445+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __check_status_for_cgroup(145) > enter background group
10-14 22:53:07.615+0200 E/EFL     (  767): ecore_x<767> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=452965 button=1
10-14 22:53:07.615+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 22:53:07.615+0200 E/W_HOME  (  767): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 22:53:07.615+0200 W/APPS    (  767): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,242,216,124]
10-14 22:53:07.635+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 22:53:07.650+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 22:53:07.650+0200 W/APPS    (  767): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-14 22:53:07.660+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 22:53:07.675+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 22:53:07.685+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 22:53:07.700+0200 E/EFL     (  767): ecore_x<767> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=453049 button=1
10-14 22:53:07.700+0200 E/APPS    (  767): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-14 22:53:08.000+0200 W/AUL_AMD (  535): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 22:53:08.000+0200 W/AUL_AMD (  535): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-14 22:53:08.440+0200 E/EFL     (  767): ecore_x<767> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=453790 button=1
10-14 22:53:08.440+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 22:53:08.445+0200 E/W_HOME  (  767): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 22:53:08.445+0200 W/APPS    (  767): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-14 22:53:08.485+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 22:53:08.520+0200 E/EFL     (  767): ecore_x<767> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=453873 button=1
10-14 22:53:08.525+0200 W/APPS    (  767): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-14 22:53:08.525+0200 E/APPS    (  767): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-14 22:53:08.525+0200 W/APPS    (  767): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-14 22:53:08.530+0200 W/AUL     (  767): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 22:53:08.530+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 22:53:08.535+0200 W/AUL_AMD (  535): amd_launch.c: _start_app(1710) > caller pid : 767
10-14 22:53:08.535+0200 I/AUL_AMD (  535): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-14 22:53:08.545+0200 W/AUL_AMD (  535): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 22:53:08.545+0200 W/AUL_PAD ( 1190): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 22:53:08.545+0200 W/AUL_PAD ( 1190): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 22:53:08.555+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-14 22:53:08.555+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 22:53:08.600+0200 I/efl-extension( 3437): efl_extension.c: eext_mod_init(40) > Init
10-14 22:53:08.605+0200 I/UXT     ( 3437): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 22:53:08.605+0200 I/CAPI_APPFW_APPLICATION( 3437): app_main.c: ui_app_main(704) > app_efl_main
10-14 22:53:08.610+0200 I/CAPI_APPFW_APPLICATION( 3437): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 22:53:08.645+0200 W/AUL_AMD (  535): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 22:53:08.645+0200 E/AUL     (  535): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 22:53:08.645+0200 W/AUL     (  767): launch.c: app_request_to_launchpad(282) > request cmd(0) result(3437)
10-14 22:53:08.645+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 22:53:08.645+0200 E/W_HOME  (  767): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-14 22:53:08.700+0200 E/EFL     ( 3437): ecore_evas<3437> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-14 22:53:08.930+0200 I/APP_CORE( 3437): appcore-efl.c: __do_app(429) > [APP 3437] Event: RESET State: CREATED
10-14 22:53:08.930+0200 I/CAPI_APPFW_APPLICATION( 3437): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-14 22:53:08.945+0200 I/APP_CORE( 3437): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-14 22:53:08.945+0200 I/APP_CORE( 3437): appcore-efl.c: __do_app(474) > [APP 3437] Initial Launching, call the resume_cb
10-14 22:53:08.945+0200 I/CAPI_APPFW_APPLICATION( 3437): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-14 22:53:08.950+0200 W/W_HOME  (  767): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-14 22:53:08.950+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 22:53:08.950+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 22:53:08.950+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 22:53:08.975+0200 W/APP_CORE( 3437): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600002
10-14 22:53:09.030+0200 W/W_HOME  (  767): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-14 22:53:09.030+0200 W/W_HOME  (  767): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-14 22:53:09.030+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 22:53:09.030+0200 W/W_HOME  (  767): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-14 22:53:09.035+0200 I/APP_CORE(  767): appcore-efl.c: __do_app(429) > [APP 767] Event: PAUSE State: RUNNING
10-14 22:53:09.035+0200 I/CAPI_APPFW_APPLICATION(  767): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 22:53:09.035+0200 W/W_HOME  (  767): main.c: _appcore_pause_cb(696) > appcore pause
10-14 22:53:09.035+0200 W/W_HOME  (  767): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-14 22:53:09.035+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 22:53:09.035+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 22:53:09.035+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 22:53:09.035+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:09.035+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:09.035+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:09.035+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 22:53:09.035+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 22:53:09.035+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:09.040+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 22:53:09.040+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:09.040+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:53:09.040+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:53:09.040+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:53:09.040+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:53:09.040+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:53:09.040+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:53:09.040+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 22:53:09.040+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:53:09.040+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:53:09.040+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:53:09.040+0200 E/CAPI_APPFW_APP_CONTROL( 1653): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 22:53:09.040+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1653]   [com.samsung.w-home]register msg port [false][0m
10-14 22:53:09.060+0200 I/APP_CORE( 3437): appcore-efl.c: __do_app(429) > [APP 3437] Event: RESUME State: RUNNING
10-14 22:53:09.110+0200 W/wnotib  (  767): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-14 22:53:09.310+0200 E/EFL     ( 3437): elementary<3437> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:53:09.385+0200 E/AUL     (  535): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 22:53:09.560+0200 I/APP_CORE(  767): appcore-efl.c: __do_app(429) > [APP 767] Event: MEM_FLUSH State: PAUSED
10-14 22:53:09.850+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.255
10-14 22:53:09.920+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 22:53:09.930+0200 W/AUL_AMD (  535): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3437
10-14 22:53:09.930+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 22:53:09.945+0200 W/AUL_AMD (  535): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3437
10-14 22:53:09.945+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 22:53:09.950+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 22:53:10.045+0200 E/EFL     ( 3594): elementary<3594> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 22:53:10.045+0200 E/EFL     ( 3594): elementary<3594> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 22:53:10.080+0200 E/EFL     ( 3594): elementary<3594> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 22:53:10.080+0200 E/EFL     ( 3594): elementary<3594> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 22:53:10.145+0200 E/EFL     ( 3594): elementary<3594> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 22:53:10.150+0200 E/EFL     ( 3594): elementary<3594> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 22:53:10.155+0200 E/EFL     ( 3594): elementary<3594> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 22:53:10.155+0200 E/EFL     ( 3594): elementary<3594> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 22:53:10.160+0200 E/EFL     ( 3594): elementary<3594> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 22:53:10.185+0200 E/EFL     ( 3594): elementary<3594> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 22:53:10.190+0200 E/EFL     ( 3594): elementary<3594> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 22:53:10.190+0200 E/EFL     ( 3594): elementary<3594> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 22:53:10.235+0200 E/EFL     ( 3594): elementary<3594> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 22:53:10.245+0200 E/EFL     ( 3594): elementary<3594> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 22:53:10.245+0200 E/EFL     ( 3594): elementary<3594> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 22:53:10.245+0200 E/EFL     ( 3594): elementary<3594> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 22:53:10.245+0200 E/EFL     ( 3594): elementary<3594> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 22:53:10.245+0200 E/EFL     ( 3594): elementary<3594> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 22:53:10.245+0200 E/EFL     ( 3594): elementary<3594> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 22:53:10.245+0200 I/AUL_PAD ( 3594): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 22:53:12.400+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-14 22:53:14.065+0200 I/APP_CORE(  767): appcore-efl.c: __do_app(429) > [APP 767] Event: MEM_FLUSH State: PAUSED
10-14 22:53:16.810+0200 E/EFL     ( 3437): ecore_x<3437> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=462159 button=1
10-14 22:53:16.930+0200 I/INFO_TAG( 3437): HEART RATE 0: 57
10-14 22:53:16.950+0200 E/EFL     ( 3437): ecore_x<3437> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=462290 button=1
10-14 22:53:17.160+0200 E/EFL     ( 3437): elementary<3437> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-14 22:53:17.160+0200 E/EFL     ( 3437): elementary<3437> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-14 22:53:17.295+0200 E/EFL     ( 3437): elementary<3437> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:53:17.910+0200 I/INFO_TAG_SENSOR_EVENT2( 3437): HEART RATE : 56
10-14 22:53:17.910+0200 F/EFL     ( 3437): evas_main<3437> main.c:122 evas_debug_magic_wrong() Input object is wrong type
10-14 22:53:17.910+0200 F/EFL     ( 3437):     Expected: 71737723 - Evas_Object
10-14 22:53:17.910+0200 F/EFL     ( 3437):     Supplied: 4156b70f - <UNKNOWN>
10-14 22:53:18.320+0200 I/MALI    (  767): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
10-14 22:53:18.350+0200 W/AUL_AMD (  535): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 22:53:18.350+0200 W/AUL_AMD (  535): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-14 22:53:18.380+0200 W/CRASH_MANAGER( 3615): worker.c: worker_job(1205) > 1103437646174150801439

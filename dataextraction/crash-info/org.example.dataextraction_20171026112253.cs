S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 2694
Date: 2017-10-26 11:22:53+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x36302e31

Register Information
r0   = 0x36302e35, r1   = 0x403bb469
r2   = 0x000000e4, r3   = 0x00000000
r4   = 0x4175790c, r5   = 0x36302e35
r6   = 0x00000249, r7   = 0xbec523f8
r8   = 0xbec524a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40452304, sp   = 0xbec523a0
lr   = 0x403bb469, pc   = 0x404e6150
cpsr = 0x20000010

Memory Information
MemTotal:   490928 KB
MemFree:     87668 KB
Buffers:     27268 KB
Cached:     154896 KB
VmPeak:      94864 KB
VmSize:      94492 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17844 KB
VmRSS:       17844 KB
VmData:      40204 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23608 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 2694 TID = 2694
2694 2802 2809 2810 2811 

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
4156a000 41575000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
4157d000 41581000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4158a000 4158c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41595000 4159b000 r-xp /usr/lib/libappsvc.so.0.1.0
415a3000 415c7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415d0000 4169f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416b5000 416bf000 r-xp /lib/libnss_files-2.13.so
41743000 41748000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
41758000 4178a000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
41793000 41797000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417a0000 417a8000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
417a9000 417ca000 r-xp /usr/lib/libefl-extension.so.0.1.0
417d3000 4180d000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41816000 4182f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41837000 4183c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41844000 4186e000 r-xp /usr/lib/libsensor.so.1.9.6
41877000 41889000 r-xp /usr/lib/libefl-assist.so.0.1.0
41891000 41949000 r-xp /usr/lib/libcairo.so.2.11200.14
41954000 41957000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4195f000 41965000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4196e000 41976000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4197e000 41988000 r-xp /usr/lib/libsensord-shared.so
41991000 419a3000 r-xp /usr/lib/libtts.so
419ab000 419cd000 r-xp /usr/lib/libui-extension.so.0.1.0
419d6000 419dd000 r-xp /usr/lib/libtbm.so.1.0.0
419e5000 419f3000 r-xp /usr/lib/libGLESv2.so.2.0
419fc000 419fd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a06000 41a0c000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a14000 41a17000 r-xp /usr/lib/libEGL.so.1.4
41a1f000 41a2c000 r-xp /usr/lib/libail.so.0.1.0
41a35000 41b72000 r-xp /usr/lib/libicui18n.so.51.1
41b82000 41c66000 r-xp /usr/lib/libicuuc.so.51.1
43204000 43220000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43229000 4322c000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
43234000 43235000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
4323e000 43246000 r-xp /usr/lib/libdrm.so.2.4.0
4324e000 43250000 r-xp /usr/lib/libdri2.so.0.0.0
43258000 4325f000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43268000 4326a000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43272000 43279000 r-xp /usr/lib/libminizip.so.1.0.0
43281000 43287000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
4328f000 43294000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4329c000 432bd000 r-xp /usr/lib/libexif.so.12.3.3
432d0000 432d2000 r-xp /usr/lib/libttrace.so.1.1
432da000 432df000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
433e7000 434b1000 r-xp /usr/lib/libCOREGL.so.4.0
436c4000 43ec3000 rw-p [stack:2802]
43ec3000 43ece000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ed7000 43edc000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43ef6000 43ef7000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4408c000 4408e000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44097000 44896000 rw-p [stack:2809]
44897000 45096000 rw-p [stack:2810]
45097000 45996000 rw-p [stack:2811]
459f2000 459f5000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
45b59000 45b5a000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
bec32000 bec53000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2694)
Call Stack Count: 1
 0: cfree + 0x30 (0x404e6150) [/lib/libc.so.6] + 0x6f150
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
4): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 769
10-26 11:22:32.970+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 11:22:32.975+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2179
10-26 11:22:32.980+0200 W/AUL_AMD (  564): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(769), cmd(0)
10-26 11:22:32.980+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(282) > request cmd(0) result(769)
10-26 11:22:32.980+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESET State: RUNNING
10-26 11:22:32.980+0200 E/STARTER (  732): starter.c: _w_app_dead_cb(241) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.6.37/src/starter.c:241:E] w-clock-viewer (pid:2179) is destroyed. ambient mode[0], charging[0], sports mode[0]
10-26 11:22:32.980+0200 W/STARTER (  732): starter.c: _w_app_dead_cb(249) > [_w_app_dead_cb:249] >> clockstop
10-26 11:22:32.980+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-26 11:22:32.980+0200 W/W_HOME  (  769): main.c: _app_control(1704) > Service value : powerkey
10-26 11:22:32.980+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
10-26 11:22:32.980+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
10-26 11:22:32.980+0200 W/W_HOME  (  769): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
10-26 11:22:32.980+0200 E/W_HOME  (  769): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
10-26 11:22:32.980+0200 W/W_HOME  (  769): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
10-26 11:22:32.985+0200 W/W_HOME  (  769): move.c: move_move_to_apps(220) > move to apps
10-26 11:22:32.985+0200 W/W_HOME  (  769): move.c: _create_fake_apps(823) > fake image position : 432
10-26 11:22:32.985+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.209
10-26 11:22:32.990+0200 W/W_HOME  (  769): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
10-26 11:22:32.990+0200 W/W_HOME  (  769): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
10-26 11:22:32.995+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:22:32.995+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:22:33.000+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-26 11:22:33.000+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
10-26 11:22:33.000+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-26 11:22:33.000+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:22:33.005+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:22:33.005+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:22:33.005+0200 W/W_HOME  (  769): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
10-26 11:22:33.005+0200 W/W_HOME  (  769): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
10-26 11:22:33.005+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
10-26 11:22:33.005+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
10-26 11:22:33.010+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_alpm_handler(1066) > signal_alpm_handler: ambient mode: 0, state: 2
10-26 11:22:33.010+0200 E/WATCH_CORE(  806): appcore-watch.c: __signal_alpm_handler(1070) > invalid state
10-26 11:22:33.015+0200 E/AUL     (  732): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 11:22:33.015+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 11:22:33.035+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 11:22:33.035+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 11:22:33.035+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 11:22:33.035+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 11:22:33.045+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 11:22:33.300+0200 W/W_HOME  (  769): move.c: _transit_del_cb(115) > transit end
10-26 11:22:33.300+0200 W/W_HOME  (  769): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
10-26 11:22:33.300+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:22:33.315+0200 W/W_HOME  (  769): move.c: _scroller_up_done(515) > up signal done
10-26 11:22:33.320+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(583) > apps,show
10-26 11:22:33.325+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
10-26 11:22:33.325+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:33.325+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:33.325+0200 W/W_HOME  (  769): main.c: home_pause(766) > clock/widget paused
10-26 11:22:33.325+0200 W/W_HOME  (  769): clock_indicator.c: clock_indicator_pause(554) > 
10-26 11:22:33.325+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:33.325+0200 W/W_HOME  (  769): noti_broker.c: _apptray_visibility_cb(789) > apps,show
10-26 11:22:33.325+0200 W/W_HOME  (  769): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
10-26 11:22:33.325+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
10-26 11:22:33.325+0200 I/wnotib  (  769): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
10-26 11:22:33.325+0200 E/APPS    (  769): apps_main.c: apps_main_resume(636) >  resumed already
10-26 11:22:33.340+0200 W/WATCH_CORE(  806): appcore-watch.c: __widget_pause(1028) > widget_pause
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 11:22:33.620+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:33.625+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 11:22:33.625+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [true][0m
10-26 11:22:33.625+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:22:33.630+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 769
10-26 11:22:33.635+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 11:22:33.635+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1061]   bundle_add_str() .. [0xffffffea][0m
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 11:22:33.635+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:33.635+0200 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 11:22:33.635+0200 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 11:22:33.635+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 11:22:33.640+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:33.640+0200 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 11:22:33.640+0200 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 11:22:33.645+0200 I/TIZEN_N_SOUND_MANAGER( 1061): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-26 11:22:33.645+0200 E/TIZEN_N_SOUND_MANAGER( 1061): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-26 11:22:33.645+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1061]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 11:22:33.645+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:33.970+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 11:22:33.970+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 11:22:34.395+0200 W/AUL_AMD (  564): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-26 11:22:35.220+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-26 11:22:35.220+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-26 11:22:35.245+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 11:22:35.300+0200 E/wnoti-service(  876): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 1 
10-26 11:22:35.300+0200 E/wnoti-service(  876): wnoti-native-client.c: handle_cache_notification(603) > >>
10-26 11:22:35.315+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 1
10-26 11:22:35.335+0200 W/SHealth_Service( 1085): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
10-26 11:22:35.360+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-26 11:22:35.360+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-26 11:22:35.365+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_boolean(1173) > preference_get_boolean(1085) : test_healthy_pace error
10-26 11:22:35.365+0200 W/SHealth_Service( 1085): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1122) > [1;40;33mOnNotWearingStop[0;m
10-26 11:22:35.495+0200 W/SHealth_Common( 1085): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1508976000000,000000[0;m
10-26 11:22:35.555+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
10-26 11:22:35.565+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (643869)]][0;m
10-26 11:22:35.655+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
10-26 11:22:35.660+0200 W/SHealthWidget(  836): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (643869), msgName: timeline_summary_updated[0;m
10-26 11:22:35.660+0200 W/SHealth_Common(  836): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
10-26 11:22:35.670+0200 I/HealthDataService(  777): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-26 11:22:35.710+0200 I/healthData( 1085): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-26 11:22:35.750+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 11:22:35.750+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 11:22:35.750+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 11:22:35.750+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 11:22:35.860+0200 I/CAPI_WIDGET_APPLICATION(  836): widget_app.c: __provider_update_cb(281) > received updating signal
10-26 11:22:35.875+0200 E/EFL     (  836): edje<836> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 11:22:37.585+0200 I/APP_CORE(  735): appcore-efl.c: __do_app(429) > [APP 735] Event: MEM_FLUSH State: PAUSED
10-26 11:22:39.175+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1153523 button=1
10-26 11:22:39.175+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:22:39.175+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 11:22:39.175+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,242,216,124]
10-26 11:22:39.195+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:22:39.205+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:22:39.205+0200 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-26 11:22:39.235+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:22:39.235+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:22:39.255+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:22:39.260+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:22:39.280+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:22:39.290+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1153629 button=1
10-26 11:22:39.295+0200 E/APPS    (  769): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-26 11:22:40.065+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1154413 button=1
10-26 11:22:40.065+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:22:40.070+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 11:22:40.070+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 11:22:40.095+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1154447 button=1
10-26 11:22:40.095+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 11:22:40.095+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 11:22:40.100+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 11:22:40.100+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 11:22:40.110+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 11:22:40.110+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 11:22:40.110+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 11:22:40.120+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 11:22:40.120+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 11:22:40.120+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 11:22:40.125+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-26 11:22:40.125+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 11:22:40.180+0200 I/efl-extension( 2694): efl_extension.c: eext_mod_init(40) > Init
10-26 11:22:40.185+0200 I/UXT     ( 2694): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 11:22:40.185+0200 I/CAPI_APPFW_APPLICATION( 2694): app_main.c: ui_app_main(704) > app_efl_main
10-26 11:22:40.190+0200 I/CAPI_APPFW_APPLICATION( 2694): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 11:22:40.220+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(2694)
10-26 11:22:40.220+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 11:22:40.220+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 11:22:40.235+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 11:22:40.305+0200 I/Bluetooth( 2694): [bt_initialize] success.
10-26 11:22:40.310+0200 I/Bluetooth( 2694): [bt_adapter_le_create_advertiser] success.
10-26 11:22:40.330+0200 I/Bluetooth( 2694): [bt_adapter_le_set_advertising_mode] success.
10-26 11:22:40.340+0200 I/Bluetooth( 2694): [bt_adapter_le_set_advertising_connectable] success.
10-26 11:22:40.340+0200 I/Bluetooth( 2694): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:22:40.340+0200 I/Bluetooth( 2694): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:22:40.440+0200 I/Bluetooth( 2694): [bt_adapter_le_start_advertising_new] success.
10-26 11:22:40.440+0200 I/Bluetooth( 2694): Heart Rate Measurement advertiser started.
10-26 11:22:40.475+0200 I/Bluetooth( 2694): [bt_adapter_le_stop_advertising] success.
10-26 11:22:40.475+0200 I/Bluetooth( 2694): [bt_adapter_le_clear_advertising_data] success.
10-26 11:22:40.475+0200 I/Bluetooth( 2694): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:22:40.475+0200 I/Bluetooth( 2694): [bt_adapter_le_add_advertising_service_solicitation_uuid] success.
10-26 11:22:40.570+0200 I/Bluetooth( 2694): [bt_adapter_le_start_advertising_new] success.
10-26 11:22:40.620+0200 E/EFL     ( 2694): ecore_evas<2694> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-26 11:22:40.860+0200 W/W_HOME  (  769): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-26 11:22:40.860+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:40.860+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:40.860+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:40.860+0200 I/APP_CORE( 2694): appcore-efl.c: __do_app(429) > [APP 2694] Event: RESET State: CREATED
10-26 11:22:40.860+0200 I/CAPI_APPFW_APPLICATION( 2694): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-26 11:22:40.875+0200 I/APP_CORE( 2694): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-26 11:22:40.875+0200 I/APP_CORE( 2694): appcore-efl.c: __do_app(474) > [APP 2694] Initial Launching, call the resume_cb
10-26 11:22:40.875+0200 I/CAPI_APPFW_APPLICATION( 2694): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-26 11:22:40.885+0200 W/APP_CORE( 2694): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4800002
10-26 11:22:40.935+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-26 11:22:40.935+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-26 11:22:40.935+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:40.935+0200 W/W_HOME  (  769): event_manager.c: _state_control(344) > appcore paused manually
10-26 11:22:40.935+0200 W/W_HOME  (  769): main.c: home_appcore_pause(723) > Home Appcore Paused
10-26 11:22:40.935+0200 W/W_HOME  (  769): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-26 11:22:40.935+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:40.935+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:40.935+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:40.945+0200 I/APP_CORE( 2694): appcore-efl.c: __do_app(429) > [APP 2694] Event: RESUME State: RUNNING
10-26 11:22:40.950+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:40.950+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:40.950+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:40.955+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 11:22:40.955+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 11:22:40.955+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:40.955+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 11:22:40.955+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:40.960+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:40.960+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:40.960+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:40.960+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 11:22:40.960+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 11:22:40.960+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:40.960+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 11:22:40.960+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 11:22:40.960+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 11:22:40.960+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:40.960+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 11:22:40.960+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
10-26 11:22:40.965+0200 W/W_HOME  (  769): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-26 11:22:40.965+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: PAUSE State: RUNNING
10-26 11:22:40.965+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 11:22:40.965+0200 W/W_HOME  (  769): main.c: _appcore_pause_cb(696) > appcore pause
10-26 11:22:40.965+0200 E/W_HOME  (  769): main.c: _pause_cb(674) > paused already
10-26 11:22:40.995+0200 I/INFO_TAG( 2694): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:40.995+0200 I/INFO_TAG( 2694): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:41.025+0200 W/wnotib  (  769): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-26 11:22:41.240+0200 E/EFL     ( 2694): elementary<2694> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 11:22:41.245+0200 E/EFL     ( 2694): elementary<2694> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 11:22:41.290+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.214
10-26 11:22:41.305+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 11:22:41.320+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:22:41.325+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2694
10-26 11:22:41.325+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 11:22:41.335+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:22:41.340+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2694
10-26 11:22:41.340+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 11:22:41.410+0200 E/EFL     ( 2812): elementary<2812> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 11:22:41.410+0200 E/EFL     ( 2812): elementary<2812> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 11:22:41.435+0200 E/EFL     ( 2812): elementary<2812> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 11:22:41.440+0200 E/EFL     ( 2812): elementary<2812> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 11:22:41.465+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 11:22:41.475+0200 E/EFL     ( 2812): elementary<2812> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 11:22:41.475+0200 E/EFL     ( 2812): elementary<2812> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 11:22:41.485+0200 E/EFL     ( 2812): elementary<2812> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 11:22:41.485+0200 E/EFL     ( 2812): elementary<2812> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 11:22:41.485+0200 E/EFL     ( 2812): elementary<2812> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 11:22:41.505+0200 E/EFL     ( 2812): elementary<2812> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 11:22:41.510+0200 E/EFL     ( 2812): elementary<2812> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 11:22:41.510+0200 E/EFL     ( 2812): elementary<2812> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 11:22:41.545+0200 E/EFL     ( 2812): elementary<2812> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 11:22:41.550+0200 E/EFL     ( 2812): elementary<2812> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 11:22:41.550+0200 E/EFL     ( 2812): elementary<2812> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 11:22:41.550+0200 E/EFL     ( 2812): elementary<2812> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 11:22:41.550+0200 E/EFL     ( 2812): elementary<2812> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 11:22:41.550+0200 E/EFL     ( 2812): elementary<2812> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 11:22:41.550+0200 E/EFL     ( 2812): elementary<2812> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 11:22:41.550+0200 I/AUL_PAD ( 2812): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 11:22:41.665+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 4
10-26 11:22:41.665+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-26 11:22:41.805+0200 I/INFO_TAG( 2694): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:42.810+0200 I/INFO_TAG( 2694): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:43.815+0200 I/INFO_TAG( 2694): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:44.150+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 11:22:44.815+0200 I/INFO_TAG( 2694): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:45.815+0200 I/INFO_TAG( 2694): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:45.995+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 11:22:46.190+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 11:22:46.260+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-26 11:22:46.260+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-26 11:22:46.265+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 11:22:46.270+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
10-26 11:22:46.820+0200 I/INFO_TAG( 2694): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:47.820+0200 I/INFO_TAG( 2694): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:48.820+0200 I/INFO_TAG( 2694): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:49.820+0200 I/INFO_TAG( 2694): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:50.820+0200 I/INFO_TAG( 2694): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:51.695+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
10-26 11:22:51.720+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-26 11:22:51.810+0200 I/INFO_TAG( 2694): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:52.835+0200 I/INFO_TAG( 2694): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:52.940+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-26 11:22:52.945+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-26 11:22:52.945+0200 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-26 11:22:52.945+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 11:22:52.945+0200 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 1
10-26 11:22:52.945+0200 W/W_HOME  (  769): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-26 11:22:52.945+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:52.970+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
10-26 11:22:52.970+0200 W/STARTER (  732): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-26 11:22:52.970+0200 E/STARTER (  732): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-26 11:22:52.970+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-26 11:22:52.970+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-26 11:22:53.135+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 11:22:53.190+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 11:22:53.195+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 11:22:53.220+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
10-26 11:22:53.220+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
10-26 11:22:53.240+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-26 11:22:53.240+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-26 11:22:53.240+0200 E/ALARM_MANAGER(  732): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(26-10-2017, 11:23:13), repeat(1), interval(20), type(-1073741822)
10-26 11:22:53.245+0200 I/APP_CORE( 2694): appcore-efl.c: __do_app(429) > [APP 2694] Event: PAUSE State: RUNNING
10-26 11:22:53.250+0200 I/CAPI_APPFW_APPLICATION( 2694): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
10-26 11:22:53.270+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 11:22:53.350+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1441694497, next duetime: 1509009793
10-26 11:22:53.350+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1441694497)
10-26 11:22:53.350+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509021900), due_time(1509009793)
10-26 11:22:53.350+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 11:22:53.350+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 09:23:13 (UTC).
10-26 11:22:53.355+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 11:22:53.370+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 11:22:53.370+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 11:22:53.430+0200 I/APP_CORE( 2694): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
10-26 11:22:53.430+0200 I/CAPI_APPFW_APPLICATION( 2694): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
10-26 11:22:53.610+0200 W/CRASH_MANAGER( 2695): worker.c: worker_job(1205) > 1102694646174150900977

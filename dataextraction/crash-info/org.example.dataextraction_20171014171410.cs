S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 13460
Date: 2017-10-14 17:14:10+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x20000c

Register Information
r0   = 0x00200000, r1   = 0x401d4e58
r2   = 0xbeb28ea4, r3   = 0xbeb28f09
r4   = 0x401d4e58, r5   = 0x00200000
r6   = 0x402cfb88, r7   = 0xbeb28f18
r8   = 0x00000041, r9   = 0x40452824
r10  = 0x414dd148, fp   = 0x00000000
ip   = 0x401ebc20, sp   = 0xbeb28e30
lr   = 0x4019d13f, pc   = 0x4022df5e
cpsr = 0x20000030

Memory Information
MemTotal:   491948 KB
MemFree:     23616 KB
Buffers:     62460 KB
Cached:     163044 KB
VmPeak:      92436 KB
VmSize:      91696 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16240 KB
VmRSS:       16236 KB
VmData:      38084 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23132 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 13460 TID = 13460
13460 13506 13507 13508 13509 

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
43701000 43f00000 rw-p [stack:13506]
43f01000 44700000 rw-p [stack:13507]
44701000 44f00000 rw-p [stack:13508]
45001000 45800000 rw-p [stack:13509]
beb09000 beb2a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13460)
Call Stack Count: 17
 0: evas_object_smart_type_check_ptr + 0xd (0x4022df5e) [/usr/lib/libevas.so.1] + 0x34f5e
 1: elm_widget_text_part_set + 0x12 (0x4019d13f) [/usr/lib/libelementary.so.1] + 0xf513f
 2: on_sensor_event + 0xc0 (0x4156be39) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1e39
 3: (0x4175782f) [/usr/lib/libcapi-system-sensor.so.0] + 0x182f
 4: (0x417aaaf0) [/usr/lib/libsensor.so.1] + 0x14af0
 5: (0x403b5fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 6: g_main_context_dispatch + 0xbc (0x403b77a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 7: (0x402fdca7) [/usr/lib/libecore.so.1] + 0x10ca7
 8: (0x402f8b4f) [/usr/lib/libecore.so.1] + 0xbb4f
 9: (0x402f95a7) [/usr/lib/libecore.so.1] + 0xc5a7
10: ecore_main_loop_begin + 0x30 (0x402f9879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x20a (0x40044523) [/usr/lib/libappcore-efl.so.1] + 0x3523
12: ui_app_main + 0xb0 (0x41541421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x10e (0x4156b623) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1623
14: create_base_gui + 0x222 (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
15: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
16: create_base_gui + 0x597 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
event_client_message_cb
10-14 17:14:06.455+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 17:14:06.475+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 17:14:06.475+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 17:14:06.475+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 17:14:06.475+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 1
10-14 17:14:06.475+0200 E/wnoti-service(  838): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 1 
10-14 17:14:06.475+0200 E/wnoti-service(  838): wnoti-native-client.c: handle_cache_notification(603) > >>
10-14 17:14:06.565+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 13086 pgid = 13086
10-14 17:14:06.565+0200 E/DATA_PROVIDER_MASTER(  706): client_life.c: client_deactivated_by_fault(494) > Client[0x43946c78] is faulted(1), pid(13086)
10-14 17:14:06.575+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
10-14 17:14:06.580+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
10-14 17:14:06.585+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=14328929
10-14 17:14:06.585+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
10-14 17:14:06.585+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
10-14 17:14:06.585+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
10-14 17:14:06.615+0200 E/STARTER (  705): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
10-14 17:14:06.615+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
10-14 17:14:06.615+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
10-14 17:14:06.710+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-14 17:14:06.710+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-14 17:14:06.715+0200 W/STARTER (  705): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
10-14 17:14:06.715+0200 W/STARTER (  705): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
10-14 17:14:06.730+0200 W/STARTER (  705): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
10-14 17:14:06.730+0200 W/STARTER (  705): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[0] pressed lcd status[1], current lcd status[1] pressed pm state[1]
10-14 17:14:06.735+0200 E/STARTER (  705): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
10-14 17:14:06.735+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-14 17:14:06.740+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 17:14:06.745+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 705
10-14 17:14:06.765+0200 W/AUL_AMD (  532): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 1063
10-14 17:14:06.780+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=14329067
10-14 17:14:06.785+0200 W/AUL_AMD (  532): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(1063), cmd(0)
10-14 17:14:06.785+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(282) > request cmd(0) result(1063)
10-14 17:14:06.785+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: RESET State: RUNNING
10-14 17:14:06.785+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-14 17:14:06.785+0200 W/W_HOME  ( 1063): main.c: _app_control(1704) > Service value : powerkey
10-14 17:14:06.790+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
10-14 17:14:06.790+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
10-14 17:14:06.790+0200 W/W_HOME  ( 1063): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
10-14 17:14:06.790+0200 E/W_HOME  ( 1063): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
10-14 17:14:06.790+0200 W/W_HOME  ( 1063): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:1
10-14 17:14:06.790+0200 W/W_HOME  ( 1063): move.c: move_back_to_home(252) > back to home
10-14 17:14:06.800+0200 W/W_HOME  ( 1063): move.c: _create_fake_apps(823) > fake image position : 0
10-14 17:14:06.805+0200 W/W_HOME  ( 1063): move.c: _create_fake_apps(847) > move_info.current_y_coord: 0
10-14 17:14:06.805+0200 W/W_HOME  ( 1063): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
10-14 17:14:06.805+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:06.805+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(314) > clock/widget (force) resumed
10-14 17:14:06.810+0200 W/W_HOME  ( 1063): clock_indicator.c: clock_indicator_resume(537) > 
10-14 17:14:06.810+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:06.815+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-14 17:14:06.815+0200 W/W_HOME  ( 1063): event_manager.c: _apptray_visibility_cb(583) > apps,hide,start
10-14 17:14:06.815+0200 W/W_HOME  ( 1063): event_manager.c: _apptray_visibility_cb(601) > state: 0 -> 1
10-14 17:14:06.815+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:06.820+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:06.820+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:06.820+0200 W/W_HOME  ( 1063): noti_broker.c: _apptray_visibility_cb(789) > apps,hide,start
10-14 17:14:06.825+0200 W/W_HOME  ( 1063): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
10-14 17:14:06.825+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
10-14 17:14:06.825+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
10-14 17:14:06.855+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/13086/oom_score_adj failed
10-14 17:14:06.855+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 13086
10-14 17:14:06.860+0200 E/AUL     (  705): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 17:14:06.865+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 17:14:06.880+0200 W/SHealth_Service( 1005): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
10-14 17:14:06.895+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 17:14:06.895+0200 W/WATCH_CORE( 1130): appcore-watch.c: __widget_resume(1039) > widget_resume
10-14 17:14:06.895+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 17:14:06.900+0200 E/STARTER (  705): starter.c: _w_app_dead_cb(241) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.6.37/src/starter.c:241:E] w-clock-viewer (pid:13086) is destroyed. ambient mode[0], charging[0], sports mode[0]
10-14 17:14:06.900+0200 W/STARTER (  705): starter.c: _w_app_dead_cb(249) > [_w_app_dead_cb:249] >> clockstop
10-14 17:14:06.900+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 13086
10-14 17:14:06.910+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.3016
10-14 17:14:06.930+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_alpm_handler(1066) > signal_alpm_handler: ambient mode: 0, state: 2
10-14 17:14:06.930+0200 E/WATCH_CORE( 1130): appcore-watch.c: __signal_alpm_handler(1070) > invalid state
10-14 17:14:07.015+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-14 17:14:07.015+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-14 17:14:07.015+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: preference_get_boolean(1173) > preference_get_boolean(1005) : test_healthy_pace error
10-14 17:14:07.015+0200 W/SHealth_Service( 1005): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1122) > [1;40;33mOnNotWearingStop[0;m
10-14 17:14:07.080+0200 W/SHealth_Common( 1005): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1507939200000,000000[0;m
10-14 17:14:07.100+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
10-14 17:14:07.100+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
10-14 17:14:07.110+0200 I/HealthDataService(  770): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-14 17:14:07.115+0200 W/W_HOME  ( 1063): move.c: _transit_del_cb(115) > transit end
10-14 17:14:07.115+0200 W/W_HOME  ( 1063): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
10-14 17:14:07.115+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
10-14 17:14:07.135+0200 I/healthData( 1005): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-14 17:14:07.135+0200 W/W_HOME  ( 1063): move.c: _scroller_down_done(494) > down signal done
10-14 17:14:07.135+0200 W/W_HOME  ( 1063): event_manager.c: _apptray_visibility_cb(583) > apps,hide
10-14 17:14:07.135+0200 W/W_HOME  ( 1063): event_manager.c: _apptray_visibility_cb(601) > state: 0 -> 0
10-14 17:14:07.135+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
10-14 17:14:07.135+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
10-14 17:14:07.135+0200 W/W_HOME  ( 1063): main.c: home_resume(735) > journal_appcore_app_fully_loaded called
10-14 17:14:07.135+0200 W/W_HOME  ( 1063): main.c: home_resume(739) > clock/widget resumed
10-14 17:14:07.135+0200 W/W_HOME  ( 1063): clock_indicator.c: clock_indicator_resume(537) > 
10-14 17:14:07.140+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
10-14 17:14:07.145+0200 W/W_HOME  ( 1063): noti_broker.c: _apptray_visibility_cb(789) > apps,hide
10-14 17:14:07.145+0200 W/W_HOME  ( 1063): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80001
10-14 17:14:07.145+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80001
10-14 17:14:07.145+0200 I/wnotib  ( 1063): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 0
10-14 17:14:07.150+0200 E/APPS    ( 1063): apps_main.c: apps_main_pause(602) >  paused already
10-14 17:14:07.340+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:14:07.340+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:14:07.340+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:14:07.340+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:14:07.340+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:14:07.340+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:14:07.340+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:14:07.340+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:14:07.340+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:14:07.340+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:14:07.340+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:14:07.345+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:14:07.345+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:14:07.345+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:14:07.345+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:14:07.345+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:14:07.345+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:14:07.345+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:14:07.345+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 17:14:07.345+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [true][0m
10-14 17:14:07.345+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:14:07.355+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1063
10-14 17:14:07.355+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 17:14:07.360+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 17:14:07.360+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 17:14:07.360+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 17:14:07.360+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 17:14:07.360+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1814]   bundle_add_str() .. [0xffffffea][0m
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:14:07.360+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:14:07.365+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 17:14:07.365+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 17:14:07.365+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 17:14:07.370+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 17:14:07.370+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 17:14:07.370+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 17:14:07.370+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:14:07.370+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:14:07.375+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 17:14:07.375+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 17:14:07.380+0200 I/TIZEN_N_SOUND_MANAGER( 1814): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 17:14:07.380+0200 E/TIZEN_N_SOUND_MANAGER( 1814): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 17:14:07.380+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1814]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:14:07.380+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:14:07.770+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 17:14:07.770+0200 W/AUL_AMD (  532): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-14 17:14:08.040+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
10-14 17:14:08.040+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
10-14 17:14:08.040+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
10-14 17:14:08.040+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
10-14 17:14:08.040+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
10-14 17:14:08.040+0200 E/STARTER (  705): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
10-14 17:14:08.040+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
10-14 17:14:08.040+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
10-14 17:14:08.050+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=14330394
10-14 17:14:08.180+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 17:14:08.210+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-14 17:14:08.210+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-14 17:14:08.210+0200 W/STARTER (  705): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
10-14 17:14:08.210+0200 W/STARTER (  705): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
10-14 17:14:08.210+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=14330566
10-14 17:14:08.220+0200 W/STARTER (  705): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
10-14 17:14:08.220+0200 W/STARTER (  705): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
10-14 17:14:08.220+0200 E/STARTER (  705): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
10-14 17:14:08.220+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-14 17:14:08.225+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 17:14:08.225+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 705
10-14 17:14:08.235+0200 W/AUL_AMD (  532): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 1063
10-14 17:14:08.235+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: RESET State: RUNNING
10-14 17:14:08.235+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-14 17:14:08.235+0200 W/W_HOME  ( 1063): main.c: _app_control(1704) > Service value : powerkey
10-14 17:14:08.235+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
10-14 17:14:08.235+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
10-14 17:14:08.235+0200 W/W_HOME  ( 1063): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
10-14 17:14:08.235+0200 E/W_HOME  ( 1063): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
10-14 17:14:08.235+0200 W/W_HOME  ( 1063): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
10-14 17:14:08.235+0200 W/W_HOME  ( 1063): move.c: move_move_to_apps(220) > move to apps
10-14 17:14:08.235+0200 W/AUL_AMD (  532): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(1063), cmd(0)
10-14 17:14:08.235+0200 W/W_HOME  ( 1063): move.c: _create_fake_apps(823) > fake image position : 432
10-14 17:14:08.240+0200 W/W_HOME  ( 1063): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
10-14 17:14:08.240+0200 W/W_HOME  ( 1063): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
10-14 17:14:08.240+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 17:14:08.240+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 17:14:08.240+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-14 17:14:08.240+0200 W/W_HOME  ( 1063): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
10-14 17:14:08.240+0200 W/W_HOME  ( 1063): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-14 17:14:08.240+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 17:14:08.240+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 17:14:08.240+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 17:14:08.240+0200 W/W_HOME  ( 1063): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
10-14 17:14:08.240+0200 W/W_HOME  ( 1063): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
10-14 17:14:08.240+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
10-14 17:14:08.240+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
10-14 17:14:08.240+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(282) > request cmd(0) result(1063)
10-14 17:14:08.240+0200 E/AUL     (  705): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 17:14:08.245+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 17:14:08.550+0200 W/W_HOME  ( 1063): move.c: _transit_del_cb(115) > transit end
10-14 17:14:08.550+0200 W/W_HOME  ( 1063): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
10-14 17:14:08.550+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 17:14:08.560+0200 W/W_HOME  ( 1063): move.c: _scroller_up_done(515) > up signal done
10-14 17:14:08.565+0200 W/W_HOME  ( 1063): event_manager.c: _apptray_visibility_cb(583) > apps,show
10-14 17:14:08.565+0200 W/W_HOME  ( 1063): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
10-14 17:14:08.565+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:08.570+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:08.570+0200 W/W_HOME  ( 1063): main.c: home_pause(766) > clock/widget paused
10-14 17:14:08.570+0200 W/W_HOME  ( 1063): clock_indicator.c: clock_indicator_pause(554) > 
10-14 17:14:08.570+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:08.570+0200 W/W_HOME  ( 1063): noti_broker.c: _apptray_visibility_cb(789) > apps,show
10-14 17:14:08.570+0200 W/W_HOME  ( 1063): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
10-14 17:14:08.570+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
10-14 17:14:08.575+0200 I/wnotib  ( 1063): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
10-14 17:14:08.575+0200 E/APPS    ( 1063): apps_main.c: apps_main_resume(636) >  resumed already
10-14 17:14:08.585+0200 W/WATCH_CORE( 1130): appcore-watch.c: __widget_pause(1028) > widget_pause
10-14 17:14:08.695+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=14331049 button=1
10-14 17:14:08.695+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:14:08.695+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 17:14:08.695+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,366,216,136]
10-14 17:14:08.710+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:14:08.720+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:14:08.720+0200 W/APPS    ( 1063): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-14 17:14:08.730+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:14:08.745+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:14:08.760+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:14:08.770+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=14331127 button=1
10-14 17:14:08.770+0200 E/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-14 17:14:09.240+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 17:14:09.240+0200 W/AUL_AMD (  532): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-14 17:14:09.650+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=14332007 button=1
10-14 17:14:09.655+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:14:09.655+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 17:14:09.655+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-14 17:14:09.675+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:14:09.730+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=14332085 button=1
10-14 17:14:09.730+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-14 17:14:09.730+0200 E/APPS    ( 1063): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-14 17:14:09.730+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-14 17:14:09.730+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 17:14:09.730+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 17:14:09.735+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 1063
10-14 17:14:09.735+0200 I/AUL_AMD (  532): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-14 17:14:09.745+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 17:14:09.745+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 17:14:09.745+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 17:14:09.745+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 3
10-14 17:14:09.745+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 17:14:09.790+0200 I/efl-extension(13460): efl_extension.c: eext_mod_init(40) > Init
10-14 17:14:09.795+0200 I/UXT     (13460): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 17:14:09.795+0200 I/CAPI_APPFW_APPLICATION(13460): app_main.c: ui_app_main(704) > app_efl_main
10-14 17:14:09.800+0200 I/CAPI_APPFW_APPLICATION(13460): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 17:14:09.850+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(282) > request cmd(0) result(13460)
10-14 17:14:09.865+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 17:14:09.890+0200 E/EFL     (13460): ecore_evas<13460> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-14 17:14:10.125+0200 I/APP_CORE(13460): appcore-efl.c: __do_app(429) > [APP 13460] Event: RESET State: CREATED
10-14 17:14:10.125+0200 I/CAPI_APPFW_APPLICATION(13460): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-14 17:14:10.140+0200 I/APP_CORE(13460): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-14 17:14:10.140+0200 I/APP_CORE(13460): appcore-efl.c: __do_app(474) > [APP 13460] Initial Launching, call the resume_cb
10-14 17:14:10.140+0200 I/CAPI_APPFW_APPLICATION(13460): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-14 17:14:10.145+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-14 17:14:10.145+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:10.145+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:10.145+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:10.170+0200 W/APP_CORE(13460): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4e00002
10-14 17:14:10.210+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-14 17:14:10.210+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-14 17:14:10.210+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:10.210+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-14 17:14:10.215+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: PAUSE State: RUNNING
10-14 17:14:10.215+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 17:14:10.215+0200 W/W_HOME  ( 1063): main.c: _appcore_pause_cb(696) > appcore pause
10-14 17:14:10.215+0200 W/W_HOME  ( 1063): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-14 17:14:10.215+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:10.215+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:10.215+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:14:10.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:14:10.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:14:10.215+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:14:10.215+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:14:10.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:14:10.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:14:10.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:14:10.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:14:10.225+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:14:10.225+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:14:10.225+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:14:10.225+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:14:10.225+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:14:10.225+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:14:10.225+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:14:10.225+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:14:10.225+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:14:10.225+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:14:10.225+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 17:14:10.225+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [false][0m
10-14 17:14:10.245+0200 I/APP_CORE(13460): appcore-efl.c: __do_app(429) > [APP 13460] Event: RESUME State: RUNNING
10-14 17:14:10.275+0200 I/HEART_RATE(13460): HEART RATE : 0
10-14 17:14:10.290+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-14 17:14:10.535+0200 W/CRASH_MANAGER(13510): worker.c: worker_job(1205) > 1113460646174150799405

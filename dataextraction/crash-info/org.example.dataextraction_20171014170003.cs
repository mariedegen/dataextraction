S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 10078
Date: 2017-10-14 17:00:03+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 10078, uid 5000)

Register Information
r0   = 0x123b0000, r1   = 0x401d4e58
r2   = 0xbef74ea4, r3   = 0xbef74f09
r4   = 0x401d4e58, r5   = 0x123b0000
r6   = 0x402cfb88, r7   = 0xbef74f18
r8   = 0x00000041, r9   = 0x40452824
r10  = 0x416b8e60, fp   = 0x00000000
ip   = 0x401ebc20, sp   = 0xbef74e38
lr   = 0x4019d13f, pc   = 0x4022df5e
cpsr = 0x20000030

Memory Information
MemTotal:   491948 KB
MemFree:     27580 KB
Buffers:     61048 KB
Cached:     160880 KB
VmPeak:      95476 KB
VmSize:      94736 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17228 KB
VmRSS:       17224 KB
VmData:      38504 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25100 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 10078 TID = 10078
10078 10109 10110 10111 10112 

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
4143f000 41443000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
41452000 41457000 r-xp /usr/lib/libappcore-common.so.1.1
4145f000 41461000 r-xp /usr/lib/libiniparser.so.0
4146a000 4146d000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
4147d000 41481000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4148a000 4148c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41495000 4149b000 r-xp /usr/lib/libappsvc.so.0.1.0
414a3000 414c7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414d0000 414da000 r-xp /lib/libnss_files-2.13.so
414e3000 414ee000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
414f6000 414fa000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41503000 4150b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
4150c000 4152d000 r-xp /usr/lib/libefl-extension.so.0.1.0
41536000 41558000 rw-p [heap]
41558000 41627000 r-xp /usr/lib/libscim-1.0.so.8.2.3
417b8000 417e2000 r-xp /usr/lib/libsensor.so.1.9.6
417eb000 417fd000 r-xp /usr/lib/libefl-assist.so.0.1.0
41805000 418bd000 r-xp /usr/lib/libcairo.so.2.11200.14
418c8000 418d2000 r-xp /usr/lib/libsensord-shared.so
418db000 418ed000 r-xp /usr/lib/libtts.so
418f5000 41917000 r-xp /usr/lib/libui-extension.so.0.1.0
41920000 41927000 r-xp /usr/lib/libtbm.so.1.0.0
4192f000 4193d000 r-xp /usr/lib/libGLESv2.so.2.0
41946000 41947000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41950000 41956000 r-xp /usr/lib/libxcb-render.so.0.0.0
4195e000 41961000 r-xp /usr/lib/libEGL.so.1.4
41969000 4196e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41976000 41979000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41981000 41982000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
4198b000 41ac8000 r-xp /usr/lib/libicui18n.so.51.1
41ad8000 41bbc000 r-xp /usr/lib/libicuuc.so.51.1
41bd1000 41bd9000 r-xp /usr/lib/libdrm.so.2.4.0
41be1000 41be3000 r-xp /usr/lib/libdri2.so.0.0.0
41beb000 41bf1000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41bf9000 41bfe000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41c06000 41c1f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
431b0000 431d1000 r-xp /usr/lib/libexif.so.12.3.3
431e4000 431e6000 r-xp /usr/lib/libttrace.so.1.1
431ee000 431f3000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
431fb000 43201000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4320a000 43212000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4321a000 43236000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4323f000 43246000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4324f000 43251000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43259000 43260000 r-xp /usr/lib/libminizip.so.1.0.0
43268000 43275000 r-xp /usr/lib/libail.so.0.1.0
4327e000 43348000 r-xp /usr/lib/libCOREGL.so.4.0
4355a000 43565000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4356e000 43573000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43719000 4371a000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43723000 43f22000 rw-p [stack:10109]
43f23000 44722000 rw-p [stack:10110]
44723000 44f22000 rw-p [stack:10111]
44f7e000 44f7f000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44f9a000 44fa1000 r-xp /usr/lib/libfeedback.so.0.1.4
44faa000 44fab000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44fb3000 44fb5000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44fbd000 44fc7000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
44fcf000 44fd6000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44fde000 44fe3000 r-xp /usr/lib/libmmfsession.so.0.0.0
44feb000 44fef000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45101000 45900000 rw-p [stack:10112]
45900000 45916000 r-xp /usr/lib/libmmfsound.so.0.1.0
45928000 45932000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
4593e000 45953000 r-xp /usr/lib/libavsysaudio.so.0.0.1
4595b000 459bc000 r-xp /usr/lib/libasound.so.2.0.0
459c6000 459c9000 r-xp /usr/lib/libpulse-simple.so.0.0.4
459d1000 45a09000 r-xp /usr/lib/libpulse.so.0.16.2
45a0a000 45a0d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45a15000 45a46000 r-xp /usr/lib/libmdm.so.1.1.86
45a4e000 45a53000 r-xp /usr/lib/libjson.so.0.0.1
45a5b000 45aa3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45aa4000 45aeb000 r-xp /usr/lib/libsndfile.so.1.0.26
45af7000 45aff000 r-xp /usr/lib/libmdm-common.so.1.0.89
45b00000 45b22000 r-xp /usr/lib/libvorbis.so.0.4.3
45b2a000 45b2e000 r-xp /usr/lib/libogg.so.0.7.1
bef55000 bef76000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10078)
Call Stack Count: 17
 0: evas_object_smart_type_check_ptr + 0xd (0x4022df5e) [/usr/lib/libevas.so.1] + 0x34f5e
 1: elm_widget_text_part_set + 0x12 (0x4019d13f) [/usr/lib/libelementary.so.1] + 0xf513f
 2: on_sensor_event_2 + 0x96 (0x4146beef) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1eef
 3: (0x414f782f) [/usr/lib/libcapi-system-sensor.so.0] + 0x182f
 4: (0x417ccaf0) [/usr/lib/libsensor.so.1] + 0x14af0
 5: (0x403b5fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 6: g_main_context_dispatch + 0xbc (0x403b77a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 7: (0x402fdca7) [/usr/lib/libecore.so.1] + 0x10ca7
 8: (0x402f8b4f) [/usr/lib/libecore.so.1] + 0xbb4f
 9: (0x402f94d5) [/usr/lib/libecore.so.1] + 0xc4d5
10: ecore_main_loop_begin + 0x30 (0x402f9879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x20a (0x40044523) [/usr/lib/libappcore-efl.so.1] + 0x3523
12: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x10e (0x4146b65b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x165b
14: create_base_gui + 0x1ea (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
15: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
16: create_base_gui + 0x55f (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
335] Hide AMPM (2)
10-14 16:59:57.930+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 16:59:57.955+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [705].
10-14 16:59:57.955+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(345663088)
10-14 16:59:57.955+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 16:59:57.955+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 15:01:00 (UTC).
10-14 16:59:57.955+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 16:59:57.955+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 16:59:57.955+0200 E/ALARM_MANAGER(  484): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[345663088] is removed.
10-14 16:59:57.955+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 16:59:57.970+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-14 16:59:57.970+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-14 16:59:57.970+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: preference_get_boolean(1173) > preference_get_boolean(1005) : test_healthy_pace error
10-14 16:59:58.005+0200 W/SHealth_Common( 1005): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1507939200000,000000[0;m
10-14 16:59:58.030+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
10-14 16:59:58.040+0200 I/HealthDataService(  770): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-14 16:59:58.060+0200 I/healthData( 1005): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-14 16:59:58.105+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
10-14 16:59:58.105+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_enable(136) > 0
10-14 16:59:58.105+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-14 16:59:58.110+0200 E/EFL     ( 1063): evas_main<1063> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46379910 is not stable during recalc loop
10-14 16:59:58.110+0200 E/EFL     ( 1063): evas_main<1063> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46379910 is not stable during recalc loop
10-14 16:59:58.125+0200 I/MALI    ( 1063): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f370] swap changed from sync to async
10-14 16:59:58.130+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 16:59:58.225+0200 W/SHealth_Common( 1156): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 16:59:58.225+0200 W/SHealth_Common( 1005): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 16:59:58.235+0200 W/SHealth_Service( 1005): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-14 16:59:58.270+0200 W/W_CLOCK_VIEWER( 9618): clock-viewer.c: __clock_viewer_lcdon_completed_cb(471) >  event lcdon completed[1]
10-14 16:59:58.270+0200 W/W_CLOCK_VIEWER( 9618): clock-viewer.c: __clock_viewer_lcdon_completed_cb(475) >  Exit from charger alpm mode
10-14 16:59:58.270+0200 W/W_CLOCK_VIEWER( 9618): clock-viewer.c: _clock_viewer_send_clock_changed(919) >  clock changed <<
10-14 16:59:58.285+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
10-14 16:59:58.285+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[1]
10-14 16:59:58.285+0200 W/SHealth_Common( 1005): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 16:59:58.290+0200 W/SHealth_Common( 1156): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 16:59:58.320+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [9618].
10-14 16:59:58.320+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(345663089)
10-14 16:59:58.320+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 16:59:58.320+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 20:47:32 (UTC).
10-14 16:59:58.320+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 16:59:58.320+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 16:59:58.320+0200 E/ALARM_MANAGER(  484): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[345663089] is removed.
10-14 16:59:58.320+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 16:59:58.355+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-14 16:59:58.400+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
10-14 16:59:58.400+0200 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 16:59:58.430+0200 I/W_INDICATOR(  714): windicator_brightness.c: _current_device_brightness_level_get(143) > [_current_device_brightness_level_get:143] Brightness level : 80
10-14 16:59:58.430+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(818) > [windicator_brightness_update:818] current device brightness level : 80 / isOutdoorMode : 0
10-14 16:59:58.430+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(827) > [windicator_brightness_update:827] NOT Outdoor mode
10-14 16:59:58.435+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_icon_set_by_level(771) > [windicator_brightness_icon_set_by_level:771] layout(0x443f5e30) signal name : brightness.icon.7
10-14 16:59:58.435+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/brightness/small_layout has a non-fixed part 'txt.brightness'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 16:59:58.440+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 16:59:58.555+0200 E/EFL     (  714): ecore_x<714> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=13480906 button=1
10-14 16:59:58.565+0200 E/EFL     (  714): ecore_x<714> ecore_x_xi2.c:343 _ecore_x_input_handler() ButtonEvent:multi press time=13480917 devid=10
10-14 16:59:58.645+0200 E/EFL     (  714): ecore_x<714> ecore_x_xi2.c:363 _ecore_x_input_handler() ButtonEvent:multi release time=13480996 devid=10
10-14 16:59:58.665+0200 E/EFL     (  714): ecore_x<714> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=13481021 button=1
10-14 16:59:58.665+0200 W/W_INDICATOR(  714): windicator_moment_view.c: on_clicked_charging_watch_layout(378) > [on_clicked_charging_watch_layout:378] Debugging mode? : 1
10-14 16:59:58.665+0200 W/W_INDICATOR(  714): windicator_moment_view.c: on_clicked_charging_watch_layout(382) > [on_clicked_charging_watch_layout:382] Debugging mode On, so hide charging watch!
10-14 16:59:58.670+0200 E/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_hide(1534) > [windicator_moment_view_hide:1534] Hide Moment View : dynamic_layout((nil)),Type(1)
10-14 16:59:58.670+0200 E/W_INDICATOR(  714): windicator_connection.c: windi_connection_pause(1642) > [windi_connection_pause:1642] There is no handle
10-14 16:59:58.730+0200 E/EFL     (  714): ecore_x<714> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=13481087 button=1
10-14 16:59:58.780+0200 E/EFL     (  714): ecore_x<714> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=13481126 button=1
10-14 16:59:58.780+0200 W/W_INDICATOR(  714): windicator_moment_view.c: on_clicked_charging_watch_layout(378) > [on_clicked_charging_watch_layout:378] Debugging mode? : 1
10-14 16:59:58.780+0200 W/W_INDICATOR(  714): windicator_moment_view.c: on_clicked_charging_watch_layout(382) > [on_clicked_charging_watch_layout:382] Debugging mode On, so hide charging watch!
10-14 16:59:58.780+0200 E/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_hide(1534) > [windicator_moment_view_hide:1534] Hide Moment View : dynamic_layout((nil)),Type(-1)
10-14 16:59:58.785+0200 E/W_INDICATOR(  714): windicator_connection.c: windi_connection_pause(1642) > [windi_connection_pause:1642] There is no handle
10-14 16:59:58.840+0200 W/STARTER (  705): clock-mgr.c: _charger_status_setting_changed_cb(890) > [_charger_status_setting_changed_cb:890] charger status is changed to [0] ambient[0]
10-14 16:59:58.840+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(268) > request cmd(4) to(9618)
10-14 16:59:58.845+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 4
10-14 16:59:58.845+0200 W/W_CLOCK_VIEWER( 9618): clock-viewer-util-status.c: __clock_viewer_util_status_rotation_changed_cb(237) >  Rotation is changed[1]
10-14 16:59:58.845+0200 W/W_CLOCK_VIEWER( 9618): clock-viewer-charging.c: __clock_viewer_charging_device_angle_changed_cb(48) >  Hide status. Skip
10-14 16:59:58.850+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_charger_status_changed_cb(437) > 
10-14 16:59:58.850+0200 W/wnotib  ( 1063): w-notification-board-panel-summary.c: wnb_summary_draw_summary_view(1619) > num_categoreis: 0
10-14 16:59:58.850+0200 I/wnotib  ( 1063): w-notification-board-panel-summary.c: _wnb_summary_draw_static_empty_view(1246) > Use existing static_empty_view.
10-14 16:59:58.850+0200 W/wnotib  ( 1063): w-notification-board-panel-summary.c: wnb_summary_draw_summary_view(1640) > current_summary_type: 1, new_summary_type: 1
10-14 16:59:58.865+0200 W/AUL_AMD (  532): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(9618), cmd(4)
10-14 16:59:58.865+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(282) > request cmd(4) result(0)
10-14 16:59:58.870+0200 I/APP_CORE( 9618): appcore-efl.c: __do_app(429) > [APP 9618] Event: TERMINATE State: RUNNING
10-14 16:59:58.870+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 22
10-14 16:59:58.870+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(916) > app status : 4
10-14 16:59:58.875+0200 E/APP_CORE( 9618): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
10-14 16:59:58.875+0200 I/APP_CORE( 9618): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
10-14 16:59:58.875+0200 I/CAPI_APPFW_APPLICATION( 9618): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
10-14 16:59:58.880+0200 I/SCONTEXT-LIB( 9618): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 45
10-14 16:59:58.920+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
10-14 16:59:58.920+0200 W/W_HOME  ( 1063): dbox.c: _dbus_rotation_cb(1341) > angle changed:0
10-14 16:59:58.925+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(305) > [windicator_battery_icon_update:305] 100%
10-14 16:59:58.930+0200 E/EFL     (  714): <714> elm_main.c:1180 elm_object_part_text_set() safety check failed: obj == NULL
10-14 16:59:58.930+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(315) > [windicator_battery_icon_update:315] battery_level: 100, isCharging: 0
10-14 16:59:58.930+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(342) > [windicator_battery_icon_update:342] [SIGNAL] battery file : change_level_100
10-14 16:59:58.930+0200 E/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(128) > [wnidicator_moment_view_battery_image_update:128] Debugging mode!, Clicked!!
10-14 16:59:58.930+0200 W/W_INDICATOR(  714): windicator_battery.c: _battery_charging_changed_cb(117) > [_battery_charging_changed_cb:117] Hide Moment View (unconnected)
10-14 16:59:58.945+0200 E/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_hide(1534) > [windicator_moment_view_hide:1534] Hide Moment View : dynamic_layout((nil)),Type(-1)
10-14 16:59:58.945+0200 E/W_INDICATOR(  714): windicator_connection.c: windi_connection_pause(1642) > [windi_connection_pause:1642] There is no handle
10-14 16:59:58.950+0200 W/W_INDICATOR(  714): windicator_battery.c: _battery_charger_status_changed_cb(164) > [_battery_charger_status_changed_cb:164] Hide Moment View (unconnected)
10-14 16:59:58.950+0200 E/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_hide(1534) > [windicator_moment_view_hide:1534] Hide Moment View : dynamic_layout((nil)),Type(-1)
10-14 16:59:58.950+0200 E/W_INDICATOR(  714): windicator_connection.c: windi_connection_pause(1642) > [windi_connection_pause:1642] There is no handle
10-14 16:59:59.010+0200 E/EFL     (  714): ecore_x<714> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=13481323 button=1
10-14 16:59:59.030+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(668) > [_windicator_rotation_changed_cb:668] [ROTATION] ROT_CHANGE, state:1 angle:0 / is_connected : 0
10-14 16:59:59.030+0200 E/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(676) > [_windicator_rotation_changed_cb:676] [ROTATION] DBus rotation callback error
10-14 16:59:59.090+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 16:59:59.090+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 16:59:59.095+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 16:59:59.100+0200 I/SCONTEXT-LIB( 9618): comm.c: disconnect_dbus(105) > Disconnecting Dbus
10-14 16:59:59.110+0200 E/EFL     (  714): ecore_x<714> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=13481452 button=1
10-14 16:59:59.115+0200 W/W_INDICATOR(  714): windicator_moment_view.c: on_clicked_charging_watch_layout(378) > [on_clicked_charging_watch_layout:378] Debugging mode? : 1
10-14 16:59:59.115+0200 W/W_INDICATOR(  714): windicator_moment_view.c: on_clicked_charging_watch_layout(382) > [on_clicked_charging_watch_layout:382] Debugging mode On, so hide charging watch!
10-14 16:59:59.115+0200 E/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_hide(1534) > [windicator_moment_view_hide:1534] Hide Moment View : dynamic_layout((nil)),Type(-1)
10-14 16:59:59.115+0200 E/W_INDICATOR(  714): windicator_connection.c: windi_connection_pause(1642) > [windi_connection_pause:1642] There is no handle
10-14 16:59:59.130+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-14 16:59:59.130+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-14 16:59:59.130+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-14 16:59:59.130+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-14 16:59:59.130+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_enable(136) > 1
10-14 16:59:59.130+0200 W/W_HOME  ( 1063): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-14 16:59:59.130+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 16:59:59.135+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
10-14 16:59:59.135+0200 W/STARTER (  705): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-14 16:59:59.140+0200 E/STARTER (  705): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-14 16:59:59.140+0200 W/STARTER (  705): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-14 16:59:59.140+0200 W/STARTER (  705): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-14 16:59:59.235+0200 E/DATA_PROVIDER_MASTER(  706): client_life.c: client_deactivated_by_fault(494) > Client[0x4392afa0] is faulted(1), pid(9618)
10-14 16:59:59.235+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 9618 pgid = 9618
10-14 16:59:59.325+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 16:59:59.330+0200 E/STARTER (  705): starter.c: _w_app_dead_cb(241) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.6.37/src/starter.c:241:E] w-clock-viewer (pid:9618) is destroyed. ambient mode[0], charging[0], sports mode[0]
10-14 16:59:59.330+0200 W/STARTER (  705): starter.c: _w_app_dead_cb(249) > [_w_app_dead_cb:249] >> clockstop
10-14 16:59:59.335+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9618
10-14 16:59:59.345+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.2764
10-14 16:59:59.355+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 1
10-14 16:59:59.365+0200 E/wnoti-service(  838): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 1 
10-14 16:59:59.365+0200 E/wnoti-service(  838): wnoti-native-client.c: handle_cache_notification(603) > >>
10-14 16:59:59.370+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 16:59:59.370+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 16:59:59.370+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 16:59:59.370+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_alpm_handler(1066) > signal_alpm_handler: ambient mode: 0, state: 3
10-14 16:59:59.370+0200 E/WATCH_CORE( 1130): appcore-watch.c: __signal_alpm_handler(1070) > invalid state
10-14 16:59:59.410+0200 W/SHealth_Common( 1005): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-14 16:59:59.410+0200 W/SHealth_Service( 1005): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-14 16:59:59.415+0200 W/SHealth_Common( 1156): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-14 16:59:59.430+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
10-14 16:59:59.430+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
10-14 16:59:59.430+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-14 16:59:59.430+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-14 16:59:59.430+0200 E/ALARM_MANAGER(  705): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(14-10-2017, 17:00:19), repeat(1), interval(20), type(-1073741822)
10-14 16:59:59.440+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/9618/oom_score_adj failed
10-14 16:59:59.440+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 9618
10-14 16:59:59.445+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [705].
10-14 16:59:59.460+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 16:59:59.460+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: PAUSE State: RUNNING
10-14 16:59:59.460+0200 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 16:59:59.495+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 374827160, next duetime: 1507993219
10-14 16:59:59.495+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(374827160)
10-14 16:59:59.495+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1508014052), due_time(1507993219)
10-14 16:59:59.495+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 16:59:59.495+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 15:00:19 (UTC).
10-14 16:59:59.495+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 16:59:59.495+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 16:59:59.500+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 16:59:59.560+0200 W/W_INDICATOR(  714): windicator_moment_view.c: _charging_watch_fade_out_end_cb(1618) > [_charging_watch_fade_out_end_cb:1618] 
10-14 16:59:59.565+0200 W/APP_CORE(  714): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:200000a
10-14 16:59:59.570+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: PAUSE State: PAUSED
10-14 16:59:59.585+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 16:59:59.585+0200 W/AUL_AMD (  532): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-14 16:59:59.625+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
10-14 16:59:59.625+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
10-14 16:59:59.625+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 16:59:59.625+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
10-14 16:59:59.625+0200 I/APP_CORE( 1063): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
10-14 16:59:59.625+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
10-14 16:59:59.630+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
10-14 16:59:59.630+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 16:59:59.630+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 16:59:59.630+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 16:59:59.685+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 16:59:59.685+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 16:59:59.685+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 16:59:59.685+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 16:59:59.685+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 16:59:59.700+0200 I/MALI    ( 1063): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4427f370] swap changed from async to sync
10-14 17:00:00.470+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
10-14 17:00:00.470+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
10-14 17:00:00.470+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 17:00:00.490+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(186) > LCD on
10-14 17:00:00.490+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_set(165) > timer set
10-14 17:00:00.490+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-14 17:00:00.495+0200 W/W_HOME  ( 1063): gesture.c: _apps_status_get(126) > apps status:0
10-14 17:00:00.495+0200 W/W_HOME  ( 1063): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:1 info->offtime:1198
10-14 17:00:00.495+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_schedule(212) > schedule, manual render
10-14 17:00:00.495+0200 W/W_HOME  ( 1063): event_manager.c: _lcd_on_cb(696) > lcd state: 1
10-14 17:00:00.495+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:00.515+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [1198]ms
10-14 17:00:00.515+0200 W/STARTER (  705): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-14 17:00:00.540+0200 W/W_HOME  ( 1063): gesture.c: _widget_updated_cb(194) > widget updated
10-14 17:00:00.540+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-14 17:00:00.540+0200 W/W_HOME  ( 1063): gesture.c: _manual_render(180) > 
10-14 17:00:00.630+0200 W/W_HOME  ( 1063): gesture.c: _manual_render(180) > 
10-14 17:00:00.670+0200 W/SHealth_Common( 1156): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 17:00:00.675+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_enable(136) > 0
10-14 17:00:00.675+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: RESUME State: PAUSED
10-14 17:00:00.675+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 17:00:00.675+0200 W/W_HOME  ( 1063): main.c: _appcore_resume_cb(687) > appcore resume
10-14 17:00:00.675+0200 W/W_HOME  ( 1063): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
10-14 17:00:00.675+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:00.675+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:00.675+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:00.685+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 17:00:00.685+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 17:00:00.685+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 17:00:00.685+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
10-14 17:00:00.710+0200 W/SHealth_Common( 1005): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 17:00:00.710+0200 W/SHealth_Service( 1005): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-14 17:00:00.735+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [705].
10-14 17:00:00.735+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(374827160)
10-14 17:00:00.735+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 17:00:00.735+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 20:47:32 (UTC).
10-14 17:00:00.735+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 17:00:00.735+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 17:00:00.735+0200 E/ALARM_MANAGER(  484): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[374827160] is removed.
10-14 17:00:00.735+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 17:00:00.740+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
10-14 17:00:00.740+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-14 17:00:00.750+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-14 17:00:00.750+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-14 17:00:00.750+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: preference_get_boolean(1173) > preference_get_boolean(1005) : test_healthy_pace error
10-14 17:00:00.750+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=13483105 button=1
10-14 17:00:00.750+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:00:00.750+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 17:00:00.750+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-14 17:00:00.760+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:00:00.775+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:00:00.780+0200 W/SHealth_Service( 1005): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
10-14 17:00:00.780+0200 W/SHealth_Common( 1005): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1507939200000,000000[0;m
10-14 17:00:00.785+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=13483143 button=1
10-14 17:00:00.790+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-14 17:00:00.790+0200 E/APPS    ( 1063): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-14 17:00:00.790+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-14 17:00:00.790+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 17:00:00.790+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 17:00:00.795+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 1063
10-14 17:00:00.795+0200 I/AUL_AMD (  532): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-14 17:00:00.810+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 3
10-14 17:00:00.810+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 17:00:00.810+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 17:00:00.810+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 17:00:00.810+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 17:00:00.815+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
10-14 17:00:00.825+0200 I/HealthDataService(  770): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-14 17:00:00.845+0200 I/healthData( 1005): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-14 17:00:00.860+0200 I/efl-extension(10078): efl_extension.c: eext_mod_init(40) > Init
10-14 17:00:00.865+0200 I/UXT     (10078): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 17:00:00.865+0200 I/CAPI_APPFW_APPLICATION(10078): app_main.c: ui_app_main(704) > app_efl_main
10-14 17:00:00.870+0200 I/CAPI_APPFW_APPLICATION(10078): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 17:00:00.910+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(282) > request cmd(0) result(10078)
10-14 17:00:00.910+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 17:00:00.910+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 17:00:00.965+0200 E/EFL     (10078): ecore_evas<10078> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-14 17:00:01.195+0200 I/APP_CORE(10078): appcore-efl.c: __do_app(429) > [APP 10078] Event: RESET State: CREATED
10-14 17:00:01.195+0200 I/CAPI_APPFW_APPLICATION(10078): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-14 17:00:01.215+0200 I/APP_CORE(10078): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-14 17:00:01.220+0200 I/APP_CORE(10078): appcore-efl.c: __do_app(474) > [APP 10078] Initial Launching, call the resume_cb
10-14 17:00:01.220+0200 I/CAPI_APPFW_APPLICATION(10078): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-14 17:00:01.225+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-14 17:00:01.225+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:01.225+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:01.225+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:01.250+0200 W/APP_CORE(10078): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00002
10-14 17:00:01.290+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-14 17:00:01.290+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-14 17:00:01.290+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:01.290+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-14 17:00:01.290+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: PAUSE State: RUNNING
10-14 17:00:01.290+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 17:00:01.290+0200 W/W_HOME  ( 1063): main.c: _appcore_pause_cb(696) > appcore pause
10-14 17:00:01.290+0200 W/W_HOME  ( 1063): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-14 17:00:01.290+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:01.290+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:01.290+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:00:01.295+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:00:01.295+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 17:00:01.295+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [false][0m
10-14 17:00:01.315+0200 E/TBM     (  409): tbm_bufmgr.c: _tgl_destroy(151) > [libtbm:409] error(Device or resource busy) _tgl_destroy:151 key:27
10-14 17:00:01.330+0200 I/APP_CORE(10078): appcore-efl.c: __do_app(429) > [APP 10078] Event: RESUME State: RUNNING
10-14 17:00:01.375+0200 I/HEART_RATE(10078): HEART RATE : 0
10-14 17:00:01.375+0200 I/HEART_RATE(10078): HEART RATE : 0
10-14 17:00:01.375+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-14 17:00:01.570+0200 E/EFL     (10078): elementary<10078> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 17:00:01.605+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 17:00:01.605+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 17:00:01.605+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 17:00:01.605+0200 E/wnoti-service(  838): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 1 to 2 
10-14 17:00:01.605+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 1 -> 2
10-14 17:00:01.625+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 17:00:01.635+0200 W/SHealth_Service( 1005): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
10-14 17:00:01.815+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: MEM_FLUSH State: PAUSED
10-14 17:00:02.060+0200 I/HEART_RATE(10078): HEART RATE : -3
10-14 17:00:02.125+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.2767
10-14 17:00:02.150+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:00:02.160+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10078
10-14 17:00:02.165+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 17:00:02.195+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:00:02.205+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10078
10-14 17:00:02.210+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 17:00:02.295+0200 E/EFL     (10114): elementary<10114> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 17:00:02.295+0200 E/EFL     (10114): elementary<10114> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 17:00:02.320+0200 E/EFL     (10114): elementary<10114> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 17:00:02.320+0200 E/EFL     (10114): elementary<10114> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 17:00:02.365+0200 E/EFL     (10114): elementary<10114> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 17:00:02.370+0200 E/EFL     (10114): elementary<10114> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 17:00:02.370+0200 E/EFL     (10114): elementary<10114> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 17:00:02.370+0200 E/EFL     (10114): elementary<10114> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 17:00:02.375+0200 E/EFL     (10114): elementary<10114> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 17:00:02.395+0200 E/EFL     (10114): elementary<10114> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 17:00:02.400+0200 E/EFL     (10114): elementary<10114> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 17:00:02.400+0200 E/EFL     (10114): elementary<10114> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 17:00:02.445+0200 E/EFL     (10114): elementary<10114> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 17:00:02.455+0200 E/EFL     (10114): elementary<10114> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 17:00:02.455+0200 E/EFL     (10114): elementary<10114> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 17:00:02.460+0200 E/EFL     (10114): elementary<10114> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 17:00:02.460+0200 E/EFL     (10114): elementary<10114> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 17:00:02.460+0200 E/EFL     (10114): elementary<10114> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 17:00:02.460+0200 E/EFL     (10114): elementary<10114> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 17:00:02.465+0200 I/AUL_PAD (10114): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 17:00:02.805+0200 E/EFL     (10078): ecore_x<10078> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=13485161 button=1
10-14 17:00:02.920+0200 E/EFL     (10078): ecore_x<10078> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=13485274 button=1
10-14 17:00:03.150+0200 E/EFL     (10078): elementary<10078> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-14 17:00:03.170+0200 E/EFL     (10078): elementary<10078> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-14 17:00:03.530+0200 W/CRASH_MANAGER(10125): worker.c: worker_job(1205) > 1110078646174150799320

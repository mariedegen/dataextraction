S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 6119
Date: 2017-10-14 23:01:04+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6119, uid 5000)

Register Information
r0   = 0x00000010, r1   = 0xfb4715d4
r2   = 0x4146c023, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x416c77fc
r6   = 0x00000010, r7   = 0xbed1bf10
r8   = 0x00000041, r9   = 0x40452824
r10  = 0xfb4715d4, fp   = 0x00000000
ip   = 0x0000016c, sp   = 0xbed1be30
lr   = 0x4146c023, pc   = 0x404e62d0
cpsr = 0x20000010

Memory Information
MemTotal:   491948 KB
MemFree:     86564 KB
Buffers:     30192 KB
Cached:     156992 KB
VmPeak:      96820 KB
VmSize:      95712 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17760 KB
VmRSS:       17760 KB
VmData:      39480 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25100 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6119 TID = 6119
6119 6157 6158 6159 6160 

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
414d0000 4159f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415b5000 415bf000 r-xp /lib/libnss_files-2.13.so
41643000 4164e000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41656000 4165a000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41663000 4166b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
4166c000 4168d000 r-xp /usr/lib/libefl-extension.so.0.1.0
41696000 416c0000 r-xp /usr/lib/libsensor.so.1.9.6
416c9000 416db000 r-xp /usr/lib/libefl-assist.so.0.1.0
416e3000 4179b000 r-xp /usr/lib/libcairo.so.2.11200.14
417a6000 417b0000 r-xp /usr/lib/libsensord-shared.so
417b9000 417cb000 r-xp /usr/lib/libtts.so
417d3000 417f5000 r-xp /usr/lib/libui-extension.so.0.1.0
417fe000 41805000 r-xp /usr/lib/libtbm.so.1.0.0
4180d000 4181b000 r-xp /usr/lib/libGLESv2.so.2.0
41824000 41825000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4182e000 41834000 r-xp /usr/lib/libxcb-render.so.0.0.0
4183c000 4183f000 r-xp /usr/lib/libEGL.so.1.4
41847000 4184c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41854000 41857000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4185f000 41860000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41869000 419a6000 r-xp /usr/lib/libicui18n.so.51.1
419b6000 41a9a000 r-xp /usr/lib/libicuuc.so.51.1
41aaf000 41ab7000 r-xp /usr/lib/libdrm.so.2.4.0
41abf000 41ac1000 r-xp /usr/lib/libdri2.so.0.0.0
41ac9000 41acf000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41ad7000 41adc000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41ae4000 41afd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41b05000 41b26000 r-xp /usr/lib/libexif.so.12.3.3
41b39000 41b3b000 r-xp /usr/lib/libttrace.so.1.1
41b43000 41b48000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41b50000 41b56000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41b5f000 41b67000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41b6f000 41b8b000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41b94000 41b9b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41ba4000 41ba6000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41bae000 41bb5000 r-xp /usr/lib/libminizip.so.1.0.0
41bbd000 41bc2000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41bca000 41ce1000 rw-p [heap]
4326a000 43277000 r-xp /usr/lib/libail.so.0.1.0
43280000 4334a000 r-xp /usr/lib/libCOREGL.so.4.0
4355c000 43567000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4370e000 4370f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43718000 43f17000 rw-p [stack:6157]
43f18000 44717000 rw-p [stack:6158]
44718000 44f17000 rw-p [stack:6159]
44f18000 45717000 rw-p [stack:6160]
45773000 45774000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
4578f000 45796000 r-xp /usr/lib/libfeedback.so.0.1.4
4579f000 457a0000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
457a8000 457aa000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
457b2000 457bc000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
457c4000 457cb000 r-xp /usr/lib/libmmfcommon.so.0.0.0
457d3000 457e9000 r-xp /usr/lib/libmmfsound.so.0.1.0
45a00000 45a05000 r-xp /usr/lib/libmmfsession.so.0.0.0
45a0d000 45a17000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45a23000 45a27000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45a30000 45a45000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45a4d000 45aae000 r-xp /usr/lib/libasound.so.2.0.0
45ab8000 45abb000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45ac3000 45afb000 r-xp /usr/lib/libpulse.so.0.16.2
45afc000 45aff000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45b07000 45b38000 r-xp /usr/lib/libmdm.so.1.1.86
45b40000 45b45000 r-xp /usr/lib/libjson.so.0.0.1
45b4d000 45b95000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45b96000 45bdd000 r-xp /usr/lib/libsndfile.so.1.0.26
45be9000 45bf1000 r-xp /usr/lib/libmdm-common.so.1.0.89
45bf2000 45c14000 r-xp /usr/lib/libvorbis.so.0.4.3
45c1c000 45c20000 r-xp /usr/lib/libogg.so.0.7.1
becfc000 bed1d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6119)
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
r::HandleReceivedMessage
10-14 23:00:59.730+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:00:59.730+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 23:00:59.730+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 23:00:59.730+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:00:59.730+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 23:00:59.730+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 23:00:59.730+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 23:00:59.730+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:00:59.730+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
10-14 23:00:59.740+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
10-14 23:00:59.865+0200 W/W_HOME  (  767): move.c: _transit_del_cb(115) > transit end
10-14 23:00:59.870+0200 W/W_HOME  (  767): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
10-14 23:00:59.870+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 23:00:59.880+0200 W/W_HOME  (  767): move.c: _scroller_up_done(515) > up signal done
10-14 23:00:59.880+0200 W/W_HOME  (  767): event_manager.c: _apptray_visibility_cb(583) > apps,show
10-14 23:00:59.885+0200 W/W_HOME  (  767): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
10-14 23:00:59.885+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 23:00:59.885+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 23:00:59.885+0200 W/W_HOME  (  767): main.c: home_pause(766) > clock/widget paused
10-14 23:00:59.890+0200 W/W_HOME  (  767): clock_indicator.c: clock_indicator_pause(554) > 
10-14 23:00:59.890+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 23:00:59.890+0200 W/W_HOME  (  767): noti_broker.c: _apptray_visibility_cb(789) > apps,show
10-14 23:00:59.890+0200 W/W_HOME  (  767): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
10-14 23:00:59.890+0200 I/wnotib  (  767): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
10-14 23:00:59.890+0200 I/wnotib  (  767): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
10-14 23:00:59.890+0200 E/APPS    (  767): apps_main.c: apps_main_resume(636) >  resumed already
10-14 23:00:59.900+0200 W/WATCH_CORE(  813): appcore-watch.c: __widget_pause(1028) > widget_pause
10-14 23:00:59.910+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 23:00:59.910+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:00:59.910+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:00:59.915+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:00:59.915+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 23:00:59.915+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 23:00:59.915+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:00:59.915+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 23:00:59.915+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 23:00:59.915+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 23:00:59.915+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:00:59.915+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 23:00:59.915+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 23:00:59.920+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 23:00:59.925+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:00:59.925+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:00:59.925+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:00:59.925+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 23:00:59.925+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 23:00:59.925+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:00:59.925+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 23:00:59.925+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 23:00:59.925+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 23:00:59.925+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:00:59.925+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 23:00:59.930+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 23:00:59.935+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 23:00:59.935+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:00:59.935+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:00:59.935+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:00:59.935+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 23:00:59.935+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 23:00:59.935+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:00:59.935+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 23:00:59.935+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 23:00:59.935+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 23:00:59.935+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:00:59.935+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 23:00:59.945+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 23:00:59.945+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:00:59.945+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:00:59.945+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:00:59.945+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 23:00:59.945+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 23:00:59.945+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:00:59.945+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 23:00:59.945+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 23:00:59.945+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 23:00:59.945+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:00:59.945+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 23:00:59.955+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 23:00:59.955+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:00:59.955+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:00:59.955+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:00:59.955+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 23:00:59.955+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 23:00:59.955+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:00:59.955+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 23:00:59.955+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 23:00:59.955+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 23:00:59.955+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:00:59.955+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 23:00:59.960+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 23:00:59.960+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __check_status_for_cgroup(145) > enter background group
10-14 23:00:59.965+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 23:00:59.965+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 23:01:00.180+0200 E/EFL     (  767): ecore_x<767> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=925532 button=1
10-14 23:01:00.180+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:00.180+0200 E/W_HOME  (  767): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 23:01:00.185+0200 W/APPS    (  767): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,242,216,124]
10-14 23:01:00.190+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:00.205+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:00.205+0200 W/APPS    (  767): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-14 23:01:00.215+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:00.230+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:00.240+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:00.255+0200 E/EFL     (  767): ecore_x<767> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=925604 button=1
10-14 23:01:00.255+0200 E/APPS    (  767): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 23:01:00.315+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:01:00.315+0200 E/CAPI_APPFW_APP_CONTROL( 1653): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 23:01:00.315+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1653]   [com.samsung.w-home]register msg port [true][0m
10-14 23:01:00.315+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 23:01:00.320+0200 W/AUL_AMD (  535): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 767
10-14 23:01:00.325+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1653]   [MUSIC_PLAYER_EVENT][0m
10-14 23:01:00.325+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1653): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 23:01:00.325+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1653): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 23:01:00.330+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1653): preference.c: preference_get_int(1132) > preference_get_int(1653) : key(music-control-service_native/playing_diration) error
10-14 23:01:00.330+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1653]   preference_get_int() .. [0xfef00030][0m
10-14 23:01:00.330+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1653]   bundle_add_str() .. [0xffffffea][0m
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 23:01:00.330+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:01:00.335+0200 W/W_HOME  (  767): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 23:01:00.335+0200 E/W_HOME  (  767): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 23:01:00.335+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1653]   [MUSIC_PLAYER_EVENT][0m
10-14 23:01:00.335+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1653): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 23:01:00.335+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1653): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 23:01:00.335+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1653): preference.c: preference_get_int(1132) > preference_get_int(1653) : key(music-control-service_native/playing_diration) error
10-14 23:01:00.335+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1653]   preference_get_int() .. [0xfef00030][0m
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 23:01:00.335+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:01:00.335+0200 W/W_HOME  (  767): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 23:01:00.335+0200 E/W_HOME  (  767): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 23:01:00.350+0200 I/TIZEN_N_SOUND_MANAGER( 1653): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 23:01:00.350+0200 E/TIZEN_N_SOUND_MANAGER( 1653): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 23:01:00.350+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1653]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 23:01:00.350+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:01:00.525+0200 W/AUL_AMD (  535): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 23:01:00.525+0200 W/AUL_AMD (  535): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-14 23:01:00.805+0200 W/AUL_AMD (  535): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 23:01:01.215+0200 E/EFL     (  767): ecore_x<767> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=926565 button=1
10-14 23:01:01.215+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:01.215+0200 E/W_HOME  (  767): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 23:01:01.220+0200 W/APPS    (  767): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,322,216,173]
10-14 23:01:01.235+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:01.250+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:01.250+0200 W/APPS    (  767): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-14 23:01:01.265+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:01.275+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:01.285+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:01.295+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:01.310+0200 E/EFL     (  767): ecore_x<767> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=926660 button=1
10-14 23:01:01.310+0200 E/APPS    (  767): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-14 23:01:01.985+0200 E/EFL     (  767): ecore_x<767> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=927337 button=1
10-14 23:01:01.990+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:01.990+0200 E/W_HOME  (  767): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 23:01:01.990+0200 W/APPS    (  767): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-14 23:01:02.095+0200 E/W_HOME  (  767): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 23:01:02.110+0200 E/EFL     (  767): ecore_x<767> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=927458 button=1
10-14 23:01:02.110+0200 W/APPS    (  767): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-14 23:01:02.110+0200 E/APPS    (  767): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-14 23:01:02.110+0200 W/APPS    (  767): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-14 23:01:02.120+0200 W/AUL     (  767): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 23:01:02.120+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 23:01:02.125+0200 W/AUL_AMD (  535): amd_launch.c: _start_app(1710) > caller pid : 767
10-14 23:01:02.125+0200 I/AUL_AMD (  535): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-14 23:01:02.135+0200 W/AUL_AMD (  535): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 23:01:02.135+0200 W/AUL_PAD ( 1190): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 23:01:02.135+0200 W/AUL_PAD ( 1190): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 23:01:02.140+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-14 23:01:02.140+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 23:01:02.190+0200 I/efl-extension( 6119): efl_extension.c: eext_mod_init(40) > Init
10-14 23:01:02.195+0200 I/UXT     ( 6119): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 23:01:02.195+0200 I/CAPI_APPFW_APPLICATION( 6119): app_main.c: ui_app_main(704) > app_efl_main
10-14 23:01:02.200+0200 I/CAPI_APPFW_APPLICATION( 6119): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 23:01:02.235+0200 W/AUL     (  767): launch.c: app_request_to_launchpad(282) > request cmd(0) result(6119)
10-14 23:01:02.235+0200 E/W_HOME  (  767): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-14 23:01:02.235+0200 E/AUL     (  535): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 23:01:02.240+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 23:01:02.290+0200 E/EFL     ( 6119): ecore_evas<6119> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-14 23:01:02.510+0200 I/APP_CORE( 6119): appcore-efl.c: __do_app(429) > [APP 6119] Event: RESET State: CREATED
10-14 23:01:02.510+0200 I/CAPI_APPFW_APPLICATION( 6119): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-14 23:01:02.530+0200 I/APP_CORE( 6119): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-14 23:01:02.530+0200 I/APP_CORE( 6119): appcore-efl.c: __do_app(474) > [APP 6119] Initial Launching, call the resume_cb
10-14 23:01:02.530+0200 I/CAPI_APPFW_APPLICATION( 6119): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-14 23:01:02.540+0200 W/APP_CORE( 6119): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3a00002
10-14 23:01:02.540+0200 W/W_HOME  (  767): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-14 23:01:02.540+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 23:01:02.540+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 23:01:02.545+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 23:01:02.600+0200 W/W_HOME  (  767): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-14 23:01:02.600+0200 W/W_HOME  (  767): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-14 23:01:02.600+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 23:01:02.600+0200 W/W_HOME  (  767): event_manager.c: _state_control(344) > appcore paused manually
10-14 23:01:02.600+0200 W/W_HOME  (  767): main.c: home_appcore_pause(723) > Home Appcore Paused
10-14 23:01:02.600+0200 W/W_HOME  (  767): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-14 23:01:02.600+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 23:01:02.600+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 23:01:02.600+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 23:01:02.605+0200 I/APP_CORE( 6119): appcore-efl.c: __do_app(429) > [APP 6119] Event: RESUME State: RUNNING
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 23:01:02.610+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 23:01:02.610+0200 E/CAPI_APPFW_APP_CONTROL( 1653): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 23:01:02.610+0200 W/MUSIC_CONTROL_SERVICE( 1653): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1653]   [com.samsung.w-home]register msg port [false][0m
10-14 23:01:02.625+0200 W/W_HOME  (  767): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-14 23:01:02.630+0200 I/APP_CORE(  767): appcore-efl.c: __do_app(429) > [APP 767] Event: PAUSE State: RUNNING
10-14 23:01:02.630+0200 I/CAPI_APPFW_APPLICATION(  767): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 23:01:02.630+0200 W/W_HOME  (  767): main.c: _appcore_pause_cb(696) > appcore pause
10-14 23:01:02.630+0200 E/W_HOME  (  767): main.c: _pause_cb(674) > paused already
10-14 23:01:02.645+0200 I/INFO_TAG( 6119): HEART RATE AFTER : 0
10-14 23:01:02.645+0200 I/INFO_TAG( 6119): HEART RATE AFTER : 0
10-14 23:01:02.645+0200 I/INFO_TAG( 6119): HEART RATE AFTER : 0
10-14 23:01:02.685+0200 W/wnotib  (  767): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-14 23:01:02.885+0200 E/EFL     ( 6119): elementary<6119> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 23:01:02.940+0200 E/AUL     (  535): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 23:01:03.130+0200 I/APP_CORE(  767): appcore-efl.c: __do_app(429) > [APP 767] Event: MEM_FLUSH State: PAUSED
10-14 23:01:03.410+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.405
10-14 23:01:03.480+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 23:01:03.490+0200 W/AUL_AMD (  535): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6119
10-14 23:01:03.490+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 23:01:03.490+0200 I/INFO_TAG( 6119): HEART RATE AFTER : -3
10-14 23:01:03.510+0200 W/AUL_AMD (  535): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6119
10-14 23:01:03.510+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 23:01:03.515+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 23:01:03.615+0200 E/EFL     ( 6119): ecore_x<6119> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=928964 button=1
10-14 23:01:03.660+0200 E/EFL     ( 6164): elementary<6164> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 23:01:03.660+0200 E/EFL     ( 6164): elementary<6164> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 23:01:03.685+0200 E/EFL     ( 6164): elementary<6164> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 23:01:03.685+0200 E/EFL     ( 6164): elementary<6164> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 23:01:03.720+0200 E/EFL     ( 6164): elementary<6164> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 23:01:03.720+0200 E/EFL     ( 6164): elementary<6164> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 23:01:03.720+0200 E/EFL     ( 6164): elementary<6164> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 23:01:03.720+0200 E/EFL     ( 6164): elementary<6164> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 23:01:03.720+0200 E/EFL     ( 6164): elementary<6164> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 23:01:03.725+0200 E/EFL     ( 6119): ecore_x<6119> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=929074 button=1
10-14 23:01:03.750+0200 E/EFL     ( 6164): elementary<6164> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 23:01:03.750+0200 E/EFL     ( 6164): elementary<6164> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 23:01:03.755+0200 E/EFL     ( 6164): elementary<6164> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 23:01:03.790+0200 E/EFL     ( 6164): elementary<6164> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 23:01:03.800+0200 E/EFL     ( 6164): elementary<6164> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 23:01:03.800+0200 E/EFL     ( 6164): elementary<6164> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 23:01:03.800+0200 E/EFL     ( 6164): elementary<6164> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 23:01:03.800+0200 E/EFL     ( 6164): elementary<6164> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 23:01:03.800+0200 E/EFL     ( 6164): elementary<6164> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 23:01:03.800+0200 E/EFL     ( 6164): elementary<6164> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 23:01:03.800+0200 I/AUL_PAD ( 6164): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 23:01:03.940+0200 E/EFL     ( 6119): elementary<6119> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-14 23:01:03.960+0200 E/EFL     ( 6119): elementary<6119> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-14 23:01:04.330+0200 E/EFL     ( 6119): elementary<6119> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 23:01:04.485+0200 I/INFO_TAG_SENSOR_EVENT2( 6119): HEART RATE : -3
10-14 23:01:04.485+0200 F/EFL     ( 6119): evas_main<6119> main.c:122 evas_debug_magic_wrong() Input object is wrong type
10-14 23:01:04.485+0200 F/EFL     ( 6119):     Expected: 71737723 - Evas_Object
10-14 23:01:04.485+0200 F/EFL     ( 6119):     Supplied: 4146b70b - <UNKNOWN>
10-14 23:01:04.595+0200 I/APP_CORE(  700): appcore-efl.c: __do_app(429) > [APP 700] Event: MEM_FLUSH State: PAUSED
10-14 23:01:04.920+0200 I/MALI    (  767): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
10-14 23:01:04.960+0200 W/AUL_AMD (  535): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 23:01:04.960+0200 W/AUL_AMD (  535): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-14 23:01:04.985+0200 W/AUL_PAD ( 1190): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6119 pgid = 6119
10-14 23:01:05.015+0200 W/PROCESSMGR(  407): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
10-14 23:01:05.020+0200 W/W_HOME  (  767): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
10-14 23:01:05.020+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 23:01:05.020+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 23:01:05.020+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 23:01:05.045+0200 W/W_HOME  (  767): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
10-14 23:01:05.045+0200 W/W_HOME  (  767): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
10-14 23:01:05.045+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 23:01:05.045+0200 W/W_HOME  (  767): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
10-14 23:01:05.045+0200 I/APP_CORE(  767): appcore-efl.c: __do_app(429) > [APP 767] Event: RESUME State: PAUSED
10-14 23:01:05.045+0200 I/CAPI_APPFW_APPLICATION(  767): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 23:01:05.045+0200 W/W_HOME  (  767): main.c: _appcore_resume_cb(687) > appcore resume
10-14 23:01:05.045+0200 W/W_HOME  (  767): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
10-14 23:01:05.045+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 23:01:05.050+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 23:01:05.050+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 23:01:05.050+0200 W/wnotib  (  767): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
10-14 23:01:05.085+0200 W/CRASH_MANAGER( 6174): worker.c: worker_job(1205) > 1106119646174150801486

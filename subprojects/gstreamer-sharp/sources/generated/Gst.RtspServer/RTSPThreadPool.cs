// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.RtspServer {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class RTSPThreadPool : GLib.Object {

		public RTSPThreadPool (IntPtr raw) : base(raw) {}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_thread_pool_new();

		public RTSPThreadPool () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RTSPThreadPool)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gst_rtsp_thread_pool_new();
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_thread_pool_get_max_threads(IntPtr raw);

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_thread_pool_set_max_threads(IntPtr raw, int max_threads);

		[GLib.Property ("max-threads")]
		public int MaxThreads {
			get  {
				int raw_ret = gst_rtsp_thread_pool_get_max_threads(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gst_rtsp_thread_pool_set_max_threads(Handle, value);
			}
		}

		static GetThreadNativeDelegate GetThread_cb_delegate;
		static GetThreadNativeDelegate GetThreadVMCallback {
			get {
				if (GetThread_cb_delegate == null)
					GetThread_cb_delegate = new GetThreadNativeDelegate (GetThread_cb);
				return GetThread_cb_delegate;
			}
		}

		static void OverrideGetThread (GLib.GType gtype)
		{
			OverrideGetThread (gtype, GetThreadVMCallback);
		}

		static void OverrideGetThread (GLib.GType gtype, GetThreadNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_thread"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetThreadNativeDelegate (IntPtr inst, int type, IntPtr ctx);

		static IntPtr GetThread_cb (IntPtr inst, int type, IntPtr ctx)
		{
			try {
				RTSPThreadPool __obj = GLib.Object.GetObject (inst, false) as RTSPThreadPool;
				Gst.RtspServer.RTSPThread __result;
				__result = __obj.OnGetThread ((Gst.RtspServer.RTSPThreadType) type, Gst.RtspServer.RTSPContext.New (ctx));
				return __result == null ? IntPtr.Zero : __result.OwnedCopy;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.RtspServer.RTSPThreadPool), ConnectionMethod="OverrideGetThread")]
		protected virtual Gst.RtspServer.RTSPThread OnGetThread (Gst.RtspServer.RTSPThreadType type, Gst.RtspServer.RTSPContext ctx)
		{
			return InternalGetThread (type, ctx);
		}

		private Gst.RtspServer.RTSPThread InternalGetThread (Gst.RtspServer.RTSPThreadType type, Gst.RtspServer.RTSPContext ctx)
		{
			GetThreadNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_thread"));
				unmanaged = (GetThreadNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetThreadNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr native_ctx = GLib.Marshaller.StructureToPtrAlloc (ctx);
			IntPtr __result = unmanaged (this.Handle, (int) type, native_ctx);
			Marshal.FreeHGlobal (native_ctx);
			return __result == IntPtr.Zero ? null : (Gst.RtspServer.RTSPThread) GLib.Opaque.GetOpaque (__result, typeof (Gst.RtspServer.RTSPThread), true);
		}

		static ConfigureThreadNativeDelegate ConfigureThread_cb_delegate;
		static ConfigureThreadNativeDelegate ConfigureThreadVMCallback {
			get {
				if (ConfigureThread_cb_delegate == null)
					ConfigureThread_cb_delegate = new ConfigureThreadNativeDelegate (ConfigureThread_cb);
				return ConfigureThread_cb_delegate;
			}
		}

		static void OverrideConfigureThread (GLib.GType gtype)
		{
			OverrideConfigureThread (gtype, ConfigureThreadVMCallback);
		}

		static void OverrideConfigureThread (GLib.GType gtype, ConfigureThreadNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("configure_thread"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ConfigureThreadNativeDelegate (IntPtr inst, IntPtr thread, IntPtr ctx);

		static void ConfigureThread_cb (IntPtr inst, IntPtr thread, IntPtr ctx)
		{
			try {
				RTSPThreadPool __obj = GLib.Object.GetObject (inst, false) as RTSPThreadPool;
				__obj.OnConfigureThread (thread == IntPtr.Zero ? null : (Gst.RtspServer.RTSPThread) GLib.Opaque.GetOpaque (thread, typeof (Gst.RtspServer.RTSPThread), false), Gst.RtspServer.RTSPContext.New (ctx));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.RtspServer.RTSPThreadPool), ConnectionMethod="OverrideConfigureThread")]
		protected virtual void OnConfigureThread (Gst.RtspServer.RTSPThread thread, Gst.RtspServer.RTSPContext ctx)
		{
			InternalConfigureThread (thread, ctx);
		}

		private void InternalConfigureThread (Gst.RtspServer.RTSPThread thread, Gst.RtspServer.RTSPContext ctx)
		{
			ConfigureThreadNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("configure_thread"));
				unmanaged = (ConfigureThreadNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ConfigureThreadNativeDelegate));
			}
			if (unmanaged == null) return;

			IntPtr native_ctx = GLib.Marshaller.StructureToPtrAlloc (ctx);
			unmanaged (this.Handle, thread == null ? IntPtr.Zero : thread.Handle, native_ctx);
			Marshal.FreeHGlobal (native_ctx);
		}

		static ThreadEnterNativeDelegate ThreadEnter_cb_delegate;
		static ThreadEnterNativeDelegate ThreadEnterVMCallback {
			get {
				if (ThreadEnter_cb_delegate == null)
					ThreadEnter_cb_delegate = new ThreadEnterNativeDelegate (ThreadEnter_cb);
				return ThreadEnter_cb_delegate;
			}
		}

		static void OverrideThreadEnter (GLib.GType gtype)
		{
			OverrideThreadEnter (gtype, ThreadEnterVMCallback);
		}

		static void OverrideThreadEnter (GLib.GType gtype, ThreadEnterNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("thread_enter"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ThreadEnterNativeDelegate (IntPtr inst, IntPtr thread);

		static void ThreadEnter_cb (IntPtr inst, IntPtr thread)
		{
			try {
				RTSPThreadPool __obj = GLib.Object.GetObject (inst, false) as RTSPThreadPool;
				__obj.OnThreadEnter (thread == IntPtr.Zero ? null : (Gst.RtspServer.RTSPThread) GLib.Opaque.GetOpaque (thread, typeof (Gst.RtspServer.RTSPThread), false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.RtspServer.RTSPThreadPool), ConnectionMethod="OverrideThreadEnter")]
		protected virtual void OnThreadEnter (Gst.RtspServer.RTSPThread thread)
		{
			InternalThreadEnter (thread);
		}

		private void InternalThreadEnter (Gst.RtspServer.RTSPThread thread)
		{
			ThreadEnterNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("thread_enter"));
				unmanaged = (ThreadEnterNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ThreadEnterNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, thread == null ? IntPtr.Zero : thread.Handle);
		}

		static ThreadLeaveNativeDelegate ThreadLeave_cb_delegate;
		static ThreadLeaveNativeDelegate ThreadLeaveVMCallback {
			get {
				if (ThreadLeave_cb_delegate == null)
					ThreadLeave_cb_delegate = new ThreadLeaveNativeDelegate (ThreadLeave_cb);
				return ThreadLeave_cb_delegate;
			}
		}

		static void OverrideThreadLeave (GLib.GType gtype)
		{
			OverrideThreadLeave (gtype, ThreadLeaveVMCallback);
		}

		static void OverrideThreadLeave (GLib.GType gtype, ThreadLeaveNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("thread_leave"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ThreadLeaveNativeDelegate (IntPtr inst, IntPtr thread);

		static void ThreadLeave_cb (IntPtr inst, IntPtr thread)
		{
			try {
				RTSPThreadPool __obj = GLib.Object.GetObject (inst, false) as RTSPThreadPool;
				__obj.OnThreadLeave (thread == IntPtr.Zero ? null : (Gst.RtspServer.RTSPThread) GLib.Opaque.GetOpaque (thread, typeof (Gst.RtspServer.RTSPThread), false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.RtspServer.RTSPThreadPool), ConnectionMethod="OverrideThreadLeave")]
		protected virtual void OnThreadLeave (Gst.RtspServer.RTSPThread thread)
		{
			InternalThreadLeave (thread);
		}

		private void InternalThreadLeave (Gst.RtspServer.RTSPThread thread)
		{
			ThreadLeaveNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("thread_leave"));
				unmanaged = (ThreadLeaveNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ThreadLeaveNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, thread == null ? IntPtr.Zero : thread.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("pool"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // pool
							, null
							, "get_thread"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_thread"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_thread
							, "pool"
							, "configure_thread"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("configure_thread"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // configure_thread
							, "get_thread"
							, "thread_enter"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("thread_enter"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // thread_enter
							, "configure_thread"
							, "thread_leave"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("thread_leave"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // thread_leave
							, "thread_enter"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "thread_leave"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_thread_pool_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_rtsp_thread_pool_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_thread_pool_cleanup();

		public static void Cleanup() {
			gst_rtsp_thread_pool_cleanup();
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_thread_pool_get_thread(IntPtr raw, int type, IntPtr ctx);

		public Gst.RtspServer.RTSPThread GetThread(Gst.RtspServer.RTSPThreadType type, Gst.RtspServer.RTSPContext ctx) {
			IntPtr native_ctx = GLib.Marshaller.StructureToPtrAlloc (ctx);
			IntPtr raw_ret = gst_rtsp_thread_pool_get_thread(Handle, (int) type, native_ctx);
			Gst.RtspServer.RTSPThread ret = raw_ret == IntPtr.Zero ? null : (Gst.RtspServer.RTSPThread) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.RtspServer.RTSPThread), true);
			Marshal.FreeHGlobal (native_ctx);
			return ret;
		}


		static RTSPThreadPool ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "priv"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}